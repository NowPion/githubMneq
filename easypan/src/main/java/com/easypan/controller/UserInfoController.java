package com.easypan.controller;

import java.io.*;
import java.util.Base64;
import java.util.List;
import java.util.stream.StreamSupport;

import com.easypan.annotation.Globallnterceptor;
import com.easypan.annotation.VerifyParam;
import com.easypan.compoent.RedisComponent;
import com.easypan.entity.config.AppConfig;
import com.easypan.entity.constants.Contstans;
import com.easypan.entity.dto.CreatelmageCode;
import com.easypan.entity.dto.SessinoWebUserDto;
import com.easypan.entity.dto.UserSpaceDto;
import com.easypan.entity.enums.VerifyRegexEnum;
import com.easypan.entity.query.UserInfoQuery;
import com.easypan.entity.po.UserInfo;
import com.easypan.entity.vo.ResponseVO;
import com.easypan.exception.BusinessException;
import com.easypan.service.EmailCodeService;
import com.easypan.service.UserInfoService;
import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import org.springframework.http.HttpStatus;
import org.springframework.web.bind.annotation.*;
import org.springframework.web.multipart.MultipartFile;

import javax.annotation.Resource;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;
import javax.swing.*;

/**
 *  Controller
 */
@RestController("userInfoController")
public class UserInfoController extends ABaseController{

	private static final Logger logger = LoggerFactory.getLogger(UserInfoController.class);
	@Resource
	private UserInfoService userInfoService;

	@Resource
	private EmailCodeService emailCodeService;

	@Resource
	private AppConfig appConfig;


	@Resource
	private RedisComponent redisComponent;

	@RequestMapping("/checkCode")
	public String  CheckCode(HttpSession session, Integer type) throws IOException{
		CreatelmageCode vCode= new CreatelmageCode(130,38,5,10);
//		response.setHeader("Praqma","no-cache");
//		response.setHeader("Cache-Control","no-cache");
//		response.setDateHeader("Expires",0);
//		response.setContentType ("image/jpeg");
		String code = vCode.getCode();
		System.out.printf("\n-----------");
		System.out.printf(code);
		System.out.printf("-----------\n");
		if(type == null||type == 0){
			session.setAttribute(Contstans.CHECK_CODE_KEY,code);
	    }else{
		    session.setAttribute(Contstans.CHECK_CODE_KEY_EMALL, code);
	    }
        //vCode.write(response.getOutputStream());
		ByteArrayOutputStream baos = new ByteArrayOutputStream();
		vCode.write(baos);
		byte[] imageBytes = baos.toByteArray();
		String base64Image = Base64.getEncoder().encodeToString(imageBytes);
		String base64DataUrl =  base64Image;
		return base64DataUrl; // 将 Base64 编码的字符串返回


	}

	@RequestMapping("/logout")
	public  ResponseVO logout(HttpSession session){
		session.invalidate();
		return getSuccessResponseVO(null);
	}


	@RequestMapping("/sendEmailCode")
	@Globallnterceptor(checkParams = true,checkLogin = false)
	public ResponseVO sendEmailCode(HttpSession session,
								@VerifyParam(required = true,reqex = VerifyRegexEnum.EMAIL,max = 150) String email,
								@VerifyParam(required = true) String checkCode,
								@VerifyParam(required = true) Integer type){
		try{
			String code = (String) session.getAttribute(Contstans.CHECK_CODE_KEY);
			if(!checkCode.equalsIgnoreCase(code)){
				throw new BusinessException("图片验证码不正确");
			}
			emailCodeService.senEmailCode(email,type);
			return getSuccessResponseVO(null);
		}
		finally {
			session.removeAttribute(Contstans.CHECK_CODE_KEY_EMALL);
		}
	}

	/**
	 * 注册
	 * @param session
	 * @param email
	 * @param nickName
	 * @param password
	 * @param checkCode 图片验证码
	 * @param emailCode 邮箱验证码
	 * @return
	 */
	@RequestMapping("/register")
	@Globallnterceptor(checkParams = true,checkLogin = false)
	public ResponseVO register(HttpSession session,
									@VerifyParam(required = true,reqex = VerifyRegexEnum.EMAIL,max = 150) String email,
									@VerifyParam(required = true) String nickName,
									@VerifyParam(required = true,reqex = VerifyRegexEnum.PASSWORD,max = 18,min = 8)  String password,
									@VerifyParam(required = true) String checkCode,
									@VerifyParam(required = true) String emailCode){
		try{
			String code = (String) session.getAttribute(Contstans.CHECK_CODE_KEY);
			if(!checkCode.equalsIgnoreCase(code)){
				throw new BusinessException("图片验证码不正确");
			}
			userInfoService.register(email,nickName,password,emailCode);
			return getSuccessResponseVO(null);
		}
		finally {
			session.removeAttribute(Contstans.CHECK_CODE_KEY);
		}
	}

	/**
	 * 用户登入
	 * @param session
	 * @param email
	 * @param password
	 * @param checkCode
	 * @return
	 */
	@RequestMapping("/login")
	@Globallnterceptor(checkParams = true,checkLogin = false)
	public ResponseVO lgoin(HttpSession session,
							   @VerifyParam(required = true) String email,
							   @VerifyParam(required = true) String password,
							   @VerifyParam(required = true) String checkCode){
		try{
			String code = (String) session.getAttribute(Contstans.CHECK_CODE_KEY);
			if(!checkCode.equalsIgnoreCase(code)){
				throw new BusinessException("图片验证码不正确");
			}
			SessinoWebUserDto sessinDto = userInfoService.login(email, password);
			session.setAttribute(Contstans.SESSION_KEY,sessinDto);
			return getSuccessResponseVO(sessinDto);
		}
		finally {
			session.removeAttribute(Contstans.CHECK_CODE_KEY);
		}
	}

	/***
	 * 修改密码
	 * @param session
	 * @param email
	 * @param password
	 * @param checkCode
	 * @param emailCode
	 * @return
	 */
	@RequestMapping("/resetPwd")
	@Globallnterceptor(checkParams = true)
	public ResponseVO resetPwd(HttpSession session,
							   @VerifyParam(required = true,reqex = VerifyRegexEnum.EMAIL,max = 150) String email,
							   @VerifyParam(required = true,reqex = VerifyRegexEnum.PASSWORD,max = 18,min = 8)  String password,
							   @VerifyParam(required = true) String checkCode,
							   @VerifyParam(required = true) String emailCode){
		try{
			String code = (String) session.getAttribute(Contstans.CHECK_CODE_KEY);
			if(!checkCode.equalsIgnoreCase(code)){
				throw new BusinessException("图片验证码不正确");
			}
			userInfoService.resetPwd(email,password,emailCode);
			return getSuccessResponseVO(null);
		}
		finally {
			session.removeAttribute(Contstans.CHECK_CODE_KEY);
		}
	}

	/**
	 * Id查询用户头像
	 * @param response
	 * @param userid
	 */
	@RequestMapping("/getAvatar/{userId}")
	@Globallnterceptor(checkParams = true)
	public void getAvatar(HttpServletResponse response,
						@VerifyParam(required = true)  @PathVariable("userId") String userid){
			String avatarFolderName = Contstans.FILE_FOLDER_FILE + Contstans.FILE_FOLDER_FILE_AVATAR_NAME;
			File folder = new File(appConfig.getProjectFolder() + avatarFolderName);
			if(!folder.exists()){
				folder.mkdirs();
			}
			String avatarPath = appConfig.getProjectFolder() + avatarFolderName + userid + Contstans.AVATAR_SUEFIX;
			File file = new File(avatarPath);
			if(!file.exists()){
				if(!new File(appConfig.getProjectFolder() + avatarFolderName + Contstans.AVATAR_DEFUALT).exists()){
					printNoDefaultImage(response);
				}
				avatarPath = appConfig.getProjectFolder() + avatarFolderName + Contstans.AVATAR_DEFUALT;
	 		}
		    response.setHeader("Content-Type","image/jpg;charset=UTF-8");
			//response.setContentType("image/jpg");
	    	response.setCharacterEncoding("UTF-8");
			readFile(response,avatarPath);
	}

	/***
	 * 查询个人信息
	 * @param httpSession
	 * @return
	 */
	@RequestMapping("/getUserInfo")
	@Globallnterceptor(checkParams = true)
	public  ResponseVO getUserInfo(HttpSession httpSession){
		SessinoWebUserDto sessinoWebUserDto = getUserInfoFromSession(httpSession);
		return  getSuccessResponseVO(sessinoWebUserDto);
	}


	/***
	 * 查询使用空间
	 * @param httpSession
	 * @return
	 */
	@RequestMapping("/getUserSpace")
	@Globallnterceptor(checkParams = true)
	public  ResponseVO getUserSpace(HttpSession httpSession){
		SessinoWebUserDto sessinoWebUserDto = getUserInfoFromSession(httpSession);
		UserSpaceDto userSpaceDto = redisComponent.getUserSpaceUse(sessinoWebUserDto.getUserId());
		return  getSuccessResponseVO(userSpaceDto);
	}



	/***
	 * 上传头像
	 * @param httpSession
	 * @param multipartFile
	 * @return
	 */
	@PostMapping("/updateUserAvatar")
	@Globallnterceptor(checkParams = true)
	public  ResponseVO updateUserAvatar(HttpSession httpSession,  @RequestParam(value = "applyFiles") MultipartFile multipartFile){
		SessinoWebUserDto sessinoWebUserDto = getUserInfoFromSession(httpSession);
		String baseFolder = appConfig.getProjectFolder() + Contstans.FILE_FOLDER_FILE;
		File tragetFoldk = new File(baseFolder + Contstans.FILE_FOLDER_FILE_AVATAR_NAME);
		if(!tragetFoldk.exists()){
			tragetFoldk.mkdir();
		}
		String path = tragetFoldk.getPath()  + "/" + sessinoWebUserDto.getUserId() + Contstans.AVATAR_SUEFIX;
		File targetFile = new File(path);
		try{
			multipartFile.transferTo(targetFile);
		}catch (Exception e){
			logger.error("头像上传失败" + e.getMessage());
		}
		UserInfo userInfo = new UserInfo();
		userInfo.setQqAvater("");
		userInfoService.updateUserInfoByUserId(userInfo,sessinoWebUserDto.getUserId());
		sessinoWebUserDto.setAvatar(null);
		httpSession.setAttribute(Contstans.SESSION_KEY,sessinoWebUserDto);
		return  getSuccessResponseVO(null);
	}


	private void printNoDefaultImage(HttpServletResponse response){
		response.setHeader("Content-Type","application/json;charset=UTF-8");
		response.setStatus(HttpStatus.OK.value());
		PrintWriter writer = null;
		try{
			writer = response.getWriter();
			writer.print("请在头像目录下放置头像default_avatar.jpg");
			writer.close();
		}catch (Exception e){
			logger.error("输出无默认图像",e);
		}
		finally {
			writer.close();
		}
	}


}

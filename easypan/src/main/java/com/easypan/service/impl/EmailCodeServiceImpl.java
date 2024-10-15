package com.easypan.service.impl;

import java.util.Date;
import java.util.List;

import javax.annotation.Resource;
import javax.mail.internet.MimeMessage;

import com.easypan.compoent.RedisComponent;
import com.easypan.entity.config.AppConfig;
import com.easypan.entity.constants.Contstans;
import com.easypan.entity.dto.SysSettingsDto;
import com.easypan.entity.po.UserInfo;
import com.easypan.entity.query.UserInfoQuery;
import com.easypan.exception.BusinessException;
import com.easypan.mappers.UserInfoMapper;
import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.mail.javamail.JavaMailSender;
import org.springframework.mail.javamail.MimeMailMessage;
import org.springframework.mail.javamail.MimeMessageHelper;
import org.springframework.stereotype.Service;

import com.easypan.entity.enums.PageSize;
import com.easypan.entity.query.EmailCodeQuery;
import com.easypan.entity.po.EmailCode;
import com.easypan.entity.vo.PaginationResultVO;
import com.easypan.entity.query.SimplePage;
import com.easypan.mappers.EmailCodeMapper;
import com.easypan.service.EmailCodeService;
import com.easypan.utils.StringTools;
import org.springframework.transaction.annotation.Transactional;


/**
 * 邮箱验证码
 业务接口实现
 */
@Service("emailCodeService")
public class EmailCodeServiceImpl implements EmailCodeService {

	private static final Logger logger = LoggerFactory.getLogger(EmailCodeServiceImpl.class);
	@Resource
	private EmailCodeMapper<EmailCode, EmailCodeQuery> emailCodeMapper;

	@Resource
	private UserInfoMapper<UserInfo, UserInfoQuery> userInfoMapper;

	@Resource
	private AppConfig appConfig;


	@Resource
	private JavaMailSender javaMailSender;

	@Resource
	private RedisComponent redisComponent;

	/**
	 * 根据条件查询列表
	 */
	@Override
	public List<EmailCode> findListByParam(EmailCodeQuery param) {
		return this.emailCodeMapper.selectList(param);
	}

	/**
	 * 根据条件查询列表
	 */
	@Override
	public Integer findCountByParam(EmailCodeQuery param) {
		return this.emailCodeMapper.selectCount(param);
	}

	/**
	 * 分页查询方法
	 */
	@Override
	public PaginationResultVO<EmailCode> findListByPage(EmailCodeQuery param) {
		int count = this.findCountByParam(param);
		int pageSize = param.getPageSize() == null ? PageSize.SIZE15.getSize() : param.getPageSize();

		SimplePage page = new SimplePage(param.getPageNo(), count, pageSize);
		param.setSimplePage(page);
		List<EmailCode> list = this.findListByParam(param);
		PaginationResultVO<EmailCode> result = new PaginationResultVO(count, page.getPageSize(), page.getPageNo(), page.getPageTotal(), list);
		return result;
	}

	/**
	 * 新增
	 */
	@Override
	public Integer add(EmailCode bean) {
		return this.emailCodeMapper.insert(bean);
	}

	/**
	 * 批量新增
	 */
	@Override
	public Integer addBatch(List<EmailCode> listBean) {
		if (listBean == null || listBean.isEmpty()) {
			return 0;
		}
		return this.emailCodeMapper.insertBatch(listBean);
	}

	/**
	 * 批量新增或者修改
	 */
	@Override
	public Integer addOrUpdateBatch(List<EmailCode> listBean) {
		if (listBean == null || listBean.isEmpty()) {
			return 0;
		}
		return this.emailCodeMapper.insertOrUpdateBatch(listBean);
	}

	/**
	 * 多条件更新
	 */
	@Override
	public Integer updateByParam(EmailCode bean, EmailCodeQuery param) {
		StringTools.checkParam(param);
		return this.emailCodeMapper.updateByParam(bean, param);
	}

	/**
	 * 多条件删除
	 */
	@Override
	public Integer deleteByParam(EmailCodeQuery param) {
		StringTools.checkParam(param);
		return this.emailCodeMapper.deleteByParam(param);
	}

	/**
	 * 根据CodeAndEmail获取对象
	 */
	@Override
	public EmailCode getEmailCodeByCodeAndEmail(String code, String email) {
		return this.emailCodeMapper.selectByCodeAndEmail(code, email);
	}

	/**
	 * 根据CodeAndEmail修改
	 */
	@Override
	public Integer updateEmailCodeByCodeAndEmail(EmailCode bean, String code, String email) {
		return this.emailCodeMapper.updateByCodeAndEmail(bean, code, email);
	}

	/**
	 * 根据CodeAndEmail删除
	 */
	@Override
	public Integer deleteEmailCodeByCodeAndEmail(String code, String email) {
		return this.emailCodeMapper.deleteByCodeAndEmail(code, email);
	}

	@Override
	@Transactional(rollbackFor = Exception.class)
	public void senEmailCode(String email, Integer type) {
		if(type == Contstans.ZERC){
			UserInfo userInfo = userInfoMapper.selectByEmail(email);
			if(null != userInfo){
				throw new BusinessException("邮箱已存在");
			}
		}

		String code = StringTools.getRandomNumber(Contstans.LENGTH_5);
		//TODO 发送验证码
		senMailCode(email,code);

		emailCodeMapper.disableEmailCode(email);
		EmailCode emailCode = new EmailCode();
		emailCode.setCode(code);
		emailCode.setEmail(email);
		emailCode.setStatus(Contstans.ZERC);
		emailCode.setCreateTime(new Date());
		emailCodeMapper.insert(emailCode);

	}

	@Override
	public void checkCode(String email, String code) {
		EmailCode emailCode = emailCodeMapper.selectByCodeAndEmail(code,email);
		if(null == emailCode){
			throw new BusinessException("邮箱验证码不正确");
		}
		if(emailCode.getStatus() == 1 || System.currentTimeMillis()-emailCode.getCreateTime().getTime() > Contstans.LENGTH_5 * 1000 * 60){
			throw new BusinessException("邮箱验证码已生效");
		}


		emailCodeMapper.disableEmailCode(email);
	}


	private void senMailCode(String toEmail,String code){
		try{

			MimeMessage message = javaMailSender.createMimeMessage();
			MimeMessageHelper helper = new MimeMessageHelper(message,true);
			helper.setFrom(appConfig.getSendUserName());
			helper.setTo(toEmail);
			SysSettingsDto sysSettingsDto = redisComponent.getSysSettngDto();
			helper.setSubject(sysSettingsDto.getRegisterMailTitle());
			helper.setText(String.format(sysSettingsDto.getRegisterEmailContent(),code));
			helper.setSentDate(new Date());
			javaMailSender.send(message);

		}catch (Exception e){
           logger.error("邮箱发送失败");
		   throw  new BusinessException("邮箱发送失败");
		}
	}

}

package com.easypan.controller;
import com.easypan.entity.constants.Contstans;
import com.easypan.entity.dto.SessinoWebUserDto;
import com.easypan.entity.enums.ResponseCodeEnum;
import com.easypan.entity.vo.ResponseVO;
import com.easypan.exception.BusinessException;
import com.easypan.utils.StringTools;
import org.slf4j.Logger;
import org.slf4j.LoggerFactory;

import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;
import javax.sound.sampled.Control;
import java.io.File;
import java.io.FileInputStream;
import java.io.IOException;
import java.io.OutputStream;


public class ABaseController {


    private static final Logger logger = LoggerFactory.getLogger(ABaseController.class);


    protected static final String STATUC_SUCCESS = "success";

    protected static final String STATUC_ERROR = "error";

    protected <T> ResponseVO getSuccessResponseVO(T t) {
        ResponseVO<T> responseVO = new ResponseVO<>();
        responseVO.setStatus(STATUC_SUCCESS);
        responseVO.setCode(ResponseCodeEnum.CODE_200.getCode());
        responseVO.setInfo(ResponseCodeEnum.CODE_200.getMsg());
        responseVO.setData(t);
        return responseVO;
    }

    protected <T> ResponseVO getBusinessErrorResponseVO(BusinessException e, T t) {
        ResponseVO vo = new ResponseVO();
        vo.setStatus(STATUC_ERROR);
        if (e.getCode() == null) {
            vo.setCode(ResponseCodeEnum.CODE_600.getCode());
        } else {
            vo.setCode(e.getCode());
        }
        vo.setInfo(e.getMessage());
        vo.setData(t);
        return vo;
    }

    protected <T> ResponseVO getServerErrorResponseVO(T t) {
        ResponseVO vo = new ResponseVO();
        vo.setStatus(STATUC_ERROR);
        vo.setCode(ResponseCodeEnum.CODE_500.getCode());
        vo.setInfo(ResponseCodeEnum.CODE_500.getMsg());
        vo.setData(t);
        return vo;
    }

    protected SessinoWebUserDto getUserInfoFromSession(HttpSession httpSession){
        SessinoWebUserDto sessinoWebUserDto = (SessinoWebUserDto)httpSession.getAttribute(Contstans.SESSION_KEY);
        return sessinoWebUserDto;
    }
    protected  void readFile(HttpServletResponse response,String filePath){
        if(!StringTools.pathIsOk(filePath)){
            return;
        }
        OutputStream out = null;
        FileInputStream in = null;
        try{
            File file = new File(filePath);
            if(!file.exists()){
                return;
            }
            in = new FileInputStream(file);
            byte[] byteData = new byte[1024 * 1024 ];
            out = response.getOutputStream();
            int len = 0;
            while((len = in.read(byteData)) != -1){
                out.write(byteData,0,len);
            }
            out.flush();

        }catch (Exception e){
            logger.error("读取异常",e);
        }
        finally {
            if(out != null){
                try {
                    out.close();
                }catch (IOException e){
                    logger.error("IO异常",e);
                }
            }
            if(in != null){
                try{
                    in.close();
                }catch (IOException e){
                    logger.error("读取异常",e);
                }
            }


        }




    }

}

package com.easypan.aspect;


import com.easypan.annotation.Globallnterceptor;
import com.easypan.annotation.VerifyParam;
import com.easypan.entity.constants.Contstans;
import com.easypan.entity.dto.SessinoWebUserDto;
import com.easypan.entity.enums.ResponseCodeEnum;
import com.easypan.exception.BusinessException;
import com.easypan.utils.StringTools;
import com.easypan.utils.VerifyUtils;
import org.aspectj.lang.JoinPoint;
import org.aspectj.lang.annotation.Aspect;
import org.aspectj.lang.annotation.Before;
import org.aspectj.lang.annotation.Pointcut;
import org.aspectj.lang.reflect.MethodSignature;
import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import org.springframework.stereotype.Component;
import org.springframework.web.context.request.RequestContextHolder;
import org.springframework.web.context.request.ServletRequestAttributes;
import org.springframework.web.servlet.mvc.condition.RequestConditionHolder;
import org.springframework.web.servlet.support.RequestContext;

import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;
import java.lang.reflect.Field;
import java.lang.reflect.Method;
import java.lang.reflect.Parameter;



@Aspect
@Component("globalOpeneratcionAspect")
public class GlobalOpeneratcionAspect {

    private  static  final Logger logger = LoggerFactory.getLogger(GlobalOpeneratcionAspect.class);

    private static final String TYPE_STRING = "java.lang.String";

    private static final String TYPE_INTEGER = "java.lang.Integer";

    private static final String TYPE_LONG = "java.lang.Long";

    /***
     * 定义了一个切点，表示拦截所有被@Globallnterceptor注解标记的方法
     */
    @Pointcut("@annotation(com.easypan.annotation.Globallnterceptor)")
    private void requestInterceptor(){

    }

    @Before("requestInterceptor()")
    public void interceptorDo(JoinPoint point) throws BusinessException{
        try {
            Object targt = point.getTarget();
            Object[] aguments = point.getArgs();
            String methoName = point.getSignature().getName();;
            Class<?>[] parmeterTypes = ((MethodSignature) point.getSignature()).getMethod().getParameterTypes();
            Method method = targt.getClass().getMethod(methoName,parmeterTypes);
            Globallnterceptor interceptor = method.getAnnotation(Globallnterceptor.class);
            if (null == interceptor){
                return;
            }

            /**
             * 校验登入
             */
            if(interceptor.checkLogin() || interceptor.checkIsAdmin()){
                checkLogin(interceptor.checkIsAdmin());
            }


            /**
             * 参数校验
             */
            if(interceptor.checkParams()){
                 vaildateParms(method,aguments);
            }

        }catch (BusinessException e){
            logger.error("全局拦截异常",e);
            throw e;
        }catch (Exception e){
            logger.error("全局拦截异常",e);
            throw new BusinessException(ResponseCodeEnum.CODE_500);
        }catch (Throwable e){
            logger.error("全局拦截异常",e);
            throw new BusinessException(ResponseCodeEnum.CODE_500);
        }
    }

    private  void checkLogin(Boolean checkAdmin){
        HttpServletRequest httpServletRequest = ((ServletRequestAttributes) RequestContextHolder.getRequestAttributes()).getRequest();
        HttpSession session = httpServletRequest.getSession();
        SessinoWebUserDto webUserDto = (SessinoWebUserDto)session.getAttribute(Contstans.SESSION_KEY);
        if(null == webUserDto){
            throw new BusinessException(ResponseCodeEnum.CODE_901);
        }

        if(checkAdmin  && !webUserDto.getAdmin()){
            throw new BusinessException(ResponseCodeEnum.CODE_401);
        }
    }

    private void vaildateParms(Method m ,Object[] argments) throws BusinessException{
        Parameter[] parameters = m.getParameters();
        for(int i = 0 ; i <parameters.length ; i++){
            Parameter parameter = parameters[i];
            Object value = argments[i];
            VerifyParam verifyParam = parameter.getAnnotation(VerifyParam.class);
            if(verifyParam == null)
            {
                continue;
            }
            if(TYPE_STRING.equals(parameter.getParameterizedType().getTypeName()) || TYPE_LONG.equals(parameter.getParameterizedType().getTypeName()) || TYPE_INTEGER.equals(parameter.getParameterizedType().getTypeName())){
                checkValue(value,verifyParam);
            }else{
                checkobjValue(parameter,value);
            }

        }
    }

    private void checkobjValue(Parameter parameter,Object value){
        try {
            String typeName = parameter.getParameterizedType().getTypeName();
            Class classz = Class.forName(typeName);
            Field[] fields = classz.getDeclaredFields();
            for(Field field : fields){
                VerifyParam verifyParam = field.getAnnotation(VerifyParam.class);
                if(verifyParam == null){
                    continue;
                }
                field.setAccessible(true);
                Object resuitValue = field.get(value);
                checkValue(resuitValue,verifyParam);
            }
        }catch (BusinessException e) {
            logger.error("校验参数失败", e);
            throw e;
        }catch (Exception e){
            logger.error("校验参数失败",e);
            throw new BusinessException(ResponseCodeEnum.CODE_600);
        }
    }

    private void checkValue(Object value,VerifyParam verifyParam) throws BusinessException{
        Boolean isEmpty = value == null || StringTools.isEmpty(value.toString());
        Integer length = value == null ? 0 : value.toString().length();


        /**
         * 校验空
          */
        if(isEmpty && verifyParam.required()){
            throw new BusinessException(ResponseCodeEnum.CODE_600);
        }
        /**
         * 校验长度
         */
        if(!isEmpty && (verifyParam.max() != -1 && verifyParam.max() < length || verifyParam.min() != -1 && verifyParam.min() > length)){
           throw new BusinessException(ResponseCodeEnum.CODE_600);
        }
        /**
         * 校验正则
         */
        if(!isEmpty && !StringTools.isEmpty(verifyParam.reqex().getReqex()) && !VerifyUtils.verify(verifyParam.reqex(),String.valueOf(value))){
            throw new BusinessException(ResponseCodeEnum.CODE_600);
        }
    }

}

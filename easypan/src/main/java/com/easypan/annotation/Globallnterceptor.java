package com.easypan.annotation;

import org.springframework.web.bind.annotation.Mapping;

import java.lang.annotation.*;

@Target({ElementType.METHOD})
@Retention(RetentionPolicy.RUNTIME)
@Mapping
@Documented
public @interface Globallnterceptor {
    /***
     * 参数校验
     * @return
     */
    boolean checkParams() default  false;

    /**
     * 登入校验
     * @return
     */
    boolean checkLogin() default  true;

    /***
     * 校验超级管理员
     * @return
     */
    boolean checkIsAdmin() default false;
}

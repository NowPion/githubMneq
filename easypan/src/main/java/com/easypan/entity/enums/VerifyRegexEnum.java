package com.easypan.entity.enums;

public enum VerifyRegexEnum {
    No("","不校验"),
    EMAIL("^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$","邮箱"),
    PASSWORD("^[a-zA-Z0-9!@#$%^&*()_+\\-=\\[\\]{};':\",.<>?/]{8,18}$","只能是数字，字母，特殊字符 8 - 18 位");

    private String reqex;
    private String desc;
    VerifyRegexEnum(String reqex,String desc){
        this.reqex = reqex;
        this.desc = desc;
    }

    public String getReqex() {
        return reqex;
    }

    public String getDesc() {
        return desc;
    }
}

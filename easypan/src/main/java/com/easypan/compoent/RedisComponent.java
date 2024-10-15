package com.easypan.compoent;

import com.easypan.entity.constants.Contstans;
import com.easypan.entity.dto.SysSettingsDto;
import com.easypan.entity.dto.UserSpaceDto;
import org.springframework.stereotype.Component;

import javax.annotation.Resource;



@Component("redisComponent")
public class RedisComponent {
    @Resource
    private RedisUtils redisUtils;

    public SysSettingsDto getSysSettngDto(){
        SysSettingsDto sysSettingsDto = (SysSettingsDto)redisUtils.get(Contstans.REDIS_KEY_SETTING);
        if(null == sysSettingsDto){
            sysSettingsDto = new SysSettingsDto();
            redisUtils.set(Contstans.REDIS_KEY_SETTING,sysSettingsDto);
        }
        return  sysSettingsDto;
    }


    public void saveUserSpaceUser(String userId, UserSpaceDto userSpaceDto){
        redisUtils.setex(Contstans.REDIS_KEY_User_SETTING + userId,userSpaceDto,Contstans.REDIS_KEY_EXPIRES_ONE_DAY);
    }


    public UserSpaceDto getUserSpaceUse(String userId){
        UserSpaceDto userSpaceDto = (UserSpaceDto)redisUtils.get(Contstans.REDIS_KEY_User_SETTING + userId);

        if(null == userSpaceDto){
            userSpaceDto = new UserSpaceDto();
            userSpaceDto.setUserSpace(0L);
            userSpaceDto.setTotalSpace(getSysSettngDto().getUserInitUseSpace() * Contstans.MB);
            saveUserSpaceUser(userId,userSpaceDto);
        }

        return userSpaceDto;
    }




}

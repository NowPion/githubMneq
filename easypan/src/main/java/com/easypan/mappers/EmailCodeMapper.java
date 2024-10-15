package com.easypan.mappers;

import org.apache.ibatis.annotations.Param;

/**
 * 邮箱验证码
 数据库操作接口
 */
public interface EmailCodeMapper<T,P> extends BaseMapper<T,P> {

	/**
	 * 根据CodeAndEmail更新
	 */
	 Integer updateByCodeAndEmail(@Param("bean") T t,@Param("code") String code,@Param("email") String email);


	/**
	 * 根据CodeAndEmail删除
	 */
	 Integer deleteByCodeAndEmail(@Param("code") String code,@Param("email") String email);


	/**
	 * 根据CodeAndEmail获取对象
	 */
	 T selectByCodeAndEmail(@Param("code") String code,@Param("email") String email);


	void disableEmailCode(@Param("email") String email);
}

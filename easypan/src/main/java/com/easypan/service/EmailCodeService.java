package com.easypan.service;

import java.util.List;

import com.easypan.entity.query.EmailCodeQuery;
import com.easypan.entity.po.EmailCode;
import com.easypan.entity.vo.PaginationResultVO;


/**
 * 邮箱验证码
 业务接口
 */
public interface EmailCodeService {

	/**
	 * 根据条件查询列表
	 */
	List<EmailCode> findListByParam(EmailCodeQuery param);

	/**
	 * 根据条件查询列表
	 */
	Integer findCountByParam(EmailCodeQuery param);

	/**
	 * 分页查询
	 */
	PaginationResultVO<EmailCode> findListByPage(EmailCodeQuery param);

	/**
	 * 新增
	 */
	Integer add(EmailCode bean);

	/**
	 * 批量新增
	 */
	Integer addBatch(List<EmailCode> listBean);

	/**
	 * 批量新增/修改
	 */
	Integer addOrUpdateBatch(List<EmailCode> listBean);

	/**
	 * 多条件更新
	 */
	Integer updateByParam(EmailCode bean,EmailCodeQuery param);

	/**
	 * 多条件删除
	 */
	Integer deleteByParam(EmailCodeQuery param);

	/**
	 * 根据CodeAndEmail查询对象
	 */
	EmailCode getEmailCodeByCodeAndEmail(String code,String email);


	/**
	 * 根据CodeAndEmail修改
	 */
	Integer updateEmailCodeByCodeAndEmail(EmailCode bean,String code,String email);


	/**
	 * 根据CodeAndEmail删除
	 */
	Integer deleteEmailCodeByCodeAndEmail(String code,String email);


	void senEmailCode(String email,Integer type);

	void checkCode(String email,String code);


}

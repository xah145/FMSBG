/**************************************************************** 
 * 作    者：黄鼎 
 * CLR 版本：4.0.30319.42000 
 * 创建时间：2017-05-14 13:20:30 
 * 当前版本：1.0.0.0
 *  
 * 描述说明： 
 * 
 * 修改历史： 
 * 
***************************************************************** 
 * Copyright @ Dean 2017 All rights reserved 
*****************************************************************/
using FileSystem.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FileSystem.BLL
{
    public class AuthLogic:BaseLogic<UserFunctionService>
    {
        /// <summary>
        /// 判断用户是否拥有指定权限
        /// </summary>
        /// <param name="uid"></param>
        /// <param name="functionControl"></param>
        /// <returns></returns>
        public bool Auth(int uid,string functionControl)
        {
            return Service.GetFuncitonByUID(uid, functionControl) != null;
        }

        /// <summary>
        ///  判断用户是否拥有指定权限,默认为当前用户
        /// </summary>
        /// <param name="functionControl"></param>
        /// <returns></returns>
        public bool Auth(string functionControl)
        {
            return Auth(GObj.CurrentUser.UserID, functionControl);
        }
    }
}

/**************************************************************** 
 * 作    者：黄鼎 
 * CLR 版本：4.0.30319.42000 
 * 创建时间：2017-05-12 0:27:59 
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
using FileSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FileSystem.BLL
{
    /// <summary>
    /// 基础逻辑类，帮你自动返回一个实现IService的XXXService类型的实例，如UserService
    /// </summary>
    /// <typeparam name="T">你想返回的Service具体类型</typeparam>
    public class BaseLogic<T>
        //约束这个T类型必须是一个类(class)
        ///必须是IService的子类(IServce)
        ///必须有一个无参构造方法(new())
        where T : class, IService, new()
    {
       

        //保存具体的XXXService对象
        private T _service;

        /// <summary>
        /// 子类被实例化时自动为子类创建对应的DAL层XXXService
        /// 子类可以通过Service拿到这个T类型的具体XXXService
        /// </summary>
        public BaseLogic()
        {
            _service = Factory.Create<T>();//Type
        }     

        /// <summary>
        /// 提供给子类即XXXLogic类使用，通过该属性可以拿到具体的FileSystem.DAL.XXXService的对象，该对象继承自IService接口
        /// </summary>
        public T Service { get => _service; }
    }
}

﻿/**
* author:xishuai
* address:https://www.github.com/yuezhongxin/MessageManager
**/

using MessageManager.Domain.Repositories;
using MessageManager.Domain.ValueObject;

namespace MessageManager.Repositories
{
    public class ContactRepository : IContactRepository
    {
        #region ContactRepository Members
        /// <summary>
        /// 通过登录名获取用户
        /// </summary>
        /// <param name="loginName">登录名</param>
        /// <returns></returns>
        public Contact GetContactByLoginName(string loginName)
        {
            return new Contact("1");
            //Contact account = new Contact(loginName, "小菜");
            //account.ID = "1";
            //return account;
            //return Get(new ContactNameEqualsSpecification(name));
        }
        /// <summary>
        /// 通过显示名获取用户
        /// </summary>
        /// <param name="displayName">显示名</param>
        /// <returns></returns>
        public Contact GetContactByDisplayName(string displayName)
        {
            return new Contact("2");
            //Contact account = new Contact("dashen", displayName);
            //account.ID = "2";
            //return account;
            //return Get(new ContactNameEqualsSpecification(name));
        }
        #endregion
    }
}

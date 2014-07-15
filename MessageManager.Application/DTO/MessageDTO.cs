﻿/**
* author:xishaui
* address:https://www.github.com/yuezhongxin/MessageManager
**/

using System;

namespace MessageManager.Application.DTO
{
    public class MessageDTO
    {
        #region DTO成员
        public string ID { get; set; }
        public ContactDTO SendAccount { get; set; }
        public ContactDTO ReceiveAccount { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime SendTime { get; set; }
        public string Status { get; set; }
        #endregion
    }
}

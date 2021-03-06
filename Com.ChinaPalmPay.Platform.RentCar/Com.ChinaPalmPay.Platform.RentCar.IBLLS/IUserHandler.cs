﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Com.ChinaPalmPay.Platform.RentCar.Model;
using System.Web;
using Com.ChinaPalmPay.Platform.RentCar.Model.ParamModel;


namespace Com.ChinaPalmPay.Platform.RentCar.IBLLS
{
   public interface IUserHandler
    {
        UserLogin UserRegHandler(UserReg login);
        string UserLoginHandler(UserReg login);
        User UserCompleteHandler(User info);
        UserLogin UserUpdateHandler(string OldPwd, string LoginPwd, string UserID);
        UserLogin changeTelHandler(ChangeTel info);
        User findUserInfomation(string id);
       //修改头像
        User changePhoto(string UserID, string filePhotoPath);
        User WechatUserReg(string PhoneNumber, string Password, string IDCardNo, string OpenID, string tel);
        User queryOpenIdHandler(string openId);
       //查询用户消息
        IList<Messages> queryMessageHandler(string userid);
    }
}

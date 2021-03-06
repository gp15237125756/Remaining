﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.ChinaPalmPay.Platform.RentCar.Model;
using Com.ChinaPalmPay.Platform.RentCar.Model.ParamModel;

namespace Com.ChinaPalmPay.Platform.RentCar.IDAL
{
   public interface IUserManager
    {
       //验证微信或者app注册用户是否存在
       bool veriryUserExistOrNot(string CardId, string tel);
        UserLogin Create(UserGroup Base, UserLogin login, User info, UserRegister register);
        UserGroup Create(UserGroup Base);
        UserLogin CreateOrUpdate(UserLogin Base);
        User CreateOrUpdate(User Base);
        UserRegister Create(UserRegister Base);
        bool verifyUser(UserReg login);
        UserLogin verifyUserPwd(string UserId, string oldPwd);
        User selectUser(User info);
        User updateUser(User info);
        void deleteUser(string uid);
        void addPrivilege(UserLogin bases);
        string getUserId(UserLogin bases);
        User findLoginUser(UserLogin LoginUser);
        User UserComplete(User info);
        User findUserInfomation(string id);
        User findUserId(string id);
       //微信用户绑定
        string WechatBinding(string tel,string openId);
       //openId查询
        User selectOpenId(string id);
       //根据身份证号查询userid
        string selectUserIdByCardId(string id);
       //增加app用户login
        UserLogin AddExistUserLogin(UserLogin log);
       //查询消息
        IList<Messages> queryMsg(string id);
       //根据手机号查询被授权人是否注册且通过审核，返回被授权人User信息
        User queryBeAutho(string Tel);

     }
}

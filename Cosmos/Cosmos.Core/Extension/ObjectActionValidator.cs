using Cosmos.Core.ObjectActionValidator;
using Cosmos.Entity.DomainModels;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cosmos.Core.Extension
{
   public static class ObjectActionValidator
    {
        public static IServiceCollection UseMethodsModelParameters(this IServiceCollection services)
        {
            // Veritify Username, pwd and verification code
            ValidatorLoginModel.Login.Add<LoginInfo>(x => new
            {
                x.PassWord,
                x.UserName,
                x.VerificationCode,
                x.UUID
            });

            // Veritify password
           ValidatorLoginModel.LoginOnlyPassWord.Add<LoginInfo>(
                x => new
                {
                    x.PassWord
                });

            return services;
        }

        public static IServiceCollection UseMethodsGeneralParameters(this IServiceCollection services)
        {
            ValidatorGeneral.UserName.Add("用户名", 30);
            ValidatorGeneral.NewPwd.Add("新密码", 6, 50);
            ValidatorGeneral.OldPwd.Add("旧密码");
            ValidatorGeneral.PhoneNo.Add("手机号码", (object value) =>
            {
                ObjectValidatorResult validatorResult = new ObjectValidatorResult(true);
                if (!value.ToString().IsPhoneNo())
                {
                    validatorResult = validatorResult.Error("请输入正确的手机号码");
                }
                return validatorResult;
            });

            ValidatorGeneral.Local.Add("所在地", 6, 10);
            ValidatorGeneral.Qty.Add("存货量", ParamType.Int, 200, 500);
            return services;
        }
    }

    

    public enum ValidatorLoginModel
    {
        Login,
        LoginOnlyPassWord
    }

    public enum ValidatorGeneral
    {
        UserName,
        OldPwd,
        NewPwd,
        PhoneNo,
        Local,// validator length
        Qty // validator code value
    }
}

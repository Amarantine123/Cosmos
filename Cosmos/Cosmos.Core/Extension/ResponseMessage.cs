using Cosmos.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos.Core.Extension
{
    public static class ResponseMessage
    {
        public static string GetMessage(this HttpResponseType httpResponseType)
        {
            string msg = string.Empty;
            switch (httpResponseType)
            {
                case HttpResponseType.LoginExpiration:
                    msg = "Login Expired, Please Login Again"; break;
                case HttpResponseType.TokenExpiration:
                    msg = "Token Has Expired, Please Login Again"; break;
                case HttpResponseType.AccountLocked:
                    msg = "Account has been locked"; break;
                case HttpResponseType.LoginSuccess:
                    msg = "Login Successful"; break;
                case HttpResponseType.ParametersLack:
                    msg = "Incomplete Parameters"; break;
                case HttpResponseType.NoPermissions:
                    msg = "No Operation Authority"; break;
                case HttpResponseType.NoRolePermissions:
                    msg = "Role Has No Operation Authority"; break;
                case HttpResponseType.ServerError:
                    msg = "There Seems To Be Some Problems With Server..."; break;
                case HttpResponseType.LoginError:
                    msg = "Wrong Username or Password"; break;
                case HttpResponseType.SaveSuccess:
                    msg = "Save Successfully"; break;
                case HttpResponseType.NoKey:
                    msg = "Can Not Edit Without Primary Key"; break;
                case HttpResponseType.NoKeyDel:
                    msg = "Can Not Delete Without Primary Key"; break;
                case HttpResponseType.KeyError:
                    msg = "Incorrect Promary Key Or No Primary Key"; break;
                case HttpResponseType.EidtSuccess:
                    msg = "Edit Successfully"; break;
                case HttpResponseType.DelSuccess:
                    msg = "Delete Successfully"; break;
                case HttpResponseType.RegisterSuccess:
                    msg = "Register Successfully"; break;
                case HttpResponseType.AuditSuccess:
                    msg = "Audit Successfully"; break;
                case HttpResponseType.ModifyPwdSuccess:
                    msg = "Modify Password Successfully"; break;
                case HttpResponseType.OperSuccess:
                    msg = "Operate Successfully"; break;
                case HttpResponseType.PINError:
                    msg = "Incorrect Vertification Code"; break;

                default: msg = httpResponseType.ToString(); break;
            }
            return msg;

        }
    }
}

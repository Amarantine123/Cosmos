using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;


namespace Cosmos.Entity.DomainModels
{
    [JsonObject]
    public class Sys_UserLoginInfoEntity:BaseEntity
    {

        [JsonProperty("user_Id")]
        public int User_Id { get; set; }
        
        [JsonProperty("role_Id")]
        public int Role_Id { get; set; }

        [JsonProperty("role_Ids")]
        public int[] Role_Ids { get; set; }

        [JsonProperty("userName")]
        public string UserName { get; set; }

        [JsonProperty("userTrueName")]
        public string UserTrueName { get; set; }

        [JsonProperty("roleName")]
        public string RoleName { get; set; }

        [JsonProperty("is_Enable")]
        public bool Is_Enable { get; set; }

        [JsonProperty("token")]
        public string Token { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Cosmos.Entity.DomainModels
{
    /// <summary>
    /// Login Info
    /// When user login, will submit these info to server then server will vertify these info
    /// </summary>
   public class Sys_LoginInfoEntity
    {
        /// <summary>
        /// User Name
        /// </summary>
        [MaxLength(50)]
        [Required(ErrorMessage = "Can not be empty")]
        public string UserName { get; set; }

        /// <summary>
        /// Password
        /// </summary>
        [Required(ErrorMessage = "Can not be empty")]
        public string PassWord { get; set; }


        /// <summary>
        /// Vertification Code
        /// </summary>
        [MaxLength(6)]
        [Display(Name ="Vertification Code")]
        [Required(ErrorMessage ="Can not be empty")]
        public string VerificationCode { get; set; }


        /// <summary>
        /// UUID
        /// </summary>
        [Required(ErrorMessage = "Incomplete parameters")]
        public string UUID { get; set; }
    }
}

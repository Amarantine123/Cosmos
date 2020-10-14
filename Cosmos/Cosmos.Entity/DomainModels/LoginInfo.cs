using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Cosmos.Entity.DomainModels
{
   public class LoginInfo
    {
        [MaxLength(50)]
        [Required(ErrorMessage = "Can not be empty")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Can not be empty")]
        public string PassWord { get; set; }
        [MaxLength(6)]
        [Display(Name ="Vertification Code")]
        [Required(ErrorMessage ="Can not be empty")]
        public string VerificationCode { get; set; }
        [Required(ErrorMessage = "Incomplete parameters")]
        public string UUID { get; set; }
    }
}

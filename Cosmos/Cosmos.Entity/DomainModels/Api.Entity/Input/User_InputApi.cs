using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Cosmos.Entity.DomainModels
{
    public class User_InputApi
    {
        
        [MaxLength(200)]
        [Column(TypeName = "nvarchar(200)")]
        [Editable(true)]
        [Required(AllowEmptyStrings = false)]
        public string UserName { get; set; }

        
        
        [MaxLength(400)]
        [Column(TypeName = "nvarchar(400)")]
        [Required(AllowEmptyStrings = false)]
        public string UserPassword { get; set; }

        [MaxLength(22)]
        [Column(TypeName = "nvarchar(22)")]
        [Required(AllowEmptyStrings = false)]
        public string PhoneNumber { get; set; }
    }
}

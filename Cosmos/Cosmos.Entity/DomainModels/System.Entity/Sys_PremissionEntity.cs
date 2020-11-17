using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Cosmos.Entity.DomainModels
{
    [Table("Sys_Premission")]
    public class Sys_PremissionEntity:BaseEntity
    {
        [Key]
        [Required(AllowEmptyStrings = false)]
        public int Premission_Id { get; set; }

        //[Display(Name = "")]
        //[Column(TypeName = "int")]
        //public int? Role_Id { get; set; }


        //[Display(Name = "")]
        //[Column(TypeName = "int")]
        //public int? User_Id { get; set; }



        [Column(TypeName = "int")]
        [Required(AllowEmptyStrings = false)]
        public int Menu_Id { get; set; }


        [MaxLength(1000)]
        [Column(TypeName = "nvarchar(1000)")]
        [Required(AllowEmptyStrings = false)]
        public string PremissionValue { get; set; }

      
        [MaxLength(100)]
        [Column(TypeName = "nvarchar(1000)")]
        public string Creator { get; set; }

        [Display(Name = "")]
        [Column(TypeName = "datetime")]
        public DateTime? CreateDate { get; set; }

        
        [MaxLength(100)]
        [Column(TypeName = "nvarchar(1000)")]
        public string Modifier { get; set; }

        
        [Column(TypeName = "datetime")]
        public DateTime? ModifyDate { get; set; }
    }
}

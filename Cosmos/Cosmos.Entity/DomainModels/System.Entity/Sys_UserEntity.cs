using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Text.Json.Serialization;

namespace Cosmos.Entity.DomainModels
{
    [Table("Sys_User")]
    [Entity(InputApi = typeof(User_InputApi), OutputApi = typeof(User_OutputApi))]
    public class Sys_UserEntity
    {
        [MaxLength(200)]
        [Column(TypeName = "nvarchar(200)")]
        [Editable(true)]
        [Required(AllowEmptyStrings = false)]
        public string UserName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [Key]
        [Display(Name = "User_Id")]
        [Column(TypeName = "int")]
        [Required(AllowEmptyStrings = false)]
        public int User_Id { get; set; }

       
        [Column(TypeName = "int")]
        [Editable(true)]
        public int? Gender { get; set; }

       
        [MaxLength(400)]
        [Column(TypeName = "nvarchar(400)")]
        [Editable(true)]
        public string HeadImageUrl { get; set; }

        [Column(TypeName = "int")]
        public int? Dept_Id { get; set; }

        
        //[MaxLength(300)]
        //[Column(TypeName = "nvarchar(300)")]
        //[Editable(true)]
        //public string DeptName { get; set; }

       
        [Column(TypeName = "int")]
        [Editable(true)]
        [Required(AllowEmptyStrings = false)]
        public int Role_Id { get; set; }

      
        //[MaxLength(300)]
        //[Column(TypeName = "nvarchar(300)")]
        //[Editable(true)]
        //[Required(AllowEmptyStrings = false)]
        //public string RoleName { get; set; }

        [MaxLength(1000)]
        [Column(TypeName = "nvarchar(1000)")]
        [Editable(true)]
        public string Token { get; set; }

       
        [Column(TypeName = "int")]
        [Editable(true)]
        public int? AppType { get; set; }

        [MaxLength(40)]
        [Column(TypeName = "nvarchar(40)")]
        [Editable(true)]
        [Required(AllowEmptyStrings = false)]
        public string UserTrueName { get; set; }

        [MaxLength(400)]
        [JsonIgnore]
        [Column(TypeName = "nvarchar(400)")]
        public string UserPwd { get; set; }

        [Column(TypeName = "datetime")]
        [Editable(true)]
        public DateTime? CreateDate { get; set; }

       
        [Column(TypeName = "int")]
        [Editable(true)]
        [Required(AllowEmptyStrings = false)]
        public int IsRegregisterPhone { get; set; }

       
        [MaxLength(22)]
        [Column(TypeName = "nvarchar(22)")]
        public string PhoneNo { get; set; }

        
        [MaxLength(40)]
        [Column(TypeName = "nvarchar(40)")]
        public string Tel { get; set; }

       
        [Column(TypeName = "int")]
        public int? CreateID { get; set; }

       
        [MaxLength(400)]
        [Column(TypeName = "nvarchar(400)")]
        [Editable(true)]
        public string Creator { get; set; }

       
        [Column(TypeName = "tinyint")]
        [Editable(true)]
        [Required(AllowEmptyStrings = false)]
        public byte Enable { get; set; }

       
        [Column(TypeName = "int")]
        public int? ModifyID { get; set; }

        
        [MaxLength(400)]
        [Column(TypeName = "nvarchar(400)")]
        public string Modifier { get; set; }

      
        [Column(TypeName = "datetime")]
        public DateTime? ModifyDate { get; set; }

       
        [Column(TypeName = "int")]
        public int? AuditStatus { get; set; }

        [MaxLength(400)]
        [Column(TypeName = "nvarchar(400)")]
        public string Auditor { get; set; }

       
        [Column(TypeName = "datetime")]
        public DateTime? AuditDate { get; set; }

        
        [Column(TypeName = "datetime")]
        public DateTime? LastLoginDate { get; set; }

        
        [Column(TypeName = "datetime")]
        public DateTime? LastModifyPwdDate { get; set; }

       
        [MaxLength(400)]
        [Column(TypeName = "nvarchar(400)")]
        [Editable(true)]
        public string Address { get; set; }

        [MaxLength(200)]
        [Column(TypeName = "nvarchar(200)")]
        [Editable(true)]
        public string Mobile { get; set; }

        [MaxLength(200)]
        [Column(TypeName = "nvarchar(200)")]
        [Editable(true)]
        public string Email { get; set; }

        [MaxLength(400)]
        [Column(TypeName = "nvarchar(400)")]
        [Editable(true)]
        public string Remark { get; set; }

        
        [Column(TypeName = "int")]
        [Editable(true)]
        public int? OrderNo { get; set; }
    }
}

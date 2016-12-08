using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RecaiBlogMVC.Models.ORM.Entity
{
    public class AdminUser:BaseEntity //baseentity sinifından miras aldık
    {
        public string Name { get; set; }

        public string SurName { get; set; }

        [Required]//boş geçilemez
        [StringLength(30)]//Email uzunluğu 30 karakter yaptık
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }



    }
}
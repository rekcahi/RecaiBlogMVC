using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RecaiBlogMVC.Areas.Admin.Models.DTO
{
    public class LoginModel
    {
        [Required(ErrorMessage ="Lütfen Email Adresini Doldurunuz")]//validation---->DataAnnotationsBOŞ OLMA DURUMUNU KONTROL ETME
        [EmailAddress(ErrorMessage ="Düzgün Bir Email Adresi giriniz")]//email formatı kontrolu---->DataAnnotations
        public string Email { get; set; }
        [Required(ErrorMessage ="Lütfen Parola Kısmını Doldurunuz")]
        public string Password { get; set; }
    }
}
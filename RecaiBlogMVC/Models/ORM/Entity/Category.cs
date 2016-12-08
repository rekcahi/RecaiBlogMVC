using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RecaiBlogMVC.Models.ORM.Entity
{
    public class Category:BaseEntity
    {

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public virtual List<BlogPost> BlogPost { get; set; }//bir categorinin sınırsız blogpostu var--->1-* 1 e çok ilişki var


    }
}
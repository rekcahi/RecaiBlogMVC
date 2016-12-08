using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RecaiBlogMVC.Models.ORM.Entity
{
    public class BlogPostComment:BaseEntity
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string Content { get; set; }

        private bool _IsActive = false;

        public bool IsActive { get
            {
                return _IsActive;
            }
            set
            {

                _IsActive = value ;
            }
        }

        public int BlogPostID { get; set; }

        [ForeignKey("BlogPostID")]
        public virtual BlogPost BlogPost { get; set; }


    }
}
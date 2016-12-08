using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RecaiBlogMVC.Models.ORM.Entity
{
    public class BaseEntity
    {
        public int ID { get; set; }//primary key and increment birer artan


        private DateTime? _addDate = DateTime.Now;//veri kapsülleme ----veri (private) olduğu için ancak set ile değiştirebiliyoruz
        public DateTime? AddDate {//------?----- soru işaretinin anlamı boş geçilebilir manasında tabloda allow null
            get
            {
                return _addDate;
            }
            set
            {

                _addDate = value;
            }
        }
        private bool _isDeleted = false;
        public bool IsDeleted { get
            {
                return _isDeleted;
            }
            set
            {
                _isDeleted = value;
            }
        }
        public DateTime DeleteDate { get; set; }


    }
}
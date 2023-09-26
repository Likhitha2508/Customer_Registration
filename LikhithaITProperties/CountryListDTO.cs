using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikhithaIT.Properties
{
    public class CountryListDTO
    {
        #region Country Properties
        public bool IsActive { get; set; }
        public int CountryId { get; set; }
        public string CountryName { get; set; }
       // public bool Displayonweb { get; set; }
        public string CreatedBy { get; set; }
        public DateTime DateCreated { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool IsDeleted { get; set; }
        public string DeletedBy { get; set; }
        public DateTime DateDeleted { get; set; }
        public string IPAddress { get; set; }
        #endregion
        #region Constructor and it's assigned default values.
     public   CountryListDTO()
        {
            IsActive = false;
            CountryId = 0;
            CountryName=string.Empty;
            //Displayonweb = false;
            CreatedBy = string.Empty;
            DateCreated = DateTime.MinValue;
            UpdatedBy= string.Empty;
            DateUpdated = DateTime.MinValue;
            IsDeleted = false;
            DeletedBy= string.Empty;
            DateDeleted= DateTime.MinValue;
            IPAddress = string.Empty;
             
        }
        #endregion
    }
}

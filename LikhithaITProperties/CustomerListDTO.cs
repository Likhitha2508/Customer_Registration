using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LikhithaIT.Properties
{
    public class CustomerListDTO
    {
        #region Customer Properties
        public bool IsActive { get; set; }
        public int CustomerId { get; set; }
        public int CountryId { get; set; }
        public int StateId { get; set; }
        public int DistrictId { get; set; }
        public int CityId { get; set; }
        public int VillageId { get; set; }
        public string CustomerName { get; set; }
        public string CountryName { get; set; }
        public string StateName { get; set; }
        public string DistrictName { get; set; }
        public string CityName { get; set; }
        public string VillageName { get; set; }
        public string IPAddress { get; set; }
        public string CreatedBy { get; set; }
        public DateTime DateCreated { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool IsDeleted { get; set; }
        public string DeletedBy { get; set; }
        public DateTime DateDeleted { get; set; }
        public int Pincode { get; set; }


        public CustomerListDTO()
        {
            IsActive = false;
            CustomerId = 0;
            CountryId = 0;
            StateId = 0;
            DistrictId = 0;
            CityId = 0;
            VillageId = 0;
            CustomerName = string.Empty;
            CountryName = string.Empty;
            StateName = string.Empty;
            DistrictName = string.Empty;
            CityName = string.Empty;
            VillageName = string.Empty;
            IPAddress = string.Empty;
            CreatedBy = string.Empty;
            DateCreated = DateTime.Now;
            UpdatedBy = string.Empty;
            DateUpdated = DateTime.Now;
            IsDeleted = false;
            DeletedBy = string.Empty;
            DateDeleted = DateTime.Now;
            Pincode = 0;
            #endregion
        }


    }
}

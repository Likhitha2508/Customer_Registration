using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Likhitha.ITProperties
{
    public class CityListDTO
    {
        #region District Properties
        public bool IsActive { get; set; }
        public int CityId { get; set; }
        public int DistrictId { get; set; }
        public int CountryId { get; set; }
        public int StateId { get; set; }
        public string StateName { get; set; }
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
        public CityListDTO()
        {
            IsActive = false;
            CityId = 0;
            DistrictId = 0;
            CountryId = 0;
            StateId = 0;
            StateName = string.Empty;
            CreatedBy = string.Empty;
            DateCreated = DateTime.MinValue;
            UpdatedBy = string.Empty;
            DateUpdated = DateTime.MinValue;
            IsDeleted = false;
            DeletedBy = string.Empty;
            DateDeleted = DateTime.MinValue;
            IPAddress = string.Empty;
        }
        #endregion
    }
}

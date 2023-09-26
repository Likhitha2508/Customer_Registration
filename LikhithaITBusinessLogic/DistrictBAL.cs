using Likhitha.DataAccess;
using Likhitha.ITProperties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Likhitha.ITBusinessLogic
{
    public class DistrictBAL
    {
        public DataSet GetDistrictsById(DistrictListDTO objDistrictListDTO)
        {
            DistrictDAL objDistrictDAL = new DistrictDAL();
            return objDistrictDAL.GetDistrictByIdDB(objDistrictListDTO);
        }
    }
}

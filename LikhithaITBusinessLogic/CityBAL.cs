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
    public class CityBAL
    {
        public DataSet GetCitiesById(CityListDTO objCityListDTO)
        {
            CityDAL objCityDAL = new CityDAL();
            return objCityDAL.GetCitiesByIdDB(objCityListDTO);
        }
    }
}

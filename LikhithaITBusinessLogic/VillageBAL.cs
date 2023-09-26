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
    public class VillageBAL
    {
        public DataSet GetVillagesById(VillageListDTO objVillageListDTO)
        {
            VillageDAL objVillageDAL = new VillageDAL();
            return objVillageDAL.GetVillagesByIdDB(objVillageListDTO);
        }
    }
}

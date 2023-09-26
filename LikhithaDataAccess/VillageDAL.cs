using Likhitha.ITProperties;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Likhitha.DataAccess
{
    public class VillageDAL
    {
        public DataSet GetVillagesByIdDB(VillageListDTO objVillageListDTO)
        {
            using (SqlConnection objSqlConnection = new SqlConnection(Convert.ToString(ConfigurationManager.ConnectionStrings["CustomerDBConnectionString"])))
            {
                using (SqlCommand objSqlCommand = new SqlCommand("uspGetVillagessById", objSqlConnection))
                {
                    try
                    {
                        objSqlCommand.CommandType = CommandType.StoredProcedure;
                        objSqlCommand.Parameters.AddWithValue("IsActive", objVillageListDTO.IsActive);
                        objSqlCommand.Parameters.AddWithValue("CountryId", objVillageListDTO.CountryId);
                        objSqlCommand.Parameters.AddWithValue("StateId", objVillageListDTO.StateId);
                        objSqlCommand.Parameters.AddWithValue("DistrictId", objVillageListDTO.DistrictId);
                        objSqlCommand.Parameters.AddWithValue("CityId", objVillageListDTO.CityId);

                        SqlDataAdapter objDa = new SqlDataAdapter(objSqlCommand);
                        DataSet objDs = new DataSet();
                        objDa.Fill(objDs);
                        return objDs;
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
            }

        }
    }
}

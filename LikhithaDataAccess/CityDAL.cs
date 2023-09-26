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
    public class CityDAL
    {
        public DataSet GetCitiesByIdDB(CityListDTO objCityListDTO)
        {
            using (SqlConnection objSqlConnection = new SqlConnection(Convert.ToString(ConfigurationManager.ConnectionStrings["CustomerDBConnectionString"])))
            {
                using (SqlCommand objSqlCommand = new SqlCommand("uspGetCitiesById", objSqlConnection))
                {
                    try
                    {
                        objSqlCommand.CommandType = CommandType.StoredProcedure;
                        objSqlCommand.Parameters.AddWithValue("IsActive", objCityListDTO.IsActive);
                        objSqlCommand.Parameters.AddWithValue("CountryId", objCityListDTO.CountryId);
                        objSqlCommand.Parameters.AddWithValue("StateId", objCityListDTO.StateId);
                        objSqlCommand.Parameters.AddWithValue("DistrictId", objCityListDTO.DistrictId);

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

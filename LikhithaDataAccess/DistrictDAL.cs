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
    public class DistrictDAL
    {
        public DataSet GetDistrictByIdDB(DistrictListDTO objDistrictListDTO)
        {
            using (SqlConnection objSqlConnection = new SqlConnection(Convert.ToString(ConfigurationManager.ConnectionStrings["CustomerDBConnectionString"])))
            {
                using (SqlCommand objSqlCommand = new SqlCommand("uspGetDistrictsById", objSqlConnection))
                {
                    try
                    {
                        objSqlCommand.CommandType = CommandType.StoredProcedure;
                        objSqlCommand.Parameters.AddWithValue("IsActive", objDistrictListDTO.IsActive);
                        objSqlCommand.Parameters.AddWithValue("CountryId", objDistrictListDTO.CountryId);
                        objSqlCommand.Parameters.AddWithValue("StateId", objDistrictListDTO.StateId);

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

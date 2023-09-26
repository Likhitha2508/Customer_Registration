using LikhithaIT.Properties;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Likhitha.ITProperties;

namespace Likhitha.DataAccess
{
    public class StateDAL
    {

        public DataSet GetStatesByIdDB(StateListDTO objStateListDTO)
        {
            using (SqlConnection objSqlConnection = new SqlConnection(Convert.ToString(ConfigurationManager.ConnectionStrings["CustomerDBConnectionString"])))
            {
                using (SqlCommand objSqlCommand = new SqlCommand("uspGetStatesById", objSqlConnection))
                {
                    try
                    {
                        objSqlCommand.CommandType = CommandType.StoredProcedure;
                        objSqlCommand.Parameters.AddWithValue("IsActive", objStateListDTO.IsActive);
                        objSqlCommand.Parameters.AddWithValue("CountryId", objStateListDTO.CountryId);
                        //objSqlCommand.Parameters.AddWithValue("StateId", objStateListDTO.StateId);
                        //objSqlCommand.Parameters.AddWithValue("StateName", objStateListDTO.StateName);

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



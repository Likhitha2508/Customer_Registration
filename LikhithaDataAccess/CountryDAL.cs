using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using LikhithaIT.Properties;
using System.Configuration;
using Likhitha.ITProperties;

namespace LikhithaIT.DataAccess
{
    public class CountryDAL
    {
        public DataSet GetCountriesDB(CountryListDTO objCountryListDTO)
        {
            using (SqlConnection objSqlConnection = new SqlConnection(Convert.ToString(ConfigurationManager.ConnectionStrings["CustomerDBConnectionString"])))
            {
                using (SqlCommand objSqlCommand = new SqlCommand("uspGetCountry", objSqlConnection))
                {
                    try
                    {
                        objSqlCommand.CommandType = CommandType.StoredProcedure;
                       objSqlCommand.Parameters.AddWithValue("IsActive", objCountryListDTO.IsActive);
                        SqlDataAdapter objSqlDataAdapter = new SqlDataAdapter(objSqlCommand);
                        DataSet objDs = new DataSet();
                        objSqlDataAdapter.Fill(objDs);
                        return objDs;
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }

                }
            }
        }
        public object AddCountriesDB(CountryListDTO objCountryListDTO)
        {
            using (SqlConnection objSqlConnection = new SqlConnection(Convert.ToString(ConfigurationManager.ConnectionStrings["CustomerDBConnectionString"])))
            {
                using (SqlCommand objSqlCommand = new SqlCommand("uspInsertCountry", objSqlConnection))
                {
                    object obj = 0;
                    try
                    {
                        objSqlCommand.CommandType = CommandType.StoredProcedure;
                        objSqlCommand.Parameters.AddWithValue("IsActive", objCountryListDTO.IsActive);
                        if (objCountryListDTO.CountryName != null && objCountryListDTO.CountryName != string.Empty && objCountryListDTO.CountryName.Length > 0)
                        {
                            objSqlCommand.Parameters.AddWithValue("CountryName", objCountryListDTO.CountryName);

                        }

                        objSqlCommand.Parameters.AddWithValue("CreatedBy", objCountryListDTO.CreatedBy);
                        objSqlCommand.Parameters.AddWithValue("DateCreated", objCountryListDTO.DateCreated);
                        objSqlCommand.Parameters.AddWithValue("IPAddress", objCountryListDTO.IPAddress);
                        objSqlConnection.Open();
                        obj = objSqlCommand.ExecuteNonQuery();
                        objSqlConnection.Close();
                        return obj;

                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }

                }

            }

        }

        public DataSet GetCountryByIdDB(CountryListDTO objCountryListDTO)
        {
            using (SqlConnection objSqlConnection = new SqlConnection(Convert.ToString(ConfigurationManager.ConnectionStrings["CustomerDBConnectionString"])))
            {
                using (SqlCommand objSqlCommand = new SqlCommand("uspGetCountryById", objSqlConnection))
                {
                    try
                    {
                        objSqlCommand.CommandType = CommandType.StoredProcedure;
                        objSqlCommand.Parameters.AddWithValue("IsActive", objCountryListDTO.IsActive);
                        objSqlCommand.Parameters.AddWithValue("CountryId", objCountryListDTO.CountryId);
                        SqlDataAdapter objDa = new SqlDataAdapter(objSqlCommand);
                        DataSet objDs = new DataSet();
                        objDa.Fill(objDs);
                        return objDs;
                    }
                    catch (Exception ex)
                    {

                        throw ex;
                    }
                }
            }

        }
        public object UpdateCountriesDB(CountryListDTO objCountryListDTO)
        {
            using (SqlConnection objSqlConnection = new SqlConnection(Convert.ToString(ConfigurationManager.ConnectionStrings["CustomerDBConnectionString"])))
            {
                using (SqlCommand objSqlCommand = new SqlCommand("uspUpdateCountry", objSqlConnection))
                {
                    object obj = 0;
                    try
                    {
                        objSqlCommand.CommandType = CommandType.StoredProcedure;
                        objSqlCommand.Parameters.AddWithValue("IsActive", objCountryListDTO.IsActive);
                        if (objCountryListDTO.CountryName != null && objCountryListDTO.CountryName != string.Empty && objCountryListDTO.CountryName.Length > 0)
                        {
                            objSqlCommand.Parameters.AddWithValue("CountryName", objCountryListDTO.CountryName);

                        }
                        objSqlCommand.Parameters.AddWithValue("Countryid", objCountryListDTO.CountryId);
                        objSqlCommand.Parameters.AddWithValue("UpdatedBy", objCountryListDTO.UpdatedBy);
                        objSqlCommand.Parameters.AddWithValue("DateUpdated", objCountryListDTO.DateUpdated);
                        objSqlCommand.Parameters.AddWithValue("IPAddress", objCountryListDTO.IPAddress);
                        objSqlConnection.Open();
                        obj = objSqlCommand.ExecuteNonQuery();
                        objSqlConnection.Close();
                        return obj;

                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }

                }

            }
        }
        public DataSet DeleteCountriesDB(CountryListDTO objCountryListDTO)
        {
            using (SqlConnection objSqlConnection = new SqlConnection(Convert.ToString(ConfigurationManager.ConnectionStrings["CustomerDBConnectionString"])))
            {
                using (SqlCommand objSqlCommand = new SqlCommand("uspDeleteCountry", objSqlConnection))
                {
                    try
                    {
                        objSqlCommand.CommandType = CommandType.StoredProcedure;
                        objSqlCommand.Parameters.AddWithValue("CountryId", objCountryListDTO.CountryId);
                        objSqlCommand.Parameters.AddWithValue("CountryId", objCountryListDTO.CountryId);
                        SqlDataAdapter objDa = new SqlDataAdapter(objSqlCommand);
                        DataSet objDs = new DataSet();
                        objDa.Fill(objDs);
                        return objDs;
                    }
                    catch (Exception ex)
                    {

                        throw ex;
                    }

                }

            }

        }
    }
}


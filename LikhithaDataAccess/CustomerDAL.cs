using LikhithaIT.Properties;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikhithaIT.DataAccess
{
    public class CustomerDAL
    {
        public DataSet GetCustomersDB(CustomerListDTO objCustomerListDTO)
        {
            using (SqlConnection objsqlConnection = new SqlConnection(Convert.ToString(ConfigurationManager.ConnectionStrings["CustomerDBConnectionString"])))
            {
                using (SqlCommand objSqlCommand = new SqlCommand("uspGetCustomers", objsqlConnection))
                {
                    try
                    {
                        objSqlCommand.CommandType = CommandType.StoredProcedure;
                        objSqlCommand.Parameters.AddWithValue("IsActive", objCustomerListDTO.IsActive);

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
        public object AddCustomersDB(CustomerListDTO objCustomerListDTO)
        {
            using (SqlConnection objsqlConnection = new SqlConnection(Convert.ToString(ConfigurationManager.ConnectionStrings["CustomerDBConnectionString"])))
            {
                using (SqlCommand objSqlCommand = new SqlCommand("uspInsertCustomer", objsqlConnection))
                {
                    object objDa = 0;
                    try
                    {
                        objSqlCommand.CommandType = CommandType.StoredProcedure;
                        objSqlCommand.Parameters.AddWithValue("IsActive", objCustomerListDTO.IsActive);
                        if (objCustomerListDTO.CustomerName != null && objCustomerListDTO.CustomerName != string.Empty)
                        {
                            objSqlCommand.Parameters.AddWithValue("CustomerName", objCustomerListDTO.CustomerName);

                        }
                        objSqlCommand.Parameters.AddWithValue("CreatedBy", objCustomerListDTO.CreatedBy);
                        objSqlCommand.Parameters.AddWithValue("DateCreated", objCustomerListDTO.DateCreated);
                        objSqlCommand.Parameters.AddWithValue("IPAddress", objCustomerListDTO.IPAddress);
                        objSqlCommand.Parameters.AddWithValue("CountryId", objCustomerListDTO.CountryId);
                        objSqlCommand.Parameters.AddWithValue("StateId", objCustomerListDTO.StateId);
                        objSqlCommand.Parameters.AddWithValue("DistrictId", objCustomerListDTO.DistrictId);
                        objSqlCommand.Parameters.AddWithValue("CityId", objCustomerListDTO.CityId);
                        objSqlCommand.Parameters.AddWithValue("VillageId", objCustomerListDTO.VillageId);
                        objSqlCommand.Parameters.AddWithValue("Pincode", objCustomerListDTO.Pincode);


                        objsqlConnection.Open();
                        objDa = objSqlCommand.ExecuteNonQuery();
                        objsqlConnection.Close();
                        return objDa;
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }
        }


        public DataSet GetCustomersByIdDB(CustomerListDTO objCustomerListDTO)
        {
            using (SqlConnection objsqlConnection = new SqlConnection(Convert.ToString(ConfigurationManager.ConnectionStrings["CustomerDBConnectionString"])))
            {
                using (SqlCommand objSqlCommand = new SqlCommand("uspGetCustomerById", objsqlConnection))
                {
                    try
                    {
                        objSqlCommand.CommandType = CommandType.StoredProcedure;
                        objSqlCommand.Parameters.AddWithValue("IsActive", objCustomerListDTO.IsActive);
                        objSqlCommand.Parameters.AddWithValue("CustomerId", objCustomerListDTO.CustomerId);

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

        public object UpdateCustomersDB(CustomerListDTO objCustomerListDTO)
        {
            using (SqlConnection objSqlConnection = new SqlConnection(Convert.ToString(ConfigurationManager.ConnectionStrings["CustomerDBConnectionString"])))
            {
                using (SqlCommand objSqlCommand = new SqlCommand("uspUpdateCustomer", objSqlConnection))
                {
                    object obj = 0;
                    try
                    {
                        objSqlCommand.CommandType = CommandType.StoredProcedure;
                        objSqlCommand.Parameters.AddWithValue("IsActive", objCustomerListDTO.IsActive);
                        objSqlCommand.Parameters.AddWithValue("CustomerId", objCustomerListDTO.CustomerId);
                        objSqlCommand.Parameters.AddWithValue("CountryId", objCustomerListDTO.CountryId);
                        objSqlCommand.Parameters.AddWithValue("StateId", objCustomerListDTO.StateId);
                        objSqlCommand.Parameters.AddWithValue("DistrictId", objCustomerListDTO.DistrictId);
                        objSqlCommand.Parameters.AddWithValue("CityId", objCustomerListDTO.CityId);
                        objSqlCommand.Parameters.AddWithValue("VillageId", objCustomerListDTO.VillageId);
                        objSqlCommand.Parameters.AddWithValue("CustomerName", objCustomerListDTO.CustomerName);
                        objSqlCommand.Parameters.AddWithValue("Pincode", objCustomerListDTO.Pincode);
                        objSqlCommand.Parameters.AddWithValue("IPAddress", objCustomerListDTO.IPAddress);
                        objSqlCommand.Parameters.AddWithValue("UpdatedBy  ", objCustomerListDTO.UpdatedBy);
                        objSqlCommand.Parameters.AddWithValue("DateUpdated", objCustomerListDTO.DateUpdated);

                        objSqlConnection.Open();
                        obj = objSqlCommand.ExecuteNonQuery();
                        objSqlConnection.Close();
                        return obj;
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
            }

        }

        public object DeleteCustomerDB(CustomerListDTO objCustomerListDTO)
        {
            using (SqlConnection objSqlConnection = new SqlConnection(Convert.ToString(ConfigurationManager.ConnectionStrings["CustomerDBConnectionString"])))
            {
                using (SqlCommand objSqlCommand = new SqlCommand("uspDeleteCustomer", objSqlConnection))
                {
                    object obj = 0;
                    try
                    {
                        objSqlCommand.CommandType = CommandType.StoredProcedure;
                        objSqlCommand.Parameters.AddWithValue("CustomerId", objCustomerListDTO.CustomerId);
                        objSqlConnection.Open();
                        obj = objSqlCommand.ExecuteNonQuery();
                        objSqlConnection.Close();
                        return obj;
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



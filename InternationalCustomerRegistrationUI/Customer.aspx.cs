using Likhitha.ITBusinessLogic;
using Likhitha.ITProperties;
using LikhithaIT.BusinessLogic;
using LikhithaIT.Properties;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InternationalCustomerRegistrationUI
{
    public partial class Customer : System.Web.UI.Page
    {
        public bool IsActive
        {
            get
            {
                if ((ConfigurationManager.AppSettings["IsActive"] != null) && (ConfigurationManager.AppSettings["IsActive"] != string.Empty) && (Convert.ToInt64(ConfigurationManager.AppSettings["IsActive"]) > 0))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }
        private int CountryId
        {

            get
            {
                int _CountryId;
                if ((ViewState["CountryId"] != null) && (ViewState["CountryId"].ToString() != string.Empty) && (Convert.ToInt64(ViewState["CountryId"]) > 0))
                {
                    _CountryId = Convert.ToInt32(ViewState["CountryId"]);
                    return _CountryId;
                }
                else
                {
                    return 0;
                }
            }
            set
            {
                ViewState["CountryId"] = value;
            }

        }

        public int CustomerId { get; private set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindCountries();
                BindCustomers();

                
            }
        }
        protected void BindCountries()
        {
            CountryBAL objCountryBAL = null;
            CountryListDTO objCountryListDTO = null;
            DataSet objDs = null;
            try
            {
                objCountryBAL = new CountryBAL();
                objCountryListDTO = new CountryListDTO();
                objDs = new DataSet();

                objCountryListDTO.IsActive = IsActive;
                objDs = objCountryBAL.GetCountries(objCountryListDTO);

                ddlCountries.Items.Clear();
                ddlCountries.DataSource = objDs;
                ddlCountries.DataTextField = "CountryName";
                ddlCountries.DataValueField = "CountryId";
                ddlCountries.DataBind();
                ddlCountries.Items.Insert(0, new ListItem("-- Select --", "0"));
            }
            catch (Exception)
            {
                throw;
            }
        }
        protected void BindCustomers()
        {
            CustomerBAL objCustomerBAL = null;
            CustomerListDTO objCustomerListDTO = null;
            DataSet objDs = null;
            try
            {
                objCustomerBAL = new CustomerBAL();
                objCustomerListDTO = new CustomerListDTO();
                objDs = new DataSet();
                objCustomerListDTO.IsActive = IsActive;

                objDs = objCustomerBAL.GetCustomers(objCustomerListDTO);

                gvCustomerDetails.DataSource = objDs;
                gvCustomerDetails.DataBind();

            }
            catch (Exception)
            {
                throw;
            }
        }


        protected void ddlCountries_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindStates();
        }

        protected void BindStates()
        {
            StateBAL objStateBAL = null;
            StateListDTO objStateListDTO = null;
            DataSet objDs = null;
            try
            {
                objStateBAL = new StateBAL();
                objStateListDTO = new StateListDTO();
                objDs = new DataSet();

                objStateListDTO.IsActive = IsActive;
                objStateListDTO.CountryId = Convert.ToInt32(ddlCountries.SelectedValue);
                objDs = objStateBAL.GetStatesById(objStateListDTO);

                ddlStates.DataSource = objDs;
                ddlStates.DataTextField = "StateName";
                ddlStates.DataValueField = "StateId";
                ddlStates.DataBind();
                ddlStates.Items.Insert(0, new ListItem("-- Select --", "0"));
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected void ddlStates_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindDistricts();
        }
        protected void BindDistricts()
        {
            DistrictBAL objDistrictBAL = null;
            DistrictListDTO objDistrictListDTO = null;
            DataSet objDs = null;
            try
            {
                objDistrictBAL = new DistrictBAL();
                objDistrictListDTO = new DistrictListDTO();
                objDs = new DataSet();

                objDistrictListDTO.IsActive = IsActive;
                objDistrictListDTO.CountryId = Convert.ToInt32(ddlStates.SelectedValue);
                objDistrictListDTO.StateId = Convert.ToInt32(ddlStates.SelectedValue);
                objDs = objDistrictBAL.GetDistrictsById(objDistrictListDTO);

                ddlDistricts.DataSource = objDs;
                ddlDistricts.DataTextField = "DistrictName";
                ddlDistricts.DataValueField = "DistrictId";
                ddlDistricts.DataBind();
                ddlDistricts.Items.Insert(0, new ListItem("-- Select --", "0"));
            }
            catch (Exception)
            {
                throw;
            }
        }
        protected void ddlDistricts_SelectedIndexChanged(object sender, EventArgs e)
        {

            BindCities();

        }
        protected void BindCities()
        {
            CityBAL objCityBAL = null;
            CityListDTO objCityListDTO = null;
            DataSet objDs = null;
            try
            {
                objCityBAL = new CityBAL();
                objCityListDTO = new CityListDTO();
                objDs = new DataSet();

                objCityListDTO.IsActive = IsActive;
                objCityListDTO.CountryId = Convert.ToInt32(ddlCountries.SelectedValue);
                objCityListDTO.StateId = Convert.ToInt32(ddlStates.SelectedValue);
                objCityListDTO.DistrictId = Convert.ToInt32(ddlDistricts.SelectedValue);

                objDs = objCityBAL.GetCitiesById(objCityListDTO);

                ddlCities.DataSource = objDs;
                ddlCities.DataTextField = "CityName";
                ddlCities.DataValueField = "CityId";
                ddlCities.DataBind();
                ddlCities.Items.Insert(0, new ListItem("-- Select --", "0"));
            }
            catch (Exception)
            {
                throw;
            }
        }


        protected void ddlCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindVillages();
        }
        protected void BindVillages()
        {

            VillageBAL objVillageBAL = null;
            VillageListDTO objVillageListDTO = null;
            DataSet objDs = null;
            try
            {
                objVillageBAL = new VillageBAL();
                objVillageListDTO = new VillageListDTO();
                objDs = new DataSet();

                objVillageListDTO.IsActive = IsActive;
                objVillageListDTO.CountryId = Convert.ToInt32(ddlCountries.SelectedValue);
                objVillageListDTO.StateId = Convert.ToInt32(ddlStates.SelectedValue);
                objVillageListDTO.DistrictId = Convert.ToInt32(ddlDistricts.SelectedValue);
                objVillageListDTO.CityId = Convert.ToInt32(ddlCities.SelectedValue);

                objDs = objVillageBAL.GetVillagesById(objVillageListDTO);

                ddlVillages.DataSource = objDs;
                ddlVillages.DataTextField = "VillageName";
                ddlVillages.DataValueField = "VillageId";
                ddlVillages.DataBind();
                ddlVillages.Items.Insert(0, new ListItem("-- Select --", "0"));
            }

            catch (Exception)
            {
                throw;
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {

            object objValue = 0;
            CustomerListDTO objCustomerListDTO = null;
            CustomerBAL objCustomerBAL = null;
            try
            {
                objCustomerListDTO = new CustomerListDTO();
                objCustomerBAL = new CustomerBAL();

                objCustomerListDTO.IsActive = chkIsActive.Checked;


                if (txtCustomerName.Text != null && txtCustomerName.Text != String.Empty && txtCustomerName.Text.Length > 0)

                {
                    objCustomerListDTO.CustomerName = txtCustomerName.Text;

                }
                objCustomerListDTO.CountryId = Convert.ToInt32(ddlCountries.SelectedValue);
                objCustomerListDTO.StateId = Convert.ToInt32(ddlStates.SelectedValue);
                objCustomerListDTO.DistrictId = Convert.ToInt32(ddlDistricts.SelectedValue);
                objCustomerListDTO.CityId = Convert.ToInt32(ddlCities.SelectedValue);
                objCustomerListDTO.VillageId = Convert.ToInt32(ddlVillages.SelectedValue);
                objCustomerListDTO.Pincode = Convert.ToInt32(txtPincode.Text);

                if (CustomerId > 0)
                {
                    objCustomerListDTO.CustomerId = CustomerId;
                    objCustomerListDTO.UpdatedBy = "Likhitha";
                    objCustomerListDTO.DateUpdated = DateTime.Now;
                    objCustomerListDTO.Pincode = (int)Convert.ToInt32(txtPincode.Text);
                    objValue = objCustomerBAL.UpdateCustomers(objCustomerListDTO);
                    lblDisplayStatus.Text = "Updated Customer Successfully.";
                    lblDisplayStatus.Visible = true;
                    lblDisplayStatus.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    objCustomerListDTO.CreatedBy = "Likhitha";
                    objCustomerListDTO.DateCreated = DateTime.Now;
                    objCustomerListDTO.Pincode = (int)Convert.ToInt32(txtPincode.Text);
                    objValue = objCustomerBAL.AddCustomers(objCustomerListDTO);
                    lblDisplayStatus.Text = "Added Customer Successfully.";
                    lblDisplayStatus.Visible = true;
                    lblDisplayStatus.ForeColor = System.Drawing.Color.Green;
                }
                if (fulUploadFile.HasFile)
                {

                    fulUploadFile.SaveAs(Server.MapPath("~/Uploads/" + fulUploadFile.FileName));
                    lblMessage.Text = "File Uploaded Successfully";
                    lblMessage.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    //lblMessage.Text = "Please select a file upload";
                    lblMessage.ForeColor = System.Drawing.Color.Red;
                }

                BindCustomers();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

            }
        }

       
        protected void gvCustomerDetails_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "cmdEdit")
            {
                CustomerListDTO objCustomerListDTO = null;
                CustomerBAL objCustomerBAL = null;
                DataSet objDs = null;
                bool boolValue = false;
                try
                {
                    objCustomerBAL = new CustomerBAL();
                    objCustomerListDTO = new CustomerListDTO();
                    objDs = new DataSet();

                    if (e.CommandArgument.ToString() != null && Convert.ToString(e.CommandArgument) != string.Empty && Convert.ToInt64(e.CommandArgument) > 0)
                    {
                        CustomerId = Convert.ToInt32(e.CommandArgument);
                    }
                    objCustomerListDTO.IsActive = IsActive;
                    objCustomerListDTO.CustomerId = CustomerId;
                    objDs = objCustomerBAL.GetCustomerById(objCustomerListDTO);

                    if (objDs.Tables.Count > 0)
                    {

                        boolValue = (bool)(objDs.Tables[0].Rows[0]["IsActive"]);
                        if (boolValue)
                            chkIsActive.Checked = true;
                        else
                            chkIsActive.Checked = boolValue;

                        txtCustomerName.Text = Convert.ToString(objDs.Tables[0].Rows[0]["CustomerName"]);


                        BindCountries();
                        ddlCountries.SelectedValue = Convert.ToString(objDs.Tables[0].Rows[0]["CountryId"].ToString());

                        BindStates();
                        ddlStates.SelectedValue = Convert.ToString(objDs.Tables[0].Rows[0]["StateId"].ToString());

                        BindDistricts();
                        ddlDistricts.SelectedValue = Convert.ToString(objDs.Tables[0].Rows[0]["DistrictId"].ToString());

                        BindCities();
                        ddlCities.SelectedValue = Convert.ToString(objDs.Tables[0].Rows[0]["CityId"].ToString());

                        BindVillages();
                        ddlVillages.SelectedValue = Convert.ToString(objDs.Tables[0].Rows[0]["VillageId"].ToString());

                       txtPincode.Text = Convert.ToString(objDs.Tables[0].Rows[0]["Pincode"]);

                        btnSave.Text = "Update";
                    }
                }
                catch (Exception)
                {
                    throw;
                }

                finally
                {
                    objCustomerListDTO = null;
                    objCustomerBAL = null;
                    objDs = null;
                }
            }

            else if (e.CommandName == "cmdDelete")
            {
                CustomerListDTO objCustomerListDTO = null;
                CustomerBAL objCustomerBAL = null;
                object obj = null;

                try
                {
                    objCustomerBAL = new CustomerBAL();
                    objCustomerListDTO = new CustomerListDTO();

                    if (e.CommandArgument.ToString() != null && Convert.ToString(e.CommandArgument) != string.Empty && Convert.ToInt64(e.CommandArgument) > 0)
                    {
                        CustomerId = Convert.ToInt32(e.CommandArgument);
                    }
                    objCustomerListDTO.CustomerId = CustomerId;
                    obj = objCustomerBAL.DeleteCustomer(objCustomerListDTO);
                }
                catch (Exception ex)
                {
                    throw ex;
                }

                finally
                {
                    objCustomerListDTO = null;
                    objCustomerBAL = null;

                }
            }
        }

        protected void btnClear_Click1(object sender, EventArgs e)
        {
            txtCustomerName.Text = "";
            ddlCountries.Items.Clear();
            ddlStates.Items.Clear();
            ddlDistricts.Items.Clear();
            ddlCities.Items.Clear();
            ddlVillages.Items.Clear();
            txtPincode.Text= string.Empty;
        }
    }
}




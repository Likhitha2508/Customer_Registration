using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using LikhithaIT.BusinessLogic;
using LikhithaIT.Properties;

namespace InternationalCustomerRegistrationUI
{
    public partial class Country : System.Web.UI.Page
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


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindCountries();
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
                gvCountryDetails.DataSource = objDs;
                gvCountryDetails.DataBind();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        protected void btnSave_Click1(object sender, EventArgs e)
        {
            object objValue = 0;
            CountryListDTO objCountryListDTO = null;
            CountryBAL objCountryBAL = null;
            {
                try
                {
                    objCountryListDTO = new CountryListDTO();
                    objCountryBAL = new CountryBAL();
                    objCountryListDTO.IsActive = chkIsActive.Checked;
                    if (txtCountryName.Text != null && txtCountryName.Text != string.Empty && txtCountryName.Text.Length > 0)
                        objCountryListDTO.CountryName = txtCountryName.Text;
                    if (CountryId > 0)
                    {
                        objCountryListDTO.UpdatedBy = "Likhitha";
                        objCountryListDTO.DateUpdated = DateTime.Now;
                        objCountryListDTO.IPAddress = "192.192.234";
                        objValue = objCountryBAL.UpdateCountries(objCountryListDTO);
                        lblDisplayStatus.Text = "Updated Countries Succssfully.....!!";
                        lblDisplayStatus.Visible = true;
                        lblDisplayStatus.ForeColor = System.Drawing.Color.Brown;
                    }
                    else
                    {
                        objCountryListDTO.CreatedBy = "Likhitha";
                        objCountryListDTO.DateCreated = DateTime.Now;
                        objCountryListDTO.IPAddress = "192.192.234";
                        objValue = objCountryBAL.AddCountries(objCountryListDTO);
                        lblDisplayStatus.Text = "Added Country Succssfully.....!!";
                        lblDisplayStatus.Visible = true;
                        lblDisplayStatus.ForeColor = System.Drawing.Color.PaleVioletRed;

                    }
                    BindCountries();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {

                }
            }
        }

        protected void gvCountryDetails_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "cmdEdit")
            {
                CountryListDTO objCountryListDTO = null;
                CountryBAL objCountryBAL = null;
                DataSet objDs = null;
                bool boolValue = false;

                try
                {
                    objCountryBAL = new CountryBAL();
                    objCountryListDTO = new CountryListDTO();
                    objDs = new DataSet();

                    if (e.CommandArgument.ToString() != null && Convert.ToString(e.CommandArgument) != string.Empty && Convert.ToInt64(e.CommandArgument) > 0)
                    {
                        CountryId = Convert.ToInt32(e.CommandArgument);
                    }
                    objCountryListDTO.IsActive = IsActive;
                    objCountryListDTO.CountryId = CountryId;
                    objDs = objCountryBAL.GetCountryById(objCountryListDTO);
                    if (objDs.Tables.Count > 0)
                    {

                        boolValue = (bool)(objDs.Tables[0].Rows[0]["IsActive"]);
                        if (boolValue)
                            chkIsActive.Checked = true;
                        else
                            chkIsActive.Checked = boolValue;

                        txtCountryName.Text = Convert.ToString(objDs.Tables[0].Rows[0]["CountryName"]);

                        btnSave.Text = "Update";
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }

                finally
                {
                    objCountryListDTO = null;
                    objCountryBAL = null;
                    objDs = null;
                }
            }

            else if (e.CommandName == "cmdDelete")
            {
                CountryListDTO objCountryListDTO = null;
                CountryBAL objCountryBAL = null;
                DataSet objDs = null;
                //bool boolValue = false;

                try
                {
                    objCountryBAL = new CountryBAL();
                    objCountryListDTO = new CountryListDTO();
                    objDs = new DataSet();

                    if (e.CommandArgument.ToString() != null && Convert.ToString(e.CommandArgument) != string.Empty && Convert.ToInt64(e.CommandArgument) > 0)
                    {
                        CountryId = Convert.ToInt32(e.CommandArgument);
                    }
                   
                    objCountryListDTO.CountryId = CountryId;
                    objDs = objCountryBAL.DeleteCountries(objCountryListDTO);

                   
                    BindCountries();
                }
                catch (Exception ex)
                {
                    throw ex;
                }

                finally
                {
                    objCountryListDTO = null;
                    objCountryBAL = null;
                    objDs = null;
                }
            }
        }
    }

}






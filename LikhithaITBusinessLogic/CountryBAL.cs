using LikhithaIT.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LikhithaIT.DataAccess;

namespace LikhithaIT.BusinessLogic
{
    public class CountryBAL
    {
        public DataSet GetCountries(CountryListDTO objCountryListDTO)
        {
            CountryDAL objCountryDAL = new CountryDAL();
            return objCountryDAL.GetCountriesDB(objCountryListDTO);
        }
        public object AddCountries(CountryListDTO objCountryListDTO)
        {
            CountryDAL objCountryDAL = new CountryDAL();
            return objCountryDAL.AddCountriesDB(objCountryListDTO);
        }
        public DataSet GetCountryById(CountryListDTO objCountryListDTO)
        {
            CountryDAL objCountryDAL = new CountryDAL();
            return objCountryDAL.GetCountryByIdDB(objCountryListDTO);
        }
        public object UpdateCountries(CountryListDTO objCountryListDTO)
        {
            CountryDAL objCountryDAL = new CountryDAL();
            return objCountryDAL.UpdateCountriesDB(objCountryListDTO);
        }
        public DataSet DeleteCountries(CountryListDTO objCountryListDTO)
        {
            CountryDAL objCountryDAL = new CountryDAL();
            return objCountryDAL.DeleteCountriesDB(objCountryListDTO);
        }
    }
}

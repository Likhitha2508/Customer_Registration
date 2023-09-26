using Likhitha.DataAccess;
using Likhitha.ITProperties;
using LikhithaIT.DataAccess;
using LikhithaIT.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Likhitha.ITBusinessLogic
{
    public class StateBAL
    {
        public DataSet GetStatesById(StateListDTO objStateListDTO)
        {
            StateDAL objStateDAL = new StateDAL();
            return objStateDAL.GetStatesByIdDB(objStateListDTO);
        }
       
    }
}

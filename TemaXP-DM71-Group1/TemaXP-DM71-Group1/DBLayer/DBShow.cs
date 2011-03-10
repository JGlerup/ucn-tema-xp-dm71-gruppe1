using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TemaXP_DM71_Group1.ModelLayer;

namespace TemaXP_DM71_Group1.DBLayer
{
    class DBShow
    {
        public IList<Show> sortShowByDate(bool retrieveAssosiation)
        {
            //IList<Show> sObj = new IList();
            
            //sObj = singleWhere("SELECT * FROM show WHERE Date_ BETWEEN (Select DATEADD(DAY, -1, GETDATE()) AS NewDate1) AND (SELECT DATEADD(Week,1,GETDATE()) AS NewDate)", retrieveAssociation);

            return miscWhere("Date_ BETWEEN (Select DATEADD(DAY, -1, GETDATE()) AS NewDate1) AND (SELECT DATEADD(Week,1,GETDATE()) AS NewDate)", retrieveAssociation);
        }
    }
}

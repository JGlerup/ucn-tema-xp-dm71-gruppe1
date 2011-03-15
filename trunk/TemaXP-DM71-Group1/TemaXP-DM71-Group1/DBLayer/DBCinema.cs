using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TemaXP_DM71_Group1.ModelLayer;

namespace TemaXP_DM71_Group1.DBLayer
{
    class DBCinema : IFdbCinema
    {
        public void InsertCinema(Cinema c)
        {
            throw new NotImplementedException();
        }

        public void DeleteCinema(Cinema c)
        {
            throw new NotImplementedException();
        }

        public void UpdateCinema(Cinema c)
        {
            throw new NotImplementedException();
        }

        public Cinema FindCinemaByNoOfCinema(int noOfCinema, bool retrieveAssociation)
        {
            throw new NotImplementedException();
        }

        public Cinema FindCinemaByShowID(Show s, bool retrieveAssociation)
        {
            throw new NotImplementedException();
        }

        public IList<Cinema> FindAllShows(bool retrieveAssociation)
        {
            throw new NotImplementedException();
        }
    }
}

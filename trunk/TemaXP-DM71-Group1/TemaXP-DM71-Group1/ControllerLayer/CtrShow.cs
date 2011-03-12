using System;
using System.Linq;
using System.Collections.Generic;
using TemaXP_DM71_Group1.DBLayer;
using TemaXP_DM71_Group1.ModelLayer;

namespace TemaXP_DM71_Group1.ControllerLayer
{
    public class CtrShow
    {
        public void InsertShow(string movieStartTime, string showDate, Movie movie)
        {
            IFDBShow dbShow = new DBShow();
            Show sObj = new Show();
            sObj.MovieStartTime = movieStartTime;
            sObj.ShowDate = showDate;
            sObj.Movie = movie;
            dbShow.InsertShow(sObj);
        }

        public void DeleteShow(int id)
        {
            IFDBShow dbShow = new DBShow();
            dbShow.DeleteShow(id);
        }

        public void UpdateShow(int id, string movieStartTime, string showDate, Movie movie)
        {
            IFDBShow dbShow = new DBShow();
            Show sObj = FindShowById(id);
            sObj.MovieStartTime = movieStartTime;
            sObj.ShowDate = showDate;
            sObj.Movie = movie;
            dbShow.UpdateShow(sObj);
        }

        public IList<Show> FindAllShows()
        {
            IFDBShow dbShow = new DBShow();
            IList<Show> showList = dbShow.FindAllShows();
            return showList;
        }

        public Show FindShowById(int id)
        {
            IFDBShow dbShow = new DBShow();
            return dbShow.FindShowById(id);
        }

        public IList<Show> GetAllShowsOneWeekAhead()
        {
            //DBShow dbShow = new DBShow();   
            //IList<Show> showList = new List<Show>();
            //showList = dbShow.sortShowByDate(false);
            //return showList;
            throw new NotImplementedException();
        }
    }
}
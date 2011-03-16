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

        public void DeleteShow(Show s)
        {
            IFDBShow dbShow = new DBShow();
            dbShow.DeleteShow(s);
        }

        public void UpdateShow(Show s, string movieStartTime, string showDate, Movie movie)
        {
            IFDBShow dbShow = new DBShow();
            s.MovieStartTime = movieStartTime;
            s.ShowDate = showDate;
            s.Movie = movie;
           dbShow.UpdateShow(s);
        }

        public IList<Show> FindAllShows(bool retrieveAssociation)
        {
            IFDBShow dbShow = new DBShow();
            IList<Show> showList = dbShow.FindAllShows(retrieveAssociation);
            return showList;
        }

        public Show FindShowById(Movie m)
        {
            IFDBShow dbShow = new DBShow();
            return dbShow.FindShowByMovieId(m, false);
        }


        public Show FindShowByMovieIdAndShowDate(Movie m, string date)
        {
            IFDBShow dbShow = new DBShow();
            return dbShow.FindShowByMovieIdAndShowDate(m, date, false);
        }

        public Show FindShowByMovieId(Movie m)
        {
            IFDBShow dbShow = new DBShow();
            return dbShow.FindShowByMovieId(m, true);
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
using System;
using System.Collections.Generic;
using TemaXP_WCFServiceLib.DBLayer;
using TemaXP_WCFServiceLib.ModelLayer;

namespace TemaXP_WCFServiceLib.ControllerLayer
{
    public class CtrShow : IService3
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

        public IList<Show> FindShowsByCinemaId(Cinema c, bool retrieveAssociation)
        {
            IFDBShow dbShow = new DBShow();
            IList<Show> showList = dbShow.FindShowsByCinemaId(c, retrieveAssociation);
            return showList;
        }

        public Show FindShowByMovieIdAndShowDate(Movie m, string date)
        {
            IFDBShow dbShow = new DBShow();
            return dbShow.FindShowByMovieIdAndShowDate(m, date, false);
        }

        public Show FindShowByMovieId(Movie m, bool retrieveAssociation)
        {
            IFDBShow dbShow = new DBShow();
            return dbShow.FindShowByMovieId(m, retrieveAssociation);
        }

        public Show FindShowById(Show s, bool retrievAssociation)
        {
            IFDBShow dbShow = new DBShow();
            return dbShow.FindShowById(s, retrievAssociation);
        }

        public IList<Show> GetAllShowsOneWeekAhead(bool retrieveAssociation)
        {
            IFDBShow dbShow = new DBShow();
            IList<Show> showList = new List<Show>();
            showList = dbShow.GetAllShowsOneWeekAhead(retrieveAssociation);
            return showList;
        }
    }
}
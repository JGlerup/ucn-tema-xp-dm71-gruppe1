using System;
using System.Collections.Generic;
using TemaXP_DM71_Group1.DBLayer;
using TemaXP_DM71_Group1.ModelLayer;

namespace TemaXP_DM71_Group1.ControllerLayer
{
    public class CtrShow
    {
        public void InsertShow(string movieStartTime, string showDate, Movie movie)
        {
            IFDBShow dbShow = new DbShow();
            Show sObj = new Show();
            sObj.MovieStartTime = movieStartTime;
            sObj.ShowDate = showDate;
            sObj.Movie = movie;
            dbShow.InsertShow(sObj);
        }

        public void DeleteShow(Show s)
        {
            IFDBShow dbShow = new DbShow();
            dbShow.DeleteShow(s);
        }

        public void UpdateShow(Show s, string movieStartTime, string showDate, Movie movie)
        {
            IFDBShow dbShow = new DbShow();
            s.MovieStartTime = movieStartTime;
            s.ShowDate = showDate;
            s.Movie = movie;
           dbShow.UpdateShow(s);
        }

        public IList<Show> FindAllShows(bool retrieveAssociation)
        {
            IFDBShow dbShow = new DbShow();
            IList<Show> showList = dbShow.FindAllShows(retrieveAssociation);
            return showList;
        }

        public IList<Show> FindShowsByCinemaId(Cinema c, bool retrieveAssociation)
        {
            IFDBShow dbShow = new DbShow();
            IList<Show> showList = dbShow.FindShowsByCinemaId(c, retrieveAssociation);
            return showList;
        }
        
        public Show FindShowByMovieIdAndShowDate(Movie m, string date)
        {
            IFDBShow dbShow = new DbShow();
            return dbShow.FindShowByMovieIdAndShowDate(m, date, false);
        }

        public Show FindShowByMovieId(Movie m)
        {
            IFDBShow dbShow = new DbShow();
            return dbShow.FindShowByMovieId(m, true);
        }

        public Show FindShowById(Show s, bool retrievAssociation)
        {
            IFDBShow dbShow = new DbShow();
            return dbShow.FindShowById(s, retrievAssociation);
        }

        public IList<Show> GetAllShowsOneWeekAhead(bool retrieveAssociation)
        {
            IFDBShow dbShow = new DbShow();   
            IList<Show> showList = new List<Show>();
            showList = dbShow.GetAllShowsOneWeekAhead(retrieveAssociation);
            return showList;
        }

        public void InsertCinemaShow(Cinema c, Show s)
        {
            IFDBShow dbShow = new DbShow();
            dbShow.InsertCinemaShow(c,s);
        }

        public void DeleteCinemaShow(Cinema c, Show s)
        {
            IFDBShow dbShow = new DbShow();
            dbShow.DeleteCinemaShow(c, s);
        }

        public void UpdateCinemaShow(Cinema oldc, Show olds, Cinema newc, Show news)
        {
        }
    }
}
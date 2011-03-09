using System;
using System.Collections;

namespace TemaXP_DM71_Group1.ControllerLayer
{
    public class CtrShow : IShow
    {
        public void insertShow(String time, String date, String playTime, int cinema, String movie)
        {
            var dbShow = new DBShow();
            var sObj = new CtrShow();
            sObj.setTime(time);
            sObj.setDate(date);
            sObj.setPlayTime(playTime);
            sObj.setCinema(cinema.number);
            sObj.setMovie(movie);
            dbShow.insertShow(cObj);
        }

        public void deleteShow(int id)
        {
            var dbShow = new DBShow();
            dbShow.deleteShow(id);
        }

        public void updateShow(int id, String time, String date, String playTime, int cinema, String movie)
        {
            int showID = findShowById(id).getShowID();
            var dbShow = new DBShow();
            var sObj = new Show();
            sObj.setTime(time);
            sObj.setDate(date);
            sObj.setPlayTime(playTime);
            sObj.setCinema(cinema);
            sObj.setMovie(movie);
            dbShow.updateShow(sObj);
        }

        public ArrayList getAllShows()
        {
            var dbShow = new DBShow();
            var allShow = new ArrayList<Show>();
            allShow = dbShow.getAllShows(false);
            return allShow;
        }

        public Show findShowByID(int showID)
        {
            var dbShow = new DBShow();
            return dbShow.findShowByID(showID, true);
        }
    }
}
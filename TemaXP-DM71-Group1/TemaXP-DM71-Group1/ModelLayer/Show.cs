using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemaXP_DM71_Group1.ModelLayer
{
    public class Show
    {
        public Show(int id, string movieStartTime, Movie movie, string showDate)
        {
            this.Id = id;
            this.MovieStartTime = movieStartTime;
            this.Movie = movie;
            this.ShowDate = showDate;
        }

        public Show()
        {
        }

        public int Id { get; set; }

        public string MovieStartTime { get; set; }

        public string ShowDate { get; set; }

        public Movie Movie { get; set; }

        public override string ToString()
        {
            return ShowDate + MovieStartTime + Movie.Title;
        }
    }
}
namespace TemaXP_DM71_Group1.ModelLayer
{
    public class Show
    {
        public Show(string time, string date, Cinema cinema, Movie movie)
        {
            this.Time = time;
            this.Date = date;
            this.Cinema = cinema;
            this.Movie = movie;
        }

        public Show()
        {
        }

        public string Time { get; set; }

        public string Date { get; set; }

        public Cinema Cinema { get; set; }

        public Movie Movie { get; set; }
    }
}
using System.Collections.Generic;
using System.ServiceModel;
using TemaXP_WCFServiceLib.ModelLayer;


namespace TemaXP_WCFServiceLib
{
     //NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        Cinema FindCinemaByName(string cinemaName, bool retrieveAssociation);

        [OperationContract]
        IList<Cinema> FindAllCinemas(bool retrieveAssociation);

        [OperationContract]
        void InsertCinema(string cinemaName, int noOfRows);

        [OperationContract]
        void AddSeatsToRow(Cinema c, int rowNumber, int noOfSeats);

        [OperationContract]
        void UpdateCinema(Cinema c, string cinemaName);

        [OperationContract]
        void DeleteCinema(Cinema c);
    //CtrMovie
        [OperationContract]
        Movie FindMovieByTitle(string title, bool retrieveAssociation);

        [OperationContract]
        Movie FindMovieById(Movie m, bool retrieveAssociation);

        [OperationContract]
        void InsertMovie(string releaseDate, string title, string distributor, string arrivalDate, string returnDate,
                         string duration, string director, string actors, string movieDescription);

        [OperationContract]
        void UpdateMovie(string currentTitle, string releaseDate, string title, string distributor, string arrivalDate,
                         string returnDate, string duration, string director, string actors, string movieDescription);

        [OperationContract]
        void DeleteMovie(Movie m);

        [OperationContract]
        IList<Movie> FindAllMovies(bool retrieveAssociation);
        //CtrShow
        [OperationContract]
        void InsertShow(string movieStartTime, string showDate, Movie movie);

        [OperationContract]
        void DeleteShow(Show s);

        [OperationContract]
        void UpdateShow(Show s, string movieStartTime, string showDate, Movie movie);

        [OperationContract]
        IList<Show> FindAllShows(bool retrieveAssociation);

        [OperationContract]
        Show FindShowByMovieId(Movie m, bool retrieveAssociation);

        [OperationContract]
        Show FindShowByMovieIdAndShowDate(Movie m, string date);

        [OperationContract]
        IList<Show> GetAllShowsOneWeekAhead(bool retrieveAssociation);
 
    }
    
}

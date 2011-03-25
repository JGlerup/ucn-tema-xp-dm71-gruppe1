using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using TemaXP_Groupe1_WcfService1.ModelLayer;

namespace TemaXP_Groupe1_WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
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

        // TODO: Add your service operations here
    }

//    [ServiceContract]
//    public interface IService2
//    {
//        [OperationContract]
//        Movie FindMovieByTitle(string title, bool retrieveAssociation);
//
//        [OperationContract]
//        Movie FindMovieById(Movie m, bool retrieveAssociation);
//
//        [OperationContract]
//        void InsertMovie(string releaseDate, string title, string distributor, string arrivalDate, string returnDate,
//                         string duration, string director, string actors, string movieDescription);
//
//        [OperationContract]
//        void UpdateMovie(string currentTitle, string releaseDate, string title, string distributor, string arrivalDate,
//                         string returnDate, string duration, string director, string actors, string movieDescription);
//
//        [OperationContract]
//        void DeleteMovie(Movie m);
//
//        [OperationContract]
//        IList<Movie> FindAllMovies(bool retrieveAssociation);
//
        // TODO: Add your service operations here
//    }
//
//    [ServiceContract]
//    public interface IService3
//    {
//        [OperationContract]
//        void InsertShow(string movieStartTime, string showDate, Movie movie);
//
//        [OperationContract]
//        void DeleteShow(Show s);
//
//        [OperationContract]
//        void UpdateShow(Show s, string movieStartTime, string showDate, Movie movie);
//
//        [OperationContract]
//        IList<Show> FindAllShows(bool retrieveAssociation);
//
//        [OperationContract]
//        Show FindShowByMovieId(Movie m, bool retrieveAssociation);
//
//        [OperationContract]
//        Show FindShowByMovieIdAndShowDate(Movie m, string date);
//
//        [OperationContract]
//        IList<Show> GetAllShowsOneWeekAhead(bool retrieveAssociation);
//
        // TODO: Add your service operations here
//    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations
//    [DataContract]
//    public class CompositeType
//    {
//        bool boolValue = true;
//        string stringValue = "Hello ";
//
//        [DataMember]
//        public bool BoolValue
//        {
//            get { return boolValue; }
//            set { boolValue = value; }
//        }
//
//        [DataMember]
//        public string StringValue
//        {
//            get { return stringValue; }
//            set { stringValue = value; }
//        }
//    }
}

using System;
using System.Collections.Generic;
using System.Data.Common;
using TemaXP_DM71_Group1_ServiceLib.ModelLayer;

namespace TemaXP_DM71_Group1_ServiceLib.DBLayer
{
    public class DBRow : IFdbRow
    {

        private DbCommand command;
        private DbConnection conn;
        private DbProviderFactory dbFactory;
        private String provider = null;
        private String connStr = null;
        private DbDataReader dbReader = null;

        public DBRow()
        {
            //provider = ConfigurationManager.ConnectionStrings["TemaXP.Properties.Settings.DatabaseConnectionString"].ProviderName;
            //connStr = ConfigurationManager.ConnectionStrings["TemaXP.Properties.Settings.DatabaseConnectionString"].ConnectionString;

            connStr = "Data Source=balder.ucn.dk;initial catalog=DM71_2;User Id=DM71_2; Password=MaaGodt;";
            provider = "System.Data.SqlClient";

            dbFactory = DbProviderFactories.GetFactory(provider);

            conn = dbFactory.CreateConnection();
            conn.ConnectionString = connStr;

            Console.WriteLine("Database is open: {0}", conn.State);
        }

        public void InsertRow(Row row)
        {
            conn.Open();
            String sql = "INSERT INTO row(RowNo, NoOfSeats, CinemaID)  VALUES("
               + row.RowNo + ","
               + row.NoOfSeats + ","
               + row.Cinema.Id + ")";

            Console.WriteLine("insert : " + sql);
            try
            { // insert new row
                command = CreateCommand(sql);

                dbReader = command.ExecuteReader();


            }//end try
            catch (Exception ex)
            {
                Console.WriteLine("Insert exception in row db: " + ex);
            }//end catch
            conn.Close();
        }

        public void DeleteRow(Row row)
        {
            conn.Open();
            String sql = "DELETE FROM row "
                         + " WHERE id = " + row.Id;
            Console.WriteLine("Delete query:" + sql);
            try
            { // delete row
                command = CreateCommand(sql);
                dbReader = command.ExecuteReader();
            }//end try
            catch (Exception ex)
            {
                Console.WriteLine("Delete exception in row db: " + ex);
            }//end catch
            conn.Close();
        }

        public void UpdateRow(Row row)
        {
            Row r = row;

            conn.Open();

            String sql = "UPDATE row SET "
                    + "RowNo = " + r.RowNo + ", "
                    + "NoOfSeats = " + r.NoOfSeats + ", "
                    + "CinemaID = " + r.Cinema.Id + " "
                    + "WHERE Id = " + r.Id;
            Console.WriteLine("Update query:" + sql);
            try
            { // update row
                command = CreateCommand(sql);
                dbReader = command.ExecuteReader();

            }//end try
            catch (Exception ex)
            {
                Console.WriteLine("Update exception in row db: " + ex);
            }//end catch

            conn.Close();
        }

        public Row FindRowByRowNoAndCinema(int rowNo, Cinema cinema, bool retrieveAssociation)
        {
            conn.Open();
            Row row = new Row();
            string sql = "SELECT * FROM row WHERE RowNo = " + rowNo + " AND CinemaID = " + cinema.Id;

            command = CreateCommand(sql);
            dbReader = command.ExecuteReader();

            while (dbReader.Read())
            {
                row = CreateSingle(dbReader, retrieveAssociation);
            }

            conn.Close();
            return row;
        }

        public Row FindRowById(Row row, bool retrieveAssociation)
        {
            conn.Open();
            Row r = new Row();
            string sql = "SELECT * FROM row WHERE Id = " + row.Id;

            command = CreateCommand(sql);
            dbReader = command.ExecuteReader();

            while (dbReader.Read())
            {
                r = CreateSingle(dbReader, retrieveAssociation);
            }

            conn.Close();
            return r;
        }

        public IList<Row> FindAllRows(bool retrieveAssociation)
        {
            conn.Open();

            IList<Row> rowList = new List<Row>();
            string sql = "SELECT * FROM row";
            command = CreateCommand(sql);

            dbReader = command.ExecuteReader();

            rowList = CreateList(dbReader, sql, retrieveAssociation);

            conn.Close();
            return rowList;
        }

        private Row CreateSingle(DbDataReader dbReader, bool retrieveAssociation)
        {
            Row row = new Row();
            try
            {
                row.Id = dbReader.GetInt32(0);
                row.RowNo = dbReader.GetInt32(1);
                row.NoOfSeats = dbReader.GetInt32(2);
                Cinema cinema = new Cinema();
                cinema.Id = dbReader.GetInt32(3);
                
                if (retrieveAssociation)
                {
                    //IFdbCinema dbCinema = new DBCinema();
                    //cinema = dbCinema.FindCinemasByID(cinema);
                }//end if
                row.Cinema = cinema;
            }
            catch (Exception e)
            {
                Console.WriteLine("building Row object" + e);
            }
            return row;
        }

        private IList<Row> CreateList(DbDataReader dbReader, string sql, bool retrieveAssociation)
        {

            IList<Row> list = new List<Row>();


            Console.WriteLine("DbRow List" + sql);
            try
            { // read from Row


                while (dbReader.Read())
                {
                    list.Add(CreateSingle(dbReader, retrieveAssociation));
                }//end while

            }//end try
            catch (Exception e)
            {
                Console.WriteLine("Query exception - select Row : " + e.Message);

            }//end catch

            return list;
        }

        private DbCommand CreateCommand(String sql)
        {
            command = dbFactory.CreateCommand();
            command.CommandText = sql;
            command.Connection = conn;

            return command;
        }


        public IList<Row> FindRowsByCinemaId(Cinema c, bool retrieveAssociation)
        {
            conn.Open();

            IList<Row> rowList = new List<Row>();
            string sql = "SELECT * FROM row WHERE cinemaid =" + c.Id;
            command = CreateCommand(sql);

            dbReader = command.ExecuteReader();

            rowList = CreateList(dbReader, sql, retrieveAssociation);

            conn.Close();
            return rowList;
        }
    }
}

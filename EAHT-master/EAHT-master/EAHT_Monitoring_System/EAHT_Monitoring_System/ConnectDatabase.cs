using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace EAHT_Monitoring_System
{
    class ConnectDatabase
    {

        //an instance of the class
        private static ConnectDatabase _instance;

        //the variable the connection string is held in
        private static string dbConnectionString;

        public SqlConnection sqlConn;

        private SqlDataAdapter sqlAdapter;

        //properties for the class ConnectDatabase.cs

        public static ConnectDatabase Instance
        {
            get
            {
                //check if object was created
                if (_instance == null)
                {
                    //create object
                    _instance = new ConnectDatabase();

                    //set the connection string
                    ConnectDatabase.DBConnectionString = Properties.Settings.Default.DBConnStr;
                }
                return _instance;
            }
        }

        public static string DBConnectionString
        {
            set
            {
                dbConnectionString = value;
            }
        }

        //open the connection to the DB
        public void openConnection()
        {
            //create the connection
            sqlConn = new SqlConnection(dbConnectionString);

            //open the connection

            sqlConn.Open();
        }

        //close the connection to the DB
        public void closeConnection()
        {
            //close the connection
            sqlConn.Close();
        }

        // create and return a data set
        public DataSet getDataSet(string sqlStatement)
        {
            DataSet dsPatient = new DataSet();
            //open connection
            openConnection();

            //create the table adapter using the connection string and the sql statement
            sqlAdapter = new SqlDataAdapter(sqlStatement, dbConnectionString);

            //fills in the data set
            sqlAdapter.Fill(dsPatient);

            //close conn
            closeConnection();
            return dsPatient;


        }

        public void recordInDB(string name, string problem)
        {
            //create the object SqlCommand
            SqlCommand command = new SqlCommand();
            //set its properties
            command.CommandType = CommandType.Text;
            command.Parameters.Add(new SqlParameter("Name", name));
            command.Parameters.Add(new SqlParameter("Mark", problem));

            openConnection();
            command.Connection = sqlConn;

            //execute the command
            int noRows = command.ExecuteNonQuery();

            closeConnection();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CSharp_Student_System
{
    /*
     * in this class we will create the create the connection btw our app and the mysql db
     * we need to add the mysql connector to the project
     * we need to create the database
     */
    class MY_DB
    {
        //the connection
        private MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=csharp_student_db");

        //create a function to get the connection
        public MySqlConnection getConnection
        {
            get
            {
                return conn;
            }
        }

        //create a function to open the connection
        public void openConnection()
        {
            if(conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }
    }
}

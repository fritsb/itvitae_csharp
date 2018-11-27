/* Small, quick and simple example how to connect from C# to a local MS SQL database
 * Based on MS SQL database with a table Pets
 * 
 * Based on these tutorials:
 * - https://www.codeproject.com/Articles/823854/%2FArticles%2F823854%2FHow-to-connect-SQL-Database-to-your-Csharp-program
 * - https://www.codeproject.com/Articles/4416/Beginners-guide-to-accessing-SQL-Server-through-C
 *
 * Updated version with connection string in App.Config
 * NOTE: "You need to reference System.Configuration.dll in your project as well as the "using" statement."
 * ( Reference in project: right-click on 'add references' folder in the solution explorer, select the '.NET' tab, 
 *     search for the .NET reference you would like to add (in this case System.Configuration) )
 *
 * Also notice the difference between the connection strings; both ways work. 
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;


namespace ConsoleDbApp
{
    class DatabaseConnector
    {
        public SqlConnection conn;
        public Boolean connectionOpened = false;

        public DatabaseConnector() {

            try { 
                conn = new SqlConnection();
                //conn.ConnectionString = "Server=STREEKWIN\\SQLEXPRESS;Database=itvitae;Trusted_Connection=true";
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["dbString"].ConnectionString;
                conn.Open();
                connectionOpened = true;
            }
            catch(Exception e)
            {
                Console.WriteLine("AYE AYE connection not possible: " + e.ToString());
            }

        }
        
        public void getPets()
        {
            if(connectionOpened == true) {
                SqlCommand command = new SqlCommand("SELECT * FROM Pets  ", conn);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    Console.WriteLine("petsID\tPetName\tOwnerID");
                    while (reader.Read())
                    {
                        String tmpData = String.Format("{0} \t | {1} \t | {2} \t",
                            reader[0], reader[1], reader[2]);
                        Console.WriteLine(tmpData);
                    }
                }
                Console.WriteLine("Data displayed!");
                
            }

            Console.ReadLine();
            //return "";
        }
    }
}

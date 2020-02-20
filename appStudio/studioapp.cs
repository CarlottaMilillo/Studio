using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using CLSdb;
using System.Data.SqlClient;

namespace appStudio
{
    class studioapp
    {
        public static cdb sql = new cdb();
        public static string conn = ConfigurationManager.AppSettings["stringconnection"].ToString();
        public static List<utenze> ut;
        public static string query;
        /// <summary>
        /// entry point 
        /// </summary>
        static void Main()
        {

            if (!sql.isConnected(conn))
            {
                Console.WriteLine("la connessione è fallita!");
            }
            else
            {
                Console.WriteLine("database connesso!\n");
            }
            query = "select * from Studio where nome like '%a%'"; //database non case sensitive
            ut = sql.GetData(conn, query);
            if (ut.Count > 0)
            {
                foreach (utenze u in ut)
                {
                    Console.WriteLine("nome: {0}, cognome: {1}, indirizzo: {2}, città: {3}, età: {4}",
                        u.nome,
                        u.cognome,
                        u.indirizzo,
                        u.città,
                        u.età.ToString());

                }
            }
            else
            {
                Console.WriteLine("\nNon sono presenti dati per questa ricerca.");
            }
            Console.WriteLine("\npremi un tasto per uscire");
            Console.ReadKey();


        }

    }
}

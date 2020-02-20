using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLSdb
{
    /// <summary>
    /// definisco la struttura dinamica dei campi del db 
    /// </summary>
    public class utenze
    {
        public string id { get; set; }
        public string nome { get; set; }
        public string cognome { get; set; }
        public string indirizzo { get; set; }
        public string città { get; set; }
        public int età { get; set; } 


    }
    public class cdb
    {

        public bool isConnected(string strconn)
        {
            SqlConnection conn = new SqlConnection(strconn);
            bool bRes = false;
            try
            {
                conn.Open();
                bRes = true;
            }
            catch (Exception ex)
            {
                bRes = false;
                Console.WriteLine(ex.ToString());

            }

            conn.Close();
            return bRes;

        }
        //creo una routine che mi prenda i dati del db e me li faccia leggere 
        //prima prendo i dati e con un bool verifico che ce ne siano 


        /// <summary>
        /// prende i dati da una tabella 
        /// </summary>
        /// <returns> lista di dati </returns>
        public  List<utenze> GetData(string strconn, string q)
        {
            List<utenze> result = new List<utenze>();
            SqlConnection conn = new SqlConnection(strconn);

            try
            {
                string query = q; //parametri per la chiamata al database
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader dr;
                conn.Open();
                dr = cmd.ExecuteReader();

                //se il db ha righe
                if (dr.HasRows)
                {
                    Console.WriteLine("ecco i dati del database:\n");
                    while (dr.Read())
                    {
                        result.Add(new utenze()
                        {
                            nome = dr["nome"].ToString(),
                            cognome = dr["cognome"].ToString(),
                            indirizzo = dr["indirizzo"].ToString(),
                            città = dr["città"].ToString(),
                            età = (int) dr["età"],//casting , forzatura 
                            id= dr["id"].ToString() //to string necessairo per passare da unique identifier a stringa 
                        });
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("attenzione errore" + ex.ToString());
            }

            conn.Close();
            return result;
        }
        public List<utenze> GetData(string strconn)
        {

            return new List<utenze>();
        }
    }


}

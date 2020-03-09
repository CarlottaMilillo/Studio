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
        //declared variables with no value assigned 
        //can be read and set 
        //to declare a class of structures: visibility: public or private type: string, int ecc name and commands 
        // 
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
        /// takes data form table 
        /// </summary>
        /// <returns> list of datas </returns>
        public  List<utenze> GetData(string strconn, string q)
        {
            List<utenze> result = new List<utenze>();
            SqlConnection conn = new SqlConnection(strconn);

            try
            {
                string query = q; //parameters passed to the class that gets the data from db 
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader dr;
                conn.Open();
                dr = cmd.ExecuteReader();
        

                //if the db has rows 
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
                            id= dr["id"].ToString() //to string (to pass from unique identifier to a string ) 
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
        public List<utenze> GetData(string strconn) ///declaring more classes wiht the same purpose but with differet parameters allows 
        ///the user to personalize the class they bought depending on what they need to do 
        {

            return new List<utenze>();
        }
    }


}

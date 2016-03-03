using System.Collections.Generic;
using System.Data.SqlClient;

namespace webservice.Areas.Api.Models
{
    class SongManager
    {
        private static string cadenaConexio = @"Data Server=tcp:bdonplay.database.windows.net,1433;Database=serviceonplay_db;User ID = onplay@bdonplay;Password={P@ssw0rd}; Encrypt=True;TrustServerCertificate=False;Connection Timeout = 30";
            //@"Data Source=bdonplay.database.windows.net;Initial Catalog=DBonplay;Integrated Security=True";
       
    public song obtenirSong(int id)
        {

            song sng = null;

            SqlConnection con = new SqlConnection(cadenaConexio);

            con.Open();

            string sql = "SELECT Nom, Duracio FROM Songs WHERE IdSong = @idSong";

            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.Parameters.Add("@idsong", System.Data.SqlDbType.NVarChar).Value = id;

            SqlDataReader reader =
                cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

            if (reader.Read())
            {
                sng = new song();
                sng.Id = id;
                sng.Nom = reader.GetString(0);
                sng.Duracio = reader.GetInt32(1);
            }

            reader.Close();

            return sng;
        }

        public List<song> obtenirSongs()
        {

            List<song> llista = new List<song>();
            SqlConnection con = new SqlConnection(cadenaConexio);
            con.Open();

            string sql = "SELECT IdSong, Nom, Duracio FROM Songs";
            SqlCommand cmd = new SqlCommand(sql, con);

            SqlDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

            while (reader.Read())
            {
                song sng = new song();

                sng = new song();
                sng.Id = reader.GetInt32(0);
                sng.Nom = reader.GetString(1);
                sng.Duracio = reader.GetInt32(2);

                llista.Add(sng);
            }

            reader.Close();

            return llista;
        }
    }
}

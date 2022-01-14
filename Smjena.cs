using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt___TBP
{
    public static class Smjena
    {
        public static List<DateTime> blagdani = new List<DateTime>()
        {
            new DateTime (1,12,25), new DateTime(1,11,18), new DateTime(1,1,1), new DateTime(1,1,6), new DateTime(1,5,1), new DateTime(1,5,30),
            new DateTime(1,8,15), new DateTime(1,8,5), new DateTime(1,11,1)
        };


        public static int DohvatiTrenutnuSmjenu()
        {
            int idVrsteTrenutneSmjene = DohvatiVrstuTrenutneSmjenu();

            var veza = Baza.Dohvati.Veza;
            var trenutnoVrijeme = DateTime.Now;

            if (veza.State != System.Data.ConnectionState.Open)
                veza.Open();

            using var cmdTrazi = new NpgsqlCommand($"SELECT id_smjene FROM smjene WHERE datum = @datum AND id_vrsta_smjene = @idVrste", veza);
            cmdTrazi.Parameters.AddWithValue("datum", trenutnoVrijeme.Date);
            cmdTrazi.Parameters.AddWithValue("idVrste", idVrsteTrenutneSmjene);
            var reader = cmdTrazi.ExecuteReader();
            reader.Read();

            int idSmjene = -1;

            if (reader.HasRows)
            {
                idSmjene = Convert.ToInt32(reader["id_smjene"]);
            }
            else
            {
                veza.Close();
                veza.Open();
                using var cmdDodaj = new NpgsqlCommand($"INSERT INTO smjene (datum, id_vrsta_smjene) VALUES (@datum, @idVrsteSmjene) RETURNING id_smjene", veza);
                cmdDodaj.Parameters.AddWithValue("datum", trenutnoVrijeme.Date);
                cmdDodaj.Parameters.AddWithValue("idVrsteSmjene", idVrsteTrenutneSmjene);
                cmdDodaj.ExecuteNonQuery();

                idSmjene = (int)cmdDodaj.ExecuteScalar();
            }

            veza.Close();
            return idSmjene;
        }

        public static int DohvatiVrstuTrenutneSmjenu()
        {
            var veza = Baza.Dohvati.Veza;
            var trenutnoVrijeme = DateTime.Now;

            if (trenutnoVrijeme.DayOfWeek == DayOfWeek.Saturday || trenutnoVrijeme.DayOfWeek == DayOfWeek.Sunday || blagdani.Any(b=>b.Day==trenutnoVrijeme.Day && b.Month==trenutnoVrijeme.Month))
            {
                return 4;
            }

            if (veza.State != System.Data.ConnectionState.Open)
                veza.Open();

            using var cmd = new NpgsqlCommand($"SELECT id_smjene FROM vrsta_smjene WHERE @vrijeme BETWEEN vrijeme_pocetka AND vrijeme_zavrsetka", veza);
            cmd.Parameters.AddWithValue("vrijeme", trenutnoVrijeme.TimeOfDay);
            var reader = cmd.ExecuteReader();
            reader.Read();

            int idVrsteSmjene = -1;

            if (reader.HasRows)
            {
                idVrsteSmjene = Convert.ToInt32(reader["id_smjene"]);
            }

            veza.Close();

            return idVrsteSmjene;
        }
    }
}

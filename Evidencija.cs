using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt___TBP
{
    class Evidencija
    {
        public static List<VrstaSmjene> DohvatiVrsteSmjene()
        {
            List<VrstaSmjene> vrsteSmjene = new List<VrstaSmjene>();
            var veza = Baza.Dohvati.Veza;

            veza.Open();

            using var cmd = new NpgsqlCommand($"SELECT * FROM vrsta_smjene", veza);
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                vrsteSmjene.Add(new VrstaSmjene()
                {
                    id_smjene = Convert.ToInt32(reader["id_smjene"]),
                    naziv = reader["naziv"].ToString(),
                    satnica = Convert.ToInt32(reader["satnica"])
                });
            }

            reader.Close();

            veza.Close();

            return vrsteSmjene;
        }

        public static List<EvidencijaRada> DohvatiSveEvidencije(DateTime zaMjesec)
        {
            List<EvidencijaRada> evidencijeRada = new List<EvidencijaRada>();

            var veza = Baza.Dohvati.Veza;


            veza.Open();

            using var cmd = new NpgsqlCommand($"SELECT * FROM evidencija_rada e " +
                                              $"JOIN smjene s ON e.id_smjene = s.id_smjene " +
                                              $"JOIN vrsta_smjene v ON v.id_smjene = s.id_vrsta_smjene " +
                                              $"JOIN zaposlenik z ON z.id_zaposlenik = e.id_zaposlenik " +
                                              $"WHERE EXTRACT(MONTH FROM s.datum) = @mjesecPretrage AND EXTRACT(YEAR FROM s.datum) = @godinaPretrage", veza);
            cmd.Parameters.AddWithValue("mjesecPretrage", zaMjesec.Month);
            cmd.Parameters.AddWithValue("godinaPretrage", zaMjesec.Year);
            var reader = cmd.ExecuteReader();


            evidencijeRada.Clear();

            while (reader.Read())
            {
                evidencijeRada.Add(new EvidencijaRada()
                {
                    ID_zaposlenik = Convert.ToInt32(reader["id_zaposlenik"]),
                    ID_vrsta_smjene = Convert.ToInt32(reader["id_vrsta_smjene"]),
                    ID_statusa = Convert.ToInt32(reader["id_statusa"]),
                    VrstaRada = "Rad",
                    VrstaSmjene = reader["naziv"].ToString(),
                    Datum = DateTime.Parse(reader["datum"].ToString()).ToShortDateString(),
                    Ime = reader["ime"].ToString(),
                    Prezime = reader["prezime"].ToString(),
                    PocetakRada = (reader["pocetak_rada"]).ToString(),
                    KrajRada = (reader["kraj_rada"]).ToString()
                });
            }

            reader.Close();

            using var cmdBolovanja = new NpgsqlCommand($"SELECT * FROM bolovanja b JOIN zaposlenik z ON z.id_zaposlenik = b.id_zaposlenika WHERE " +
                                              $"(EXTRACT(MONTH FROM b.pocetak_bolovanja) = @mjesecPretrage AND EXTRACT(YEAR FROM b.pocetak_bolovanja) = @godinaPretrage) OR ( EXTRACT(MONTH FROM b.kraj_bolovanja) = @mjesecPretrage AND EXTRACT(YEAR FROM b.kraj_bolovanja) = @godinaPretrage)", veza);
            cmdBolovanja.Parameters.AddWithValue("mjesecPretrage", zaMjesec.Month);
            cmdBolovanja.Parameters.AddWithValue("godinaPretrage", zaMjesec.Year);
            var readerBolovanja = cmdBolovanja.ExecuteReader();

            while (readerBolovanja.Read())
            {
                DateTime trenutniDan = (DateTime)readerBolovanja["pocetak_bolovanja"];
                DateTime krajBolovanja = (DateTime)readerBolovanja["kraj_bolovanja"];
                DateTime krajMjeseca = new DateTime(zaMjesec.Year, zaMjesec.Month, 1).AddMonths(1).AddDays(-1);

                while (trenutniDan <= krajBolovanja && trenutniDan <= krajMjeseca)
                {
                    if (trenutniDan.DayOfWeek != DayOfWeek.Saturday && trenutniDan.DayOfWeek != DayOfWeek.Sunday)
                    {
                        evidencijeRada.Add(new EvidencijaRada()
                        {
                            VrstaRada = "Bolovanje",
                            VrstaSmjene = "-",
                            ID_vrsta_smjene = 6,
                            ID_zaposlenik = Convert.ToInt32(readerBolovanja["id_zaposlenika"]),
                            KrajRada = "-",
                            PocetakRada = "-",
                            Datum = trenutniDan.ToShortDateString(),
                            Ime = readerBolovanja["ime"].ToString(),
                            Prezime = readerBolovanja["prezime"].ToString()
                        });
                    }

                    trenutniDan = trenutniDan.AddDays(1);
                }
            }

            readerBolovanja.Close();

            using var cmdGO = new NpgsqlCommand($"SELECT * FROM godisnji_odmori g JOIN zaposlenik z ON z.id_zaposlenik = g.id_zaposlenika WHERE  " +
                                             $"(EXTRACT(MONTH FROM pocetak_go) = @mjesecPretrage AND EXTRACT(YEAR FROM pocetak_go) = @godinaPretrage) OR ( EXTRACT(MONTH FROM kraj_go) = @mjesecPretrage AND EXTRACT(YEAR FROM kraj_go) = @godinaPretrage)", veza);
            cmdGO.Parameters.AddWithValue("mjesecPretrage", zaMjesec.Month);
            cmdGO.Parameters.AddWithValue("godinaPretrage", zaMjesec.Year);
            var readerGO = cmdGO.ExecuteReader();

            while (readerGO.Read())
            {
                DateTime trenutniDan = (DateTime)readerGO["pocetak_go"];
                DateTime krajGO = (DateTime)readerGO["kraj_go"];
                DateTime krajMjeseca = new DateTime(zaMjesec.Year, zaMjesec.Month, 1).AddMonths(1).AddDays(-1);

                while (trenutniDan <= krajGO && trenutniDan <= krajMjeseca)
                {
                    if (trenutniDan.DayOfWeek != DayOfWeek.Saturday && trenutniDan.DayOfWeek != DayOfWeek.Sunday)
                    {
                        evidencijeRada.Add(new EvidencijaRada()
                        {
                            VrstaRada = "GO",
                            VrstaSmjene = "-",
                            ID_vrsta_smjene = 5,
                            ID_zaposlenik = Convert.ToInt32(readerBolovanja["id_zaposlenika"]),
                            KrajRada = "-",
                            PocetakRada = "-",
                            Datum = trenutniDan.ToShortDateString(),
                            Ime = readerBolovanja["ime"].ToString(),
                            Prezime = readerBolovanja["prezime"].ToString()
                        });
                    }
                    trenutniDan = trenutniDan.AddDays(1);
                }
            }

            readerGO.Close();
            veza.Close();

            return evidencijeRada;
        }
    }
}

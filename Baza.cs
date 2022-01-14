using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt___TBP
{
    class Baza
    {
        private static string connString = "Host=localhost;Username=postgres;Password=tbp99;Database=tbp;SearchPath=public;";
        private static Baza baza;
        private static NpgsqlConnection veza;
        private static Zaposlenik zaposlenik;

        public Zaposlenik Zaposlenik
        {
            get => zaposlenik;
            set
            {
                zaposlenik = value;
            }
        }

        public NpgsqlConnection Veza
        {
            get => veza;
        }

        private Baza() { }

        public static Baza Dohvati
        {
            get
            {
                if (baza == null)
                {
                    veza = new NpgsqlConnection(connString);
                    zaposlenik = new Zaposlenik();
                    baza = new Baza();
                }

                return baza;
            }
        }

    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt___TBP
{
    class Placa
    {
        public float Neto { get; set; }
        public float Bruto1 { get; set; }
        public float Bruto2 { get; set; }
        public int BrojDjece { get; set; }
        public int BrojUzdrzavanihOsoba { get; set; }
        public float PostotakPrirez { get; set; } = 7.5f;
        public int PostotakPoreza1 { get; set; } = 20;
        public int PostotakPoreza2 { get; set; } = 30;
        public int PostotakMirovinsko1 { get; set; } = 15;
        public int PostotakMirovinsko2 { get; set; } = 5;
        public float PostotakZdravstveno { get; set; } = 16.5f;


        public float OsobniOdbitak()
        {
            float osobbniodbitak = 4000;

            float[] koeficijenti = new float[6] { 0f, 0.7f, 1f, 1.4f, 1.9f, 2.5f };



            float dodatak = 2500 * (koeficijenti[BrojDjece] + 0.7f * BrojUzdrzavanihOsoba);
            osobbniodbitak = osobbniodbitak + dodatak;

            return osobbniodbitak;
        }


        public float IzracunajBruto1()
        {

            float bruto1 = 0;

            if (Neto <= OsobniOdbitak())
            {
                bruto1 = Neto * 1.25f;
            }

            else
            {
                if (Neto < 30000)
                {
                    bruto1 = (float)((Neto - OsobniOdbitak()) / (1 - (0.2 * 1.075)) + OsobniOdbitak()) / 0.8f;
                }

                else
                {
                    bruto1 = (float)((Neto - OsobniOdbitak()) / (1 - (0.3 * 1.075)) + OsobniOdbitak()) / 0.8f;
                }
            }

            return bruto1;
        }

        public float IzracunajMIO1()
        {
            return IzracunajBruto1() * 0.15f;
        }

        public float IzracunajMIO2()
        {
            return IzracunajBruto1() * 0.05f;
        }

        public float IzracunMIO()
        {
            return IzracunajMIO1() + IzracunajMIO2();
        }


        public float IzracunajDohodak()
        {
            float dohodak = IzracunajBruto1() - IzracunMIO();

            return dohodak;
        }

        public float IzracunajPoreznuOsnovicu()
        {
            if(Neto <= OsobniOdbitak())
            {
                return 0.0f;
            }

            float poreznaOsnovica = IzracunajDohodak() - OsobniOdbitak();

            return poreznaOsnovica;
        }


        public float IzracunajPorez()
        {
            float porez = 0;

            if (Neto <= OsobniOdbitak())
            {
                return 0.0f;
            }
            
            if (Neto <= 30000)
            {
                porez = IzracunajPoreznuOsnovicu() - (IzracunajPoreznuOsnovicu() * 0.2f);
            }

            else
            {
                porez = IzracunajPoreznuOsnovicu() - (IzracunajPoreznuOsnovicu() * 0.3f);
            }

            return porez;
        }

        public float IzracunajPrirez()
        {
            if (Neto <= OsobniOdbitak())
            {
                return 0.0f;
            }

            float prirez = IzracunajPorez() * 1.075f;

            return prirez;
        }

        public float IzracunajZdravstveno()
        {
            float zdravstveno = IzracunajBruto1() * 0.165f;

            return zdravstveno;
        }

        public float IzracunajBruto2()
        {
            float bruto2 = IzracunajBruto1() + IzracunajZdravstveno();

            return bruto2;
        }

    }
}

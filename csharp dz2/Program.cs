
using System;

namespace IgrovayaSistema
{
    class Polzovatel
    {
        public string Nikneym { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            PoschitatBal();
            SozdatInventar();
            ProveritPolzovatelya();
            OchistitImena();
        }

        static void PoschitatBal()
        {
            int[] ochki = { 85, 92, 78, 95, 88 };
            int summa = 0;

            foreach (int bal in ochki)
            {
                summa += bal;
            }

            double sredniyBal = (double)summa / ochki.Length;
            Console.WriteLine($"Sredniy bal: {sredniyBal:F1}");
        }

        static void SozdatInventar()
        {
            int[][] inventar = new int[3][];
            inventar[0] = new int[4];
            inventar[1] = new int[8];
            inventar[2] = new int[3];

            Console.WriteLine($"Kolichestvo sektsiy: {inventar.Length}");
        }

        static void ProveritPolzovatelya()
        {
            Polzovatel polzovatel = null;

            string imya = polzovatel?.Nikneym ?? "Gost_01";

            Console.WriteLine($"Aktivniy polzovatel: {imya}");
        }

        static void OchistitImena()
        {
            string[] imena = { "  alex ", "ANNA", "  bob  " };

            for (int i = 0; i < imena.Length; i++)
            {
                string imya = imena[i].Trim().ToLower();

                if (imya.Length > 0)
                {
                    imena[i] = char.ToUpper(imya[0]) + imya.Substring(1);
                }
                else
                {
                    imena[i] = "Neizvestno";
                }

                Console.WriteLine($"Imya: [{imena[i]}]");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace kosar2004
{
    class Program
    {
        static List<Kosarlabda> adatok = new List<Kosarlabda>();
        static void Main(string[] args)
        {
            Beolvasas();
            Feladat3();
            Feladat4();
            Feladat5();
            Feladat6();
            Feladat7();
            Console.ReadKey();
            
        }

        private static void Feladat7()
        {
            Console.WriteLine("7. feladat:");
            Dictionary<string, int> stat = new Dictionary<string, int>();
            foreach (var item in adatok)
            {
                if (stat.ContainsKey(item.Helyszín))
                {
                    stat[item.Helyszín]++;
                }
                else
                {
                    stat.Add(item.Helyszín, 1);
                }
            }
            foreach (var item in stat)
            {
                if (item.Value > 20)
                {
                    Console.WriteLine($"\t{item.Key} {item.Value}");
                }
            }
        }

        private static void Feladat6()
        {
            Console.WriteLine("6. feladat:");
            for (int i = 0; i < adatok.Count; i++)
            {
                if (adatok[i].Idopont.Year == 2004 && adatok[i].Idopont.Month == 11 && adatok[i].Idopont.Day == 21)
                {
                    Console.WriteLine($"\t{adatok[i].Hazai} - {adatok[i].Idegen} ({adatok[i].Hazai_pont}:{adatok[i].Idegen_pont})");
                }
            }
        }

        private static void Feladat5()
        {
            bool van = false;
            int x = 0;
            while (x < adatok.Count && !van)
            {
                if (adatok[x].Hazai.Contains("Barcelona"))
                {
                    van = true; 
                }
                x++;
            }
            if (van)
            {   
                Console.WriteLine($"{adatok[x].Hazai}");
            }
            
        }

        private static void Feladat4()
        {
            bool van = false;
            int x = 0;
            while (x < adatok.Count)
            {
                if (adatok[x].Idegen_pont == adatok[x].Hazai_pont)
                {
                    van = true;
                }
                x++;
            }
            
            if (van)
            {
                Console.WriteLine("4. feladat: Volt döntetlen? igen");
            }
            else
            {
                Console.WriteLine("4. feladat: Volt döntetlen? nem");
            }
        }

        private static void Feladat3()
        {
            int hazai = 0;
            int idegen = 0;
            for (int i = 0; i < adatok.Count; i++)
            {
                if (adatok[i].Hazai == "Real Madrid")
                {
                    hazai++;
                }
                else if (adatok[i].Idegen == "Real Madrid")
                {
                    idegen++;
                }
            }
            Console.WriteLine($"3. feladat: Real Madrid: Hazai: {hazai}, Idegen: {idegen}");
        }

        private static void Beolvasas()
        {
            using (StreamReader be = new StreamReader("eredmenyek.csv"))
            {
                be.ReadLine();
                while (!be.EndOfStream)
                {
                    string[] a = be.ReadLine().Split(';');
                    adatok.Add(new Kosarlabda(a[0], a[1], Convert.ToInt32(a[2]), Convert.ToInt32(a[3]), a[4], Convert.ToDateTime(a[5])));
                }
            }
            
            
        }
    }
}

using System.Security.Cryptography.X509Certificates;

namespace Dolgozat2
{
    internal class Program
    {
        //1. feladat
        static string[] huto = {"", "hal", "", "disznó", "máj", "alma", "", "rántotta"};
        static void Berakas()
        {
            bool exit = false;
            bool tester = false;
            string input;
            do
            {
                for (int i = 0; i < huto.Length; i++)
                {
                    Console.WriteLine(huto[i]);
                }
                Console.Write("Szeretnél valamit berakni a hűtőbe? Ha nem nyomd meg az [x] gombot: ");

                input = Console.ReadLine();

                if (input == "x")
                {
                    exit = true;
                }
                else
                {
                    for (int i = 0; i < huto.Length; i++)
                    {
                        if (huto[i] == "")
                        {
                            huto[i] = input;
                            tester = true;
                            break;
                        }
                    }
                    if (tester == false)
                    {
                        Console.WriteLine("Nincs hely");
                        exit = true;

                    }
                    tester = false;

                }
            } while (exit == false);

        }
        static void Takarit()
        {
            bool tester = false;
            bool invalid = false;
            int counter = 0;
            do 
            {
                invalid = false;
                for (int i = 0; i < huto.Length; i++)
                {
                    if (huto[i] == "")
                    {
                        if (i == 7)
                        {
                        }
                        else
                        {
                            huto[i] = huto[i + 1];
                            huto[i + 1] = "";
                        }

                    }
                }
                for (int i = 0; i < huto.Length; i++)
                {
                    if (i > 0)
                    {
                        if (huto[i] != "")
                        {
                            if (huto[i - 1] == "")
                            {
                                invalid = true;
                            }
                        }
                    }

                }
            } while (invalid == true);
            


            for (int i = 0; i < huto.Length; i++)
            {
                if (huto[i] != "")
                {
                    counter++;
                }
                Console.WriteLine(huto[i]);
            }
            Console.WriteLine(counter + " étel van");
            Console.WriteLine("---------------------------");
        }
        static void KeresEtel()
        {
            bool tester = true;
            Console.Write("Milyen ételt keresel: ");
            string input = Console.ReadLine();
            for (int i = 0; i < huto.Length; i++)
            {
                if (input == huto[i])
                {
                    Console.WriteLine(i + " indexen található meg az étel");
                    tester = false;
                } 
                
            }
            if (tester == true)
            {
                Console.WriteLine("0");
            }
            Console.WriteLine("--------------------------");
        }
        static void MaganHangzo()
        {
            string etel;
            char[] betuk = { 'a', 'á', 'e', 'é', 'i', 'í', 'o', 'ó', 'ö', 'ő', 'u', 'ú', 'ü', 'ű' };
            for (int i = 0; i < huto.Length; i++)
            {
                etel = huto[i];
                for (int j = 0; j < betuk.Length; j++)
                {
                    if (etel != "")
                    {
                        if (etel[0] == betuk[j])
                        {
                            Console.WriteLine(etel);
                        }
                    }

                }
            }
            Console.WriteLine("----------------------------");

        }

        //2. feladat
        static Random r = new Random();
        static int[] szamok = new int[10];
        static void FeltoltEgyediekkel(int min, int max)
        {
            int memory;
            bool tester = true;
            for (int i = 0; i < szamok.Length; i++)
            {
                memory = r.Next(min, max);
                for (int j = 0; j < szamok.Length; j++)
                {
                    if (memory == szamok[j])
                    {
                        tester = false;
                    }
                }
                if (tester = true)
                {
                    szamok[i] = memory;
                } else
                {
                    i--;
                }
            }
            for (int i = 0; i < szamok.Length; i++)
            {
                Console.WriteLine(szamok[i]);
            }
            Console.WriteLine("--------------------------");
        }
        static void LeghosszabbNovekvo()
        {

        }
        static void AtlagAlattiDuplazas()
        {
            int adder = 0;
            int atlag;
            for (int i = 0; i < szamok.Length; i++)
            {
                adder += szamok[i];
            }
            atlag = adder / szamok.Length;
            for (int i = 0; i < szamok.Length; i++)
            {
                if (szamok[i] < atlag)
                {
                    szamok[i] += szamok[i];
                }
            }
            for (int i = 0; i < szamok.Length; i++)
            {
                Console.WriteLine(szamok[i]);
            }
            Console.WriteLine("----------------------------");
        }
        static void Main(string[] args)
        {
            //Berakas();
            //Takarit();
            //KeresEtel();
            //MaganHangzo();

            FeltoltEgyediekkel(0, 99);
            LeghosszabbNovekvo();
            AtlagAlattiDuplazas();
        }
    }
}

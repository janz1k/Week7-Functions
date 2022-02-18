using System;

namespace UserNameDataTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm küsib kasutajal sisestada eesnime;
            //Programm küsib kasutajal sisestada numbrit 1-3;
            //kui kasutaja sisestab '1', siis kuvatakse kasutaja eesnime tagurpidi
            //kui kasutaja valib 2, siis kuvatakse kasutaja eesnime esimest tähte
            //kui kasutaja valib 3, siis kuvatakse kasutaja eesnime pikkust

            Console.WriteLine("Palun sisestage enda nimi:");
            string userName = Console.ReadLine();

            Console.WriteLine("Palun sisestage number vahemikus 1-3");
            int userNumber = Convert.ToInt32(Console.ReadLine());



            switch (userNumber)
            {
                case <= 1:
                    for (int i = userName.Length - 1; i >= 0; i--)
                        Console.WriteLine($"sinu nimi tagurpidi on {userName[i]}");
                    break;
                case <= 2:
                    Console.WriteLine($"Sinu eesnime esimene täht on {userName[0]}, Kena päeva!");
                    break;
                case <= 3:
                    Console.WriteLine($"Sinu nimi on {userName.Length} sümbolit pikk, Kena päeva!"); 
                    break;
                default:
                    Console.WriteLine("Vale number sisestatud, Kena päeva!");
                    break;
            }

            



        }

    }

}





using System;

namespace JeuDeMath
{
    class Program
    {
        static bool poserQuestion(int min, int max)
        {
            Random rand = new Random();
            int reponseInt = 0; 
            while (true) 
            {
                int a = rand.Next(min, max+1);
                int b = rand.Next(min,max+1);

                Console.WriteLine($"{a} + {b} =");
                string reponse = Console.ReadLine();

                try
                {
                    reponseInt = int.Parse(reponse);

                    if(reponseInt == a + b)
                    {
                        return true;
                    }

                    return false;
                }
                catch
                {
                    Console.WriteLine("ERREUR : Vous devez rentrer un nombre");
                }
            }
           
        }
        static void Main(String[] args)
        {
            const int NOMBRE_MIN = 1;
            const int NOMBRE_MAX = 10;

            const int NB_QUESTION = 3;
            // la boucle for
            for (int i = 0; i < NB_QUESTION; i++)
            {

                Console.WriteLine($"Question N°{i+1}/{NB_QUESTION}");
                bool bonneReponse = poserQuestion(NOMBRE_MIN, NOMBRE_MAX);
                if (bonneReponse)
                {
                    Console.WriteLine("Bonne reponse");
                }
                else
                {
                    Console.WriteLine("Mauvaise reponse");
                }
                Console.WriteLine();
            }
            
        }

    }
   
}
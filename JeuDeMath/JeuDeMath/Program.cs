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
                int o = rand.Next(min,3);
                // o -> 1 ou 2
                //      1 = multiplication
                //      2 = multiplication
                int resultatAttendu;

                if (o == 1)//Addition
                {
                    Console.Write($"{a} + {b} = ");
                    resultatAttendu = a + b;
                }
                else //multiplication
                {
                    Console.Write($"{a} x {b} = ");
                    resultatAttendu = a * b;

                }
                string reponse = Console.ReadLine();

                try
                {
                    reponseInt = int.Parse(reponse);

                    if(reponseInt == resultatAttendu)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                    
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
            const int NB_QUESTION = 10;

            int points = 0;

            // la boucle for
            for (int i = 0; i < NB_QUESTION; i++)
            {

                Console.WriteLine($"Question N°{i+1}/{NB_QUESTION}");
                bool bonneReponse = poserQuestion(NOMBRE_MIN, NOMBRE_MAX);
                if (bonneReponse)
                {
                    Console.WriteLine("Bonne reponse");
                    points++;
                }
                else
                {
                    Console.WriteLine("Mauvaise reponse");
                }
                Console.WriteLine();
                
            }
            Console.WriteLine($"Nombres de points : {points}/{NB_QUESTION}");

            int moyenne = NB_QUESTION / 2;

            if(points == NB_QUESTION)
            {
                Console.WriteLine("Excellent !");
            }
            else if(points == 0)
            {
                Console.WriteLine("Revisez vos maths");
            }
            else if (points > moyenne)
            {
                Console.WriteLine("Pas mal");
            } 
            else
            {
                Console.WriteLine("Peut mieux faire");
            }

        }

    }
   
}
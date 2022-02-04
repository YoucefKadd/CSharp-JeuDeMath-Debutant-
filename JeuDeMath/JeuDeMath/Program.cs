using System;

namespace JeuDeMath
{
    class Program
    {
        static void poserQuestion()
        {
            while (true) 
            {
                Console.Write("5 + 3 = ");
                string reponse = Console.ReadLine();

                try
                {
                    int reponseInt = int.Parse(reponse);
                    break;
                }
                catch
                {
                    Console.WriteLine("ERREUR : Vous devez rentrer un nombre");
                }
            }
           
        }
        static void Main(String[] args)
        {
            poserQuestion();
        }

    }
   
}
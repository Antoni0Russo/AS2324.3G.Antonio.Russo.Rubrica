﻿namespace AS2324._3G.Antonio.Russo.Rubrica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int scelta ;
            int cont= 0;
            int[] rubrica = new int[100];
            int[] annoDiNacita  = new int[100];
            int[] simpatia  = new int[100];
            string[] nome = new string[100];
            string[] email = new string[100];
            string[] cognome = new string[100];
            string[] nickName = new string[100];
            Console.WriteLine("BENVENUTO NELLA RUBRICA DI ANTONIO RUSSO");

            do
            {
                Console.WriteLine("1) Inserimento completo di un nominativo \n 2) Elenco dei nominativi inseriti \n 3) Ricerca di un nominativo in base al Nickname \n PER USCIRE 0");
                scelta = Convert.ToInt32(Console.ReadLine());
                switch (scelta)
                {
                    case 1:
                        Console.WriteLine("PARAMETRI OBLIGATORI");
                        Console.WriteLine("inserisci il nome");
                        nome[cont] = Console.ReadLine();
                        Console.WriteLine("inserici il cognome ");
                        cognome [cont] = Console.ReadLine();
                        Console.WriteLine("inserisci il nickname");
                        nickName[cont] = Console.ReadLine();
                        Console.WriteLine("\n ARAMENTRI FACOLTATIVI");
                        Console.WriteLine("inserisci la simpatia Tra 1-5");
                        simpatia[cont]= Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("inserisci anno di nascita yyyy");
                        annoDiNacita[cont]= Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("inserisci l'email");
                        email[cont] = Console.ReadLine();

                        cont++;
                        break;



                }
            } while (scelta != 0);
        }
    }
}
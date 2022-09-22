using System;
using System.Runtime.CompilerServices;

namespace Zahlenspiel
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int zufallszahl = 0;
            int Versuche =0;

            

            int erratetZahl = 0;

            do
            {
                Random random = new Random();
                zufallszahl = random.Next(0, 100);
                Versuche = 0;
                bool Invalidentry = true;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Errate eine Zahl von 0-100");
                do
                {
                    do
                    {
                        try
                        {
                            erratetZahl = Convert.ToInt16(Console.ReadLine());
                            if ((erratetZahl > 100) || (erratetZahl < 1))
                            {
                                throw new Exception();
                            }
                            Invalidentry=false;
                        }
                        catch
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.WriteLine("Bitte geben sie eine Zahl zwichen 1 und 100 ein");
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.White;
                            Invalidentry =true;
                        }
                    } while (Invalidentry);

                    
                    Versuche++;

                    if (erratetZahl == zufallszahl)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(" ██████╗ ██████╗  █████╗ ████████╗██╗   ██╗██╗      █████╗ ████████╗██╗ ██████╗ ███╗   ██╗██╗\r\n██╔════╝ ██╔══██╗██╔══██╗╚══██╔══╝██║   ██║██║     ██╔══██╗╚══██╔══╝██║██╔═══██╗████╗  ██║██║\r\n██║  ███╗██████╔╝███████║   ██║   ██║   ██║██║     ███████║   ██║   ██║██║   ██║██╔██╗ ██║██║\r\n██║   ██║██╔══██╗██╔══██║   ██║   ██║   ██║██║     ██╔══██║   ██║   ██║██║   ██║██║╚██╗██║╚═╝\r\n╚██████╔╝██║  ██║██║  ██║   ██║   ╚██████╔╝███████╗██║  ██║   ██║   ██║╚██████╔╝██║ ╚████║██╗\r\n ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═╝   ╚═╝    ╚═════╝ ╚══════╝╚═╝  ╚═╝   ╚═╝   ╚═╝ ╚═════╝ ╚═╝  ╚═══╝╚═╝");
                        Console.WriteLine("Du hast die Zahl erraten!");
                    }
                    else
                    {
                        if (erratetZahl > zufallszahl)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Schade! Deine Zahl ist leider zu hoch.");
                            Console.ForegroundColor = ConsoleColor.White;

                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Schade! Deine Zahl ist leider zu tief.");
                            Console.ForegroundColor = ConsoleColor.White;

                        }
                    }
                } while (erratetZahl != zufallszahl);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Du hast " + Versuche + " Versuch(e) Gebruaucht");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Möchtest du erneut Spielen? (y/n)");
            } while (Console.ReadLine() == "y");
            


        }
    }
}
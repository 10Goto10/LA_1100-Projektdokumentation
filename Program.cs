using System;
using System.Runtime.CompilerServices;

namespace Zahlenspiel
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int zufallszahl = 0;
            
            
            
            int erratetZahl = 0;

            do
            {
                Random random = new Random();
                zufallszahl = random.Next(0, 100);
                bool Invalidentry = true;
                Console.WriteLine(zufallszahl);
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
                            Console.WriteLine("Bitte geben sie eine Zahl zwichen 0 und 100 ein");
                            Invalidentry=true;
                        }
                    } while (Invalidentry);
                    



                    if (erratetZahl == zufallszahl)
                    {
                        Console.WriteLine("Gratulation, du hast die Zahl erraten!");
                    }
                    else
                    {
                        if (erratetZahl > zufallszahl)
                        {
                            Console.WriteLine("Schade! Deine Zahl ist leider zu hoch.");
                        }
                        else
                        {
                            Console.WriteLine("Schade! Deine Zahl ist leider zu tief.");
                        }
                    }
                } while (erratetZahl != zufallszahl);
                Console.WriteLine("Möchtest du erneut Spielen? (y/n)");
            } while (Console.ReadLine() == "y");
            


        }
    }
}
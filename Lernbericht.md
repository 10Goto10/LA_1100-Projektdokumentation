# Lern-Bericht

Noah meier

## Einleitung

In diesem Projekt ging es um ein Programm, welches eine zufällige Zahl generiert,welche dann vom Benutzer erraten werden kann.

## Was habe ich gelernt?

Ich habe gelernt, wie ich den Try-Catch Block in einem Programm implementieren kann.

## Beschreibung

Diese

``
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
                        
``


## Verifikation

✍️ Erklären Sie kurz und bündig, inwiefern die von Ihnen verwendeten Medien zeigen, was Sie gelernt haben.

# Reflexion zum Arbeitsprozess

👍 Überlegen Sie sich jeweils etwas, was gut an Ihrer Arbeit lief; 

👎 und etwas, was nicht gut lief.

**VBV**: ✍️ Formulieren Sie davon ausgehend einen *handelbaren* Verbesserungsvorschlag.

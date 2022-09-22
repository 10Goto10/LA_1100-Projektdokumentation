# Lern-Bericht

Noah meier

## Einleitung

In diesem Projekt ging es um ein Programm, welches eine zufällige Zahl generiert,welche dann vom Benutzer erraten werden kann.

## Was habe ich gelernt?

Ich habe gelernt, wie ich eien Try-Catch Block in einem Programm implementieren kann.

## Beschreibung

Das Try-Catch Element ist grundsätzlich da, um ein Absturz eines Programmes zu verhindern. Der Code ,welcher von "try {}" umschlossen ist, wird, wenn er Ausgeführt werden sollte, zuerst überprüft. Wenn dieses "überprüfen" keinen Fehler erzeugt, wird der ganze Code im Try-Elemt ausgeführ. Falls allerding ein Fehler erzeugt werden würde, wird der Code im Try-Element nur bis zu der Zeile ausgeführ, in der der Fehler entstanden ist. Zusätzlich wird bei einem Laufzeitfehler der Code im Catch-Element ausgefüht. Es ist ausserdem möglich, einen Fehler bewusst aufzurufen mit dem Befehl "throw new Exception();" 
Der Try-Catch Block ist sehr gut für eingaben geeignet, da die Funktion "Convert.ToInt16(Console.ReadLine());" sofort einen Fehler aufwirft, wenn wenn keine Gültige Zahl eingegeben wird. Zusätlich kann man den Block "throw new Exception();" sehr gut in Kombination mit einem If-Statement verwenden, um z.B. zu überprüfen, ob die eingegebene Zahl Zwischen 1 und 100 liegt.


                    Invalidentry=true;        // Die Bool-Variabel Invalidentry wird auf true gesetzt und unten Geprüft, um sicherzustellen, dass der Code bei einer Falscheingabe nicht weiterlaufen kann
                        
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
                            
                            Console.WriteLine("Bitte geben sie eine Zahl zwichen 1 und 100 ein");
                            
                        }
                        
                     } while (Invalidentry);                        


## Verifikation

✍️ Erklären Sie kurz und bündig, inwiefern die von Ihnen verwendeten Medien zeigen, was Sie gelernt haben.

# Reflexion zum Arbeitsprozess

👍 Überlegen Sie sich jeweils etwas, was gut an Ihrer Arbeit lief; 

👎 und etwas, was nicht gut lief.

**VBV**: ✍️ Formulieren Sie davon ausgehend einen *handelbaren* Verbesserungsvorschlag.

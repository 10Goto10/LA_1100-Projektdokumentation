# Lern-Bericht

Noah meier

## Einleitung

In diesem Projekt ging es um ein Programm, welches eine zufällige Zahl generiert,welche dann vom Benutzer erraten werden kann.

## Was habe ich gelernt?

Ich habe gelernt, wie ich eien Try-Catch Block in einem Programm implementieren kann.

## Beschreibung

Das Try-Catch Element ist grundsätzlich da, um ein Absturz eines Programmes zu verhindern. Der Code ,welcher von "try {}" umschlossen ist, wird, wenn er Ausgeführt werden sollte, zuerst überprüft. Wenn dieses "überprüfen" keinen Fehler erzeugt, wird der ganze Code im Try-Elemt ausgeführ. Falls allerding ein Fehler erzeugt werden würde, wird der Code im Try-Element nur bis zu der Zeile ausgeführt, in der der Fehler entstanden ist. Zusätzlich wird bei einem Laufzeitfehler der Code im Catch-Element ausgefüht. Es ist ausserdem möglich, einen Fehler bewusst aufzurufen mit dem Befehl "throw new Exception();" 
Der Try-Catch Block ist sehr gut für eingaben geeignet, da die Funktion "Convert.ToInt16(Console.ReadLine());" sofort einen Fehler aufwirft, wenn wenn keine Gültige Zahl eingegeben wird. Zusätlich kann man den Block "throw new Exception();" sehr gut in Kombination mit einem If-Statement verwenden, um z.B. zu überprüfen, ob die eingegebene Zahl Zwischen 1 und 100 liegt.


                    Invalidentry=true;        // Die Bool-Variabel Invalidentry wird auf true gesetzt und unten Geprüft, um das weiterlaufen des Codes bei einer Falscheingabe zu verhindern.
                        
                    do
                    {
                        
                        try
                        {
                            erratetZahl = Convert.ToInt16(Console.ReadLine());  // In dieser Zeile wird ein Fehler erzeugt, wenn z.B. Buchstaben eingegeben weden.
                            
                            if ((erratetZahl > 100) || (erratetZahl < 1))  // Hier wird ein Fehler Künstlich erzeugt, wenn die Zahl nich zwischen 0 und 100 ist.
                            
                            {
                            
                                throw new Exception();
                                
                            }
                            
                            Invalidentry=false;  // wenn der obige Code ohne Fehler ausgeführt werden konnte, wird Invalidentry auf false gesetzt, um im Code weiterfahren zu können.
                            
                        }
                        
                        catch
                        
                        {
                            
                            Console.WriteLine("Bitte geben sie eine Zahl zwichen 1 und 100 ein");  // Bei einer Falscheingabe wird diese Nachricht ausgegeben.
                            
                        }
                        
                     } while (Invalidentry);                        

![image](https://user-images.githubusercontent.com/111045975/191700683-f38a6596-7b31-4b8f-8926-137db5cc54c6.png)

## Verifikation

Der Code zeigt, wie der Try-Catch Block in der Praxis angewendet werden kann.
Auf dem Bild ist zu sehen ,dass das Programm mit diesem Block bei einer Falscheingabe nicht abstürzt, sondern den Benutzer erneut nach einer Zahl fragt.

# Reflexion zum Arbeitsprozess

Ich bin sehr zufrieden mit meiner Konzentration während dem Präsenzunterricht.
Ich bin nicht zufrieden damit, dass ich bei dem Fernunterricht sehr leich abgelenkt wurde.

Aus diesem Grund werde ich von nun an mein Smartphone bei Fernunterricht immer in einem anderen Raum haben.

# Projekt-Dokumentation

☝️ Alle Text-Stellen, welche mit einem ✍️ beginnen, können Sie löschen, sobald Sie die entsprechende Stellen ausgefüllt haben.

✍️ Ihr Gruppenname und Ihre Nachnamen

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
| 1.9.  | 0.0.1   | Ich habe die wichtigsten Elemente wie den Zufallszahlgenerator implementiert|
| 8.9.  | 1.0.0   | Ich habe alle "muss"-User Stories in das Programm eingebaut  |
|       |         |                                                              |

## 1 Informieren

### 1.1 Ihr Projekt

Ich erstelle ein Programm, welches eine Zufallszahl generiert, die von dem Benutzer erraten werden kann.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    | muss            | Funktional | Als ein Spieler möchte ich dass eine Zahl generiert wird, die ich erraten kann, damit ich diese erraten kann             |
| 2    | muss            | Funktional | Als ein Spieler möchte ich eine Zahl eingeben können, damit ich raten kann                                               |
| 3    | muss            | Qualität | Als ein Spieler möchte ich Anweisungen bekommen, damit ich weiss, was ich machen muss                                    |
| 4    | muss            | Funktional | Als ein Spieler möchte ich erfahren, ob ich zu hoch oder zu tief geraten habe, damit ich weniger eingeben muss           |
| 5    | muss            | Qualität | Als ein Spieler möchte ich bei einer falschen eingabe gewarnt werden, damit ich das Programm nicht zum abstürzen bringe  |
| 6    | kann            | Qualität | Als ein Spieler möchte ich erfahren, wie viele versuche ich gebraucht habe, damit ich sehen kann, wie gut ich raten kann |
| 7    | kann            | Qualität | Als ein Spieler möchte ich verschiedene Textfarben sehen, damit ich die Verschiedenen Nachrichten besser unterscheiden kann |



✍️ Jede User Story hat eine ganzzahlige Nummer (1, 2, 3 etc.), eine Verbindlichkeit (Muss oder Kann?), und einen Typ (Funktional, Qualität, Rand). Die User Story selber hat folgende Form: *Als ein 🤷‍♂️ möchte ich 🤷‍♂️, damit 🤷‍♂️*.

### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  | Das Programm tut nichts | Ich starte und beende das Programm | Ich bekomme keine Fehlermeldungen                   |
| 2.1  | Das Programm startet und ein cursor erscheint | ich gebe die Zahl 50 ein | Das Programm Endet ohne Fehlermeldungen |
| 3.1  | Ich starte das Programm | ich tue nichts | Das Programm sagt "Gebe eine Zahl ein" |
| 3.2  | Das Programm startet | ich gebe die Zahl 50 ein | Das Programm Sagt mir ob ich die Zahl erraten habe |
| 4.1  | Das Programm startet und ein cursor erscheint | ich gebe die Zahl 50 ein | Das Programm sagt entweder "zu hoch" oder "zu tief" |
| 5.1  | Das Programm startet und ein cursor erscheint | ich gebe die Zahl -20 ein | Das Programm sagt "bitte gebe eine zahl zwischen 1 und 100 ein" |
| 5.2  | Das Programm startet und ein cursor erscheint | ich gebe die Zahl 0 ein | Das Programm sagt "bitte gebe eine zahl zwischen 1 und 100 ein" |
| 5.3  | Das Programm startet und ein cursor erscheint | ich gebe die Zahl 621 ein | Das Programm sagt "bitte gebe eine zahl zwischen 1 und 100 ein" |

✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, die der Testfall abdeckt, und `m` von `1` an nach oben gezählt. Beispiel: Der dritte Testfall, der die zweite User Story abdeckt, hat also die Nummer `2.3`.

### 1.4 Diagramme

![Hauptprogramm 1](https://user-images.githubusercontent.com/111045975/189069514-ccf9ff8f-1b5c-40bb-83d3-557d08ae3f25.png)


## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  | 1.9.  | Noah      | Das Program soll eine Zufallszahl generieren | 45 Min.       |
| 2.B  | 1.9.  | Noah      | Das Programm soll den Spieler nach einer Zahl fragen             | 45 Min.       |
| 3.C  | 1.9.  | Noah      | Das Programm soll dem Spieler Anweisungen geben, was er machen muss             | 45 Min.       |
| 5.D  | 8.9.  | Noah      | Ich baue ein "try" und ein "catch" Element ein, welches den Spieler bei Falscheingaben warnt             | 45 Min.       |
| 4.E  | 8.9.  | Noah      | Ich erweitere das try-Element um einen Test, ob die Zahl zwischen 1 und 100 ist          | 45 Min.       |
| 6.F  | 15.9. | Noah      | Ich Implementiere eine Variable, die zählt, wie viele Versuche der Spieler benötigt hat, um die Zahl zu erraten     | 45 Min.       |
| 7.G  | 15.9. | Noah      |            | 45 Min.       |

Total: 




## 3 Entscheiden

Ich habe mich dazu entschieden, dass ich, nachdem ich alle "muss"-User Stories implementiert habe, noch weitere Elemente wie farbigen Text und die Angabe der Menge an Versuchen, die der Spieler gebraucht hat, implementieren werde.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  | 1.9.  | Noah      | 45 Min.       |                   |
| 2.B  | 1.9.  | Noah      | 45 Min.       |                   |
| 3.C  | 1.9.  | Noah      | 45 Min.       |                   |
| 5.D  | 1.9.  | Noah      | 45 Min.       |                   |
| 4.E  |       | Noah      | 45 Min.       |                   |



## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |       |          |        |
| ...  |       |          |        |

✍️ Vergessen Sie nicht, ein Fazit hinzuzufügen, welches das Test-Ergebnis einordnet.

### 5.2 Exploratives Testen

| BR-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | ------------ | ------- | ----------------- | -------------------- |
| I    |              |         |                   |                      |
| ...  |              |         |                   |                      |

✍️ Verwenden Sie römische Ziffern für Ihre Bug Reports, also I, II, III, IV etc.

## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein.

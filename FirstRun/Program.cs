﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace FirstRun
{
    class Program
    {
        static void Main(string[] args)
        {
            startbildschirm();
        }

        public static void startbildschirm()
        {
            Console.WriteLine();
            Console.WriteLine("Willkommen zu 'First Run'.");
            Console.WriteLine("Um das Spiel zu starten, drücke bitte eine beliebige Taste.");
            Console.ReadLine();
            ersteSzene();
        }

        public static void ersteSzene()
        {
            string wahlEins;

            Console.WriteLine("Tja Omae, das ist dann wohl mal ordentlich schief gelaufen.");
            Console.WriteLine("Wie immer gilt: Reinkommen ist leicht. Rauskommen ist die Kunst");
            Console.WriteLine("Ihr konntet zwar die Daten stehlen, die eure Auftraggeberin haben wollte,");
            Console.WriteLine("aber auf dem Weg raus haben die Sicherheitstypen euch erwischt.");
            Console.WriteLine("Der Rest deines Teams ist tot und du versteckst dich hier gerade in einer Putzkammer.");
            Console.WriteLine("Was willst du also tun?");
            Console.WriteLine("1. In den Lüftungsschacht klettern!");
            Console.WriteLine("2. Losrennen!");
            Console.WriteLine("3. Vorsichtig zur Tür heraus sehen.");
            Console.Write("Wähle eine Nummer:");
            wahlEins = Console.ReadLine();
            Console.Clear();

            switch (wahlEins)
            {
                case "1":
                    {
                        Console.WriteLine("Nach ungefähr zehn Metern stellst du fest, dass du leider nicht das Alien bist.");
                        Console.WriteLine("Du bleibst im Schacht stecken. Sicherheitsdronen finden und beseitigen dich.");
                        Console.WriteLine();
                        duHastVerloren();
                        break;
                    }

                case "2":
                    {
                        Console.WriteLine("Du stürmst los und rennst blindlings einen Gang entlang.");
                        Console.WriteLine("Plötzlich sind das Foyer und damit den Weg nach Draußen in Sichtweite.");
                        Console.WriteLine("Doch auf einmal schlägt links und rechts von dir automatisches Feuer in die Wände ein!");
                        Console.WriteLine("Das Sicherheitsteam ist dir auf den Fersen.");
                        Console.WriteLine("Reflexartig wirfst du dich durch eine Tür neben dir.");
                        Console.WriteLine();
                        zweiteSzene();
                        break;
                    }

                case "3":
                    {
                        Console.WriteLine("Du siehst wie ein Trupp Wachleute gerade vorbei läuft.");
                        Console.WriteLine("Einen kurzen Moment wartest du noch, nutzt dann deine Chance und schleichst los.");
                        Console.WriteLine("Plötzlich sind das Foyer und damit den Weg nach Draußen in Sichtweite.");
                        Console.WriteLine("Doch auf einmal schlägt links und rechts von dir automatisches Feuer in die Wände ein!");
                        Console.WriteLine("Das Sicherheitsteam ist dir wieder auf den Fersen.");
                        Console.WriteLine("Reflexartig wirfst du dich durch eine Tür neben dir.");
                        Console.WriteLine();
                        zweiteSzene();
                        break;
                    }


                default:
                    {
                        Console.WriteLine("Das geht so nicht!");
                        Console.Write("Bitte drücke eine beliebige Taste.");
                        Console.ReadLine();
                        ersteSzene();
                        break;
                    }
            }

            
        }

        public static void zweiteSzene()
        {
            string wahlZwei;
            Random rnd = new Random();
            int feuergefecht = rnd.Next(1,11);

            Console.WriteLine("Du brichst durch die Tür und findest dich in einem Büroraum wieder.");
            Console.WriteLine("Mit dem Sicherheitsteam direkt hinter dir, hechtest du erstmal hinter einem Tisch in Deckung.");
            Console.WriteLine("Wie willst du aus dieser Situation entkommen?");
            Console.WriteLine("1. Du nimmst dir einen Moment Zeit und siehst dich im Raum um.");
            Console.WriteLine("2. Du nutzt deine Postion und beginnst ein Feuergefecht.");
            Console.Write("Wähle eine Nummer:");
            wahlZwei = Console.ReadLine();
            Console.Clear();

            switch (wahlZwei)
            {
                case "1":
                    {
                        Console.WriteLine("Hektisch siehst du dich um während die schweren Schritte der Security näher kommen.");
                        Console.WriteLine("Dein Blick fällt auf eines der Terminals im Raum.");
                        Console.WriteLine("Es ist ein Sicherheitsterminal!");
                        Console.WriteLine("Sofort beginnst du es via AR zu hacken.");
                        Console.WriteLine();
                        dritteSzene();
                        break;
                    }

                case "2":
                    {
                        Console.WriteLine("Du macht deine Waffe bereit und nimmst die Wachleute unter Feuer als sie den Raum betreten.");
                        Console.Write("Zeit für einen Würfelwurf. Drücke 'Enter'.");
                        Console.ReadLine();
                        Console.WriteLine("Du würfelst eine "+ feuergefecht);
                        Console.WriteLine();
                        if (feuergefecht >= 7)
                        {
                            Console.WriteLine("Dank deiner Position, deinem Können und einer ziemlichen Menge Glück, legst du alle Angreifer um.");
                            Console.WriteLine("Der Weg zum Ausgang ist nun frei.");
                            Console.WriteLine();
                            duHastGewonnen();
                        }
                        else
                        {
                            Console.WriteLine("Du schlägst dich taper und legst sogar zwei von den Typen um.");
                            Console.WriteLine("Doch dann kommt jemand darauf, dass eine Granate eine tolle Idee in einem so kleinen Raum ist.");
                            Console.WriteLine();
                            duHastVerloren();
                        }
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Das geht so nicht!");
                        Console.Write("Bitte drücke eine beliebige Taste.");
                        Console.ReadLine();
                        zweiteSzene();
                        break;
                    }

            }
            
        }

        public static void dritteSzene()
        {
            Random rnd = new Random();
            int hacking = rnd.Next(1, 11);

            Console.WriteLine("Du kommst durch die ersten paar Schichten den Codes ohne Probleme.");
            Console.WriteLine("Doch plötzlich triffst du auf ICE.");
            Console.WriteLine("Schnell aktivierst deine Angriffsprogamme.");
            Console.Write("Zeit für einen Würfelwurf. Drücke 'Enter'.");
            Console.ReadLine();
            Console.WriteLine("Du würfelst eine " + hacking);
            Console.WriteLine();

            if (hacking >= 7)
            {
                Console.WriteLine("Yeah, das ICE zersplittert in virtualisierte  Bits und Bytes.");
                Console.WriteLine("Du hast Kontrolle über die Konsole");
                Console.WriteLine();
                vierteSzene();
            }
            else
            {
                Console.WriteLine("Diesem ICE bist du nicht gewachsen.");
                Console.WriteLine("Innerhalb von Nanosekunden überwindet es deine Verteidigung.");
                Console.WriteLine("Mit einer gezielten neuralen Attacke lobotomisiert dich das ICE.");
                Console.WriteLine();
                duHastVerloren();
            }
            Console.ReadLine();
            startbildschirm();

        }

        public static void vierteSzene()
        {
            string wahlDrei;

            Console.WriteLine("Die ersten Sicherheitsleute kommen hinter dir zur Tür herein und eröffnen vorbeugend schon mal das Feuer.");
            Console.WriteLine("Deine Deckung wird das nicht mehr lange mitmachen.");
            Console.WriteLine("Welches Kommando der Sicherheitskonsole willst du ausführen?");
            Console.WriteLine("1. Sicherheitsdrohne aktivieren");
            Console.WriteLine("2. Feuerlöschanlage aktivieren");
            Console.WriteLine("3. Den Zugang nutzen und die Gestohlenen Daten an deine Auftraggeberin schicken.");
            Console.Write("Wähle eine Nummer:");
            wahlDrei = Console.ReadLine();
            Console.Clear();

            switch (wahlDrei)
            {
                case "1":

                    Console.WriteLine("Summend löst sich die Sicherheitsdrohne aus der Decke.");
                    Console.WriteLine("Mit einem surrenden Geräusch beginne sich die Läufe ihrer aufmontierten Waffe zu drehen");
                    Console.WriteLine("und sie entfesselt auf dein Kommando einen Geschosshagel auf das vorstürmende Team.");
                    Console.WriteLine("Innerhalb weniger Sekunden gibt es niemanden mehr, der zwischen dir und dem Ausgang steht.");
                    Console.WriteLine();
                    duHastGewonnen();
                    break;

                case "2":

                    Console.WriteLine("Löschschaum sprüht aus seinen Ventilen an der Decke.");
                    Console.WriteLine("Dadurch wirkt es ein wenig, als ob ein Trupp fieser Schneemänner dich umkreist");
                    Console.WriteLine("um dich dann mit ihren Maschinenpistolen zu durchsieben.");
                    Console.WriteLine();
                    duHastVerloren();
                    break;

                case "3":

                    Console.WriteLine("Du siehst noch, wie eine automatisierte Empfangsbestätigung erfolgt.");
                    Console.WriteLine("Du hast deinen Auftrag erfolgreich abgeschlossen.");
                    Console.WriteLine("Leider wird deine erfoglreiche Karriere direkt von den Sicherheitsleuten brutal beendet.");
                    Console.WriteLine();
                    verstecktesEnde();
                    break;

                default:
                    {
                        Console.WriteLine("Das geht so nicht!");
                        Console.Write("Bitte drücke eine beliebige Taste.");
                        Console.ReadLine();
                        vierteSzene();
                        break;
                    }
            }
        }

        public static void duHastGewonnen()
        {
            string weiter;
            
            Console.WriteLine("Es ist unglaublich, aber wahr.");
            Console.WriteLine("Du hast dieses Debakel doch noch in einen Erfolg verwandelt.");
            Console.WriteLine("Also zumindest für dich.");
            Console.WriteLine("Danke, dass du 'First Run' gespielt hast.");
            Console.WriteLine("Möchtest du nochmal Spielen? J/N");
            Console.Write("J/N: ");
            weiter = Console.ReadLine().ToLower();
            if (weiter == "j")
            {
                startbildschirm();
            }
            
        }

        public static void duHastVerloren()
        {
            string weiter; 

            Console.WriteLine("Tröste dich Omae. So geht es vielen bei ihrem ersten Versuch.");
            Console.WriteLine("Mehr Glück beim nächsten Durchgang.");
            Console.WriteLine("Möchtest du nochmal Spielen? J/N");
            Console.Write("J/N: ");
            weiter = Console.ReadLine().ToLower();
            if (weiter == "j")
            {
                startbildschirm();
            }
            
        }

        public static void verstecktesEnde()
        {
            string weiter;

            Console.WriteLine("Herzlichen Glückwunsch. Du hast das geheime Ende von 'First Run' entdeckt.");
            Console.WriteLine("Erfolgreich aber totzdem tot. Das schafft man auch nicht alle Tage.");
            Console.WriteLine("Danke, dass du 'First Run' gespielt hast.");
            Console.WriteLine("Möchtest du nochmal Spielen? J/N");
            Console.Write("J/N: ");
            weiter = Console.ReadLine().ToLower();
            if (weiter == "j")
            {
                startbildschirm();
            }
            
        }

        
    }
}

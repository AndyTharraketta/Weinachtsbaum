namespace Weinachtsbaum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AufgabenStellung();
            SelbstVersuch();
            Korrektur();
            static void AufgabenStellung()
            {
                //Stufe1:
                //
                //Programmiere die Ausgabe eines Weinachtsbaum im ASCII Format.
                //Du kannst dir das Aussehen des Baums selber aussuchen
                //Nutze für die Ausgabe Schleifen.
                //
                //Beispiel:
                //       x
                //      xxx
                //     xxxxx
                //    xxxxxxx
                //	 xxxxxxxxx
                //	xxxxxxxxxxx
                //      xxx
                //      xxx

                //Stufe 2:
                //
                //Unter dem Baum soll ein zuffäliger weinachtsgruß ausgegeben werden. nutze dafür ein Array
                //Nutze ggf. Farben.

                //Stufe 3: 
                //
                //Alle paar Sekunden soll sich die Gruß nachricht verändern also aktualisiert werden

                //Stufe 4:
                //
                //Lass den Baum Blinken und Funkeln
                //Mach eine Recherche wie man spezifische stellen in der Konsole aktualisiert.
            }       // Aufgabenstellung
            static void SelbstVersuch()
            {
                

                //string[] weinachtsbaum = {@"          *",@"         /^\",@"        /* *\",@"       /* * *\",@"      /* * * *\",@"     /* * * * *\",@"    /* * * * * *\",@"   /* * * * * * *\",@"  /* * * * * * * *\",@" *******************",@"         |||" };
               
                //Console.ForegroundColor = ConsoleColor.Green;       // Farbe des Weichachtsbaums

                //for (int i = 0; i < weinachtsbaum.Length; i++)      // ASCII Darstellung des Weinachtsbaum
                //{
                //    Console.WriteLine(weinachtsbaum[i]);
                //    Thread.Sleep(150);
                //}
                //Console.WriteLine();        // Leerzeile

                //string[] gruß = {"Frohe Weihnachten und ein glückliches neues Jahr!             ",
                //                "Genieße die besinnliche Zeit im Kreise deiner Lieben!          ",
                //                "Möge dein Herz in dieser festlichen Zeit leuchten!             ",
                //                "Wünsche dir frohe Feiertage und viel Freude!                   ",
                //                "Besinnliche Weihnachten und einen guten Rutsch ins neue Jahr!  ",
                //                "Weihnachten ist Liebe – und du bist ein Teil davon!            ",
                //                "Frohes Fest! Mögen deine Wünsche in Erfüllung gehen!           ",
                //                "Die besten Geschenke sind die, die wir miteinander teilen.     ",
                //                "Wärme, Frieden und Freude – das wünsche ich dir zu Weihnachten!",
                //                "Frohe Weihnachten! Lass uns die Zeit genießen!                 "};
                //Random random = new Random();
                
                //for (int i = 0; i < 5; i++)        // Ausgabe der Weinachtsgrüße
                //{
                //    int randomIndex = random.Next(gruß.Length);
                //    string randomText = gruß[randomIndex];
                //    Console.ForegroundColor = ConsoleColor.Yellow;      // Farbe der Grußnachrichten
                //    Console.Write("\r{0}", randomText);     // \r zum Reseten des Grußes
                //    Thread.Sleep(1500);
                //    Console.ForegroundColor= ConsoleColor.White;
                //}


               
               
                
            }       // Eigener Lösungs Versuch
            static void Korrektur()
            {
                // Stufe 1
                string[] baum = { "       x", "      xxx", "     xxxxx", "    xxxxxxx", "   xxxxxxxxx", "  xxxxxxxxxxx", "      xxx", "      xxx" };

                foreach (string s in baum)
                {
                    Console.WriteLine(s);
                }

                // Stufe 2

                string[] gruss = { "Frohe Weinachten!", "Es Weinachtet! OMG!", "Stille Nacht! Heilige Nacht!" };

                Random rand = new Random();
                int auswahl = rand.Next(0, gruss.Length);

                Console.ForegroundColor = (ConsoleColor)rand.Next(1, 15);
                
                Console.WriteLine(gruss[auswahl]);

                // Stufe 3

                while (true)
                {
                    Thread.Sleep(1000);
                    Console.Clear();

                    Console.ResetColor();

                    foreach (string s in baum)
                    {
                        Console.WriteLine(s);
                    }
                    int letzteAuswahl = auswahl;
                    while (true)
                    {
                        auswahl = rand.Next(0, gruss.Length);
                        if (auswahl != letzteAuswahl)
                        {
                            break;
                        }
                    }
                    Console.ForegroundColor = (ConsoleColor)rand.Next(1, 15);
                    Console.WriteLine(gruss[auswahl]);

                    // Stufe 4

                    Console.SetCursorPosition(7, 1);
                    Console.ForegroundColor = (ConsoleColor)rand.Next(1, 15);
                    Console.WriteLine("o");

                    Console.SetCursorPosition(6, 2);
                    Console.ForegroundColor = (ConsoleColor)rand.Next(1, 15);
                    Console.WriteLine("o");

                    Console.SetCursorPosition(8, 2);
                    Console.ForegroundColor = (ConsoleColor)rand.Next(1, 15);
                    Console.WriteLine("o");

                    Console.SetCursorPosition(5, 3);
                    Console.ForegroundColor = (ConsoleColor)rand.Next(1, 15);
                    Console.WriteLine("o");

                    Console.SetCursorPosition(7, 3);
                    Console.ForegroundColor = (ConsoleColor)rand.Next(1, 15);
                    Console.WriteLine("o");

                    Console.SetCursorPosition(9, 3);
                    Console.ForegroundColor = (ConsoleColor)rand.Next(1, 15);
                    Console.WriteLine("o");

                    Console.SetCursorPosition(4, 4);
                    Console.ForegroundColor = (ConsoleColor)rand.Next(1, 15);
                    Console.WriteLine("o");

                    Console.SetCursorPosition(6, 4);
                    Console.ForegroundColor = (ConsoleColor)rand.Next(1, 15);
                    Console.WriteLine("o");

                    Console.SetCursorPosition(8, 4);
                    Console.ForegroundColor = (ConsoleColor)rand.Next(1, 15);
                    Console.WriteLine("o");

                    Console.SetCursorPosition(10, 4);
                    Console.ForegroundColor = (ConsoleColor)rand.Next(1, 15);
                    Console.WriteLine("o");

                    Console.SetCursorPosition(3, 5);
                    Console.ForegroundColor = (ConsoleColor)rand.Next(1, 15);
                    Console.WriteLine("o");

                    Console.SetCursorPosition(5, 5);
                    Console.ForegroundColor = (ConsoleColor)rand.Next(1, 15);
                    Console.WriteLine("o");

                    Console.SetCursorPosition(7, 5);
                    Console.ForegroundColor = (ConsoleColor)rand.Next(1, 15);
                    Console.WriteLine("o");

                    Console.SetCursorPosition(3, 5);
                    Console.ForegroundColor = (ConsoleColor)rand.Next(1, 15);
                    Console.WriteLine("o");

                    Console.SetCursorPosition(9, 5);
                    Console.ForegroundColor = (ConsoleColor)rand.Next(1, 15);
                    Console.WriteLine("o");

                    Console.SetCursorPosition(11, 5);
                    Console.ForegroundColor = (ConsoleColor)rand.Next(1, 15);
                    Console.WriteLine("o");

                }









            }       // Korrektur der Aufgabe
        }
    }       

}
    

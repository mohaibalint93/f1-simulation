using System.Text.RegularExpressions;

namespace F1
{
    internal class Program
    {
        static public Track[] tracks = 
                {
                    new Track(
                        "Melbourne Circuit",
                        "1:18.589",
                        "1:23.000",
                        58,
                        new Dictionary<string, int>
                        {
                            { "Soft", 20 },
                            { "Medium", 30 },
                            { "Hard", 40 }
                        },
                        22.5
                    ),
                    new Track(
                        "Bahrain International Circuit",
                        "1:31.624",
                        "1:35.000",
                        57,
                        new Dictionary<string, int>
                        {
                            { "Soft", 15 },
                            { "Medium", 25 },
                            { "Hard", 35 }
                        },
                        20.2
                    ),
                    new Track(
                        "Jeddah Street Circuit",
                        "1:28.215",
                        "1:32.000",
                        50,
                        new Dictionary<string, int>
                        {
                            { "Soft", 18 },
                            { "Medium", 28 },
                            { "Hard", 38 }
                        },
                        21.0
                    ),
                    new Track(
                        "Imola",
                        "1:14.909",
                        "1:19.000",
                        63,
                        new Dictionary<string, int>
                        {
                            { "Soft", 22 },
                            { "Medium", 32 },
                            { "Hard", 42 }
                        },
                        21.5
                    ),
                    new Track(
                        "Monaco Grand Prix",
                        "1:12.909",
                        "1:18.000",
                        78,
                        new Dictionary<string, int>
                        {
                            { "Soft", 18 },
                            { "Medium", 26 },
                            { "Hard", 36 }
                        },
                        20.8
                    ),
                    new Track(
                        "Silverstone Circuit",
                        "1:24.080",
                        "1:29.000",
                        52,
                        new Dictionary<string, int>
                        {
                            { "Soft", 20 },
                            { "Medium", 30 },
                            { "Hard", 40 }
                        },
                        19.0
                    ),
                    new Track(
                        "Hungaroring",
                        "1:14.458",
                        "1:18.000",
                        70,
                        new Dictionary<string, int>
                        {
                            { "Soft", 19 },
                            { "Medium", 29 },
                            { "Hard", 39 }
                        },
                        21.2
                    ),
                    new Track(
                        "Circuit de Spa-Francorchamps",
                        "1:46.286",
                        "1:51.000",
                        44,
                        new Dictionary<string, int>
                        {
                            { "Soft", 18 },
                            { "Medium", 28 },
                            { "Hard", 38 }
                        },
                        23.5
                    ),
                    new Track(
                        "Zandvoort",
                        "1:10.576",
                        "1:15.000",
                        72,
                        new Dictionary<string, int>
                        {
                            { "Soft", 21 },
                            { "Medium", 31 },
                            { "Hard", 41 }
                        },
                        21.0
                    ),
                    new Track(
                        "Monza",
                        "1:19.072",
                        "1:23.000",
                        53,
                        new Dictionary<string, int>
                        {
                            { "Soft", 17 },
                            { "Medium", 27 },
                            { "Hard", 37 }
                        },
                        18.5
                    ),
                    new Track(
                        "Singapore Grand Prix",
                        "1:36.015",
                        "1:42.000",
                        61,
                        new Dictionary<string, int>
                        {
                            { "Soft", 14 },
                            { "Medium", 24 },
                            { "Hard", 34 }
                        },
                        22.0
                    ),
                    new Track(
                        "Suzuka Circuit",
                        "1:30.805",
                        "1:35.000",
                        53,
                        new Dictionary<string, int>
                        {
                            { "Soft", 16 },
                            { "Medium", 26 },
                            { "Hard", 36 }
                        },
                        19.8
                    ),
                    new Track(
                        "Austin Circuit",
                        "1:34.029",
                        "1:39.000",
                        56,
                        new Dictionary<string, int>
                        {
                            { "Soft", 19 },
                            { "Medium", 29 },
                            { "Hard", 39 }
                        },
                        20.5
                    ),
                    new Track(
                        "Interlagos",
                        "1:10.540",
                        "1:15.000",
                        71,
                        new Dictionary<string, int>
                        {
                            { "Soft", 22 },
                            { "Medium", 32 },
                            { "Hard", 42 }
                        },
                        20.0
                    ),
                    new Track(
                        "Abu Dhabi Circuit",
                        "1:34.790",
                        "1:39.000",
                        58,
                        new Dictionary<string, int>
                        {
                            { "Soft", 16 },
                            { "Medium", 26 },
                            { "Hard", 36 }
                        },
                        19.0
                    )
                };
        static public List<Team> teams = new List<Team>()
        {

        };
        static void Main(string[] args)
        {
            bool a = true;
            while (a == true)
            {
                DriversTeams();
                a = Menu();
            }
        }

        static void DriversTeams()
        {
            Team mclaren = new Team("McLaren-Mercedes");
            Team ferrari = new Team("Ferrari");
            Team racingBulls = new Team("Racing Bulls-Honda RBPT");
            Team mercedes = new Team("Mercedes");
            Team astonMartin = new Team("Aston Martin Aramco-Mercedes");
            Team alpine = new Team("Alpine-Renault");
            Team haas = new Team("Haas-Ferrari");
            Team williams = new Team("Williams");
            Team vcarb = new Team("Visa Cash App Racing Bulls");
            Team sauber = new Team("Kick Sauber");

            teams.Add(mclaren);
            teams.Add(ferrari);
            teams.Add(racingBulls);
            teams.Add(mercedes);
            teams.Add(astonMartin);
            teams.Add(alpine);
            teams.Add(haas);
            teams.Add(williams);
            teams.Add(vcarb);
            teams.Add(sauber);

            mclaren.AddDriver(new Driver("Lando Norris",8,0));
            mclaren.AddDriver(new Driver("Oscar Piastri", 7, 0));

            ferrari.AddDriver(new Driver("Charles Leclerc", 9, 0));
            ferrari.AddDriver(new Driver("Lewis Hamilton", 9, 0));

            racingBulls.AddDriver(new Driver("Max Verstappen", 9, 0));
            racingBulls.AddDriver(new Driver("Liam Lawson", 5, 0));

            mercedes.AddDriver(new Driver("George Russell", 7, 0));
            mercedes.AddDriver(new Driver("Andrea Kimi Antonelli", 5, 0));

            astonMartin.AddDriver(new Driver("Fernando Alonso", 7, 0));
            astonMartin.AddDriver(new Driver("Lance Stroll", 2, 0));

            alpine.AddDriver(new Driver("Pierre Gasly", 5, 0));
            alpine.AddDriver(new Driver("Jack Doohan", 4, 0));

            haas.AddDriver(new Driver("Esteban Ocon", 5, 0));
            haas.AddDriver(new Driver("Oliver Bearman", 4, 0));

            williams.AddDriver(new Driver("Alexander Albon", 5, 0));
            williams.AddDriver(new Driver("Carlos Sainz Jr.", 6, 0));

            vcarb.AddDriver(new Driver("Yuki Tsunoda", 4, 0));
            vcarb.AddDriver(new Driver("Isack Hadjar", 3, 0));

            sauber.AddDriver(new Driver("Nico Hulkenberg", 5, 0));
            sauber.AddDriver(new Driver("Gabriel Bortoleto", 5, 0));


        }

        static Team SearchTeambyPoint(int point)
        {
            for (int j = 0; j < 10; j++)
            {
                if (teams[j].Drivers[0].Points + teams[j].Drivers[1].Points == point)
                {
                    return teams[j];
                }
                
            }
            return null;
        }

        static Driver SearchDriverbyPoint(int point)
        {
            for (int j = 0; j < 10; j++)
            {
                foreach (var item in teams[j].Drivers)
                {
                    if (item.Points == point)
                    {
                        return item;
                    }
                }
            }
            return null;
        }

        static Driver SearchDriverbyTime(int time)
        {
            for (int j = 0; j < 10; j++)
            {
                foreach (var item in teams[j].Drivers)
                {
                    if (item.CurrentTime == time)
                    {
                        return item;
                    }
                }
            }
            return null;
        }

        public static int[] CseresRendez(int[] bemenet)
        {
            int[] tomb = new int[bemenet.Length];
            Array.Copy(bemenet, tomb, bemenet.Length);
            for (int i = 0; i < tomb.Length; i++)
            {
                for (int j = 0; j < tomb.Length; j++)
                {
                    if (tomb[i] < tomb[j])
                    {
                        var tmp = tomb[i];
                        tomb[i] = tomb[j];
                        tomb[j] = tmp;
                    }
                }
            }
            return tomb;
        }

        public static int[] CseresRendez2(int[] bemenet)
        {
            int[] tomb = new int[bemenet.Length];
            Array.Copy(bemenet, tomb, bemenet.Length);
            for (int i = 0; i < tomb.Length; i++)
            {
                for (int j = 0; j < tomb.Length; j++)
                {
                    if (tomb[i] > tomb[j])
                    {
                        var tmp = tomb[i];
                        tomb[i] = tomb[j];
                        tomb[j] = tmp;
                    }
                }
            }
            return tomb;
        }

        static int TimeToSeconds(string time)
        {
            string[] time1 = time.Split(':');
            string[] time2 = time1[1].Split('.');

            int minutes = int.Parse(time1[0]);
            int seconds = int.Parse(time2[0]);
            int milliseconds = int.Parse(time2[1]);

            int totalSeconds = (minutes * 60 + seconds + milliseconds / 1000);
            return totalSeconds;
        }

        static string SecondsToTime(double totalTime)
        {
            int hours = (int)(totalTime / 3600);
            int minutes = (int)((totalTime % 3600) / 60);
            int seconds = (int)(totalTime % 60);
            int milliseconds = (int)((totalTime - (int)totalTime) * 1000);

            string formattedTime = string.Format("{0}:{1:D2}.{2:D3}", hours, minutes, seconds * 1000 + milliseconds);
            return formattedTime;
        }

        static void TeamsPrint()
        {
            Console.Clear();
            for (int j = 0; j < 10; j++)
            {
                
                switch (teams[j].TeamName)
                {
                    case "Ferrari":
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        break;
                    case "McLaren-Mercedes":
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        break;
                    case "Racing Bulls-Honda RBPT":
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        break;
                    case "Mercedes":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        break;
                    case "Aston Martin Aramco-Mercedes":
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        break;
                    case "Alpine-Renault":
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        break;
                    case "Haas-Ferrari":
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    case "Williams":
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                    case "Visa Cash App Racing Bulls":
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        break;
                    case "Kick Sauber":
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                }
                Console.WriteLine("---------------------------------");
                Console.WriteLine(teams[j].TeamName);
                Console.WriteLine();

                foreach (var item in teams[j].Drivers)
                {
                    Console.WriteLine(item.Name);
                    Console.WriteLine(" - Points: " + item.Points);
                }
                Console.WriteLine("---------------------------------");
                Console.ResetColor();
            }
        }

        static bool Menu()
        {
            Console.Clear();
            Console.WriteLine("0. Kilépés");
            Console.WriteLine("1. Szezon szimulálásának indítása");
            Console.WriteLine("2. Csapatok megtekintése");
            string valasz = Console.ReadLine();
            if (valasz == "2")
            {
                TeamsPrint();
                Console.WriteLine();
                Console.Write("<ENTER>");
                Console.ReadKey();
                return true;
            }
            if (valasz == "1")
            {
                Console.Clear();

                for (int j = 0; j < 10; j++)
                {
                    foreach (var item in teams[j].Drivers)
                    {
                        item.Points = 0;
                    }
                }

                for (int i = 0; i < tracks.Length; i++)
                {
                    //Console.WriteLine(TimeToSeconds(tracks[i].BestLapTime));
                    Console.WriteLine();
                    Console.WriteLine(i + 1 + ". forduló");
                    tracks[i].DisplayTrackInfo();
                    OneRound(i);
                    Console.WriteLine();
                    Console.Write("Következő forduló <ENTER>");
                    Console.ReadKey();
                    Console.Clear();
                }

                int[] driverStanding = new int[20];
                int[] constructorStanding = new int[10];
                int index = -1;

                for (int j = 0; j < 10; j++)
                {
                    foreach (var item in teams[j].Drivers)
                    {
                        index++;
                        driverStanding[index] = item.Points;
                    }
                }

                for (int j = 0; j < 10; j++)
                {
                    constructorStanding[j] = teams[j].Drivers[0].Points + teams[j].Drivers[1].Points;

                }
                Console.WriteLine();
                Console.WriteLine("****************************************");
                Console.WriteLine("Konstruktőri Világbajnokság végeredmény:");
                Console.WriteLine("****************************************");
                Console.WriteLine();
                index = 0;
                foreach (var item in CseresRendez2(constructorStanding))
                {
                    index++;
                    Team currentTeam = SearchTeambyPoint(item);

                    switch(currentTeam.TeamName)
                    {
                        case "Ferrari":
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            break;
                        case "McLaren-Mercedes":
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            break;
                        case "Racing Bulls-Honda RBPT":
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            break;
                        case "Mercedes":
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            break;
                        case "Aston Martin Aramco-Mercedes":
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            break;
                        case "Alpine-Renault":
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            break;
                        case "Haas-Ferrari":
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                        case "Williams":
                            Console.ForegroundColor = ConsoleColor.Blue;
                            break;
                        case "Visa Cash App Racing Bulls":
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            break;
                        case "Kick Sauber":
                            Console.ForegroundColor = ConsoleColor.Green;
                            break;
                    }
                    Console.WriteLine(index + ". " + currentTeam.TeamName + " (" + currentTeam.Drivers[0].Name + " Points: " + currentTeam.Drivers[0].Points + ", " + currentTeam.Drivers[1].Name + " Points: " + currentTeam.Drivers[1].Points + ") " + "Total Points: " + item);
                    Console.ResetColor();
                }

                Console.WriteLine();
                Console.WriteLine("*******************************************");
                Console.WriteLine("Egyéni Világbajnokság végeredmény (Top 10):");
                Console.WriteLine("*******************************************");
                Console.WriteLine();
                index = 0;
                foreach (int item in CseresRendez2(driverStanding))
                {
                    //Console.WriteLine(item);
                    if (index < 10)
                    {
                        index++;
                        Driver currentdriver = SearchDriverbyPoint(item);

                        Console.WriteLine(index + ". " + currentdriver.Name + " Total Points: " + currentdriver.Points);
                    }
                    
                }
                Console.ReadLine();
                return true;
            }
            return false;
        }

        static void OneRound(int roundnumber)
        {
            Random rnd = new Random();
            int weather = 0;
            
            for (int j = 0; j < 10; j++)
            {
                int rand = rnd.Next(0, 100);
                int kiallasszam;
                if (rand >= 70)
                {
                    kiallasszam = 2;
                }
                else
                {
                    kiallasszam = 1;
                }

                foreach (var item in teams[j].Drivers)
                {
                    item.CurrentTime = (int)(100 * tracks[roundnumber].PitStopTime * kiallasszam);
                }
            }

            weather = rnd.Next(0, 100);
            Console.WriteLine("Időjárás: ");
            if (weather >= 40)
            {
                Console.WriteLine(" - Tiszta");
            }
            else if (weather >= 20)
            {
                Console.WriteLine(" - Enyhén esős");
            }
            else
            {
                Console.WriteLine(" - Zuhogó eső");
            }
            
            for (int i = 0; i < tracks[roundnumber].Laps; i++)
            {

                for (int j = 0; j < 10; j++)
                {                    
                    foreach (var item in teams[j].Drivers)
                    {
                        item.CurrentTime += rnd.Next(TimeToSeconds(tracks[roundnumber].BestLapTime)*1000, TimeToSeconds(tracks[roundnumber].WorstLapTime)*1000-item.DriverLevel*100);
                        if (weather >= 40)
                        {
                            item.CurrentTime += 2000;
                        }
                        else if (weather >=20)
                        {
                            item.CurrentTime += 3000;
                        }
                        else
                        {
                            item.CurrentTime += 5000;
                        }
                    }
                }
            }

            int[] finalTimes = new int[20];
            int count = -1;

            for (int j = 0; j < 10; j++)
            {
                //Console.WriteLine();
                //Console.WriteLine(teams[j].TeamName);
                //Console.WriteLine();

                foreach (var item in teams[j].Drivers)
                {
                    count++;
                    //Console.Write(item.Name + ": ");
                    //Console.WriteLine(item.CurrentTime / 1000.000);
                    finalTimes[count] = item.CurrentTime;
                }
            }

            count = 0;
            Console.WriteLine();
            foreach (int item in CseresRendez(finalTimes))
            {
                count++;
                Driver currentdriver = SearchDriverbyTime(item);

                switch (count)
                {
                    case 1:
                        currentdriver.Points += 25;
                        break;
                    case 2:
                        currentdriver.Points += 18;
                        break;
                    case 3:
                        currentdriver.Points += 15;
                        break;
                    case 4:
                        currentdriver.Points += 12;
                        break;
                    case 5:
                        currentdriver.Points += 10;
                        break;
                    case 6:
                        currentdriver.Points += 8;
                        break;
                    case 7:
                        currentdriver.Points += 6;
                        break;
                    case 8:
                        currentdriver.Points += 4;
                        break;
                    case 9:
                        currentdriver.Points += 2;
                        break;
                    case 10:
                        currentdriver.Points += 1;
                        break;
                }


                Console.WriteLine(count + ". " + currentdriver.Name + ": " + SecondsToTime(currentdriver.CurrentTime/1000.000) + " Total Points: " + currentdriver.Points);
                }
        }
    }
}

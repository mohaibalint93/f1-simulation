namespace F1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DriversTeams();
            Tracks();
            
        }
        static void DriversTeams()
        {
            Team mclaren = new Team("McLaren-Mercedes");
            mclaren.AddDriver(new Driver("Lando Norris",));
            mclaren.AddDriver(new Driver("Oscar Piastri"));

            Team ferrari = new Team("Ferrari");
            ferrari.AddDriver(new Driver("Charles Leclerc"));
            ferrari.AddDriver(new Driver("Lewis Hamilton"));

            Team racingBulls = new Team("Racing Bulls-Honda RBPT");
            racingBulls.AddDriver(new Driver("Max Verstappen"));
            racingBulls.AddDriver(new Driver("Liam Lawson"));

            Team mercedes = new Team("Mercedes");
            mercedes.AddDriver(new Driver("George Russell"));
            mercedes.AddDriver(new Driver("Andrea Kimi Antonelli"));

            Team astonMartin = new Team("Aston Martin Aramco-Mercedes");
            astonMartin.AddDriver(new Driver("Fernando Alonso"));
            astonMartin.AddDriver(new Driver("Lance Stroll"));

            Team alpine = new Team("Alpine-Renault");
            alpine.AddDriver(new Driver("Pierre Gasly"));
            alpine.AddDriver(new Driver("Jack Doohan"));

            Team haas = new Team("Haas-Ferrari");
            haas.AddDriver(new Driver("Esteban Ocon"));
            haas.AddDriver(new Driver("Oliver Bearman"));

            Team williams = new Team("Williams");
            williams.AddDriver(new Driver("Alexander Albon"));
            williams.AddDriver(new Driver("Carlos Sainz Jr."));
        }

        static void Tracks()
        {
            List<Track> tracks = new List<Track>()
                {
                    new Track(
                        "Melbourne Circuit",
                        TimeSpan.Parse("1:18.589"),
                        TimeSpan.Parse("1:23.000"),
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
                        TimeSpan.Parse("1:31.624"),
                        TimeSpan.Parse("1:35.000"),
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
                        TimeSpan.Parse("1:28.215"),
                        TimeSpan.Parse("1:32.000"),
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
                        TimeSpan.Parse("1:14.909"),
                        TimeSpan.Parse("1:19.000"),
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
                        TimeSpan.Parse("1:12.909"),
                        TimeSpan.Parse("1:18.000"),
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
                        TimeSpan.Parse("1:24.080"),
                        TimeSpan.Parse("1:29.000"),
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
                        TimeSpan.Parse("1:14.458"),
                        TimeSpan.Parse("1:18.000"),
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
                        TimeSpan.Parse("1:46.286"),
                        TimeSpan.Parse("1:51.000"),
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
                        TimeSpan.Parse("1:10.576"),
                        TimeSpan.Parse("1:15.000"),
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
                        TimeSpan.Parse("1:19.072"),
                        TimeSpan.Parse("1:23.000"),
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
                        TimeSpan.Parse("1:36.015"),
                        TimeSpan.Parse("1:42.000"),
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
                        TimeSpan.Parse("1:30.805"),
                        TimeSpan.Parse("1:35.000"),
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
                        TimeSpan.Parse("1:34.029"),
                        TimeSpan.Parse("1:39.000"),
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
                        TimeSpan.Parse("1:10.540"),
                        TimeSpan.Parse("1:15.000"),
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
                        TimeSpan.Parse("1:34.790"),
                        TimeSpan.Parse("1:39.000"),
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
        }
    }
}

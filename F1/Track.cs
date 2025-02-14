using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1
{
    internal class Track
    {
        public string Name { get; set; }
        public TimeSpan BestLapTime { get; set; }
        public TimeSpan WorstLapTime { get; set; }
        public Dictionary<string, int> TireWear { get; set; }  // Gumikeverékek átlagos kopása (körök számában)
        public int Laps { get; set; }  // Pálya hossza (körök száma)
        public double PitStopTime { get; set; }  // Kerékcsere átlagos időtartama (másodpercekben)

        public Track(string name, TimeSpan bestLapTime, TimeSpan worstLapTime, int laps, Dictionary<string, int> tireWear, double pitStopTime)
        {
            Name = name;
            BestLapTime = bestLapTime;
            WorstLapTime = worstLapTime;
            Laps = laps;
            TireWear = tireWear;
            PitStopTime = pitStopTime;
        }

        // Pálya információinak kiíratása
        public void DisplayTrackInfo()
        {
            Console.WriteLine($"Pálya: {Name}");
            Console.WriteLine($"Legjobb köridő (2024): {BestLapTime}");
            Console.WriteLine($"Legrosszabb köridő (2024): {WorstLapTime}");
            Console.WriteLine($"Verseny hossza: {Laps} kör");

            Console.WriteLine("Gumikeverékek kopása (átlagos körszám):");
            foreach (var tire in TireWear)
            {
                Console.WriteLine($"- {tire.Key}: {tire.Value} kör");
            }

            Console.WriteLine($"Kerékcsere átlagos időtartama: {PitStopTime} másodperc");
            Console.WriteLine();
        }
    }
}

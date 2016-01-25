using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PrOb3Music
{
    class Program
    {
        static void Main(string[] args)
        {
            MusicPlayer player = new MusicPlayer();
            bool exit = true;
            while(exit == true)
            {
                Console.WriteLine("Dostepne gatunki: \n");
                Console.WriteLine("1) Blues");
                Console.WriteLine("2) Disco");
                Console.WriteLine("3) Doo Wop");
                Console.WriteLine("4) Funk");
                Console.WriteLine("5) Hard Rock");
                Console.WriteLine("6) R&B");
                Console.WriteLine("7) Rock & Roll");
                Console.WriteLine("8) Zakoncz program");

                int choice;
                while (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Podaj cyfre od 1 do 8!");
                }

                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Podaj tytul utworu bluesowego: ");
                        string bluesTitle = Console.ReadLine();
                        Console.WriteLine("Podaj wykonawce: ");
                        string bluesArtist = Console.ReadLine();
                        Song bluesTrack = new Blues(bluesTitle, bluesArtist);
                        player.Add(bluesTrack);
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("Podaj tytul utworu disco: ");
                        string discoTitle = Console.ReadLine();
                        Console.WriteLine("Podaj wykonawce: ");
                        string discoArtist = Console.ReadLine();
                        Song discoTrack = new Disco(discoTitle, discoArtist);
                        player.Add(discoTrack);
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("Podaj tytul utworu doo wop: ");
                        string dooWopTitle = Console.ReadLine();
                        Console.WriteLine("Podaj wykonawce: ");
                        string dooWopArtist = Console.ReadLine();
                        Song dooWopTrack = new DooWop(dooWopTitle, dooWopArtist);
                        player.Add(dooWopTrack);
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("Podaj tytul utworu funk: ");
                        string funkTitle = Console.ReadLine();
                        Console.WriteLine("Podaj wykonawce: ");
                        string funkArtist = Console.ReadLine();
                        Song funkTrack = new Funk(funkTitle, funkArtist);
                        player.Add(funkTrack);
                        break;

                    case 5:
                        Console.Clear();
                        Console.WriteLine("Podaj tytul utworu hard rock: ");
                        string hardRockTitle = Console.ReadLine();
                        Console.WriteLine("Podaj wykonawce: ");
                        string hardRockArtist = Console.ReadLine();
                        Song hardRockTrack = new HardRock(hardRockTitle, hardRockArtist);
                        player.Add(hardRockTrack);
                        break;

                    case 6:
                        Console.Clear();
                        Console.WriteLine("Podaj tytul utworu r&b: ");
                        string rAndBTitle = Console.ReadLine();
                        Console.WriteLine("Podaj wykonawce: ");
                        string rAndBArtist = Console.ReadLine();
                        Song rAndBTrack = new RandB(rAndBTitle, rAndBArtist);
                        player.Add(rAndBTrack);
                        break;

                    case 7:
                        Console.Clear();
                        Console.WriteLine("Podaj tytul utworu rock & roll: ");
                        string rockAndRollTitle = Console.ReadLine();
                        Console.WriteLine("Podaj wykonawce: ");
                        string rockAndRollArtist = Console.ReadLine();
                        Song rockAndRollTrack = new RockAndRoll(rockAndRollTitle, rockAndRollArtist);
                        player.Add(rockAndRollTrack);
                        break;

                    case 8:
                        Console.Clear();
                        exit = false;
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Wybierz cyfre od 1 do 8!");
                        break;
                }

                if (exit == true)
                {
                    Console.WriteLine("Chcesz dodac utwor? {Y/N}");
                    string addQuestion = Console.ReadLine();
                   
                    switch (addQuestion)
                    {
                        case "Y":
                            break;
                        case "y":
                            break;
                        case "N":
                            exit = false;
                            break;
                        case "n":
                            exit = false;
                            break;
                    }
                }

                Console.Clear();

            }

            int j = 0;
            foreach (Song song in player.playlist)
            {
                
                player.Play(j);
                j++;
                Thread.Sleep(3000);
                Console.Clear();

            }

            Console.WriteLine("Koniec");
            Console.ReadKey();
        }
    }
}

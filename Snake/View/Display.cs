using System;
using System.Collections.Generic;

namespace Snake.View
{
    public class Display
    {
        public void VisualiseFied(int rows, int cols, List<string> snakeCoo, List<string> foodCoo, List<string> obsCoo)
        {
            const string borderSymbol = "| ";
            
            for (int c = 0; c < cols + 2; c++)
            {
                Console.Write(borderSymbol);
            }
            Console.WriteLine();

            string currCoo;
            
            for (int r = 0; r < rows; r++)
            {
                Console.Write(borderSymbol);
                for (int c = 0; c < cols; c++)
                {
                    currCoo = r + " " + c;
                    
                    if(snakeCoo[0] == currCoo)
                        Console.Write("0 ");
                    else if(snakeCoo.Contains(currCoo))
                        Console.Write("O ");
                    else if(foodCoo.Contains(currCoo))
                        Console.Write("+ ");
                    else if (obsCoo.Contains(currCoo))
                        Console.Write("X ");
                    else
                        Console.Write("  ");
                }
                Console.Write(borderSymbol);
                Console.WriteLine();
            }
            
            for (int c = 0; c < cols+2; c++)
            {
                Console.Write(borderSymbol);
            }
        }

        public void VisualiseManual()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("USE W/A/S/D + ENTER TO MOVE");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                         MANUAL                         ");
            Console.WriteLine("________________________________________________________");
            Console.WriteLine("Eat all the food marked with '+'.");
            Console.WriteLine("It is not possible to walk through walls," +
                              "\n\r marked with '|', or obstacles, marked with 'X'.");
            Console.WriteLine("When all the food is eaten, the next level will start.");
            Console.WriteLine("If you get stuck, you can press 'r' to restart from lvl.1.");
            Console.WriteLine("You are the snake, marked with '0OOO");
            Console.WriteLine("                                   O");
            Console.WriteLine("                                 OOO");
            Console.WriteLine("                                 O  ");
            Console.WriteLine("                                 OOO");
            Console.WriteLine("                                   O'");
            
            
        }

        public void VisualiseVictoryScrean()
        {
            Console.WriteLine("                                  _         _       _   _                 ");
            Console.WriteLine("                                 | |       | |     | | (_)                ");
            Console.WriteLine("   ___ ___  _ __   __ _ _ __ __ _| |_ _   _| | __ _| |_ _  ___  _ __  ___ ");
            Console.WriteLine("  / __/ _ \\| '_ \\ / _` | '__/ _` | __| | | | |/ _` | __| |/ _ \\| '_ \\/ __|");
            Console.WriteLine(" | (_| (_) | | | | (_| | | | (_| | |_| |_| | | (_| | |_| | (_) | | | \\__ \\");
            Console.WriteLine("  \\___\\___/|_| |_|\\__, |_|  \\__,_|\\__|\\__,_|_|\\__,_|\\__|_|\\___/|_| |_|___/");
            Console.WriteLine("                   __/ |                                                  ");
            Console.WriteLine("                  |___/                                                   ");
            Console.WriteLine("                   _               _           _                               _      _           _  ");
            Console.WriteLine("                  ( )             (_)         | |                             | |    | |         | | ");
            Console.WriteLine(" _   _  ___  _   _|/__   _____     _ _   _ ___| |_    ___ ___  _ __ ___  _ __ | | ___| |_ ___  __| | ");
            Console.WriteLine("| | | |/ _ \\| | | | \\ \\ / / _ \\   | | | | / __| __|  / __/ _ \\| '_ ` _ \\| '_ \\| |/ _ \\ __/ _ \\/ _` |");
            Console.WriteLine("| |_| | (_) | |_| |  \\ V /  __/   | | |_| \\__ \\ |_  | (_| (_) | | | | | | |_) | |  __/ ||  __/ (_| |");
            Console.WriteLine(" \\__, |\\___/ \\__,_|   \\_/ \\___|   | |\\__,_|___/\\__|  \\___\\___/|_| |_| |_| .__/|_|\\___|\\__\\___|\\__,_|");
            Console.WriteLine("  __/ |                          _/ |                                   | |                     ");
            Console.WriteLine(" |___/                          |__/                                    |_|                       ");
            Console.WriteLine(" _   _                                                             _        _           ");
            Console.WriteLine("| | | |                                                           | |      | |          ");
            Console.WriteLine("| |_| |__   ___    __ _  __ _ _ __ ___   ___   _ __ ___   __ _  __| | ___  | |__  _   _ ");
            Console.WriteLine("| __| '_ \\ / _ \\  / _` |/ _` | '_ ` _ \\ / _ \\ | '_ ` _ \\ / _` |/ _` |/ _ \\ | '_ \\| | | |");
            Console.WriteLine("| |_| | | |  __/ | (_| | (_| | | | | | |  __/ | | | | | | (_| | (_| |  __/ | |_) | |_| |");
            Console.WriteLine(" \\__|_| |_|\\___|  \\__, |\\__,_|_| |_| |_|\\___| |_| |_| |_|\\__,_|\\__,_|\\___| |_.__/ \\__, |");
            Console.WriteLine("                   __/ |                                                           __/ |");
            Console.WriteLine("                  |___/                                                           |___/ ");
            Console.WriteLine("______                          ______ ");
            Console.WriteLine("| ___ \\                         |  _  \\");
            Console.WriteLine("| |_/ / ___  _   _  __ _ _ __   | | | |");
            Console.WriteLine("| ___ \\/ _ \\| | | |/ _` | '_ \\  | | | |");
            Console.WriteLine("| |_/ / (_) | |_| | (_| | | | | | |/ / ");
            Console.WriteLine("\\____/ \\___/ \\__, |\\__,_|_| |_| |___(_)");
            Console.WriteLine("              __/ |                    ");
            Console.WriteLine("             |___/                     ");
            Console.WriteLine();
            Console.WriteLine("          _____ _   _  _____   _____ _   _   ___   _   __ _____  ______ _   _  ______    _      _____ ");
            Console.WriteLine("         |_   _| | | ||  ___| /  ___| \\ | | / _ \\ | | / /|  ___| | ___ \\ | | ||___  /   | |    |  ___|");
            Console.WriteLine(" ______    | | | |_| || |__   \\ `--.|  \\| |/ /_\\ \\| |/ / | |__   | |_/ / | | |   / / ___| |    | |__  ");
            Console.WriteLine("|______|   | | |  _  ||  __|   `--. \\ . ` ||  _  ||    \\ |  __|  |  __/| | | |  / / |_  / |    |  __| ");
            Console.WriteLine("           | | | | | || |___  /\\__/ / |\\  || | | || |\\  \\| |___  | |   | |_| |./ /___/ /| |____| |___ ");
            Console.WriteLine("           \\_/ \\_| |_/\\____/  \\____/\\_| \\_/\\_| |_/\\_| \\_/\\____/  \\_|    \\___/ \\_____/___\\_____/\\____/ ");

        }
    }
}
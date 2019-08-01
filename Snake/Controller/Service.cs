using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using Snake.View;

namespace Snake.Controller
{
    public class Service
    {
        private Display _display;
        private Snake s;
        private Field f;
        private Food fd;
        private Obstacles o;
        
        public void StartDemo()
        {
            f = new Field(5,5);
            s = new Snake(new List<string>(){"0 0","0 1","0 2"});
            fd = new Food(new List<string>(){"0 4","4 0","4 4"});
            o = new Obstacles(new List<string>());
            Console.Clear();
            _display = new Display();
            Console.WriteLine("--- DEMO LEVEL ---");
            Console.WriteLine();
            _display.VisualiseFied(f.Rows,f.Cols, s.Coordinates, fd.Coordinates, o.Coordinates);
            
            while (fd.Coordinates.Count != 0)
            {
                _display.VisualiseManual();
                ConsoleKeyInfo inputString = Console.ReadKey();
                char input = inputString.KeyChar;
                MoveSnake(input);
                Console.Clear();
                Console.WriteLine("--- DEMO LEVEL ---");
                Console.WriteLine();
                _display.VisualiseFied(f.Rows,f.Cols,s.Coordinates,fd.Coordinates, o.Coordinates);
            }
            StartLevel1();
        }

        public void StartLevel1()
        {
            f = new Field(5,5);
            s = new Snake(new List<string>(){"2 0","1 0","0 0"});
            fd = new Food(new List<string>()
                {
                    "3 0","4 0",
                    "0 1","2 1","3 1","4 1",
                    "0 2","2 2","4 2",
                    "0 3","2 3","4 3",
                    "0 4","2 4","3 4","4 4"
                }
            );
            o = new Obstacles(new List<string>(){"3 2","3 3","1 1","1 2","1 3"});
            Console.Clear();
            _display = new Display();
            Console.WriteLine("--- 1st LEVEL ---");
            Console.WriteLine();
            _display.VisualiseFied(f.Rows,f.Cols, s.Coordinates, fd.Coordinates,o.Coordinates);
            
            while (fd.Coordinates.Count != 0)
            {
                _display.VisualiseManual();
                ConsoleKeyInfo inputString = Console.ReadKey();
                char input = inputString.KeyChar;
                if(input == 'r')
                    StartLevel1();
                if(input == 'l')
                    StartLevel1();
                MoveSnake(input);
                Console.Clear();
                Console.WriteLine("--- 1st LEVEL ---");
                Console.WriteLine();
                _display.VisualiseFied(f.Rows,f.Cols,s.Coordinates,fd.Coordinates,o.Coordinates);
            }
            StartLevel2();
        }
        
        public void StartLevel2()
        {
            f = new Field(2,11);
            s = new Snake(new List<string>(){"0 1","1 1","1 0"});
            fd = new Food(new List<string>()
                {
                   "0 0","0 2","0 3","0 4","0 5","0 6","0 7","0 8","0 10",
                   "1 3","1 4","1 5","1 6","1 7","1 8"
                }
            );
            o = new Obstacles(new List<string>()
                {
                    "0 9"
                }
            );
            Console.Clear();
            _display = new Display();
            Console.WriteLine("--- 2nd LEVEL ---");
            Console.WriteLine();
            _display.VisualiseFied(f.Rows,f.Cols, s.Coordinates, fd.Coordinates,o.Coordinates);
            
            while (fd.Coordinates.Count != 0)
            {
                _display.VisualiseManual();
                ConsoleKeyInfo inputString = Console.ReadKey();
                char input = inputString.KeyChar;
                if(input == 'r')
                    StartLevel1();
                if(input == 'l')
                    StartLevel2();
                MoveSnake(input);
                Console.Clear();
                Console.WriteLine("--- 2nd LEVEL ---");
                Console.WriteLine();
                _display.VisualiseFied(f.Rows,f.Cols,s.Coordinates,fd.Coordinates,o.Coordinates);
            }
            StartLevel3();
        }

        public void StartLevel3()
        {
            f = new Field(7, 7);
            s = new Snake(new List<string>() {"2 0","1 0","0 0"});
            fd = new Food(new List<string>()
                {
                    "0 2", "0 3", "0 4", "0 5", "0 6",
                    "1 4", "1 6",
                    "2 1", "2 4", "2 6",
                    "3 1", "3 4", "3 6",
                    "4 0", "4 1", "4 2", "4 3", "4 4", "4 6",
                    "5 0", "5 6",
                    "6 0", "6 1", "6 2", "6 3", "6 4", "6 5", "6 6" 
                }
            );
            o = new Obstacles(new List<string>()
                {
                    "0 1",
                    "1 1", "1 2", "1 3", "1 5",
                    "2 5",
                    "3 5",
                    "4 5",
                    "5 1", "5 2", "5 3", "5 4", "5 5",

                }
            );
            Console.Clear();
            _display = new Display();
            Console.WriteLine("--- 3rd LEVEL ---");
            Console.WriteLine();
            _display.VisualiseFied(f.Rows, f.Cols, s.Coordinates, fd.Coordinates, o.Coordinates);

            while (fd.Coordinates.Count != 0)
            {
                _display.VisualiseManual();
                ConsoleKeyInfo inputString = Console.ReadKey();
                char input = inputString.KeyChar;
                if (input == 'r')
                    StartLevel1();
                if(input == 'l')
                    StartLevel3();
                MoveSnake(input);
                Console.Clear();
                Console.WriteLine("--- 3rd LEVEL ---");
                Console.WriteLine();
                _display.VisualiseFied(f.Rows, f.Cols, s.Coordinates, fd.Coordinates, o.Coordinates);
            }

            StartLevel4();
        }
        public void StartLevel4()
        {
            f = new Field(7, 7);
            s = new Snake(new List<string>() {"1 0","1 1","0 1","0 0"});
            fd = new Food(new List<string>()
                {
                    "0 5",
                    "2 0", "2 2", "2 3",
                    "3 0",
                    "4 0", "4 6",
                    "5 0", "5 2",
                    "6 0", "6 1", "6 2", "6 6"
                }
            );
            o = new Obstacles(new List<string>()
                {
                    "0 6",
                    "1 2", "1 3", "1 5", "1 6",
                    "2 1", "2 5", "2 6",
                    "3 1", "3 5", "3 6",
                    "4 1",
                    "5 1", "5 3", "5 5",
                    "6 3"
                }
            );
            Console.Clear();
            _display = new Display();
            Console.WriteLine("--- 4th LEVEL ---");
            Console.WriteLine();
            _display.VisualiseFied(f.Rows, f.Cols, s.Coordinates, fd.Coordinates, o.Coordinates);

            while (fd.Coordinates.Count != 0)
            {
                _display.VisualiseManual();
                ConsoleKeyInfo inputString = Console.ReadKey();
                char input = inputString.KeyChar;
                if (input == 'r')
                    StartLevel1();
                if(input == 'l')
                    StartLevel4();
                MoveSnake(input);
                Console.Clear();
                Console.WriteLine("--- 4th LEVEL ---");
                Console.WriteLine();
                _display.VisualiseFied(f.Rows, f.Cols, s.Coordinates, fd.Coordinates, o.Coordinates);
            }
            StartLevel5();

        }
        
        public void StartLevel5()
        {
            f = new Field(7, 3);
            s = new Snake(new List<string>() {"1 0","0 0","0 1"});
            fd = new Food(new List<string>()
                {
                    "0 2",
                    "1 2",
                    "2 0", "2 1", "2 2",
                    "3 0", "3 2",
                    "4 0", "4 1", "4 2",
                    "5 0", "5 2",
                    "6 0", "6 2"
                }
            );
            o = new Obstacles(new List<string>()
                {
                    
                    "1 1",
                    "3 1",
                    "5 1"
                }
            );
            Console.Clear();
            _display = new Display();
            Console.WriteLine("--- 5th LEVEL ---");
            Console.WriteLine();
            _display.VisualiseFied(f.Rows, f.Cols, s.Coordinates, fd.Coordinates, o.Coordinates);

            while (fd.Coordinates.Count != 0)
            {
                _display.VisualiseManual();
                ConsoleKeyInfo inputString = Console.ReadKey();
                char input = inputString.KeyChar;
                if (input == 'r')
                    StartLevel1();
                if(input == 'l')
                    StartLevel5();
                MoveSnake(input);
                Console.Clear();
                Console.WriteLine("--- 5th LEVEL ---");
                Console.WriteLine();
                _display.VisualiseFied(f.Rows, f.Cols, s.Coordinates, fd.Coordinates, o.Coordinates);
            }
            Console.Clear();
            _display.VisualiseVictoryScrean();
            Environment.Exit(0);
        }
        public void MoveSnake(char input)
        {
            string last = s.Coordinates.Last();
            string first = s.Coordinates[0];
            int row = first.Split().Select(int.Parse).ToList()[0];
            int col = first.Split().Select(int.Parse).ToList()[1];

            switch (input)
            {
                case 'w':
                    s.Coordinates.Remove(last);
                    row -= 1;
                    break;
                case 's':
                    s.Coordinates.Remove(last);
                    row += 1;
                    break;
                case 'a':
                    s.Coordinates.Remove(last);
                    col -= 1;
                    break;
                case 'd':
                    s.Coordinates.Remove(last);
                    col += 1;
                    break;
            }

            string newCoordinate = row + " " + col;

            if (!s.Coordinates.Contains(newCoordinate) && row < f.Rows && col < f.Cols && row >= 0 && col >= 0 && !o.Coordinates.Contains(newCoordinate)) 
            {
                    s.Coordinates.Insert(0, newCoordinate);
            }
            else
            {
                s.Coordinates.Add(last);
            }

            if (fd.Coordinates.Contains(newCoordinate))
            {
                fd.Coordinates.Remove(newCoordinate);
                s.Coordinates.Add(last);
            }
            
        }
        
    }
}
using System.Collections.Generic;

namespace Snake
{
    public class Snake
    {
        private List<string> coordinates;

        public Snake(List<string> snakeList)
        {
            coordinates = snakeList;

        }

        public List<string> Coordinates
        {
            get => coordinates;
            set => coordinates = value;
        }
        
        
    }
}
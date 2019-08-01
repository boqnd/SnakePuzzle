using System.Collections.Generic;

namespace Snake
{
    public class Obstacles
    {
        private List<string> coordinates;

        public List<string> Coordinates
        {
            get => coordinates;
            set => coordinates = value;
        }
        
        public Obstacles(List<string> obstacleList)
        {
            Coordinates = obstacleList;
        }
    }
}
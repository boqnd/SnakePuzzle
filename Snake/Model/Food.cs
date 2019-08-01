using System.Collections.Generic;

namespace Snake
{
    public class Food
    {
        private List<string> coordinates;

        public List<string> Coordinates
        {
            get => coordinates;
            set => coordinates = value;
        }
        
        public Food(List<string> foodList)
        {
            Coordinates = foodList;
        }
    }
}
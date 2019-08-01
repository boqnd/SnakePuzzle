using System;

namespace Snake
{
    public class Field
    {
        public int Rows
        {
            get => rows;
            set => rows = value;
        }

        public int Cols
        {
            get => cols;
            set => cols = value;
        }

        public char[,] Field1
        {
            get => field;
            set => field = value;
        }

        private int rows;
        private int cols;
        private char[,] field;
        
        public Field(int rows, int cols)
        {
            this.rows = rows;
            this.cols = cols;
            field = new char[rows,cols];
        }        
    }
}
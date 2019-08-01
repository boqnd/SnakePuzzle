using System;
using Snake.Controller;
using Snake.View;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Service s = new Service();
            s.StartDemo();
        }
    }
}
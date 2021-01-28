using System;
using Raylib_cs;
using System.Collections.Generic;
namespace Snek
{
    public class Snake: GameObject
    {
        public static List<Snake> Snakes = new List<Snake>();
        //isSnake true


        public static void DrawAllSnakes(){
            foreach (Snake p in Snakes)
            {
                p.DrawSnakes();
            }
        }
        public void DrawSnakes(){
            Raylib.DrawRectangleRec(Rect, Color.GREEN);
        }
    }
}

using System;
using Raylib_cs;
using System.Collections.Generic;
namespace Snek
{
    public class Apple: GameObject
    {
        //isApple true
        public Random random = new Random();
        public static List<Apple> Apples = new List<Apple>();

        public static void DrawApple(){
            
        }
        public void DrawSnakes(){
            Raylib.DrawRectangleRec(Rect, Color.GREEN);
        }
    }
}

using System;
using Raylib_cs;
using System.Collections.Generic;
namespace Snek
{
    public class GameObject
    {
        //rectangle
        public Rectangle Rect = new Rectangle();
        //collision


        //addtolist
        public GameObject(){
            gameObjects.Add(this);
        }
        
    }
}

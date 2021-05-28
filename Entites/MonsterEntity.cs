//using System;
//using System.Collections.Generic;
//using System.Drawing;
//using System.Text;
//using MadeInHaven.Entites;
//using MadeInHaven.Controllers;
//using MadeInHaven.Models;

//namespace MadeInHaven.Entites
//{
//    public class MonsterEntity
//    {
//        public class Entity
//        {
//            public int posX;
//            public int posY;

//            public int monsterdirX;
//            public int monsterdirY;
//            public bool monsterisMoving;

//            public int flip;

//            public int currentAnimation;
//            public int currentFrame;
//            public int currentLimit;

//            public int walkFrames;

//            public int size;

//            public Image spriteSheet;
//            private int MonsterDir;

//            public Entity(int posX, int posY, int walkFrames, Image spriteSheet)
//            {
//                this.posX = posX;
//                this.posY = posY;
//                this.walkFrames = walkFrames;
//                this.spriteSheet = spriteSheet;
//                size = 32;
//                currentAnimation = 0;
//                flip = 1;
//            }
//            public void Move()
//            {
//                posX += monsterdirX;
//                posY += monsterdirY;
//            }

//            public void PlayAnimation(Graphics g)
//            {
//                g.DrawImage(spriteSheet, new Rectangle(new Point(posX - flip * size / 2, posY), new Size(flip * size, size)), 32f * currentFrame, 32f * currentAnimation, size, size, GraphicsUnit.Pixel);
//            }

//            public int Walk(int x,int y, int dirX, int dirY)
//            {
//                if (dirX < monsterdirX && CanWalkTo(x - 1, y))
//                    monsterdirX += -1;
//                else if (monsterdirX > dirX &&
//                         CanWalkTo(x + 1, y))
//                    monsterdirX += 1;
//                else if (monsterdirY > dirY && CanWalkTo(x, y - 1))
//                    monsterdirY += -1;
//                else if (monsterdirY < dirY &&
//                         CanWalkTo(x, y + 1))
//                    monsterdirY += 1;
//                return MonsterDir = Mapcontroller.map[monsterdirX, monsterdirY];
//            }

//            private bool CanWalkTo(int x, int y)
//            {
//                if (x < 30 
//                    || x >= Mapcontroller.cellSize * (Mapcontroller.mapWidth - 1) 
//                    || y < 0 
//                    || y >= Mapcontroller.cellSize * (Mapcontroller.mapHeight - 2)) return false;
//                return true;
//            }
//        }
//    }
//}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using MadeInHaven.Controllers;

namespace MadeInHaven.Entites
{
    public class Entity
    {
        public int posX;
        public int posY;

        public int dirX;
        public int dirY;
        public bool isMoving;

        public int flip;

        public int currentAnimation;
        public int currentFrame;
        public int currentLimit;

        public int idleFrames;
        public int walkFrames;
        public int diedFrames;
        public int hurtFrames;
        public int attackFrames;

        public int size;

        public Image spriteSheet;

        public Entity(int posX, int posY, int idleFrames, int diedFrames, int hurtFrames,int walkFrames, int attackFrames, Image spriteSheet)
        {
            this.posX = posX;
            this.posY = posY;
            this.idleFrames = idleFrames;
            this.walkFrames = walkFrames;
            this.diedFrames = diedFrames;
            this.hurtFrames = hurtFrames;
            this.spriteSheet = spriteSheet;
            this.attackFrames = attackFrames;
            size = 32;
            currentAnimation = 0;
            currentFrame = 0;
            currentLimit = idleFrames;
            flip = 1;
        }
        public void Move()
        {
                posX += dirX;
                posY += dirY;
        }
        
        public void PlayAnimation(Graphics g)
        {
            if (currentFrame < currentLimit - 1)
                currentFrame++;
            else currentFrame = 0;

            g.DrawImage(spriteSheet, new Rectangle(new Point(posX - flip*size/2, posY), new Size(flip*size, size)), 32f*currentFrame, 32f*currentAnimation, size, size, GraphicsUnit.Pixel);
        }

        public void SetAnimation(int currentAnimation)
        {
            this.currentAnimation = currentAnimation;
            switch (currentAnimation)
            {
                case 0:
                    currentLimit = idleFrames;
                    break;
                case 1:
                    currentLimit = walkFrames;
                    break;
                case 2:
                    currentLimit = attackFrames;
                    break;
                case 3:
                    currentLimit = hurtFrames;
                    break;
                case 4:
                    currentLimit = diedFrames;
                    break;
            }
        }
    }
}

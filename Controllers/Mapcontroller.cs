﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;

namespace MadeInHaven.Controllers
{
    public static class Mapcontroller
    {
        public const int mapHeidth = 20;
        public const int mapWidth = 20;
        public static int cellSize = 28;
        public static int[,] map = new int[mapHeidth, mapWidth];
        public static Image spriteSheet;

        public static void Init()
        {
            map = GetMap();
            spriteSheet = new Bitmap(Path.Combine(new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName.ToString(), "Sprites\\MainSprites\\Dungeon.png"));
        }
        public static int[,] GetMap() //Левый верхний угол 1, Вертикальная стена 2, Левый нижний угол 3, Пол 0, Правый верхний угол 5, Правый нижний угол 6, Горизонтальная стена 7
        {
            return new int[,]
            {
                { 1,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,5 },
                { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                { 3,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,6 },
            };
        }
     
        public static void DrawMap(Graphics g)
        {
            for(int i=0; i<mapHeidth; i++)
            {
                for (int j=0; j< mapWidth; j++)
                {
                    if (map[i,j] == 1) //Левый верхний угол 1
                    {
                        g.DrawImage(spriteSheet, new Rectangle(new Point(i*cellSize,j*cellSize), new Size(cellSize,cellSize)), 48, 48, 47, 40, GraphicsUnit.Pixel);
                    }
                    if (map[i, j] == 2) //Вертикальная стена 2
                    {
                        g.DrawImage(spriteSheet, new Rectangle(new Point(i * cellSize, j * cellSize), new Size(cellSize, cellSize)), 94, 48, 47, 40, GraphicsUnit.Pixel);
                    }
                    if (map[i, j] == 3)//Левый нижний угол 3
                    {
                        g.DrawImage(spriteSheet, new Rectangle(new Point(i * cellSize, j * cellSize), new Size(cellSize, cellSize)), 625, 48, 47, 40, GraphicsUnit.Pixel);
                    }
                    if (map[i, j] == 0)//Пол 0 
                    {
                        g.DrawImage(spriteSheet, new Rectangle(new Point(i * cellSize, j * cellSize), new Size(cellSize, cellSize)), 242, 102, 47, 40, GraphicsUnit.Pixel);
                    }
                    if (map[i, j] == 5)//Правый верхний угол 5
                    {
                        g.DrawImage(spriteSheet, new Rectangle(new Point(i * cellSize, j * cellSize), new Size(cellSize, cellSize)), 48, 433, 47, 40, GraphicsUnit.Pixel);
                    }
                    if (map[i, j] == 6)//Правый нижний угол 6 
                    {
                        g.DrawImage(spriteSheet, new Rectangle(new Point(i * cellSize, j * cellSize), new Size(cellSize, cellSize)), 433, 433, 47, 40, GraphicsUnit.Pixel);
                    }
                    if (map[i, j] == 7)//Горизонтальная стена 7
                    {
                        g.DrawImage(spriteSheet, new Rectangle(new Point(i * cellSize, j * cellSize), new Size(cellSize, cellSize)), 48, 86, 47, 40, GraphicsUnit.Pixel);
                    }
                }
            }
        }
        public static int GetWidth()
        {
            return cellSize * mapWidth;
        }
        public static int GetHeidth()
        {
            return cellSize * mapHeidth;
        }
    }

    
}
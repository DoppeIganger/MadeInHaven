using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MadeInHaven.Controllers;
using MadeInHaven.Entites;
using MadeInHaven.Sprites;

namespace MadeInHaven
{
    public partial class Form1 : Form
    {
        public Image gladiator;
        public Image playerImage;
        public Entity player;
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 20;
            timer1.Tick += new EventHandler(Update);

            KeyDown += new KeyEventHandler(OnPress);
            KeyUp += new KeyEventHandler(OnKeyUp);

            Init();
        }

        public void OnKeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    player.dirY = 0;
                    break;
                case Keys.S:
                    player.dirY = 0;
                    break;
                case Keys.A:
                    player.dirX = 0;
                    break;
                case Keys.D:
                    player.dirX = 0;
                    break;
            }

            if (player.dirX == 0 && player.dirY == 0)
            {
                player.isMoving = false;
                player.SetAnimation(0);
            }
        }
        public void OnPress(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.W:
                    player.dirY = -3;
                    player.isMoving = true;
                    player.SetAnimation(1);
                    break;
                case Keys.S:
                    player.dirY = 3;
                    player.isMoving = true;
                    player.SetAnimation(1);
                    break;
                case Keys.A:
                    player.dirX = -3;
                    player.isMoving = true;
                    player.flip = -1;
                    player.SetAnimation(1);
                    break;
                case Keys.D:
                    player.dirX = 3;
                    player.isMoving = true;
                    player.flip = 1;
                    player.SetAnimation(1);
                    break;
                case Keys.K:
                    player.dirX = 0;
                    player.dirY = 0;
                    player.isMoving = false;
                    player.SetAnimation(2);
                    break;
            }
        }

        private void Init()/*C:\\Users\\Дмитрий\\source\\repos\\MadeInHaven\\MadeInHaven\\Sprites\\MainSprites\\Gladiator.png*/
         {
            Mapcontroller.Init();
            this.Width = Mapcontroller.GetWidth();
            this.Height = Mapcontroller.GetHeidth();
            gladiator = new Bitmap(Path.Combine(new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName.ToString(), "Sprites\\MainSprites\\Gladiator.png"));

            player = new Entity(300, 400, Hero.idleFrames, Hero.diedFrames,Hero.hurtFrames, Hero.walkFrames, Hero.attackFrames, gladiator);
            timer1.Start();
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Mapcontroller.DrawMap(g);
            player.PlayAnimation(g);
            
        }

        public void Update(object sender, EventArgs e)
        {
            PhysicsCont.IsCollide(player);
            if (player.isMoving)
                player.Move();
            Invalidate();
        }

    }
}

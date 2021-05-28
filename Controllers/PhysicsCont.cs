using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using MadeInHaven.Entites;

namespace MadeInHaven.Controllers
{
    public static class PhysicsCont
    {
        public static bool IsCollide(Entity entity, PointF dir)
        {
            if (entity.posX + dir.X <= 30 || entity.posX + dir.X >= Mapcontroller.cellSize * (Mapcontroller.mapWidth - 1) || entity.posY + dir.Y <= 0 || entity.posY + dir.Y >= Mapcontroller.cellSize * (Mapcontroller.mapHeight - 2))
                return true;
            return false;
        }
    }
}
        

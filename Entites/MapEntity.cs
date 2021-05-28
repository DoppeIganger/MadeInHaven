using System.Drawing;

namespace MadeInHaven.Entites
{
    public class MapEntity
    {
        public PointF position;
        public Size size;

        public MapEntity(PointF pos,Size size)
        {
            this.position = pos;
            this.size = size;
        }
    }
}

using System.Drawing;
using System.Windows.Forms;

namespace Reticle {
    public class Crosshair {
        public Crosshair() {
            Length = 17;
            Thickness = 2;
            Gap = 8;
            Color = Color.Green;
            OffsetX = 0;
            OffsetY = 0;
            Dot = false;
        }
        
        public bool Dot { get; set; }
        public int OffsetX { get; set; }
        public int OffsetY { get; set; }
        public Color Color { get; set; }
        public int Length { get; set; }
        public int Thickness { get; set; }
        public int Gap { get; set; }
    }
}
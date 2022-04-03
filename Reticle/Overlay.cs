using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Reticle {
    public partial class Overlay : Form {
        [DllImport("user32.dll")]
        private static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);
        [DllImport("user32.dll", SetLastError = true)]
        private static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        private Point _center;
        public Crosshair Crosshair = new Crosshair(); 

        public Overlay() {
            InitializeComponent();
        }
        
        
        private void Overlay_Load(object sender, EventArgs e) {
            // Set the window to the size of the screen and center
            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            
            // Set the window to be transparent
            this.BackColor = Color.Orchid;
            this.TransparencyKey = Color.Orchid;
            
            // Set the window style to be click through
            int windowLong = GetWindowLong(this.Handle, -20);
            SetWindowLong(this.Handle, -20, windowLong | 0x80000 | 0x20);
            
            // Get center coordinates
            _center = new Point(this.Width / 2, this.Height / 2);
        }
        
        protected override void OnPaint(PaintEventArgs e) {
            using (Graphics g = e.Graphics)
            using (Pen pen = new Pen(Crosshair.Color, Crosshair.Thickness)) {
                g.DrawLine(pen, 
                    Crosshair.OffsetX + _center.X - Crosshair.Length - Crosshair.Gap, 
                    Crosshair.OffsetY + _center.Y, 
                    Crosshair.OffsetX + _center.X - Crosshair.Gap, 
                    Crosshair.OffsetY + _center.Y);
                g.DrawLine(pen, 
                    Crosshair.OffsetX + _center.X + Crosshair.Length + Crosshair.Gap, 
                    Crosshair.OffsetY + _center.Y, 
                    Crosshair.OffsetX + _center.X + Crosshair.Gap, 
                    Crosshair.OffsetY + _center.Y);
                g.DrawLine(pen, 
                    Crosshair.OffsetX + _center.X, 
                    Crosshair.OffsetY + _center.Y + Crosshair.Length + Crosshair.Gap, 
                    Crosshair.OffsetX + _center.X, 
                    Crosshair.OffsetY + _center.Y + Crosshair.Gap);
                g.DrawLine(pen,
                    Crosshair.OffsetX + _center.X, 
                    Crosshair.OffsetY + _center.Y - Crosshair.Length - Crosshair.Gap, 
                    Crosshair.OffsetX + _center.X, 
                    Crosshair.OffsetY + _center.Y - Crosshair.Gap);
                // Paint center pixel
                if (Crosshair.Dot) {
                    using (Brush brush = new SolidBrush(Crosshair.Color)) {
                        g.FillRectangle(brush,
                            Crosshair.OffsetX + _center.X - (Crosshair.Thickness / 2),
                            Crosshair.OffsetY + _center.Y - (Crosshair.Thickness / 2),
                            Crosshair.Thickness,
                            Crosshair.Thickness);

                    }
                }
            }
        }
    }
}
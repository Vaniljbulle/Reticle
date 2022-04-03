using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reticle {
    public partial class Form1 : Form {
        private readonly Overlay _overlay = new Overlay();

        public Form1() {
            InitializeComponent();
            
            numLength.ValueChanged += Update;
            numThickness.ValueChanged += Update;
            numGap.ValueChanged += Update;
            cbDot.CheckedChanged += Update;
            numOffsetX.ValueChanged += Update;
            numOffsetY.ValueChanged += Update;
        }
        
        private void Update(object sender, EventArgs e) {
            _overlay.Invalidate();
        }

        private void btnColor_Click(object sender, EventArgs e) {
            // Color dialog
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() != DialogResult.OK) return;
            _overlay.Crosshair.Color = dialog.Color;
            _overlay.Invalidate();
        }

        // Convert decimal to integer
        private static int DecimalToInt(decimal d) {
            return (int)Math.Round(d);
        }
        // Show or hide overlay
        private bool _show = true;
        private void btnEnable_Click(object sender, EventArgs e) {
            if (_show) {
                _overlay.Show();
                btnEnable.Text = "DISABLE";
                _show = false;
            } else {
                _overlay.Hide();
                btnEnable.Text = "ENABLE";
                _show = true;
            }
        }

        #region Control events

        private void LengthChanged(object sender, EventArgs e) {
            _overlay.Crosshair.Length = DecimalToInt(numLength.Value);
        }

        private void GapChanged(object sender, EventArgs e) {
            _overlay.Crosshair.Gap = DecimalToInt(numGap.Value);
        }

        private void ThicknessChanged(object sender, EventArgs e) {
            _overlay.Crosshair.Thickness = DecimalToInt(numThickness.Value);
        }

        private void DotChanged(object sender, EventArgs e) {
            _overlay.Crosshair.Dot = cbDot.Checked;
        }

        private void OffsetXChanged(object sender, EventArgs e) {
            _overlay.Crosshair.OffsetX = DecimalToInt(numOffsetX.Value);
        }

        private void OffsetYChanged(object sender, EventArgs e) {
            _overlay.Crosshair.OffsetY = DecimalToInt(numOffsetY.Value);
        }

        #endregion

    }
}
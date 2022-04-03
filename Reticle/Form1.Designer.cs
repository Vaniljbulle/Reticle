namespace Reticle {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnColor = new System.Windows.Forms.Button();
            this.btnEnable = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numLength = new System.Windows.Forms.NumericUpDown();
            this.numGap = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numThickness = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.cbDot = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numOffsetX = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numOffsetY = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.numLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.numGap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.numThickness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.numOffsetX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.numOffsetY)).BeginInit();
            this.SuspendLayout();
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(12, 12);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(90, 30);
            this.btnColor.TabIndex = 0;
            this.btnColor.Text = "SET COLOR";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnEnable
            // 
            this.btnEnable.Location = new System.Drawing.Point(108, 12);
            this.btnEnable.Name = "btnEnable";
            this.btnEnable.Size = new System.Drawing.Size(90, 30);
            this.btnEnable.TabIndex = 1;
            this.btnEnable.Text = "ENABLE";
            this.btnEnable.UseVisualStyleBackColor = true;
            this.btnEnable.Click += new System.EventHandler(this.btnEnable_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Length";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numLength
            // 
            this.numLength.Location = new System.Drawing.Point(108, 56);
            this.numLength.Name = "numLength";
            this.numLength.Size = new System.Drawing.Size(90, 20);
            this.numLength.TabIndex = 3;
            this.numLength.Value = new decimal(new int[] {20, 0, 0, 0});
            this.numLength.ValueChanged += new System.EventHandler(this.LengthChanged);
            // 
            // numGap
            // 
            this.numGap.Location = new System.Drawing.Point(108, 82);
            this.numGap.Name = "numGap";
            this.numGap.Size = new System.Drawing.Size(90, 20);
            this.numGap.TabIndex = 5;
            this.numGap.Value = new decimal(new int[] {5, 0, 0, 0});
            this.numGap.ValueChanged += new System.EventHandler(this.GapChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Gap";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numThickness
            // 
            this.numThickness.Location = new System.Drawing.Point(108, 108);
            this.numThickness.Name = "numThickness";
            this.numThickness.Size = new System.Drawing.Size(90, 20);
            this.numThickness.TabIndex = 7;
            this.numThickness.Value = new decimal(new int[] {2, 0, 0, 0});
            this.numThickness.ValueChanged += new System.EventHandler(this.ThicknessChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Thickness";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbDot
            // 
            this.cbDot.Location = new System.Drawing.Point(108, 134);
            this.cbDot.Name = "cbDot";
            this.cbDot.Size = new System.Drawing.Size(89, 24);
            this.cbDot.TabIndex = 8;
            this.cbDot.UseVisualStyleBackColor = true;
            this.cbDot.CheckedChanged += new System.EventHandler(this.DotChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Dot";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numOffsetX
            // 
            this.numOffsetX.Location = new System.Drawing.Point(108, 164);
            this.numOffsetX.Minimum = new decimal(new int[] {100, 0, 0, -2147483648});
            this.numOffsetX.Name = "numOffsetX";
            this.numOffsetX.Size = new System.Drawing.Size(90, 20);
            this.numOffsetX.TabIndex = 11;
            this.numOffsetX.ValueChanged += new System.EventHandler(this.OffsetXChanged);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Offset X";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numOffsetY
            // 
            this.numOffsetY.Location = new System.Drawing.Point(108, 192);
            this.numOffsetY.Minimum = new decimal(new int[] {100, 0, 0, -2147483648});
            this.numOffsetY.Name = "numOffsetY";
            this.numOffsetY.Size = new System.Drawing.Size(90, 20);
            this.numOffsetY.TabIndex = 13;
            this.numOffsetY.ValueChanged += new System.EventHandler(this.OffsetYChanged);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(12, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Offset Y";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(213, 225);
            this.Controls.Add(this.numOffsetY);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numOffsetX);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbDot);
            this.Controls.Add(this.numThickness);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numGap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numLength);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEnable);
            this.Controls.Add(this.btnColor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Reticle";
            ((System.ComponentModel.ISupportInitialize) (this.numLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.numGap)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.numThickness)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.numOffsetX)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.numOffsetY)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numLength;
        private System.Windows.Forms.NumericUpDown numGap;
        private System.Windows.Forms.NumericUpDown numThickness;
        private System.Windows.Forms.NumericUpDown numOffsetX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numOffsetY;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cbDot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnEnable;

        #endregion
    }
}
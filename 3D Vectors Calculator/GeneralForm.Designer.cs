using System;

namespace VectorsCalculator
{
    partial class GeneralForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbMoon3X = new System.Windows.Forms.TextBox();
            this.tbMoon3Y = new System.Windows.Forms.TextBox();
            this.tbMoon3Z = new System.Windows.Forms.TextBox();
            this.tbPlanet3X = new System.Windows.Forms.TextBox();
            this.tbPlanet3Y = new System.Windows.Forms.TextBox();
            this.tbPlanet3Z = new System.Windows.Forms.TextBox();
            this.tbPlanet1X = new System.Windows.Forms.TextBox();
            this.tbPlanet1Y = new System.Windows.Forms.TextBox();
            this.tbPlanet1Z = new System.Windows.Forms.TextBox();
            this.tbPlanet2X = new System.Windows.Forms.TextBox();
            this.tbPlanet2Y = new System.Windows.Forms.TextBox();
            this.tbPlanet2Z = new System.Windows.Forms.TextBox();
            this.tbMoon2X = new System.Windows.Forms.TextBox();
            this.tbMoon2Y = new System.Windows.Forms.TextBox();
            this.tbMoon2Z = new System.Windows.Forms.TextBox();
            this.tbMoon1X = new System.Windows.Forms.TextBox();
            this.tbMoon1Y = new System.Windows.Forms.TextBox();
            this.tbMoon1Z = new System.Windows.Forms.TextBox();
            this.lblCenterToPlanet3 = new System.Windows.Forms.Label();
            this.lblCenterToPlanet1 = new System.Windows.Forms.Label();
            this.lblCenterToPlanet2 = new System.Windows.Forms.Label();
            this.lblPlanet2ToPlanet3 = new System.Windows.Forms.Label();
            this.lblPlanet1ToPlanet3 = new System.Windows.Forms.Label();
            this.lblPlanet1ToPlanet2 = new System.Windows.Forms.Label();
            this.lblPlanet1ToMoon1 = new System.Windows.Forms.Label();
            this.lblPlanet2ToMoon2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblPlanet3ToMoon3 = new System.Windows.Forms.Label();
            this.lblCenter = new System.Windows.Forms.Label();
            this.btnLoadLastSavedSettings = new System.Windows.Forms.Button();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbMoon3X
            // 
            this.tbMoon3X.Location = new System.Drawing.Point(352, 72);
            this.tbMoon3X.Name = "tbMoon3X";
            this.tbMoon3X.Size = new System.Drawing.Size(63, 20);
            this.tbMoon3X.TabIndex = 0;
            this.tbMoon3X.Text = "0,0";
            this.tbMoon3X.Click += new System.EventHandler(this.tb_Click);
            this.tbMoon3X.TextChanged += new System.EventHandler(this.UpdateLabels);
            // 
            // tbMoon3Y
            // 
            this.tbMoon3Y.Location = new System.Drawing.Point(352, 89);
            this.tbMoon3Y.Name = "tbMoon3Y";
            this.tbMoon3Y.Size = new System.Drawing.Size(63, 20);
            this.tbMoon3Y.TabIndex = 0;
            this.tbMoon3Y.Text = "0,0";
            this.tbMoon3Y.Click += new System.EventHandler(this.tb_Click);
            this.tbMoon3Y.TextChanged += new System.EventHandler(this.UpdateLabels);
            // 
            // tbMoon3Z
            // 
            this.tbMoon3Z.Location = new System.Drawing.Point(352, 108);
            this.tbMoon3Z.Name = "tbMoon3Z";
            this.tbMoon3Z.Size = new System.Drawing.Size(63, 20);
            this.tbMoon3Z.TabIndex = 0;
            this.tbMoon3Z.Text = "0,0";
            this.tbMoon3Z.Click += new System.EventHandler(this.tb_Click);
            this.tbMoon3Z.TextChanged += new System.EventHandler(this.UpdateLabels);
            // 
            // tbPlanet3X
            // 
            this.tbPlanet3X.Location = new System.Drawing.Point(518, 89);
            this.tbPlanet3X.Name = "tbPlanet3X";
            this.tbPlanet3X.Size = new System.Drawing.Size(63, 20);
            this.tbPlanet3X.TabIndex = 0;
            this.tbPlanet3X.Text = "0,0";
            this.tbPlanet3X.Click += new System.EventHandler(this.tb_Click);
            this.tbPlanet3X.TextChanged += new System.EventHandler(this.UpdateLabels);
            // 
            // tbPlanet3Y
            // 
            this.tbPlanet3Y.Location = new System.Drawing.Point(518, 106);
            this.tbPlanet3Y.Name = "tbPlanet3Y";
            this.tbPlanet3Y.Size = new System.Drawing.Size(63, 20);
            this.tbPlanet3Y.TabIndex = 0;
            this.tbPlanet3Y.Text = "0,0";
            this.tbPlanet3Y.Click += new System.EventHandler(this.tb_Click);
            this.tbPlanet3Y.TextChanged += new System.EventHandler(this.UpdateLabels);
            // 
            // tbPlanet3Z
            // 
            this.tbPlanet3Z.Location = new System.Drawing.Point(518, 125);
            this.tbPlanet3Z.Name = "tbPlanet3Z";
            this.tbPlanet3Z.Size = new System.Drawing.Size(63, 20);
            this.tbPlanet3Z.TabIndex = 0;
            this.tbPlanet3Z.Text = "0,0";
            this.tbPlanet3Z.Click += new System.EventHandler(this.tb_Click);
            this.tbPlanet3Z.TextChanged += new System.EventHandler(this.UpdateLabels);
            // 
            // tbPlanet1X
            // 
            this.tbPlanet1X.Location = new System.Drawing.Point(668, 414);
            this.tbPlanet1X.Name = "tbPlanet1X";
            this.tbPlanet1X.Size = new System.Drawing.Size(63, 20);
            this.tbPlanet1X.TabIndex = 0;
            this.tbPlanet1X.Text = "0,0";
            this.tbPlanet1X.Click += new System.EventHandler(this.tb_Click);
            this.tbPlanet1X.TextChanged += new System.EventHandler(this.UpdateLabels);
            // 
            // tbPlanet1Y
            // 
            this.tbPlanet1Y.Location = new System.Drawing.Point(668, 431);
            this.tbPlanet1Y.Name = "tbPlanet1Y";
            this.tbPlanet1Y.Size = new System.Drawing.Size(63, 20);
            this.tbPlanet1Y.TabIndex = 0;
            this.tbPlanet1Y.Text = "0,0";
            this.tbPlanet1Y.Click += new System.EventHandler(this.tb_Click);
            this.tbPlanet1Y.TextChanged += new System.EventHandler(this.UpdateLabels);
            // 
            // tbPlanet1Z
            // 
            this.tbPlanet1Z.Location = new System.Drawing.Point(668, 450);
            this.tbPlanet1Z.Name = "tbPlanet1Z";
            this.tbPlanet1Z.Size = new System.Drawing.Size(63, 20);
            this.tbPlanet1Z.TabIndex = 0;
            this.tbPlanet1Z.Text = "0,0";
            this.tbPlanet1Z.Click += new System.EventHandler(this.tb_Click);
            this.tbPlanet1Z.TextChanged += new System.EventHandler(this.UpdateLabels);
            // 
            // tbPlanet2X
            // 
            this.tbPlanet2X.Location = new System.Drawing.Point(98, 306);
            this.tbPlanet2X.Name = "tbPlanet2X";
            this.tbPlanet2X.Size = new System.Drawing.Size(63, 20);
            this.tbPlanet2X.TabIndex = 0;
            this.tbPlanet2X.Text = "0,0";
            this.tbPlanet2X.Click += new System.EventHandler(this.tb_Click);
            this.tbPlanet2X.TextChanged += new System.EventHandler(this.UpdateLabels);
            // 
            // tbPlanet2Y
            // 
            this.tbPlanet2Y.Location = new System.Drawing.Point(98, 323);
            this.tbPlanet2Y.Name = "tbPlanet2Y";
            this.tbPlanet2Y.Size = new System.Drawing.Size(63, 20);
            this.tbPlanet2Y.TabIndex = 0;
            this.tbPlanet2Y.Text = "0,0";
            this.tbPlanet2Y.Click += new System.EventHandler(this.tb_Click);
            this.tbPlanet2Y.TextChanged += new System.EventHandler(this.UpdateLabels);
            // 
            // tbPlanet2Z
            // 
            this.tbPlanet2Z.Location = new System.Drawing.Point(98, 342);
            this.tbPlanet2Z.Name = "tbPlanet2Z";
            this.tbPlanet2Z.Size = new System.Drawing.Size(63, 20);
            this.tbPlanet2Z.TabIndex = 0;
            this.tbPlanet2Z.Text = "0,0";
            this.tbPlanet2Z.Click += new System.EventHandler(this.tb_Click);
            this.tbPlanet2Z.TextChanged += new System.EventHandler(this.UpdateLabels);
            // 
            // tbMoon2X
            // 
            this.tbMoon2X.Location = new System.Drawing.Point(161, 487);
            this.tbMoon2X.Name = "tbMoon2X";
            this.tbMoon2X.Size = new System.Drawing.Size(63, 20);
            this.tbMoon2X.TabIndex = 0;
            this.tbMoon2X.Text = "0,0";
            this.tbMoon2X.Click += new System.EventHandler(this.tb_Click);
            this.tbMoon2X.TextChanged += new System.EventHandler(this.UpdateLabels);
            // 
            // tbMoon2Y
            // 
            this.tbMoon2Y.Location = new System.Drawing.Point(161, 504);
            this.tbMoon2Y.Name = "tbMoon2Y";
            this.tbMoon2Y.Size = new System.Drawing.Size(63, 20);
            this.tbMoon2Y.TabIndex = 0;
            this.tbMoon2Y.Text = "0,0";
            this.tbMoon2Y.Click += new System.EventHandler(this.tb_Click);
            this.tbMoon2Y.TextChanged += new System.EventHandler(this.UpdateLabels);
            // 
            // tbMoon2Z
            // 
            this.tbMoon2Z.Location = new System.Drawing.Point(161, 523);
            this.tbMoon2Z.Name = "tbMoon2Z";
            this.tbMoon2Z.Size = new System.Drawing.Size(63, 20);
            this.tbMoon2Z.TabIndex = 0;
            this.tbMoon2Z.Text = "0,0";
            this.tbMoon2Z.Click += new System.EventHandler(this.tb_Click);
            this.tbMoon2Z.TextChanged += new System.EventHandler(this.UpdateLabels);
            // 
            // tbMoon1X
            // 
            this.tbMoon1X.Location = new System.Drawing.Point(588, 504);
            this.tbMoon1X.Name = "tbMoon1X";
            this.tbMoon1X.Size = new System.Drawing.Size(63, 20);
            this.tbMoon1X.TabIndex = 0;
            this.tbMoon1X.Text = "0,0";
            this.tbMoon1X.Click += new System.EventHandler(this.tb_Click);
            this.tbMoon1X.TextChanged += new System.EventHandler(this.UpdateLabels);
            // 
            // tbMoon1Y
            // 
            this.tbMoon1Y.Location = new System.Drawing.Point(588, 521);
            this.tbMoon1Y.Name = "tbMoon1Y";
            this.tbMoon1Y.Size = new System.Drawing.Size(63, 20);
            this.tbMoon1Y.TabIndex = 0;
            this.tbMoon1Y.Text = "0,0";
            this.tbMoon1Y.Click += new System.EventHandler(this.tb_Click);
            this.tbMoon1Y.TextChanged += new System.EventHandler(this.UpdateLabels);
            // 
            // tbMoon1Z
            // 
            this.tbMoon1Z.Location = new System.Drawing.Point(588, 540);
            this.tbMoon1Z.Name = "tbMoon1Z";
            this.tbMoon1Z.Size = new System.Drawing.Size(63, 20);
            this.tbMoon1Z.TabIndex = 0;
            this.tbMoon1Z.Text = "0,0";
            this.tbMoon1Z.Click += new System.EventHandler(this.tb_Click);
            this.tbMoon1Z.TextChanged += new System.EventHandler(this.UpdateLabels);
            // 
            // lblCenterToPlanet3
            // 
            this.lblCenterToPlanet3.AutoSize = true;
            this.lblCenterToPlanet3.Location = new System.Drawing.Point(406, 215);
            this.lblCenterToPlanet3.Name = "lblCenterToPlanet3";
            this.lblCenterToPlanet3.Size = new System.Drawing.Size(39, 13);
            this.lblCenterToPlanet3.TabIndex = 1;
            this.lblCenterToPlanet3.Text = "0.0 km";
            // 
            // lblCenterToPlanet1
            // 
            this.lblCenterToPlanet1.AutoSize = true;
            this.lblCenterToPlanet1.Location = new System.Drawing.Point(448, 349);
            this.lblCenterToPlanet1.Name = "lblCenterToPlanet1";
            this.lblCenterToPlanet1.Size = new System.Drawing.Size(39, 13);
            this.lblCenterToPlanet1.TabIndex = 1;
            this.lblCenterToPlanet1.Text = "0.0 km";
            // 
            // lblCenterToPlanet2
            // 
            this.lblCenterToPlanet2.AutoSize = true;
            this.lblCenterToPlanet2.Location = new System.Drawing.Point(266, 342);
            this.lblCenterToPlanet2.Name = "lblCenterToPlanet2";
            this.lblCenterToPlanet2.Size = new System.Drawing.Size(39, 13);
            this.lblCenterToPlanet2.TabIndex = 1;
            this.lblCenterToPlanet2.Text = "0.0 km";
            // 
            // lblPlanet2ToPlanet3
            // 
            this.lblPlanet2ToPlanet3.AutoSize = true;
            this.lblPlanet2ToPlanet3.Location = new System.Drawing.Point(294, 215);
            this.lblPlanet2ToPlanet3.Name = "lblPlanet2ToPlanet3";
            this.lblPlanet2ToPlanet3.Size = new System.Drawing.Size(39, 13);
            this.lblPlanet2ToPlanet3.TabIndex = 1;
            this.lblPlanet2ToPlanet3.Text = "0.0 km";
            // 
            // lblPlanet1ToPlanet3
            // 
            this.lblPlanet1ToPlanet3.AutoSize = true;
            this.lblPlanet1ToPlanet3.Location = new System.Drawing.Point(503, 241);
            this.lblPlanet1ToPlanet3.Name = "lblPlanet1ToPlanet3";
            this.lblPlanet1ToPlanet3.Size = new System.Drawing.Size(39, 13);
            this.lblPlanet1ToPlanet3.TabIndex = 1;
            this.lblPlanet1ToPlanet3.Text = "0.0 km";
            // 
            // lblPlanet1ToPlanet2
            // 
            this.lblPlanet1ToPlanet2.AutoSize = true;
            this.lblPlanet1ToPlanet2.Location = new System.Drawing.Point(360, 414);
            this.lblPlanet1ToPlanet2.Name = "lblPlanet1ToPlanet2";
            this.lblPlanet1ToPlanet2.Size = new System.Drawing.Size(39, 13);
            this.lblPlanet1ToPlanet2.TabIndex = 1;
            this.lblPlanet1ToPlanet2.Text = "0.0 km";
            // 
            // lblPlanet1ToMoon1
            // 
            this.lblPlanet1ToMoon1.AutoSize = true;
            this.lblPlanet1ToMoon1.Location = new System.Drawing.Point(560, 457);
            this.lblPlanet1ToMoon1.Name = "lblPlanet1ToMoon1";
            this.lblPlanet1ToMoon1.Size = new System.Drawing.Size(39, 13);
            this.lblPlanet1ToMoon1.TabIndex = 1;
            this.lblPlanet1ToMoon1.Text = "0.0 km";
            // 
            // lblPlanet2ToMoon2
            // 
            this.lblPlanet2ToMoon2.AutoSize = true;
            this.lblPlanet2ToMoon2.Location = new System.Drawing.Point(95, 450);
            this.lblPlanet2ToMoon2.Name = "lblPlanet2ToMoon2";
            this.lblPlanet2ToMoon2.Size = new System.Drawing.Size(39, 13);
            this.lblPlanet2ToMoon2.TabIndex = 1;
            this.lblPlanet2ToMoon2.Text = "0.0 km";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(406, 561);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "label1";
            // 
            // lblPlanet3ToMoon3
            // 
            this.lblPlanet3ToMoon3.AutoSize = true;
            this.lblPlanet3ToMoon3.Location = new System.Drawing.Point(389, 43);
            this.lblPlanet3ToMoon3.Name = "lblPlanet3ToMoon3";
            this.lblPlanet3ToMoon3.Size = new System.Drawing.Size(39, 13);
            this.lblPlanet3ToMoon3.TabIndex = 1;
            this.lblPlanet3ToMoon3.Text = "0.0 km";
            // 
            // lblCenter
            // 
            this.lblCenter.AutoSize = true;
            this.lblCenter.Location = new System.Drawing.Point(406, 296);
            this.lblCenter.Name = "lblCenter";
            this.lblCenter.Size = new System.Drawing.Size(51, 13);
            this.lblCenter.TabIndex = 2;
            this.lblCenter.Text = "CENTER";
            // 
            // btnLoadLastSavedSettings
            // 
            this.btnLoadLastSavedSettings.Location = new System.Drawing.Point(31, 12);
            this.btnLoadLastSavedSettings.Name = "btnLoadLastSavedSettings";
            this.btnLoadLastSavedSettings.Size = new System.Drawing.Size(152, 23);
            this.btnLoadLastSavedSettings.TabIndex = 3;
            this.btnLoadLastSavedSettings.Text = "Load last saved Settings";
            this.btnLoadLastSavedSettings.UseVisualStyleBackColor = true;
            this.btnLoadLastSavedSettings.Click += new System.EventHandler(this.btnLoadLastSavedSettings_Click);
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Location = new System.Drawing.Point(31, 43);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(152, 23);
            this.btnSaveSettings.TabIndex = 4;
            this.btnSaveSettings.Text = "Save Settings";
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // GeneralForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VectorsCalculator.Properties.Resources.Mapa_Galaktyczna;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnSaveSettings);
            this.Controls.Add(this.btnLoadLastSavedSettings);
            this.Controls.Add(this.lblCenter);
            this.Controls.Add(this.lblCenterToPlanet1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblPlanet1ToMoon1);
            this.Controls.Add(this.lblPlanet1ToPlanet2);
            this.Controls.Add(this.lblPlanet1ToPlanet3);
            this.Controls.Add(this.lblPlanet2ToMoon2);
            this.Controls.Add(this.lblPlanet2ToPlanet3);
            this.Controls.Add(this.lblPlanet3ToMoon3);
            this.Controls.Add(this.lblCenterToPlanet2);
            this.Controls.Add(this.lblCenterToPlanet3);
            this.Controls.Add(this.tbPlanet1X);
            this.Controls.Add(this.tbPlanet1Y);
            this.Controls.Add(this.tbPlanet1Z);
            this.Controls.Add(this.tbMoon1X);
            this.Controls.Add(this.tbMoon1Y);
            this.Controls.Add(this.tbMoon1Z);
            this.Controls.Add(this.tbPlanet2X);
            this.Controls.Add(this.tbPlanet2Y);
            this.Controls.Add(this.tbPlanet2Z);
            this.Controls.Add(this.tbMoon2X);
            this.Controls.Add(this.tbMoon2Y);
            this.Controls.Add(this.tbMoon2Z);
            this.Controls.Add(this.tbPlanet3X);
            this.Controls.Add(this.tbPlanet3Y);
            this.Controls.Add(this.tbPlanet3Z);
            this.Controls.Add(this.tbMoon3X);
            this.Controls.Add(this.tbMoon3Y);
            this.Controls.Add(this.tbMoon3Z);
            this.Name = "GeneralForm";
            this.Text = "3D Vectors Calculator for Rebels-Games.com by szczepix";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbMoon3X;
        private System.Windows.Forms.TextBox tbMoon3Y;
        private System.Windows.Forms.TextBox tbMoon3Z;
        private System.Windows.Forms.TextBox tbPlanet3X;
        private System.Windows.Forms.TextBox tbPlanet3Y;
        private System.Windows.Forms.TextBox tbPlanet3Z;
        private System.Windows.Forms.TextBox tbPlanet1X;
        private System.Windows.Forms.TextBox tbPlanet1Y;
        private System.Windows.Forms.TextBox tbPlanet1Z;
        private System.Windows.Forms.TextBox tbPlanet2X;
        private System.Windows.Forms.TextBox tbPlanet2Y;
        private System.Windows.Forms.TextBox tbPlanet2Z;
        private System.Windows.Forms.TextBox tbMoon2X;
        private System.Windows.Forms.TextBox tbMoon2Y;
        private System.Windows.Forms.TextBox tbMoon2Z;
        private System.Windows.Forms.TextBox tbMoon1X;
        private System.Windows.Forms.TextBox tbMoon1Y;
        private System.Windows.Forms.TextBox tbMoon1Z;
        private System.Windows.Forms.Label lblCenterToPlanet3;
        private System.Windows.Forms.Label lblCenterToPlanet1;
        private System.Windows.Forms.Label lblCenterToPlanet2;
        private System.Windows.Forms.Label lblPlanet2ToPlanet3;
        private System.Windows.Forms.Label lblPlanet1ToPlanet3;
        private System.Windows.Forms.Label lblPlanet1ToPlanet2;
        private System.Windows.Forms.Label lblPlanet1ToMoon1;
        private System.Windows.Forms.Label lblPlanet2ToMoon2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblPlanet3ToMoon3;
        private System.Windows.Forms.Label lblCenter;
        private System.Windows.Forms.Button btnLoadLastSavedSettings;
        private System.Windows.Forms.Button btnSaveSettings;
    }
}


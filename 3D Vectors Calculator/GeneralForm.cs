using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VectorsCalculator
{
    public partial class GeneralForm : Form
    {
        public GeneralForm()
        {
            InitializeComponent();
        }

        private void UpdateLabels(object sender, EventArgs e)
        {
            // Planet 1
            double result1 = GetDistance(tbPlanet1X.Text, tbPlanet1Y.Text, tbPlanet1Z.Text, tbMoon1X.Text, tbMoon1Y.Text, tbMoon1Z.Text);
            lblPlanet1ToMoon1.Text = result1.ToString() + " km";
            double result2 = GetDistance(tbPlanet1X.Text, tbPlanet1Y.Text, tbPlanet1Z.Text, tbPlanet2X.Text, tbPlanet2Y.Text, tbPlanet2Z.Text);
            lblPlanet1ToPlanet2.Text = result2.ToString() + " km";
            double result3 = GetDistance(tbPlanet1X.Text, tbPlanet1Y.Text, tbPlanet1Z.Text, tbPlanet3X.Text, tbPlanet3Y.Text, tbPlanet3Z.Text);
            lblPlanet1ToPlanet3.Text = result3.ToString() + " km";
            double result4 = GetDistance("0", "0", "0", tbPlanet1X.Text, tbPlanet1Y.Text, tbPlanet1Z.Text);
            lblCenterToPlanet1.Text = result4.ToString() + " km";

            // Planet 2
            double result5 = GetDistance(tbPlanet2X.Text, tbPlanet2Y.Text, tbPlanet2Z.Text, tbMoon2X.Text, tbMoon2Y.Text, tbMoon2Z.Text);
            lblPlanet2ToMoon2.Text = result5.ToString() + " km";
            double result6 = GetDistance("0", "0", "0", tbPlanet2X.Text, tbPlanet2Y.Text, tbPlanet2Z.Text);
            lblPlanet2ToPlanet3.Text = result6.ToString() + " km";
            double result7 = GetDistance(tbPlanet2X.Text, tbPlanet2Y.Text, tbPlanet2Z.Text, tbPlanet3X.Text, tbPlanet3Y.Text, tbPlanet3Z.Text);
            lblCenterToPlanet2.Text = result7.ToString() + " km";

            // Planet 3
            double result8 = GetDistance(tbPlanet3X.Text, tbPlanet3Y.Text, tbPlanet3Z.Text, tbMoon3X.Text, tbMoon3Y.Text, tbMoon3Z.Text);
            lblPlanet3ToMoon3.Text = result8.ToString() + " km";
            double result9 = GetDistance("0", "0", "0", tbPlanet3X.Text, tbPlanet3Y.Text, tbPlanet3Z.Text);
            lblCenterToPlanet3.Text = result9.ToString() + " km";
        }

        private double GetDistance(string p1x, string p1y, string p1z, string p2x, string p2y, string p2z)
        {
            double point1X, point1Y, point1Z, point2X, point2Y, point2Z;
            Double.TryParse(p1x, out point1X);
            Double.TryParse(p1y, out point1Y);
            Double.TryParse(p1z, out point1Z);
            Double.TryParse(p2x, out point2X);
            Double.TryParse(p2y, out point2Y);
            Double.TryParse(p2z, out point2Z);
            // D = √
            // [
            //   (x₂ - x₁)²
            // + (y₂ - y₁)²
            // + (z₂ - z₁)²
            // ]

            double result = Math.Sqrt(
                Math.Pow(point2X - point1X, 2)
              + Math.Pow(point2Y - point1Y, 2)
              + Math.Pow(point2Z - point1Z, 2)
            );

            result = Math.Round(result, 5, MidpointRounding.ToEven);

            return result;
        }

        private void tb_Click(object sender, EventArgs e)
        {
            TextBox tb = (TextBox) sender;
            tb.SelectAll();
        }

        private void btnLoadLastSavedSettings_Click(object sender, EventArgs e)
        {
            tbPlanet1X.Text = Properties.Settings.Default.Planet1X;
            tbPlanet1Y.Text = Properties.Settings.Default.Planet1Y;
            tbPlanet1Z.Text = Properties.Settings.Default.Planet1Z;
            tbMoon1X.Text = Properties.Settings.Default.Moon1X;
            tbMoon1Y.Text = Properties.Settings.Default.Moon1Y;
            tbMoon1Z.Text = Properties.Settings.Default.Moon1Z;

            tbPlanet2X.Text = Properties.Settings.Default.Planet2X;
            tbPlanet2Y.Text = Properties.Settings.Default.Planet2Y;
            tbPlanet2Z.Text = Properties.Settings.Default.Planet2Z;
            tbMoon2X.Text = Properties.Settings.Default.Moon2X;
            tbMoon2Y.Text = Properties.Settings.Default.Moon2Y;
            tbMoon2Z.Text = Properties.Settings.Default.Moon2Z;

            tbPlanet3X.Text = Properties.Settings.Default.Planet3X;
            tbPlanet3Y.Text = Properties.Settings.Default.Planet3Y;
            tbPlanet3Z.Text = Properties.Settings.Default.Planet3Z;
            tbMoon3X.Text = Properties.Settings.Default.Moon3X;
            tbMoon3Y.Text = Properties.Settings.Default.Moon3Y;
            tbMoon3Z.Text = Properties.Settings.Default.Moon3Z;
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Planet1X = tbPlanet1X.Text;
            Properties.Settings.Default.Planet1Y = tbPlanet1Y.Text;
            Properties.Settings.Default.Planet1Z = tbPlanet1Z.Text;
            Properties.Settings.Default.Moon1X = tbMoon1X.Text;
            Properties.Settings.Default.Moon1Y = tbMoon1Y.Text;
            Properties.Settings.Default.Moon1Z = tbMoon1Z.Text;

            Properties.Settings.Default.Planet2X = tbPlanet2X.Text;
            Properties.Settings.Default.Planet2Y = tbPlanet2Y.Text;
            Properties.Settings.Default.Planet2Z = tbPlanet2Z.Text;
            Properties.Settings.Default.Moon2X = tbMoon2X.Text;
            Properties.Settings.Default.Moon2Y = tbMoon2Y.Text;
            Properties.Settings.Default.Moon2Z = tbMoon2Z.Text;

            Properties.Settings.Default.Planet3X = tbPlanet3X.Text;
            Properties.Settings.Default.Planet3Y = tbPlanet3Y.Text;
            Properties.Settings.Default.Planet3Z = tbPlanet3Z.Text;
            Properties.Settings.Default.Moon3X = tbMoon3X.Text;
            Properties.Settings.Default.Moon3Y = tbMoon3Y.Text;
            Properties.Settings.Default.Moon3Z = tbMoon3Z.Text;

            Properties.Settings.Default.Save();
        }
    }
}

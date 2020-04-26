using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weather_App
{
    public partial class WindHumid : UserControl
    {
        public WindHumid()
        {
            InitializeComponent();
            windName.Text = Form1.days[0].windName;
            DisplayWind();
        }

        public void DisplayWind()
        {
            pictureBox1.Image = Weather_App.Properties.Resources.bar;
            pictureBox2.Image = Weather_App.Properties.Resources.facewind;
            windName.Text = Form1.days[0].windName;
            windSpeed.Text = Form1.days[0].windSpeed + " m/s";
            windDir.Text = Form1.days[0].windDirection;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            WeekScreen ws = new WeekScreen();
            f.Controls.Add(ws);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            HomeScreen hs = new HomeScreen();
            f.Controls.Add(hs);
        }
    }
}

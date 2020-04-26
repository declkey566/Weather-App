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
            DisplayWind(); //run the display wind code
        }

        public void DisplayWind()
        {
            pictureBox1.Image = Weather_App.Properties.Resources.bar; //set images in picture boxes
            pictureBox2.Image = Weather_App.Properties.Resources.facewind;
            windName.Text = Form1.days[0].windName; //set labels such as wind name, speed and direction
            windSpeed.Text = Form1.days[0].windSpeed + " m/s";
            windDir.Text = Form1.days[0].windDirection;

        }
        private void button1_Click(object sender, EventArgs e) //button to go to forecast screen
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            WeekScreen ws = new WeekScreen();
            f.Controls.Add(ws);
        }

        private void button2_Click(object sender, EventArgs e) //button to go back to the current day screen
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            HomeScreen hs = new HomeScreen();
            f.Controls.Add(hs);
        }
    }
}

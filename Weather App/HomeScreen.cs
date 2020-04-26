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
    public partial class HomeScreen : UserControl
    {
        //int low = Convert.ToInt32(Form1.days[0].tempLow);
        public HomeScreen()
        {
            InitializeComponent();
            pictureBox3.SendToBack();
            cityLabel.Parent = pictureBox3;
            tempLabel.Parent = pictureBox3;
            condLabel.Parent = pictureBox3;
            dateLabel.Parent = pictureBox3;
           
            
            DisplayCurrent();
        }

        public void DisplayCurrent()
        {
            // the current information is in index 0, thus why all information is retreived from there
            cityLabel.Text = Form1.days[0].location;
            tempLabel.Text = Form1.days[0].currentTemp + "°C";
            minLabel.Text = "Low: " + Form1.days[0].tempLow + "°C";
            maxLabel.Text = "High: "+Form1.days[0].tempHigh + "°C";
            condLabel.Text = Form1.days[0].condition;
            dateLabel.Text = Form1.days[0].date;
            double low = Convert.ToDouble(Form1.days[0].tempLow);
            double high = Convert.ToDouble(Form1.days[0].tempHigh);
            int weather = Convert.ToInt32(Form1.days[0].weather);
            
            if (low <0)
            {
                pictureBox1.Image = Weather_App.Properties.Resources.snow_small;

            }
            else
            {
                pictureBox1.Image = Weather_App.Properties.Resources.sun_small;
            }
            if (high < 0)
            {
                pictureBox2.Image = Weather_App.Properties.Resources.snow_small;

            }
            else
            {
                pictureBox2.Image = Weather_App.Properties.Resources.sun_small;
            }
            if (weather <233 && weather >199)
            {
                pictureBox3.Image = Weather_App.Properties.Resources.thunder;
            }
            else if (weather <532 && weather >299)
            {
                pictureBox3.Image = Weather_App.Properties.Resources.rain;
            }
            else if (weather < 623 && weather > 599)
            {
                pictureBox3.Image = Weather_App.Properties.Resources.snow;
            }
            else if (weather < 782 && weather > 700)
            {
                pictureBox3.Image = Weather_App.Properties.Resources.storm;
            }
            else if (weather ==800)
            {
                pictureBox3.Image = Weather_App.Properties.Resources.sky;
            }
            else if (weather < 805 && weather > 800)
            {
                pictureBox3.Image = Weather_App.Properties.Resources.cloud;
            }
        }

        /// <summary>
        /// When the forecast label is clicked this user control is removed from the form
        /// and the ForecastScreen user control is added to the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
       

        private void button1_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            WeekScreen ws = new WeekScreen();
            f.Controls.Add(ws);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            WindHumid wh = new WindHumid();
            f.Controls.Add(wh);
        }
    }
}

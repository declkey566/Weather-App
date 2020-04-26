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
    public partial class WeekScreen : UserControl
    {
        public WeekScreen()
        {
            InitializeComponent();

            //Set Parents//
            //box 1//
            min1.Parent = pictureBox1;
            max1.Parent = pictureBox1;
            cond1.Parent = pictureBox1;
            date1.Parent = pictureBox1;
            //box 2//
            // min2.Parent = pictureBox2;
           // max2.Parent = pictureBox2;
             //cond2.Parent = pictureBox2;
            // date2.Parent = pictureBox2;
            //box 3//
           // min3.Parent = pictureBox3;
           // max3.Parent = pictureBox3;
            //cond3.Parent = pictureBox3;
           // date3.Parent = pictureBox3;
            //box 4//
           // min4.Parent = pictureBox4;
           // max4.Parent = pictureBox4;
           // cond4.Parent = pictureBox4;
           // date4.Parent = pictureBox4;
            //box 5//
           // min5.Parent = pictureBox5;
           // max5.Parent = pictureBox5;
           // cond5.Parent = pictureBox5;
           // date5.Parent = pictureBox5;
            displayForecast();
        }

        /// <summary>
        /// This method displays forecast information. The information in days at 
        /// index 1 is tomorrow's information, 2 is 2 days from now, etc. 
        /// </summary>
        public void displayForecast()
        {
            date1.Text = Form1.days[1].date;
            min1.Text = "Low: " + Form1.days[1].tempLow + "°c";
            max1.Text = "High: " + Form1.days[1].tempHigh + "°c";
            cond1.Text = Form1.days[1].condition;

            date2.Text = Form1.days[2].date;
            min2.Text = "Low: " + Form1.days[2].tempLow + "°c";
            max2.Text = "High: " + Form1.days[2].tempHigh + "°c";
            cond2.Text = Form1.days[2].condition;

            date3.Text = Form1.days[3].date;
            min3.Text = "Low: " + Form1.days[3].tempLow + "°c";
            max3.Text = "High: " + Form1.days[3].tempHigh + "°c";
            cond3.Text = Form1.days[3].condition;

            date4.Text = Form1.days[4].date;
            min4.Text = "Low: " + Form1.days[4].tempLow + "°c";
            max4.Text = "High: " + Form1.days[4].tempHigh + "°c";
            cond4.Text = Form1.days[4].condition;

            date5.Text = Form1.days[5].date;
            min5.Text = "Low: " + Form1.days[5].tempLow + "°c";
            max5.Text = "High: " + Form1.days[5].tempHigh + "°c";
            cond5.Text = Form1.days[5].condition;

            int weather1 = Convert.ToInt32(Form1.days[1].weather);
            int weather2 = Convert.ToInt32(Form1.days[2].weather);
            int weather3 = Convert.ToInt32(Form1.days[3].weather);
            int weather4 = Convert.ToInt32(Form1.days[4].weather);
            int weather5 = Convert.ToInt32(Form1.days[5].weather);

          
            if (weather1 == 800)
            {
                pictureBox1.Image = Weather_App.Properties.Resources.clear;
            }
            else if (weather1 < 803 && weather1 > 800)
            {
                pictureBox1.Image = Weather_App.Properties.Resources.few;
            }
            else
            {
                pictureBox1.Image = Weather_App.Properties.Resources.cloudy;
            }
            if (weather2 == 800)
            {
                pictureBox2.Image = Weather_App.Properties.Resources.clear;
            }
            else if (weather2 < 803 && weather2 > 800)
            {
                pictureBox2.Image = Weather_App.Properties.Resources.few;
            }
            else
            {
                pictureBox2.Image = Weather_App.Properties.Resources.cloudy;
            }
            if (weather3 == 800)
            {
                pictureBox3.Image = Weather_App.Properties.Resources.clear;
            }
            else if (weather3 < 803 && weather3 > 800)
            {
                pictureBox3.Image = Weather_App.Properties.Resources.few;
            }
            else
            {
                pictureBox3.Image = Weather_App.Properties.Resources.cloudy;
            }
            if (weather4 == 800)
            {
                pictureBox4.Image = Weather_App.Properties.Resources.clear;
            }
            else if (weather4 < 803 && weather4 > 800)
            {
                pictureBox4.Image = Weather_App.Properties.Resources.few;
            }
            else
            {
                pictureBox4.Image = Weather_App.Properties.Resources.cloudy;
            }
            if (weather5 == 800)
            {
                pictureBox5.Image = Weather_App.Properties.Resources.clear;
            }
            else if (weather5 < 803 && weather5 > 800)
            {
                pictureBox5.Image = Weather_App.Properties.Resources.few;
            }
            else
            {
                pictureBox5.Image = Weather_App.Properties.Resources.cloudy;
            }


        }

        /// <summary>
        /// When the Today label is clicked, this user control is removed from the form
        /// and the CurrentScreen user control is added to the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void todayLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            HomeScreen hs = new HomeScreen();
            f.Controls.Add(hs);
        }

        private void WeekScreen_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            WindHumid wh = new WindHumid();
            f.Controls.Add(wh);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            HomeScreen hs = new HomeScreen();
            f.Controls.Add(hs);
        }
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Diagnostics;

namespace Google_Maps
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string streetaddress, cityname;
        int zoom = 13;

         private void btnstaticmap_Click(object sender, EventArgs e)
        {
            streetaddress = textbox1.Text;
            cityname = textbox2.Text;

            WebRequest requestPic = WebRequest.Create("http://maps.googleapis.com/maps/api/staticmap?center=" + streetaddress + "," + cityname + "&zoom=13&size=300x300&sensor=false");
            WebResponse repsonsePic = requestPic.GetResponse();
            Image map = Image.FromStream(repsonsePic.GetResponseStream());
            pictureBox1.Image = map;

            trackBar1.Visible = true;
            btnstreetview.Visible = true;
        }
       

        private void btnstreetview_Click(object sender, EventArgs e)
        {
            streetaddress = textbox1.Text;
            cityname = textbox2.Text;

            WebRequest requestPic = WebRequest.Create("http://maps.googleapis.com/maps/api/streetview?size=300x300&location=" + streetaddress + "," + cityname + "&heading=235&sensor=false");
            WebResponse repsonsePic = requestPic.GetResponse();
            Image map = Image.FromStream(repsonsePic.GetResponseStream());
            pictureBox2.Image = map;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            zoom = trackBar1.Value;
            streetaddress = textbox1.Text;
            cityname = textbox2.Text;
            WebRequest requestPic = WebRequest.Create("http://maps.googleapis.com/maps/api/staticmap?center=" + streetaddress + "," + cityname + "&zoom=" + zoom + "&size=300x300&sensor=false");
            WebResponse repsonsePic = requestPic.GetResponse();
            Image map = Image.FromStream(repsonsePic.GetResponseStream());
            pictureBox1.Image = map;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("chrome.exe", "http://maps.googleapis.com/maps/api/streetview?size=300x300&location=" + streetaddress + "," + cityname + "&heading=235&sensor=false");
        }
       
    }
}

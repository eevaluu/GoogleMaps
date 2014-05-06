﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace Google_Maps
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string streetaddress, cityname;

         private void btnstaticmap_Click(object sender, EventArgs e)
        {
            streetaddress = textbox1.Text;
            cityname = textbox2.Text;
            WebRequest requestPic = WebRequest.Create("http://maps.googleapis.com/maps/api/staticmap?center=" + streetaddress + "," + cityname + "&zoom=13&size=300x300&sensor=false");
            WebResponse repsonsePic = requestPic.GetResponse();
            Image map = Image.FromStream(repsonsePic.GetResponseStream());
            pictureBox1.Image = map;
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

       
    }
}
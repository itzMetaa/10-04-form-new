﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_04_New
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //xd
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.timer1.Start();
            //label_kiir.Text = "Hello " + text_szoveg.Text;
        }

        private void rich(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);
            if (this.progressBar1.Value == 100)
            {
                label_kiir.Text = "Hello " + text_szoveg.Text;
            }
        }
    }
}

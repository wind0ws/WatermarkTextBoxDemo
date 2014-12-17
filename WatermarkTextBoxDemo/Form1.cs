using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace WatermarkTextBoxDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            linkLabel1.Click += delegate(object sender, EventArgs e)
            {
                Process.Start("www.csharpwin.com");
            };
        }
    }
}
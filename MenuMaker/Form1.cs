using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuMaker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MeunMaker meun = new MeunMaker() { Randomizer = new Random() };
            label1.Text = meun.GetMeunItem();
            label2.Text = meun.GetMeunItem();
            label3.Text = meun.GetMeunItem();
            label4.Text = meun.GetMeunItem();
            label5.Text = meun.GetMeunItem();
            label6.Text = meun.GetMeunItem();
        }
    }
}
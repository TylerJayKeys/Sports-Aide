using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics; // REMOVE WHEN DONE WITH DEBUGGING

namespace SportsAide
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Core.MainMenu = this;
            Core.PlayerMenu = new Form2();
            Core.TrackerMenu = new Form3();
            // ADD MEDIAMENU CONSTRUCTOR!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        }

        private void button1_Click(object sender, EventArgs e) // Team Menu
        {
            Core.OpenForm(Core.PlayerMenu);
        }

        private void button2_Click(object sender, EventArgs e) // Tracker
        {
            Core.OpenForm(Core.TrackerMenu);
        }

        private void button4_Click(object sender, EventArgs e) // Exit Button
        {
            Application.Exit();
        }
    }
}

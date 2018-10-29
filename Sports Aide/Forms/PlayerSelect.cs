using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SportsAide;

namespace Sports_Aide.Forms
{
    public partial class PlayerSelect : Form
    {
        public PlayerSelect()
        {
            InitializeComponent();
        }

        public string Selection; // data used to transfer to host form

        // Show all players in a listbox
        private void PlayerSelect_Load(object sender, EventArgs e)
        {
            // Shutdown item drawing while data is collected
            listBox1.BeginUpdate();

            foreach (string name in Player.GetAll())
            {
                listBox1.Items.Add(name);
            }

            listBox1.EndUpdate();
        }

        // Sets the public data to the selected item
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ?? operator used to avoid crashing if it's null
            Selection = listBox1.SelectedItem.ToString() ?? null;
        }
    }
}

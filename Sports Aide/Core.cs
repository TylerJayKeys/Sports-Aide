using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportsAide
{
    public static class Core
    {

        public static Form MainMenu;
        public static Form PlayerMenu;
        public static Form TrackerMenu;
        public static Form MediaMenu;

        public static void OpenForm(Form f, bool closeLast = true)
        {
            if (closeLast == true) {
                Form.ActiveForm.Hide();
            }
            f.Show();
        }
    }
}

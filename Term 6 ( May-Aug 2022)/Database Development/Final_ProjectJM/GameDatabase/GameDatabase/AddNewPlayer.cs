using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameDatabase
{
    public partial class AddNewPlayer : Form
    {
       public string newplayername;
        public AddNewPlayer()
        {
            InitializeComponent();
        }
        
        private void btnCreatePlayer_Click(object sender, EventArgs e)
        {
            newplayername = txtNewPName.Text;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

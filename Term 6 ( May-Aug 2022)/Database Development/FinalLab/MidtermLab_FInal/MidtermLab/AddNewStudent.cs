using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidtermLab
{
    public partial class AddNewStudent : Form
    {
        public string Fname,Lname,BDate,GPA,Term;
        public AddNewStudent()
        {
            InitializeComponent();
        }

        private void btnCreateStudent_Click(object sender, EventArgs e)
        {
            Fname = txtFName.Text;
            Lname = txtLName.Text;
            BDate = txtBirthdate.Text;
            GPA = txtGPA.Text;
            Term = txtTerm.Text;
            this.Close();
        }


        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text_Adventure_Project
{
    public partial class StartingPrompt : Form
    {
        Dungeon d;
        public StartingPrompt()
        {
            InitializeComponent();
            StartingText.Text = "Welcome to Texty's Dungeon!\n"+ "What is your name?";
        }

        static void Start()
        {

            Console.ReadKey();
            Console.Clear();
            //Starting Prompt 
            Console.WriteLine("*insert beginning prompt here*\n\n");

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            d = new Dungeon(NameChoosing.Text);
            d.Show();
        }
    }
}

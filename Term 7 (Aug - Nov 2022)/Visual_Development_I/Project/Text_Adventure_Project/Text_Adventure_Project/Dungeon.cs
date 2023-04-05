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
    public partial class Dungeon : Form
    {
        
        public Player currentplayer = new Player();
        public Dungeon(string name)
        {
            
            InitializeComponent();
        }
    }
}

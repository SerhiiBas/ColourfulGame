using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColourfulGame
{
    public partial class Level : Form
    {
        public static EnumLenguage lenguageSwich { get; set; }
        public Level()
        {
            InitializeComponent();
            if (lenguageSwich == EnumLenguage.English)
            {
                lbLevel.Text = "Level";
                buEasy.Text = "Easy";
                buMiddle.Text = "Midle";
                buHard.Text = "Hard";

                lbLevel.Location = new Point(359, 79);
            }
            else if (lenguageSwich == EnumLenguage.Ukranian)
            {
                lbLevel.Text = "Рівень";
                buEasy.Text = "Легкий";
                buMiddle.Text = "Середній";
                buHard.Text = "Складний";

                lbLevel.Location = new Point(339, 79);
            }
        }

        private void buEasy_Click(object sender, EventArgs e)
        {
            this.Close();
            ColoreGame coloreGame = new ColoreGame();
            coloreGame.InitScor(5, -10, 2000);
            coloreGame.Show();
        }

        private void buMiddle_Click(object sender, EventArgs e)
        {
            this.Close();
            ColoreGame coloreGame = new ColoreGame();
            coloreGame.InitScor(10, -5, 1500);
            coloreGame.Show();
        }

        private void buHard_Click(object sender, EventArgs e)
        {
            this.Close();
            ColoreGame coloreGame = new ColoreGame();
            coloreGame.InitScor(15, -1, 1000);
            coloreGame.Show();
        }
    }
}

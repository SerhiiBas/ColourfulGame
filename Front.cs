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
    public partial class Front : Form
    {
        public Front()
        {
            InitializeComponent();
            rbUkranian.CheckedChanged += RbUkranian_CheckedChanged;
            rbEnglish.CheckedChanged += RbEnglish_CheckedChanged;
        }

        private void RbEnglish_CheckedChanged(object sender, EventArgs e)
        {
            ColoreGame.lenguageSwich = EnumLenguage.English;
            Level.lenguageSwich = EnumLenguage.English;
            gbLeng.Text = "Lenguage";
            rbEnglish.Text = "English";
            rbUkranian.Text = "Ukranian";
            buPlay.Text = "Play";
        }

        private void RbUkranian_CheckedChanged(object sender, EventArgs e)
        {
            ColoreGame.lenguageSwich = EnumLenguage.Ukranian;
            Level.lenguageSwich = EnumLenguage.Ukranian;
            gbLeng.Text = "Мова";
            rbEnglish.Text = "Англійська";
            rbUkranian.Text = "Українська";
            buPlay.Text = "Грати";
        } 

        private void buPlay_MouseClick(object sender, MouseEventArgs e)
        {
            Level level = new Level();
            level.Show();
        }
    }
}

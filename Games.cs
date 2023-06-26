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
    public partial class ColoreGame : Form
    {
        Dictionary<int, string> writtenColourNameEn;
        Dictionary<int, string> writtenColourNameUa;
        Dictionary<int, Color> textColour;
        Dictionary<int, string> useColerNameDict;

        Random random = new Random();

        private int winningScore { get; set; }
        private int loseScore { get; set; }
        private int counteScore { get; set; }

        public static EnumLenguage lenguageSwich { get; set; }


        private int textForUser;
        private int colourForUser;
        private bool boolClickCheck;
        bool checkEqualty;
        public ColoreGame()
        {
            InitializeComponent();
            InitializationColour();

            // перевіряємо на клік та його правильність
            this.Click += ColoreGame_Click;
            lbTextForUser.Click += LbTextForUser_Click;
            lbScoreInfo.Click += LbScoreInfo_Click;
            lbScore.Click += LbScore_Click;

            // Перевірка на мову
            if (lenguageSwich==EnumLenguage.English)
            {
                lbScoreInfo.Text = "Win: ";
                lbScoreInfo2.Text = "Lose: ";
                lbScore.Text = "Score: ";

                lbScoreInfo.Location = new Point(24, 13);
                lbWinScore.Location = new Point(61, 13);
                lbScoreInfo2.Location = new Point(20, 33);
                lbLoseScore.Location = new Point(55, 33);
                lbScore.Location = new Point(12, 53);
                lbSco.Location = new Point(61, 53);

                useColerNameDict = writtenColourNameEn;
            }
            else if (lenguageSwich==EnumLenguage.Ukranian)
            {
                lbScoreInfo.Text = "Виграш: ";
                lbScoreInfo2.Text = "Програш: ";
                lbScore.Text = "Рахунок: ";

                lbScoreInfo.Location = new Point(24, 13);
                lbWinScore.Location = new Point(95, 13);
                lbScoreInfo2.Location = new Point(12, 33);
                lbLoseScore.Location = new Point(89, 33);
                lbScore.Location = new Point(21, 53);
                lbSco.Location = new Point(102, 53);
                useColerNameDict = writtenColourNameUa;
            }
        }

        // Ініціалізую Dictionary (назви кольорів та самі кольори)
        private void InitializationColour()
        {
            writtenColourNameUa = new Dictionary<int, string>
            {
                [0] = "Червоний",
                [1] = "Зелений",
                [2] = "Фіолетовий",
                [3] = "Блакитний",
                [4] = "Жовтий",
                [5] = "Білий",
            };
            writtenColourNameEn = new Dictionary<int, string>
            {
                [0] = "Red",
                [1] = "Green",
                [2] = "Purple",
                [3] = "Blue",
                [4] = "Yellow",
                [5] = "White",
            };
            textColour = new Dictionary<int, Color>
            {
                [0] = Color.Red,
                [1] = Color.Green,
                [2] = Color.Purple,
                [3] = Color.Blue,
                [4] = Color.Yellow,
                [5] = Color.White
            };
        }

        //виводжу вихідні параметри
        private void PrintScor()
        {
            lbSco.Text = $"{counteScore}";
            lbWinScore.Text = $"{winningScore}";
            lbLoseScore.Text = $"{loseScore}";
        }

        // Перевіряє чи рахунок гравця співпадає з границями виграшу програшу. Завершує гру.
        private void CheckWinOrLose()
        {
            if (counteScore <= loseScore)
            {
                timer1.Stop();
                MessageBox.Show("your lose =(");
                this.Close();
                counteScore = 0;
            }
            else if (counteScore >= winningScore)
            {
                timer1.Stop();
                MessageBox.Show("your won!");
                this.Close();
                counteScore = 0;
            }
        }

        //перевірка на співпадіння кольору і тексту
        private bool CheckEquality(int text, int color)
        {
            if (text == color)
                return true;

                return false;
        }

        // Кліки на поле та інші елементи
        private void ColoreGame_Click(object sender, EventArgs e)
        {
            boolClickCheck = true;
        }
        private void LbScore_Click(object sender, EventArgs e)
        {
            boolClickCheck = true;
        }
        private void LbScoreInfo_Click(object sender, EventArgs e)
        {
            boolClickCheck = true;
        }
        private void LbTextForUser_Click(object sender, EventArgs e)
        {
            boolClickCheck = true;
        }

        // таймер тік
        private void Timer1_Tick(object sender, EventArgs e)
        {
            // превірка

            if (checkEqualty)
            {
                if (boolClickCheck)
                    counteScore++;
                else
                    counteScore--;
            }
            if (!checkEqualty)
            {
                if (boolClickCheck)
                    counteScore--;
            }

            // виводжу рахунок
            PrintScor();

            // перевіряю на відповідність очків гравця лімітам виграшу програшу
            CheckWinOrLose();

            // Обнулення флажка кліка
            boolClickCheck = false;

            // рандомно обираю Текст та Колір
            textForUser = random.Next(0, useColerNameDict.Count);
            colourForUser = random.Next(0, textColour.Count);

            // Виводжу на екран новий текст та колір
            lbTextForUser.Text = useColerNameDict[textForUser];
            lbTextForUser.ForeColor = textColour[colourForUser];

            // перевіряю на співпадіння тексту та кольору 
            checkEqualty = CheckEquality(textForUser, colourForUser);
            
        }

        // Змінює вхідні параметри залежно від рівня складності
        public void InitScor(int winsc, int losscr, int wheitTime)
        {
            winningScore = winsc;
            loseScore = losscr;
            timer1.Interval = wheitTime;
        }
    }
}

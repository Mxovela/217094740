using QiuzGame1._0._0;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LanguageLearningGame
{
    public partial class frmMainMenu : Form
    {
        
        public int scoreG = 0;

        public frmMainMenu()
        {
            InitializeComponent();
        }

        frmStartMenu startMenu = new frmStartMenu();
        System.Media.SoundPlayer btnClick = new System.Media.SoundPlayer(Properties.Resources.button_Click);
        private void btnHome_Click(object sender, EventArgs e)
        {
            btnClick.Play();

            startMenu.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            btnClick.Play();
            btnGreetings.Enabled = true;
            btnNumber.Enabled = true;

            btnPhrases.Enabled = false;
            

        }

        private void btnBasics2_Click(object sender, EventArgs e)
        {
            btnClick.Play();

            btnPhrases.Enabled = true;
            

            btnGreetings.Enabled =false;
            btnNumber.Enabled = false;

        }

        private void btnGreetings_Click(object sender, EventArgs e)
        {
            btnClick.Play();

            LearnGreetings lrnGreetings = new LearnGreetings();
            lrnGreetings.Show();
            this.Hide();
        }

        private void lblScoreTotal_Click(object sender, EventArgs e)
        {

        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            lblScore.Text = scoreG.ToString();
        }

        private void lblHighscore_Click(object sender, EventArgs e)
        {

        }

        private void lblScore_Click(object sender, EventArgs e)
        {

        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            btnClick.Play();

            IMRound1 imRound1 = new IMRound1();
            imRound1.Show();
            this.Hide();
        }

        private void btnTips_Click(object sender, EventArgs e)
        {
            btnClick.Play();
            MessageBox.Show("Click on the options on the left to open up the right options");
        }

        private void btnPhrases_Click(object sender, EventArgs e)
        {
            btnClick.Play();
            PhrasesRound1 Round1 = new PhrasesRound1();
            Round1.Show();
            this.Hide();
        }

        private void btnSound_Click(object sender, EventArgs e)
        {
            btnClick.Play();
        }

        private void btnQuiz_Click(object sender, EventArgs e)
        {
            Form1 ft = new Form1();
            ft.Show();
            this.Hide();
        }

        private void btnNumbers2_Click(object sender, EventArgs e)
        {
            btnClick.Play();
        }
    }
}

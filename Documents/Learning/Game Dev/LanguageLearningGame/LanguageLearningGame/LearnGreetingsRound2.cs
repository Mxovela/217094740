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
    public partial class LearnGreetingsRound2 : Form
    {
       
        public LearnGreetingsRound2()
        {
            InitializeComponent();
           
        }

        bool btnSound2IsClicked;
        bool btnSound1IsClicked;
        public int scoreG = 0;
        LearnGreetingsRound3 Round3 = new LearnGreetingsRound3();
        System.Media.SoundPlayer btnClick = new System.Media.SoundPlayer(Properties.Resources.button_Click);

        public void Verify()
        {
            

            if (btnSound2IsClicked || btnSound1IsClicked)
            {
                MessageBox.Show("Incorrect");
            }
            else
            {

                scoreG += 1;

                lblScore.Text = scoreG.ToString();
                Round3.scoreG = scoreG;

                MessageBox.Show("Score " + scoreG);

                btnCheck.Visible = false;
                btnContinue.Visible = true;
            }


        }
        private void btnCheck_Click(object sender, EventArgs e)
        {
            btnClick.Play();
            Verify();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            btnClick.Play();
            frmMainMenu mainMenu = new frmMainMenu();

            mainMenu.Show();
            this.Hide();
        }

        private void btnSound1_Click(object sender, EventArgs e)
        {
            btnClick.Play();
            btnCheck.Enabled = true;
            btnSound1IsClicked = true;
        }

        private void btnSound2_Click(object sender, EventArgs e)
        {
            btnClick.Play();
            btnCheck.Enabled = true;
            btnSound2IsClicked = true;
        }

        private void btnSound3_Click(object sender, EventArgs e)
        {
            btnClick.Play();
            btnCheck.Enabled = true;
        }

        private void LearnGreetingsRound2_Load(object sender, EventArgs e)
        {
            lblScore.Text = scoreG.ToString();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            btnClick.Play();
            Round3.Show();
            this.Hide();
        }

        private void btnAudio_Click(object sender, EventArgs e)
        {
            btnClick.Play();
        }

        private void btnSound_Click(object sender, EventArgs e)
        {
            btnClick.Play();
        }
    }
}

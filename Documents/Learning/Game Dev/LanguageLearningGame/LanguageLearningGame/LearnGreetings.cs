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
    public partial class LearnGreetings : Form
    {
        LearnGreetingsRound2 learnGreetingsRound2 = new LearnGreetingsRound2();
        public LearnGreetings()
        {
            InitializeComponent();
        }
      
        bool btnSound2IsClicked;
        bool btnSound3IsClicked;
        public int scoreG = 0;


        // System.Media.SoundPlayer sndHallo = new System.Media.SoundPlayer(Properties.Resources.Hallo);
        System.Media.SoundPlayer btnClick = new System.Media.SoundPlayer(Properties.Resources.button_Click);


        public void Verify()
        {
            if(btnSound2IsClicked || btnSound3IsClicked)
            {
                MessageBox.Show("Incorrect");
               
            }
            else
            {
                scoreG += 1;
                lblScore.Text = scoreG.ToString();

                MessageBox.Show("Score " + scoreG);

                learnGreetingsRound2.scoreG += scoreG;
              
                btnCheck.Visible = false;
                btnContinue.Visible = true;
            }

            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            btnClick.Play();
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
            // sndHallo.Play();
            //  btnSound1IsClicked = true;

            btnCheck.Enabled = true;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            btnClick.Play();
            Verify();
        }

        private void btnSound2_Click(object sender, EventArgs e)
        {
            btnClick.Play();

            btnSound2IsClicked = true;
           

            btnCheck.Enabled = true;
        }

        private void btnSound3_Click(object sender, EventArgs e)
        {
            btnClick.Play();
            btnSound3IsClicked = true;

            btnCheck.Enabled = true;
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {

            btnClick.Play();
            learnGreetingsRound2.Show();
            this.Hide();
        }

        private void btnTips_Click(object sender, EventArgs e)
        {
            btnClick.Play();
            MessageBox.Show("Click on the word that dire");
        }

        private void LearnGreetings_Load(object sender, EventArgs e)
        {

        }
    }
}

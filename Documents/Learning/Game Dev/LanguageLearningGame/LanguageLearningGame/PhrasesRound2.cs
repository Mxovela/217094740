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
    public partial class PhrasesRound2 : Form
    {
        public PhrasesRound2()
        {
            InitializeComponent();
           
        }

        bool btnOptionOneIsClicked;
        bool btnOptionTwoIsClicked;
        bool btnOptionThreeIsClicked;
        bool btnOptionFourIsClicked;

       

        int clicks = 0;


        public int scoreG = 0;
        PhrasesRound3 Round3 = new PhrasesRound3();
        System.Media.SoundPlayer btnClick = new System.Media.SoundPlayer(Properties.Resources.button_Click);
        public void Verify()
        {

            if (btnOptionTwoIsClicked || btnOptionThreeIsClicked || btnOptionFourIsClicked)
            {
                MessageBox.Show("Incorrect");
            }
            else if(btnOptionOneIsClicked)
            {
                
                scoreG += 1;

                lblScore.Text = scoreG.ToString();
                Round3.scoreG = scoreG;
                
                btnContinue.Visible = true;
                btnCheck.Visible = false;
            }
            

        }
        private void btnCheck_Click(object sender, EventArgs e)
        {
            btnClick.Play();
            Verify();
            clicks++;

            if (clicks == 3)
            {
                MessageBox.Show("Attempts maxed out\nCorrect answer was 'The bird flies in the sky'");

                btnOption2.Enabled = false;
                btnOption3.Enabled = false;
                btnOption4.Enabled = false;

                scoreG += 0;

                btnContinue.Visible = true;
            }

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
            btnOptionOneIsClicked = true;

            
        }

        private void btnSound2_Click(object sender, EventArgs e)
        {
            btnClick.Play();
            btnCheck.Enabled = true;
            btnOptionTwoIsClicked = true ;
           
        }

        private void btnSound3_Click(object sender, EventArgs e)
        {
            btnClick.Play();
            btnCheck.Enabled = true;
           btnOptionThreeIsClicked = true;
            
        }

        private void LearnGreetingsRound2_Load(object sender, EventArgs e)
        {
            lblScore.Text = scoreG.ToString();
          
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void btnOptionFour_Click(object sender, EventArgs e)
        {
            btnCheck.Enabled = true;
            btnOptionFourIsClicked = true;
           
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            btnClick.Play();
            Round3.Show();
              this.Hide();
        }

        private void btnOption1_Click(object sender, EventArgs e)
        {
            btnClick.Play();
            btnOptionOneIsClicked = true;
        }

        private void btnTranslate_Click(object sender, EventArgs e)
        {
           
                lblPhrase.Text = "Die voël vlieg in die lug";
                btnRET.Visible = false;
                btnTranslate.Visible = true;
            
           
        }

        private void btnTranslate_Click_1(object sender, EventArgs e)
        {
            btnClick.Play();
            lblPhrase.Text = "The bird flies in the sky";
            btnTranslate.Visible = false;
            btnRET.Visible = true;
           
        }

        private void btnSound_Click(object sender, EventArgs e)
        {
            btnClick.Play();
        }

        private void btnOption3_Click(object sender, EventArgs e)
        {
            btnClick.Play();
        }

        private void btnOption2_Click(object sender, EventArgs e)
        {
            btnClick.Play();
        }

        private void btnOption4_Click(object sender, EventArgs e)
        {
            btnClick.Play();
        }
    }
}

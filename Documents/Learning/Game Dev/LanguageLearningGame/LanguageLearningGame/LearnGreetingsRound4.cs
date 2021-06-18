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
    public partial class LearnGreetingsRound4 : Form
    {
        public LearnGreetingsRound4()
        {
            InitializeComponent();
           
        }

        bool btnOptionOneIsClicked;
        bool btnOptionTwoIsClicked;
        bool btnOptionThreeIsClicked;
        bool btnOptionFourIsClicked;

        bool lblRightGood;
        bool lblRightHello;
        bool lblRightHow;
        bool lblRightWelcome;

        int clicks = 0;


        public int scoreG = 0;
        frmMainMenu mainMenu = new frmMainMenu();
        IMRound1 Round1 = new IMRound1();
        System.Media.SoundPlayer btnClick = new System.Media.SoundPlayer(Properties.Resources.button_Click);
        public void Verify()
        {
            

            if (btnOptionOneIsClicked && lblRightGood)
            {
                clicks += 1;
                MessageBox.Show("Right");
                btnOptionOne.Enabled = false;
                lblGoodMorning.Enabled = false;
                

            }
            else
            {
                MessageBox.Show("Incorrect");
            }

            if (btnOptionTwoIsClicked && lblRightHello)
            {
                clicks += 1;
                MessageBox.Show("Right 2");
                btnOptionTwo.Enabled = false;
                lblHello.Enabled = false;
               

            }
            if (btnOptionThreeIsClicked && lblRightHow)
            {
                clicks += 1;
                MessageBox.Show("Right 3");
                
                btnOptionThree.Enabled = false;
                lblHowrU.Enabled = false;
              
            }

            if (btnOptionFourIsClicked && lblRightWelcome)
            {
                clicks += 1;
                MessageBox.Show("Right 4");
               
                btnOptionFour.Enabled = false;
                lblWelcome.Enabled = false;
                
            }

            if (clicks == 3)
            {
                scoreG += 1;
                btnContinue.Visible = true;
                lblScore.Text = scoreG.ToString();
                mainMenu.scoreG = scoreG;
                Round1.scoreG = scoreG;

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
            btnClick.Play();
            lblRightGood = true;
        }

        private void btnOptionFour_Click(object sender, EventArgs e)
        {
            btnClick.Play();
            btnCheck.Enabled = true;
            btnOptionFourIsClicked = true;
           
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            btnClick.Play();
            mainMenu.Show();
            this.Hide();
        }

        private void lblHello_Click(object sender, EventArgs e)
        {
            btnClick.Play();
            lblRightHello = true;
        }

        private void lblHowrU_Click(object sender, EventArgs e)
        {
            btnClick.Play();
            lblRightHow = true;
        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {
            btnClick.Play();
            lblRightWelcome = true;

        }

        private void btnSound_Click(object sender, EventArgs e)
        {
            btnClick.Play();
        }
    }
}

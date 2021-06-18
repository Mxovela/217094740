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
    public partial class IMRound1 : Form
    {
        public IMRound1()
        {
            InitializeComponent();
           
        }
        System.Media.SoundPlayer btnClick = new System.Media.SoundPlayer(Properties.Resources.button_Click);
        bool btnOption4IsClicked;
        int clicked = 1;


        public int scoreG = 0;
        IMRound2 Round2 = new IMRound2();

        public void Verify()
        {
            if (btnOption4IsClicked)
            {
                scoreG += 1;
                lblScore.Text = scoreG.ToString();
                btnOption1.Enabled = false;
                btnOption2.Enabled = false;
                btnOption3.Enabled = false;

                Round2.scoreG = scoreG;
                btnContinue.Visible = true;

            }else if (clicked.Equals(3))
            {
                btnOption1.Enabled = false;
                btnOption2.Enabled = false;
                btnOption3.Enabled = false;
                btnContinue.Visible = true;
                MessageBox.Show("The correct answer was the 'Car'");
            }
            else
            {
                MessageBox.Show("Incorrect");
                
            }
        }
        private void btnCheck_Click(object sender, EventArgs e)
        {
            btnClick.Play();

            Verify();
            clicked++;
           
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

        }

        private void btnSound2_Click(object sender, EventArgs e)
        {
            btnClick.Play();
            btnCheck.Enabled = true;
            
           
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

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void btnOptionFour_Click(object sender, EventArgs e)
        {
            btnClick.Play();
            btnCheck.Enabled = true;
          
           
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            btnClick.Play();
            Round2.Show();
            this.Hide();
        }

        private void lblHello_Click(object sender, EventArgs e)
        {
           
        }

        private void lblHowrU_Click(object sender, EventArgs e)
        {

          
        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {
         

        }

        private void btnOption1_Click(object sender, EventArgs e)
        {
            btnClick.Play();
        }

        private void btnOption4_Click(object sender, EventArgs e)
        {
            btnClick.Play();
            btnOption4IsClicked = true;
        }

        private void btnOption2_Click(object sender, EventArgs e)
        {
            btnClick.Play();
        }

        private void btnOption3_Click(object sender, EventArgs e)
        {
            btnClick.Play();
        }

        private void btnSound_Click(object sender, EventArgs e)
        {
            btnClick.Play();
        }
    }
}

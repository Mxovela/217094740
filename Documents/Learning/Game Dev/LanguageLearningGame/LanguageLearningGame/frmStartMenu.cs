using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LanguageLearningGame
{
    public partial class frmStartMenu : Form
    {
        public frmStartMenu()
        {
            Thread t = new Thread(new ThreadStart(Splash));
            t.Start();
           
            InitializeComponent();

            string str = string.Empty;

            for (int i = 0; i < 100000; i++)
            {
                str += i.ToString();
            }
            t.Abort();

        }

        public void Splash()
        {
            SplashScreen.SplashForm frm = new SplashScreen.SplashForm();
            frm.AppName = "Crow Learning";
            Application.Run(frm);
        }


        System.Media.SoundPlayer bckMusic = new System.Media.SoundPlayer(Properties.Resources.Free_Synthwave_Loop);
        System.Media.SoundPlayer btnClick = new System.Media.SoundPlayer(Properties.Resources.button_Click);
        private void btnStart_Click(object sender, EventArgs e)
        {
            btnClick.Play();

            btnEnglish.Visible = true;
            btnAfrikaans.Visible = true;
            btnStart.Visible = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            btnClick.Play();

            btnEnglish.Visible = false;
            btnAfrikaans.Visible = false;
            btnStart.Visible = true;
        }

        private void btnEnglish_Click(object sender, EventArgs e)
        {
            btnClick.Play();

            frmMainMenu mainMenu = new frmMainMenu();

            mainMenu.Show();
            this.Hide();

        }

        private void btnAfrikaans_Click(object sender, EventArgs e)
        {
            btnClick.Play();

            frmMainMenu mainMenu = new frmMainMenu();

            mainMenu.Show();
            this.Close();
        }

        private void btnSound_Click(object sender, EventArgs e)
        {
 
        }

        private void frmStartMenu_Load(object sender, EventArgs e)
        {
            bckMusic.PlayLooping();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btnClick.Play();

            bckMusic.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnClick.Play();

            bckMusic.PlayLooping();
        }
    }
}

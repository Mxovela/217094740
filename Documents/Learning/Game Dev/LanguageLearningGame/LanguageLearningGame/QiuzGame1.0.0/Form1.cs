using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace QiuzGame1._0._0
{
    

    public partial class Form1 : Form
    {
        int TotalAnswers;
        int Questions = 1;
        int Answer;
        int Total;
        SoundPlayer sound = new SoundPlayer(@"C:\Users\MXO\source\repos\QiuzGame1.0.0\QiuzGame1.0.0\bin\Debug\sound\pop.wav");
        public Form1()
        {
            

            InitializeComponent();


            Questioning(Questions);

            Total = 10;
        }


        //Asking questions page
        private void Questioning(int QuestionNUmber)
        {
            switch (QuestionNUmber)
            {
                case 1:

                    lblQuestion.Text = "IT IS USED FOR LONG DISTANCE";

                    button1.BackgroundImage = Properties.Resources.car;
                    button1.BackgroundImageLayout = ImageLayout.Stretch;
                    button1.Text = "Car";

                    button2.BackgroundImage = Properties.Resources.human;
                    button2.BackgroundImageLayout = ImageLayout.Stretch;
                    button2.Text = "Human";

                    button3.BackgroundImage = Properties.Resources.buikding;
                    button3.BackgroundImageLayout = ImageLayout.Stretch;
                    button3.Text = "Building";

                    button4.BackgroundImage = Properties.Resources.tree;
                    button4.BackgroundImageLayout = ImageLayout.Stretch;
                    button4.Text = "Tree";

                    Answer = 1;

                    break;
                case 2:

                    lblQuestion.Text = "USED TO DRINK COFFE";

                    button1.BackgroundImage = Properties.Resources.Glass;
                    button1.BackgroundImageLayout = ImageLayout.Stretch;
                    button1.Text = "Glass";

                    button2.BackgroundImage = Properties.Resources.cup;
                    button2.BackgroundImageLayout = ImageLayout.Stretch;
                    button2.Text = "Cup";

                    button3.BackgroundImage = Properties.Resources.dish;
                    button3.BackgroundImageLayout = ImageLayout.Stretch;
                    button3.Text = "Dish";

                    button4.BackgroundImage = Properties.Resources.spoon;
                    button4.BackgroundImageLayout = ImageLayout.Stretch;
                    button4.Text = "spoon";

                    Answer = 2;

                    break;
                case 3:

                    lblQuestion.Text = "IT IS COMFORTABLE AND IS USED TO SLEEP";


                    button1.BackgroundImage = Properties.Resources.fridge;
                    button1.BackgroundImageLayout = ImageLayout.Stretch;
                    button1.Text = "Fridge";

                    button2.BackgroundImage = Properties.Resources.closet;
                    button2.BackgroundImageLayout = ImageLayout.Stretch;
                    button2.Text = "Closet";

                    button3.BackgroundImage = Properties.Resources.table;
                    button3.BackgroundImageLayout = ImageLayout.Stretch;
                    button3.Text = "Table";

                    button4.BackgroundImage = Properties.Resources.bed;
                    button4.BackgroundImageLayout = ImageLayout.Stretch;
                    button4.Text = "Bed";

                    Answer = 4;

                    break;
                case 4:

                    lblQuestion.Text = "WHEN YOU ARE PLAYINING VIDEO GAMES YOU USE IT TO CONTROL THE GAME OBJECT";

                    button1.BackgroundImage = Properties.Resources.remote;
                    button1.BackgroundImageLayout = ImageLayout.Stretch;
                    button1.Text = "Remote";

                    button2.BackgroundImage = Properties.Resources.radio;
                    button2.BackgroundImageLayout = ImageLayout.Stretch;
                    button2.Text = "Radio";

                    button3.BackgroundImage = Properties.Resources.controller;
                    button3.BackgroundImageLayout = ImageLayout.Stretch;
                    button3.Text = "Controller";

                    button4.BackgroundImage = Properties.Resources.TV;
                    button4.BackgroundImageLayout = ImageLayout.Stretch;
                    button4.Text = "TV";

                    Answer = 3;

                    break;

                case 5:

                    lblQuestion.Text = "IT IS USED TO FOR A COMMUNOCATION BETWEEN PEOPLE WHO ARE IN DIFFERENT LOCATION";


                    button1.BackgroundImage = Properties.Resources.phone;
                    button1.BackgroundImageLayout = ImageLayout.Stretch;
                    button1.Text = "Phone";

                    button2.BackgroundImage = Properties.Resources.charger;
                    button2.BackgroundImageLayout = ImageLayout.Stretch;
                    button2.Text = "charger";

                    button3.BackgroundImage = Properties.Resources.car;
                    button3.BackgroundImageLayout = ImageLayout.Stretch;
                    button3.Text = "car";

                    button4.BackgroundImage = Properties.Resources.fridge;
                    button4.BackgroundImageLayout = ImageLayout.Stretch;
                    button4.Text = "Fridge";

                    Answer = 1;

                    break;

                case 6:

                    lblQuestion.Text = "IT IS USED TO PUT CLEAN CLOTHES IN";

                    button1.BackgroundImage = Properties.Resources.bed;
                    button1.BackgroundImageLayout = ImageLayout.Stretch;
                    button1.Text = "Bed";

                    button2.BackgroundImage = Properties.Resources.Glass;
                    button2.BackgroundImageLayout = ImageLayout.Stretch;
                    button2.Text = "Glass";

                    button3.BackgroundImage = Properties.Resources.closet;
                    button3.BackgroundImageLayout = ImageLayout.Stretch;
                    button3.Text = "Closet";

                    button4.BackgroundImage = Properties.Resources.TV;
                    button4.BackgroundImageLayout = ImageLayout.Stretch;
                    button4.Text = "TV";

                    Answer = 3;

                    break;

                case 7:

                    lblQuestion.Text = "CAN BE USED TO STORE FOOD";

                    button1.BackgroundImage = Properties.Resources.dish;
                    button1.BackgroundImageLayout = ImageLayout.Stretch;
                    button1.Text = "Dish";

                    button2.BackgroundImage = Properties.Resources.couch;
                    button2.BackgroundImageLayout = ImageLayout.Stretch;
                    button2.Text = "Couch";

                    button3.BackgroundImage = Properties.Resources.fridge;
                    button3.BackgroundImageLayout = ImageLayout.Stretch;
                    button3.Text = "Spoon";

                    button4.BackgroundImage = Properties.Resources.spoon;
                    button4.BackgroundImageLayout = ImageLayout.Stretch;
                    button4.Text = "Fridge";

                    Answer = 3;

                    break;


                case 8:

                    lblQuestion.Text = "IT IS USED TO WATCH MOVIES, NEWS AND OTHER ENTERTAINING PROGRAMS";

                    button1.BackgroundImage = Properties.Resources.car;
                    button1.BackgroundImageLayout = ImageLayout.Stretch;
                    button1.Text = "car";

                    button2.BackgroundImage = Properties.Resources.couch;
                    button2.BackgroundImageLayout = ImageLayout.Stretch;
                    button2.Text = "Couch";

                    button3.BackgroundImage = Properties.Resources.TV;
                    button3.BackgroundImageLayout = ImageLayout.Stretch;
                    button3.Text = "TV";

                    button4.BackgroundImage = Properties.Resources.spoon;
                    button4.BackgroundImageLayout = ImageLayout.Stretch;
                    button4.Text = "Fridge";

                    Answer = 3;

                    break;

                case 9:

                    lblQuestion.Text = "WHEN YOU A PHONE RAN OUT POWER, IT CAN BE USED RECHRAGE IT";

                    button1.BackgroundImage = Properties.Resources.Glass;
                    button1.BackgroundImageLayout = ImageLayout.Stretch;
                    button1.Text = "Glass";

                    button2.BackgroundImage = Properties.Resources.charger;
                    button2.BackgroundImageLayout = ImageLayout.Stretch;
                    button2.Text = "Charger";

                    button3.BackgroundImage = Properties.Resources.buikding;

                    button3.BackgroundImageLayout = ImageLayout.Stretch;
                    button3.Text = "Building";

                    button4.BackgroundImage = Properties.Resources.phone;
                    button4.BackgroundImageLayout = ImageLayout.Stretch;
                    button4.Text = "Phone";

                    Answer = 2;

                    break;

                case 10:

                    lblQuestion.Text = "WHEN YOU ARE ON YOUR COUCH YOU USE THIS DEVICE TO CHANGE TV CHANNELS";

                    button1.BackgroundImage = Properties.Resources.radio;
                    button1.BackgroundImageLayout = ImageLayout.Stretch;
                    button1.Text = "Radio";

                    button2.BackgroundImage = Properties.Resources.bed;
                    button2.BackgroundImageLayout = ImageLayout.Stretch;
                    button2.Text = "Bed";

                    button3.BackgroundImage = Properties.Resources.TV;
                    button3.BackgroundImageLayout = ImageLayout.Stretch;
                    button3.Text = "TV";

                    button4.BackgroundImage = Properties.Resources.remote;
                    button4.BackgroundImageLayout = ImageLayout.Stretch;
                    button4.Text = "Remote";

                    Answer = 4;

                    break;

            }

        }
        int Percentage;
        private void AnsweCheck(object sender, EventArgs e)
        {
            sound.Play();

            
            var senderObject = (Button)sender;

            //converting a button tag from a string to integer
            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if (buttonTag == Answer) {TotalAnswers++;}
            if (Questions == Total)
            {
                //changing a percentage from double into integer
                Percentage = (int)Math.Round((double)(TotalAnswers * 100) / Total);

            MessageBox.Show

             ("You Completed the Quiz!\n"+"Your got\t"+TotalAnswers+"questions correctly.\n"+"You got \t"+Percentage+"%\n");

                TotalAnswers = 0;

                Questions = 0;

                Questioning(Questions);

            }
            Questions++;

            Questioning(Questions);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}


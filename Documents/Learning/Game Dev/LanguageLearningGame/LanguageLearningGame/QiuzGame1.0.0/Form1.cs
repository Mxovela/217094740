using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QiuzGame1._0._0
{
    public partial class Form1 : Form
    {
        int Score;
        int Percentage;
        int Questions = 1;
        int Answer;
        int Total;
        public Form1()
        {
            

            InitializeComponent();

            askQuestion(Questions);
            Total = 7;
        }
        //Asking questions page
        private void askQuestion(int QuestionNUmber)
        {
            switch (QuestionNUmber)
            {
                case 1:

                    lblQuestion.Text = "It is used to travel long distance";

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

                    lblQuestion.Text = "Used to drink coffe";

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

                    lblQuestion.Text = "it is comfortable and used to sleep";


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

                    lblQuestion.Text = "when you are playing video games you use it to control game objects";

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

                    lblQuestion.Text = "It is a device used to communocate with a person far away from you";


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

                    lblQuestion.Text = "You put in your clean clothes on";

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

                    lblQuestion.Text = "It is used to put food in mouth";

                    button1.BackgroundImage = Properties.Resources.dish;
                    button1.BackgroundImageLayout = ImageLayout.Stretch;
                    button1.Text = "Dish";

                    button2.BackgroundImage = Properties.Resources.couch;
                    button2.BackgroundImageLayout = ImageLayout.Stretch;
                    button2.Text = "Couch";

                    button3.BackgroundImage = Properties.Resources.spoon;
                    button3.BackgroundImageLayout = ImageLayout.Stretch;
                    button3.Text = "Spoon";

                    button4.BackgroundImage = Properties.Resources.fridge;
                    button4.BackgroundImageLayout = ImageLayout.Stretch;
                    button4.Text = "Fridge";

                    Answer = 3;

                    break;
            }

        }
        private void checkAnswerEvent(object sender, EventArgs e)
        {
            Questions++;

            askQuestion(Questions);
            var senderObject = (Button)sender;

            //converting a button tag from a string to integer
            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if (buttonTag == Answer) { Score++; }
            if (Questions == Total)
            {
                //changing a percentage from double into integer
                Percentage = (int)Math.Round((double)(Score * 100) / Total);

                MessageBox.Show(

                    "You Completed the Quiz!\n" +

                    "Your got\t" + Score + " questions correctly.\n" +

                    "You got \t" + Percentage + "%\n"
                    );

                Score = 0;

                Questions = 0;

                askQuestion(Questions);

            }
        }
    }
}

namespace quizgame
{
    public class Form1
    {
        public Form1()
        {
        }

        public DialogResult ShowDialog()
        {
            throw new NotImplementedException();
        }
    }
}
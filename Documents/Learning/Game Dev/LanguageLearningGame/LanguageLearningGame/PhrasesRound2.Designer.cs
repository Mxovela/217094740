
namespace LanguageLearningGame
{
    partial class PhrasesRound2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhrasesRound2));
            this.btnHome = new System.Windows.Forms.Button();
            this.btnSound = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnContinue = new System.Windows.Forms.Button();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblPhrase = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnOption1 = new System.Windows.Forms.Button();
            this.btnOption3 = new System.Windows.Forms.Button();
            this.btnOption2 = new System.Windows.Forms.Button();
            this.btnOption4 = new System.Windows.Forms.Button();
            this.btnRET = new System.Windows.Forms.Button();
            this.btnTranslate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btnHome.Location = new System.Drawing.Point(16, 17);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(117, 47);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnSound
            // 
            this.btnSound.FlatAppearance.BorderSize = 0;
            this.btnSound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSound.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSound.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btnSound.Location = new System.Drawing.Point(586, 21);
            this.btnSound.Margin = new System.Windows.Forms.Padding(4);
            this.btnSound.Name = "btnSound";
            this.btnSound.Size = new System.Drawing.Size(117, 47);
            this.btnSound.TabIndex = 1;
            this.btnSound.Text = "Sound";
            this.btnSound.UseVisualStyleBackColor = true;
            this.btnSound.Click += new System.EventHandler(this.btnSound_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.Orange;
            this.btnCheck.FlatAppearance.BorderSize = 0;
            this.btnCheck.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheck.Location = new System.Drawing.Point(195, 555);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(340, 47);
            this.btnCheck.TabIndex = 3;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnContinue
            // 
            this.btnContinue.BackColor = System.Drawing.Color.Orange;
            this.btnContinue.FlatAppearance.BorderSize = 0;
            this.btnContinue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinue.Location = new System.Drawing.Point(195, 513);
            this.btnContinue.Margin = new System.Windows.Forms.Padding(4);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(340, 47);
            this.btnContinue.TabIndex = 4;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = false;
            this.btnContinue.Visible = false;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.lblInstructions.Location = new System.Drawing.Point(35, 115);
            this.lblInstructions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(501, 26);
            this.lblInstructions.TabIndex = 5;
            this.lblInstructions.Text = "Choose the correct translation for the sentence below:";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.lblScore.Location = new System.Drawing.Point(377, 25);
            this.lblScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(36, 33);
            this.lblScore.TabIndex = 12;
            this.lblScore.Text = " 0";
            // 
            // lblPhrase
            // 
            this.lblPhrase.AutoSize = true;
            this.lblPhrase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPhrase.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhrase.Location = new System.Drawing.Point(34, 150);
            this.lblPhrase.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhrase.Name = "lblPhrase";
            this.lblPhrase.Size = new System.Drawing.Size(275, 33);
            this.lblPhrase.TabIndex = 13;
            this.lblPhrase.Text = "Die voël vlieg in die lug";
            this.lblPhrase.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(292, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 54);
            this.button1.TabIndex = 18;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnOption1
            // 
            this.btnOption1.BackColor = System.Drawing.Color.Coral;
            this.btnOption1.FlatAppearance.BorderSize = 0;
            this.btnOption1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnOption1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOption1.Location = new System.Drawing.Point(383, 409);
            this.btnOption1.Name = "btnOption1";
            this.btnOption1.Size = new System.Drawing.Size(104, 49);
            this.btnOption1.TabIndex = 19;
            this.btnOption1.Text = "The bird flies in the sky";
            this.btnOption1.UseVisualStyleBackColor = false;
            this.btnOption1.Click += new System.EventHandler(this.btnOption1_Click);
            // 
            // btnOption3
            // 
            this.btnOption3.BackColor = System.Drawing.Color.Coral;
            this.btnOption3.FlatAppearance.BorderSize = 0;
            this.btnOption3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnOption3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOption3.Location = new System.Drawing.Point(130, 409);
            this.btnOption3.Name = "btnOption3";
            this.btnOption3.Size = new System.Drawing.Size(104, 49);
            this.btnOption3.TabIndex = 20;
            this.btnOption3.Text = "The bird is flying";
            this.btnOption3.UseVisualStyleBackColor = false;
            this.btnOption3.Click += new System.EventHandler(this.btnOption3_Click);
            // 
            // btnOption2
            // 
            this.btnOption2.BackColor = System.Drawing.Color.Coral;
            this.btnOption2.FlatAppearance.BorderSize = 0;
            this.btnOption2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnOption2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOption2.Location = new System.Drawing.Point(255, 409);
            this.btnOption2.Name = "btnOption2";
            this.btnOption2.Size = new System.Drawing.Size(104, 49);
            this.btnOption2.TabIndex = 21;
            this.btnOption2.Text = "I\'m driving the car";
            this.btnOption2.UseVisualStyleBackColor = false;
            this.btnOption2.Click += new System.EventHandler(this.btnOption2_Click);
            // 
            // btnOption4
            // 
            this.btnOption4.BackColor = System.Drawing.Color.Coral;
            this.btnOption4.FlatAppearance.BorderSize = 0;
            this.btnOption4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnOption4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOption4.Location = new System.Drawing.Point(512, 409);
            this.btnOption4.Name = "btnOption4";
            this.btnOption4.Size = new System.Drawing.Size(104, 49);
            this.btnOption4.TabIndex = 22;
            this.btnOption4.Text = "The cat is purring";
            this.btnOption4.UseVisualStyleBackColor = false;
            this.btnOption4.Click += new System.EventHandler(this.btnOption4_Click);
            // 
            // btnRET
            // 
            this.btnRET.BackColor = System.Drawing.Color.Coral;
            this.btnRET.FlatAppearance.BorderSize = 0;
            this.btnRET.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnRET.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRET.Location = new System.Drawing.Point(570, 150);
            this.btnRET.Name = "btnRET";
            this.btnRET.Size = new System.Drawing.Size(88, 36);
            this.btnRET.TabIndex = 24;
            this.btnRET.Text = "Translate";
            this.btnRET.UseVisualStyleBackColor = false;
            this.btnRET.Click += new System.EventHandler(this.btnTranslate_Click);
            // 
            // btnTranslate
            // 
            this.btnTranslate.BackColor = System.Drawing.Color.Coral;
            this.btnTranslate.FlatAppearance.BorderSize = 0;
            this.btnTranslate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnTranslate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTranslate.Location = new System.Drawing.Point(570, 150);
            this.btnTranslate.Name = "btnTranslate";
            this.btnTranslate.Size = new System.Drawing.Size(88, 36);
            this.btnTranslate.TabIndex = 25;
            this.btnTranslate.Text = "Translate";
            this.btnTranslate.UseVisualStyleBackColor = false;
            this.btnTranslate.Click += new System.EventHandler(this.btnTranslate_Click_1);
            // 
            // PhrasesRound2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(735, 627);
            this.Controls.Add(this.btnTranslate);
            this.Controls.Add(this.btnRET);
            this.Controls.Add(this.btnOption4);
            this.Controls.Add(this.btnOption2);
            this.Controls.Add(this.btnOption3);
            this.Controls.Add(this.btnOption1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblPhrase);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnSound);
            this.Controls.Add(this.btnHome);
            this.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PhrasesRound2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Round 2";
            this.Load += new System.EventHandler(this.LearnGreetingsRound2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnSound;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblPhrase;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnOption1;
        private System.Windows.Forms.Button btnOption3;
        private System.Windows.Forms.Button btnOption2;
        private System.Windows.Forms.Button btnOption4;
        private System.Windows.Forms.Button btnRET;
        private System.Windows.Forms.Button btnTranslate;
    }
}
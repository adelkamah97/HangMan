namespace HangMan
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ltr = new System.Windows.Forms.TextBox();
            this.rmlives = new System.Windows.Forms.TextBox();
            this.lettresnon = new System.Windows.Forms.TextBox();
            this.word = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.test = new System.Windows.Forms.Button();
            this.lable2 = new System.Windows.Forms.Label();
            this.lable3 = new System.Windows.Forms.Label();
            this.lable4 = new System.Windows.Forms.Label();
            this.replay = new System.Windows.Forms.Button();
            this.pondu = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pondu)).BeginInit();
            this.SuspendLayout();
            // 
            // ltr
            // 
            this.ltr.BackColor = System.Drawing.Color.NavajoWhite;
            this.ltr.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ltr.Location = new System.Drawing.Point(284, 490);
            this.ltr.Name = "ltr";
            this.ltr.Size = new System.Drawing.Size(84, 39);
            this.ltr.TabIndex = 1;
            this.ltr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rmlives
            // 
            this.rmlives.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rmlives.Location = new System.Drawing.Point(284, 84);
            this.rmlives.Multiline = true;
            this.rmlives.Name = "rmlives";
            this.rmlives.ReadOnly = true;
            this.rmlives.Size = new System.Drawing.Size(71, 54);
            this.rmlives.TabIndex = 2;
            this.rmlives.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lettresnon
            // 
            this.lettresnon.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lettresnon.Location = new System.Drawing.Point(284, 210);
            this.lettresnon.Multiline = true;
            this.lettresnon.Name = "lettresnon";
            this.lettresnon.ReadOnly = true;
            this.lettresnon.Size = new System.Drawing.Size(227, 44);
            this.lettresnon.TabIndex = 3;
            this.lettresnon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // word
            // 
            this.word.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.word.Location = new System.Drawing.Point(284, 341);
            this.word.Multiline = true;
            this.word.Name = "word";
            this.word.ReadOnly = true;
            this.word.Size = new System.Drawing.Size(310, 44);
            this.word.TabIndex = 4;
            this.word.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(21, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "Remaining lives :";
            // 
            // test
            // 
            this.test.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.test.Location = new System.Drawing.Point(423, 472);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(171, 75);
            this.test.TabIndex = 9;
            this.test.Text = "Test the Lettre";
            this.test.UseVisualStyleBackColor = true;
            this.test.Click += new System.EventHandler(this.test_Click);
            // 
            // lable2
            // 
            this.lable2.AutoSize = true;
            this.lable2.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lable2.Location = new System.Drawing.Point(21, 193);
            this.lable2.Name = "lable2";
            this.lable2.Size = new System.Drawing.Size(254, 74);
            this.lable2.TabIndex = 10;
            this.lable2.Text = "The word does not \r\ncontain the letters :";
            this.lable2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lable3
            // 
            this.lable3.AutoSize = true;
            this.lable3.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lable3.Location = new System.Drawing.Point(21, 341);
            this.lable3.Name = "lable3";
            this.lable3.Size = new System.Drawing.Size(150, 37);
            this.lable3.TabIndex = 11;
            this.lable3.Text = "The Word :";
            // 
            // lable4
            // 
            this.lable4.AutoSize = true;
            this.lable4.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lable4.Location = new System.Drawing.Point(21, 502);
            this.lable4.Name = "lable4";
            this.lable4.Size = new System.Drawing.Size(197, 37);
            this.lable4.TabIndex = 12;
            this.lable4.Text = "Write a Lettre :";
            // 
            // replay
            // 
            this.replay.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.replay.Location = new System.Drawing.Point(245, 635);
            this.replay.Name = "replay";
            this.replay.Size = new System.Drawing.Size(132, 54);
            this.replay.TabIndex = 13;
            this.replay.Text = "Replay";
            this.replay.UseVisualStyleBackColor = true;
            this.replay.Click += new System.EventHandler(this.replay_Click);
            // 
            // pondu
            // 
            this.pondu.ErrorImage = null;
            this.pondu.InitialImage = null;
            this.pondu.Location = new System.Drawing.Point(692, 25);
            this.pondu.Name = "pondu";
            this.pondu.Size = new System.Drawing.Size(400, 621);
            this.pondu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pondu.TabIndex = 14;
            this.pondu.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1104, 701);
            this.Controls.Add(this.pondu);
            this.Controls.Add(this.replay);
            this.Controls.Add(this.lable4);
            this.Controls.Add(this.lable3);
            this.Controls.Add(this.lable2);
            this.Controls.Add(this.test);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.word);
            this.Controls.Add(this.lettresnon);
            this.Controls.Add(this.rmlives);
            this.Controls.Add(this.ltr);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HangMan Game 1.0";
            ((System.ComponentModel.ISupportInitialize)(this.pondu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox ltr;
        private TextBox rmlives;
        private TextBox lettresnon;
        private TextBox word;
        private Label label1;
        private Button test;
        private Label lable2;
        private Label lable3;
        private Label lable4;
        private Button replay;
        private PictureBox pondu;
    }
}
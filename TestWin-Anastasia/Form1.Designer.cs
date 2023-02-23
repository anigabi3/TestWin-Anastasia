namespace TestWin_Anastasia
{
    partial class fr1
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.gr2 = new System.Windows.Forms.GroupBox();
            this.cb1 = new System.Windows.Forms.CheckBox();
            this.gb2 = new System.Windows.Forms.GroupBox();
            this.rb4 = new System.Windows.Forms.RadioButton();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.tx2 = new System.Windows.Forms.TextBox();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.lb3 = new System.Windows.Forms.Label();
            this.cmb1 = new System.Windows.Forms.ComboBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.gr2.SuspendLayout();
            this.gb2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(31, 47);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(60, 20);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Автори";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(232, 49);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(72, 20);
            this.lb2.TabIndex = 3;
            this.lb2.Text = "Заглавия";
            // 
            // gr2
            // 
            this.gr2.Controls.Add(this.cb1);
            this.gr2.Location = new System.Drawing.Point(550, 260);
            this.gr2.Name = "gr2";
            this.gr2.Size = new System.Drawing.Size(165, 64);
            this.gr2.TabIndex = 4;
            this.gr2.TabStop = false;
            this.gr2.Text = "Корица";
            // 
            // cb1
            // 
            this.cb1.AutoSize = true;
            this.cb1.Location = new System.Drawing.Point(6, 26);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(67, 24);
            this.cb1.TabIndex = 8;
            this.cb1.Text = "Мека";
            this.cb1.UseVisualStyleBackColor = true;
            // 
            // gb2
            // 
            this.gb2.Controls.Add(this.rb4);
            this.gb2.Controls.Add(this.rb3);
            this.gb2.Controls.Add(this.rb2);
            this.gb2.Controls.Add(this.rb1);
            this.gb2.Location = new System.Drawing.Point(35, 226);
            this.gb2.Name = "gb2";
            this.gb2.Size = new System.Drawing.Size(147, 169);
            this.gb2.TabIndex = 5;
            this.gb2.TabStop = false;
            this.gb2.Text = "Издателство";
            // 
            // rb4
            // 
            this.rb4.AutoSize = true;
            this.rb4.Location = new System.Drawing.Point(11, 126);
            this.rb4.Name = "rb4";
            this.rb4.Size = new System.Drawing.Size(103, 24);
            this.rb4.TabIndex = 3;
            this.rb4.TabStop = true;
            this.rb4.Text = "Мармалад";
            this.rb4.UseVisualStyleBackColor = true;
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.Location = new System.Drawing.Point(11, 96);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(90, 24);
            this.rb3.TabIndex = 2;
            this.rb3.TabStop = true;
            this.rb3.Text = "Архимет";
            this.rb3.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(12, 66);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(96, 24);
            this.rb2.TabIndex = 1;
            this.rb2.TabStop = true;
            this.rb2.Text = "Просвета";
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Location = new System.Drawing.Point(13, 34);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(61, 24);
            this.rb1.TabIndex = 0;
            this.rb1.TabStop = true;
            this.rb1.Text = "Зевс";
            this.rb1.UseVisualStyleBackColor = true;
            // 
            // tx2
            // 
            this.tx2.Location = new System.Drawing.Point(31, 70);
            this.tx2.Name = "tx2";
            this.tx2.Size = new System.Drawing.Size(125, 27);
            this.tx2.TabIndex = 6;
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(232, 72);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(125, 27);
            this.tb2.TabIndex = 7;
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Location = new System.Drawing.Point(442, 47);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(48, 20);
            this.lb3.TabIndex = 8;
            this.lb3.Text = "Жанр";
            // 
            // cmb1
            // 
            this.cmb1.FormattingEnabled = true;
            this.cmb1.Items.AddRange(new object[] {
            "Художествен",
            "Научно-популярен",
            "Справочна"});
            this.cmb1.Location = new System.Drawing.Point(442, 72);
            this.cmb1.Name = "cmb1";
            this.cmb1.Size = new System.Drawing.Size(151, 28);
            this.cmb1.TabIndex = 9;
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.LightGreen;
            this.btn1.Location = new System.Drawing.Point(598, 405);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(168, 34);
            this.btn1.TabIndex = 10;
            this.btn1.Text = "Потвърждавате ли";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.Sienna;
            this.btn2.Location = new System.Drawing.Point(611, 366);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(135, 33);
            this.btn2.TabIndex = 11;
            this.btn2.Text = "Отпечатване";
            this.btn2.UseVisualStyleBackColor = false;
            // 
            // fr1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.cmb1);
            this.Controls.Add(this.lb3);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.tx2);
            this.Controls.Add(this.gb2);
            this.Controls.Add(this.gr2);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lbl1);
            this.Name = "fr1";
            this.Text = "Книжарница";
            this.gr2.ResumeLayout(false);
            this.gr2.PerformLayout();
            this.gb2.ResumeLayout(false);
            this.gb2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl1;
        private Label lb2;
        private GroupBox gr2;
        private GroupBox gb2;
        private RadioButton rb4;
        private RadioButton rb3;
        private RadioButton rb2;
        private RadioButton rb1;
        private TextBox tx2;
        private TextBox tb2;
        private CheckBox cb1;
        private Label lb3;
        private ComboBox cmb1;
        private Button btn1;
        private Button btn2;
    }
}
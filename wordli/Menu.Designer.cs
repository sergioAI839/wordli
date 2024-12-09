namespace wordli
{
    partial class Menu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.buttonPlay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSetting = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.level1 = new System.Windows.Forms.Button();
            this.level2 = new System.Windows.Forms.Button();
            this.level3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPlay
            // 
            this.buttonPlay.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonPlay.Location = new System.Drawing.Point(254, 159);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(75, 23);
            this.buttonPlay.TabIndex = 0;
            this.buttonPlay.Text = "Играть";
            this.buttonPlay.UseVisualStyleBackColor = false;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            this.buttonPlay.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.buttonPlay.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(215, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "WORLD-LI";
            // 
            // buttonSetting
            // 
            this.buttonSetting.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSetting.Location = new System.Drawing.Point(254, 201);
            this.buttonSetting.Name = "buttonSetting";
            this.buttonSetting.Size = new System.Drawing.Size(75, 23);
            this.buttonSetting.TabIndex = 6;
            this.buttonSetting.Text = "Настройки";
            this.buttonSetting.UseVisualStyleBackColor = false;
            this.buttonSetting.MouseEnter += new System.EventHandler(this.button4_MouseEnter);
            this.buttonSetting.MouseLeave += new System.EventHandler(this.button4_MouseLeave);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Location = new System.Drawing.Point(254, 242);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            this.buttonExit.MouseEnter += new System.EventHandler(this.button2_MouseEnter);
            this.buttonExit.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            // 
            // level1
            // 
            this.level1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.level1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.level1.Location = new System.Drawing.Point(13, 13);
            this.level1.Name = "level1";
            this.level1.Size = new System.Drawing.Size(75, 23);
            this.level1.TabIndex = 8;
            this.level1.Text = "Уровень-1";
            this.level1.UseVisualStyleBackColor = false;
            this.level1.Visible = false;
            this.level1.Click += new System.EventHandler(this.button1_Click);
            this.level1.MouseEnter += new System.EventHandler(this.level1_MouseEnter);
            this.level1.MouseLeave += new System.EventHandler(this.level1_MouseLeave);
            // 
            // level2
            // 
            this.level2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.level2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.level2.Location = new System.Drawing.Point(12, 72);
            this.level2.Name = "level2";
            this.level2.Size = new System.Drawing.Size(75, 23);
            this.level2.TabIndex = 9;
            this.level2.Text = "Уровень-2";
            this.level2.UseVisualStyleBackColor = false;
            this.level2.Visible = false;
            this.level2.Click += new System.EventHandler(this.button2_Click);
            this.level2.MouseEnter += new System.EventHandler(this.level2_MouseEnter);
            this.level2.MouseLeave += new System.EventHandler(this.level2_MouseLeave);
            // 
            // level3
            // 
            this.level3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.level3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.level3.Location = new System.Drawing.Point(13, 131);
            this.level3.Name = "level3";
            this.level3.Size = new System.Drawing.Size(75, 23);
            this.level3.TabIndex = 10;
            this.level3.Text = "Уровень-3";
            this.level3.UseVisualStyleBackColor = false;
            this.level3.Visible = false;
            this.level3.Click += new System.EventHandler(this.button3_Click);
            this.level3.MouseEnter += new System.EventHandler(this.level3_MouseEnter);
            this.level3.MouseLeave += new System.EventHandler(this.level3_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(94, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Слово состоит из 4-ёх букв";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(93, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Слово состоит из 5-и букв";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(94, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Слово состоит из 6-и букв";
            this.label4.Visible = false;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Location = new System.Drawing.Point(12, 190);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 14;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Visible = false;
            this.buttonBack.Click += new System.EventHandler(this.button1_Click_1);
            this.buttonBack.MouseEnter += new System.EventHandler(this.buttonBack_MouseEnter);
            this.buttonBack.MouseLeave += new System.EventHandler(this.buttonBack_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(570, 450);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.level3);
            this.Controls.Add(this.level2);
            this.Controls.Add(this.level1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonSetting);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonPlay);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "WORLD-LI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSetting;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button level1;
        private System.Windows.Forms.Button level2;
        private System.Windows.Forms.Button level3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonBack;
    }
}


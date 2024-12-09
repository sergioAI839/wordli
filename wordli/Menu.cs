using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wordli
{
    public partial class Menu : Form
    {
        int g;
        private int BordSizeorg;
        private Color BordColororg;
        public Menu()
        {
            InitializeComponent();
            BordSizeorg = buttonPlay.FlatAppearance.BorderSize;
            BordColororg = buttonPlay.FlatAppearance.BorderColor;
            buttonPlay.FlatStyle = FlatStyle.Flat;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        #region Работа с кнопками
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            buttonPlay.BackColor = Color.Gray;
            buttonPlay.FlatAppearance.BorderSize = 1;
            buttonPlay.FlatAppearance.BorderColor = Color.Green;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            buttonPlay.BackColor= Color.White;
            buttonPlay.FlatAppearance.BorderSize = BordSizeorg;
            buttonPlay.FlatAppearance.BorderColor = BordColororg;
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            buttonSetting.BackColor = Color.Gray;
            buttonSetting.FlatAppearance.BorderSize = 1;
            buttonSetting.FlatAppearance.BorderColor = Color.Green;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            buttonSetting.BackColor = Color.White;
            buttonSetting.FlatAppearance.BorderSize = BordSizeorg;
            buttonSetting.FlatAppearance.BorderColor = BordColororg;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            buttonExit.BackColor = Color.White;
            buttonExit.FlatAppearance.BorderSize = BordSizeorg;
            buttonExit.FlatAppearance.BorderColor = BordColororg;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            buttonExit.BackColor = Color.Gray;
            buttonExit.FlatAppearance.BorderSize = 1;
            buttonExit.FlatAppearance.BorderColor = Color.Green;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Game_panel ert = new Game_panel();
            ert.GetLevel1(ert);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Game_panel ert = new Game_panel();
           ert.GetLevel2(ert);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Game_panel ert = new Game_panel();
            ert.GetLevel3(ert);
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            buttonPlay.Visible = false;
            buttonExit.Visible = false;
            buttonSetting.Visible = false;
            label1.Visible = false;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            level1.Visible = true;
            level2.Visible = true;
            level3.Visible = true;
            buttonBack.Visible = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            buttonPlay.Visible = true;
            buttonExit.Visible = true;
            buttonSetting.Visible = true;
            label1.Visible = true;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            level1.Visible = false;
            level2.Visible = false;
            level3.Visible = false;
            buttonBack.Visible = false;
        }
        #endregion

        private void level1_MouseEnter(object sender, EventArgs e)
        {
            level1.BackColor = Color.Gray;
            level1.FlatAppearance.BorderSize = 1;
            level1.FlatAppearance.BorderColor = Color.Green;
        }

        private void level1_MouseLeave(object sender, EventArgs e)
        {
            level1.BackColor = Color.White;
            level1.FlatAppearance.BorderSize = BordSizeorg;
            level1.FlatAppearance.BorderColor = BordColororg;
        }

        private void level2_MouseLeave(object sender, EventArgs e)
        {
            level2.BackColor = Color.White;
            level2.FlatAppearance.BorderSize = BordSizeorg;
            level2.FlatAppearance.BorderColor = BordColororg;
        }

        private void level2_MouseEnter(object sender, EventArgs e)
        {
            level2.BackColor = Color.Gray;
            level2.FlatAppearance.BorderSize = 1;
            level2.FlatAppearance.BorderColor = Color.Green;
        }

        private void level3_MouseLeave(object sender, EventArgs e)
        {
            level3.BackColor = Color.White;
            level3.FlatAppearance.BorderSize = BordSizeorg;
            level3.FlatAppearance.BorderColor = BordColororg;
        }

        private void level3_MouseEnter(object sender, EventArgs e)
        {
            level3.BackColor = Color.Gray;
            level3.FlatAppearance.BorderSize = 1;
            level3.FlatAppearance.BorderColor = Color.Green;
        }

        private void buttonBack_MouseLeave(object sender, EventArgs e)
        {
            buttonBack.BackColor = Color.White;
            buttonBack.FlatAppearance.BorderSize = BordSizeorg;
            buttonBack.FlatAppearance.BorderColor = BordColororg;
        }

        private void buttonBack_MouseEnter(object sender, EventArgs e)
        {
            buttonBack.BackColor = Color.Gray;
            buttonBack.FlatAppearance.BorderSize = 1;
            buttonBack.FlatAppearance.BorderColor = Color.Green;
        }
    }
}

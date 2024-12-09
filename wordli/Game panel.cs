using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace wordli
{
    public partial class Game_panel : Form
    {
        int l;
        public string sr;

        levele1 lev1 = new levele1 ();
        levele2 lev2 = new levele2 ();
        levele3 lev3 = new levele3 ();
        List<System.Windows.Forms.TextBox> listtext = new List<System.Windows.Forms.TextBox>();
        public Game_panel()
        {
            InitializeComponent();
        }
        #region методы запуска опр. уровня
        public void GetLevel1(Game_panel ert)
        {
            
            ert.textBox4.Visible = false;
            ert.textBox10.Visible = false;
            ert.textBox16.Visible = false;
            ert.textBox22.Visible = false;
            ert.textBox28.Visible = false;
            ert.textBox5.Visible = false;
            ert.textBox11.Visible = false;
            ert.textBox17.Visible = false;
            ert.textBox23.Visible = false;
            ert.textBox29.Visible = false;
            ert.Show();
            for (int i = 0; i < 28; i++)
            {
                if ((i == 4) || (i == 10) || (i == 16) || (i == 22))
                {
                    i += 2;
                }
               listtext.Add((System.Windows.Forms.TextBox)ert.Controls.Find("textBox" + i, true)[0]);
            }
            l = 1;
            sr = lev1.Getword();
        }
        public void GetLevel2(Game_panel ert)
        {
            ert.textBox5.Visible = false;
            ert.textBox11.Visible = false;
            ert.textBox17.Visible = false;
            ert.textBox23.Visible = false;
            ert.textBox29.Visible = false;
            ert.Show();
            for (int i = 0; i < 29; i++)
            {
                if ((i == 5) || (i == 11) || (i == 17) || (i == 23))
                {
                    i += 1;
                }
                listtext.Add((System.Windows.Forms.TextBox)ert.Controls.Find("textBox" + i, true)[0]);
            }
            l = 2;
            sr = lev2.Getword();
        }
        public void Goendfo1(List<System.Windows.Forms.TextBox> listtext, string sr)
        {
            if (listtext[listtext.Count-1].Text != "")
            {
                if ((sr[sr.Length-1].ToString() == listtext[listtext.Count - 1].Text) &&
                        (sr[sr.Length-2].ToString() == listtext[listtext.Count - 2].Text) &&
                         (sr[sr.Length - 3].ToString() == listtext[listtext.Count - 3].Text))
                {
                    MessageBox.Show("Вы победили!!!!!");
                }
                else
                {
                    MessageBox.Show("Вы прогиграли");
                }

            }
        }
        public void GetLevel3(Game_panel ert)
        {
            ert.Show();
            for (int i = 0; i < 30; i++)
            {
                listtext.Add((System.Windows.Forms.TextBox)ert.Controls.Find("textBox" + i, true)[0]);
            }
            l = 3;
            sr = lev3.Getword();
        }
        #endregion 

        private void button1_Click(object sender, EventArgs e)
        {
            switch (l)
            {
                case 1:
                    {
                        int r = 0;
                        label1.Text = sr;
                        Goendfo1(listtext, sr);
                        for (int i = 0; i < 5; i++)
                        {
                            if ((listtext[r].Text == sr[0].ToString()) &&
                                    (listtext[r + 1].Text == sr[1].ToString()) &&
                                    (listtext[r + 2].Text == sr[2].ToString()) &&
                                    (listtext[r + 3].Text == sr[3].ToString()))
                                MessageBox.Show("Вы победили!!!!!");
                            for (int j = 0; j < 4; j++)
                            {
                                if (listtext[r + j].Text == sr[j].ToString()) { listtext[r + j].BackColor = Color.Green; }
                                else
                                {
                                    for (int k = 0; k < 4; k++)
                                    {
                                        if (listtext[r + j].Text == sr[k].ToString()) { listtext[r + j].BackColor = Color.Yellow; }
                                    }
                                }
                            }

                            r += 4;
                        }
                } break;
                case 2:
                {
                        int r = 0;
                        label1.Text = sr;
                        Goendfo1(listtext, sr);
                        for (int i = 0; i < 5; i++)
                        {
                            if ((listtext[r].Text == sr[0].ToString()) &&
                                    (listtext[r + 1].Text == sr[1].ToString()) &&
                                    (listtext[r + 2].Text == sr[2].ToString()) &&
                                    (listtext[r + 3].Text == sr[3].ToString())&&
                                     (listtext[r + 4].Text == sr[4].ToString()))
                                MessageBox.Show("Вы победили!!!!!");
                            for (int j = 0; j < 5; j++)
                            {
                                if (listtext[r + j].Text == sr[j].ToString()) { listtext[r + j].BackColor = Color.Green; }
                                else
                                {
                                    for (int k = 0; k < 5; k++)
                                    {
                                        if (listtext[r + j].Text == sr[k].ToString()) { listtext[r + j].BackColor = Color.Yellow; }
                                    }
                                }
                            }

                            r += 5;
                        }
                        break;
                }
            case 3:
                {
                        int r = 0;
                        label1.Text = sr;
                        Goendfo1(listtext, sr);
                        for (int i = 0; i < 5; i++)
                        {
                            if ((listtext[r].Text == sr[0].ToString()) &&
                                    (listtext[r + 1].Text == sr[1].ToString()) &&
                                    (listtext[r + 2].Text == sr[2].ToString()) &&
                                    (listtext[r + 3].Text == sr[3].ToString()) &&
                                    (listtext[r + 4].Text == sr[4].ToString())&&
                                    (listtext[r + 5].Text == sr[5].ToString()))
                                MessageBox.Show("Вы победили!!!!!");
                            for (int j = 0; j < 6; j++)
                            {
                                if (listtext[r + j].Text == sr[j].ToString()) { listtext[r + j].BackColor = Color.Green; }
                                else
                                {
                                    for (int k = 0; k < 6; k++)
                                    {
                                        if (listtext[r + j].Text == sr[k].ToString()) { listtext[r + j].BackColor = Color.Yellow; }
                                    }
                                }
                            }

                            r += 6;
                        }
                        break;
                }
            } 
        }
    }
}

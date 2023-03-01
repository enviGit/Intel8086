using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INTEL_8086
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.listBox1.DrawMode = DrawMode.OwnerDrawVariable;
            this.listBox1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(listBox1_DrawItem);
            this.listBox1.SelectedIndexChanged += new System.EventHandler(listBox1_SelectedIndexChanged);
            this.listBox2.DrawMode = DrawMode.OwnerDrawVariable;
            this.listBox2.DrawItem += new System.Windows.Forms.DrawItemEventHandler(listBox2_DrawItem);
            this.listBox2.SelectedIndexChanged += new System.EventHandler(listBox2_SelectedIndexChanged);
        }
        private void listBox1_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            ListBox listBox = (ListBox)sender;
            e.ItemHeight = listBox.Font.Height;
        }
        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            ListBox listBox = (ListBox)sender;
            e.DrawBackground();
            Brush myBrush = Brushes.Black;

            string deger = listBox1.Items[e.Index].ToString();

            if (deger == "AX" || deger == "BX" || deger == "CX" || deger == "DX")
            {
                myBrush = Brushes.Orchid;
            }
            if (deger == "AH" || deger == "AL" || deger == "BH" || deger == "BL" || deger == "CH" || deger == "CL" || deger == "DH" || deger == "DL")
            {
                myBrush = Brushes.LightSkyBlue;
            }
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                myBrush = Brushes.Red;
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(0, 64, 64)), e.Bounds);
            }
            else
            {
                e.Graphics.FillRectangle(Brushes.White, e.Bounds);
            }

            e.Graphics.DrawString(listBox.Items[e.Index].ToString(), e.Font, myBrush, e.Bounds);
            e.DrawFocusRectangle();
        }
        private void listBox2_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            ListBox listBox = (ListBox)sender;
            e.ItemHeight = listBox.Font.Height;
        }
        private void listBox2_DrawItem(object sender, DrawItemEventArgs e)
        {
            ListBox listBox = (ListBox)sender;
            e.DrawBackground();
            Brush myBrush = Brushes.Black;

            string deger = listBox1.Items[e.Index].ToString();

            if (deger == "AX" || deger == "BX" || deger == "CX" || deger == "DX")
            {
                myBrush = Brushes.Orchid;
            }
            if (deger == "AH" || deger == "AL" || deger == "BH" || deger == "BL" || deger == "CH" || deger == "CL" || deger == "DH" || deger == "DL")
            {
                myBrush = Brushes.LightSkyBlue;
            }
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                myBrush = Brushes.Red;
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(0, 64, 64)), e.Bounds);
            }
            else
            {
                e.Graphics.FillRectangle(Brushes.White, e.Bounds);
            }

            e.Graphics.DrawString(listBox.Items[e.Index].ToString(), e.Font, myBrush, e.Bounds);
            e.DrawFocusRectangle();
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (new Regex(@"^[A-Fa-f0-9]+$").IsMatch(textBox2.Text) && textBox2.Text.Length == 4)
            {
                textBox2.BackColor = Color.LawnGreen;
            }
            else
            {
                textBox2.BackColor = Color.Red;
            }
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (new Regex(@"^[A-Fa-f0-9]+$").IsMatch(textBox3.Text) && textBox3.Text.Length == 4)
            {
                textBox3.BackColor = Color.LawnGreen;
            }
            else
            {
                textBox3.BackColor = Color.Red;
            }
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (new Regex(@"^[A-Fa-f0-9]+$").IsMatch(textBox4.Text) && textBox4.Text.Length == 4)
            {
                textBox4.BackColor = Color.LawnGreen;
            }
            else
            {
                textBox4.BackColor = Color.Red;
            }
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (new Regex(@"^[A-Fa-f0-9]+$").IsMatch(textBox5.Text) && textBox5.Text.Length == 4)
            {
                textBox5.BackColor = Color.LawnGreen;
            }
            else
            {
                textBox5.BackColor = Color.Red;
            }
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (new Regex(@"^[A-Fa-f0-9]+$").IsMatch(textBox6.Text) && textBox6.Text.Length == 2)
            {
                textBox6.BackColor = Color.LawnGreen;
            }
            else
            {
                textBox6.BackColor = Color.Red;
            }
        }
        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (new Regex(@"^[A-Fa-f0-9]+$").IsMatch(textBox7.Text) && textBox7.Text.Length == 2)
            {
                textBox7.BackColor = Color.LawnGreen;
            }
            else
            {
                textBox7.BackColor = Color.Red;
            }
        }
        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            if (new Regex(@"^[A-Fa-f0-9]+$").IsMatch(textBox9.Text) && textBox9.Text.Length == 2)
            {
                textBox9.BackColor = Color.LawnGreen;
            }
            else
            {
                textBox9.BackColor = Color.Red;
            }
        }
        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (new Regex(@"^[A-Fa-f0-9]+$").IsMatch(textBox8.Text) && textBox8.Text.Length == 2)
            {
                textBox8.BackColor = Color.LawnGreen;
            }
            else
            {
                textBox8.BackColor = Color.Red;
            }
        }
        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            if (new Regex(@"^[A-Fa-f0-9]+$").IsMatch(textBox11.Text) && textBox11.Text.Length == 2)
            {
                textBox11.BackColor = Color.LawnGreen;
            }
            else
            {
                textBox11.BackColor = Color.Red;
            }
        }
        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            if (new Regex(@"^[A-Fa-f0-9]+$").IsMatch(textBox10.Text) && textBox10.Text.Length == 2)
            {
                textBox10.BackColor = Color.LawnGreen;
            }
            else
            {
                textBox10.BackColor = Color.Red;
            }
        }
        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            if (new Regex(@"^[A-Fa-f0-9]+$").IsMatch(textBox13.Text) && textBox13.Text.Length == 2)
            {
                textBox13.BackColor = Color.LawnGreen;
            }
            else
            {
                textBox13.BackColor = Color.Red;
            }
        }
        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            if (new Regex(@"^[A-Fa-f0-9]+$").IsMatch(textBox12.Text) && textBox12.Text.Length == 2)
            {
                textBox12.BackColor = Color.LawnGreen;
            }
            else
            {
                textBox12.BackColor = Color.Red;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //AX
            if (listBox1.SelectedIndex == 0 && listBox2.SelectedIndex == 1)
            {
                textBox2.Text = textBox3.Text;

                if (textBox2 != null && !string.IsNullOrWhiteSpace(textBox2.Text) && textBox2.Text.Length == 4)
                {
                    textBox6.Text = textBox2.Text.Substring(0, 2);
                    textBox7.Text = textBox2.Text.Substring(2, 2);
                }

            }
            if (listBox1.SelectedIndex == 0 && listBox2.SelectedIndex == 2)
            {
                textBox2.Text = textBox4.Text;

                if (textBox2 != null && !string.IsNullOrWhiteSpace(textBox2.Text) && textBox2.Text.Length == 4)
                {
                    textBox6.Text = textBox2.Text.Substring(0, 2);
                    textBox7.Text = textBox2.Text.Substring(2, 2);
                }
            }
            if (listBox1.SelectedIndex == 0 && listBox2.SelectedIndex == 3)
            {
                textBox2.Text = textBox5.Text;

                if (textBox2 != null && !string.IsNullOrWhiteSpace(textBox2.Text) && textBox2.Text.Length == 4)
                {
                    textBox6.Text = textBox2.Text.Substring(0, 2);
                    textBox7.Text = textBox2.Text.Substring(2, 2);
                }
            }
            //BX
            if (listBox1.SelectedIndex == 1 && listBox2.SelectedIndex == 0)
            {
                textBox3.Text = textBox2.Text;

                if (textBox3 != null && !string.IsNullOrWhiteSpace(textBox3.Text) && textBox3.Text.Length == 4)
                {
                    textBox9.Text = textBox3.Text.Substring(0, 2);
                    textBox8.Text = textBox3.Text.Substring(2, 2);
                }

            }
            if (listBox1.SelectedIndex == 1 && listBox2.SelectedIndex == 2)
            {
                textBox3.Text = textBox4.Text;

                if (textBox3 != null && !string.IsNullOrWhiteSpace(textBox3.Text) && textBox3.Text.Length == 4)
                {
                    textBox9.Text = textBox3.Text.Substring(0, 2);
                    textBox8.Text = textBox3.Text.Substring(2, 2);
                }
            }
            if (listBox1.SelectedIndex == 1 && listBox2.SelectedIndex == 3)
            {
                textBox3.Text = textBox5.Text;

                if (textBox3 != null && !string.IsNullOrWhiteSpace(textBox3.Text) && textBox3.Text.Length == 4)
                {
                    textBox9.Text = textBox3.Text.Substring(0, 2);
                    textBox8.Text = textBox3.Text.Substring(2, 2);
                }
            }
            //CX
            if (listBox1.SelectedIndex == 2 && listBox2.SelectedIndex == 0)
            {
                textBox4.Text = textBox2.Text;

                if (textBox4 != null && !string.IsNullOrWhiteSpace(textBox4.Text) && textBox4.Text.Length == 4)
                {
                    textBox11.Text = textBox4.Text.Substring(0, 2);
                    textBox10.Text = textBox4.Text.Substring(2, 2);
                }

            }
            if (listBox1.SelectedIndex == 2 && listBox2.SelectedIndex == 1)
            {
                textBox4.Text = textBox3.Text;

                if (textBox4 != null && !string.IsNullOrWhiteSpace(textBox4.Text) && textBox4.Text.Length == 4)
                {
                    textBox11.Text = textBox4.Text.Substring(0, 2);
                    textBox10.Text = textBox4.Text.Substring(2, 2);
                }
            }
            if (listBox1.SelectedIndex == 2 && listBox2.SelectedIndex == 3)
            {
                textBox4.Text = textBox5.Text;

                if (textBox4 != null && !string.IsNullOrWhiteSpace(textBox4.Text) && textBox4.Text.Length == 4)
                {
                    textBox11.Text = textBox4.Text.Substring(0, 2);
                    textBox10.Text = textBox4.Text.Substring(2, 2);
                }
            }
            //DX
            if (listBox1.SelectedIndex == 3 && listBox2.SelectedIndex == 0)
            {
                textBox5.Text = textBox2.Text;

                if (textBox5 != null && !string.IsNullOrWhiteSpace(textBox5.Text) && textBox5.Text.Length == 4)
                {
                    textBox13.Text = textBox5.Text.Substring(0, 2);
                    textBox12.Text = textBox5.Text.Substring(2, 2);
                }

            }
            if (listBox1.SelectedIndex == 3 && listBox2.SelectedIndex == 1)
            {
                textBox5.Text = textBox2.Text;

                if (textBox5 != null && !string.IsNullOrWhiteSpace(textBox5.Text) && textBox5.Text.Length == 4)
                {
                    textBox13.Text = textBox5.Text.Substring(0, 2);
                    textBox12.Text = textBox5.Text.Substring(2, 2);
                }
            }
            if (listBox1.SelectedIndex == 3 && listBox2.SelectedIndex == 2)
            {
                textBox5.Text = textBox2.Text;

                if (textBox5 != null && !string.IsNullOrWhiteSpace(textBox5.Text) && textBox5.Text.Length == 4)
                {
                    textBox13.Text = textBox5.Text.Substring(0, 2);
                    textBox12.Text = textBox5.Text.Substring(2, 2);
                }
            }
            //AH
            if (listBox1.SelectedIndex == 4 && listBox2.SelectedIndex == 5)
            {
                textBox6.Text = textBox7.Text;

                if (textBox6.Text.Length == 2 && textBox7.Text.Length == 2)
                {
                    textBox2.Text = textBox6.Text + textBox7.Text;
                }
                else
                {
                    textBox2.Text = "Niepoprawne";
                }
            }
            if (listBox1.SelectedIndex == 4 && listBox2.SelectedIndex == 6)
            {
                textBox6.Text = textBox9.Text;

                if (textBox6.Text.Length == 2 && textBox7.Text.Length == 2)
                {
                    textBox2.Text = textBox6.Text + textBox7.Text;
                }
                else
                {
                    textBox2.Text = "Niepoprawne";
                }
            }
            if (listBox1.SelectedIndex == 4 && listBox2.SelectedIndex == 7)
            {
                textBox6.Text = textBox8.Text;

                if (textBox6.Text.Length == 2 && textBox7.Text.Length == 2)
                {
                    textBox2.Text = textBox6.Text + textBox7.Text;
                }
                else
                {
                    textBox2.Text = "Niepoprawne";
                }
            }
            if (listBox1.SelectedIndex == 4 && listBox2.SelectedIndex == 8)
            {
                textBox6.Text = textBox11.Text;

                if (textBox6.Text.Length == 2 && textBox7.Text.Length == 2)
                {
                    textBox2.Text = textBox6.Text + textBox7.Text;
                }
                else
                {
                    textBox2.Text = "Niepoprawne";
                }
            }
            if (listBox1.SelectedIndex == 4 && listBox2.SelectedIndex == 9)
            {
                textBox6.Text = textBox10.Text;

                if (textBox6.Text.Length == 2 && textBox7.Text.Length == 2)
                {
                    textBox2.Text = textBox6.Text + textBox7.Text;
                }
                else
                {
                    textBox2.Text = "Niepoprawne";
                }
            }
            if (listBox1.SelectedIndex == 4 && listBox2.SelectedIndex == 10)
            {
                textBox6.Text = textBox13.Text;

                if (textBox6.Text.Length == 2 && textBox7.Text.Length == 2)
                {
                    textBox2.Text = textBox6.Text + textBox7.Text;
                }
                else
                {
                    textBox2.Text = "Niepoprawne";
                }
            }
            if (listBox1.SelectedIndex == 4 && listBox2.SelectedIndex == 11)
            {
                textBox6.Text = textBox12.Text;

                if (textBox6.Text.Length == 2 && textBox7.Text.Length == 2)
                {
                    textBox2.Text = textBox6.Text + textBox7.Text;
                }
                else
                {
                    textBox2.Text = "Niepoprawne";
                }
            }
            //AL
            if (listBox1.SelectedIndex == 5 && listBox2.SelectedIndex == 4)
            {
                textBox7.Text = textBox6.Text;

                if (textBox6.Text.Length == 2 && textBox7.Text.Length == 2)
                {
                    textBox2.Text = textBox6.Text + textBox7.Text;
                }
                else
                {
                    textBox2.Text = "Niepoprawne";
                }
            }
            if (listBox1.SelectedIndex == 5 && listBox2.SelectedIndex == 6)
            {
                textBox7.Text = textBox9.Text;

                if (textBox6.Text.Length == 2 && textBox7.Text.Length == 2)
                {
                    textBox2.Text = textBox6.Text + textBox7.Text;
                }
                else
                {
                    textBox2.Text = "Niepoprawne";
                }
            }
            if (listBox1.SelectedIndex == 5 && listBox2.SelectedIndex == 7)
            {
                textBox7.Text = textBox8.Text;

                if (textBox6.Text.Length == 2 && textBox7.Text.Length == 2)
                {
                    textBox2.Text = textBox6.Text + textBox7.Text;
                }
                else
                {
                    textBox2.Text = "Niepoprawne";
                }
            }
            if (listBox1.SelectedIndex == 5 && listBox2.SelectedIndex == 8)
            {
                textBox7.Text = textBox11.Text;

                if (textBox6.Text.Length == 2 && textBox7.Text.Length == 2)
                {
                    textBox2.Text = textBox6.Text + textBox7.Text;
                }
                else
                {
                    textBox2.Text = "Niepoprawne";
                }
            }
            if (listBox1.SelectedIndex == 5 && listBox2.SelectedIndex == 9)
            {
                textBox7.Text = textBox10.Text;

                if (textBox6.Text.Length == 2 && textBox7.Text.Length == 2)
                {
                    textBox2.Text = textBox6.Text + textBox7.Text;
                }
                else
                {
                    textBox2.Text = "Niepoprawne";
                }
            }
            if (listBox1.SelectedIndex == 5 && listBox2.SelectedIndex == 10)
            {
                textBox7.Text = textBox13.Text;

                if (textBox6.Text.Length == 2 && textBox7.Text.Length == 2)
                {
                    textBox2.Text = textBox6.Text + textBox7.Text;
                }
                else
                {
                    textBox2.Text = "Niepoprawne";
                }
            }
            if (listBox1.SelectedIndex == 5 && listBox2.SelectedIndex == 11)
            {
                textBox7.Text = textBox12.Text;

                if (textBox6.Text.Length == 2 && textBox7.Text.Length == 2)
                {
                    textBox2.Text = textBox6.Text + textBox7.Text;
                }
                else
                {
                    textBox2.Text = "Niepoprawne";
                }
            }
            //BH
            if (listBox1.SelectedIndex == 6 && listBox2.SelectedIndex == 4)
            {
                textBox9.Text = textBox6.Text;

                if (textBox9.Text.Length == 2 && textBox8.Text.Length == 2)
                {
                    textBox3.Text = textBox9.Text + textBox8.Text;
                }
                else
                {
                    textBox3.Text = "Niepoprawne";
                }
            }
            if (listBox1.SelectedIndex == 6 && listBox2.SelectedIndex == 5)
            {
                textBox9.Text = textBox7.Text;

                if (textBox9.Text.Length == 2 && textBox8.Text.Length == 2)
                {
                    textBox3.Text = textBox9.Text + textBox8.Text;
                }
                else
                {
                    textBox3.Text = "Niepoprawne";
                }
            }
            if (listBox1.SelectedIndex == 6 && listBox2.SelectedIndex == 7)
            {
                textBox9.Text = textBox8.Text;

                if (textBox9.Text.Length == 2 && textBox8.Text.Length == 2)
                {
                    textBox3.Text = textBox9.Text + textBox8.Text;
                }
                else
                {
                    textBox3.Text = "Niepoprawne";
                }
            }
            if (listBox1.SelectedIndex == 6 && listBox2.SelectedIndex == 8)
            {
                textBox9.Text = textBox11.Text;

                if (textBox9.Text.Length == 2 && textBox8.Text.Length == 2)
                {
                    textBox3.Text = textBox9.Text + textBox8.Text;
                }
                else
                {
                    textBox3.Text = "Niepoprawne";
                }
            }
            if (listBox1.SelectedIndex == 6 && listBox2.SelectedIndex == 9)
            {
                textBox9.Text = textBox10.Text;

                if (textBox9.Text.Length == 2 && textBox8.Text.Length == 2)
                {
                    textBox3.Text = textBox9.Text + textBox8.Text;
                }
                else
                {
                    textBox3.Text = "Niepoprawne";
                }
            }
            if (listBox1.SelectedIndex == 6 && listBox2.SelectedIndex == 10)
            {
                textBox9.Text = textBox13.Text;

                if (textBox9.Text.Length == 2 && textBox8.Text.Length == 2)
                {
                    textBox3.Text = textBox9.Text + textBox8.Text;
                }
                else
                {
                    textBox3.Text = "Niepoprawne";
                }
            }
            if (listBox1.SelectedIndex == 6 && listBox2.SelectedIndex == 11)
            {
                textBox9.Text = textBox12.Text;

                if (textBox9.Text.Length == 2 && textBox8.Text.Length == 2)
                {
                    textBox3.Text = textBox9.Text + textBox8.Text;
                }
                else
                {
                    textBox3.Text = "Niepoprawne";
                }
            }
            //BL
            if (listBox1.SelectedIndex == 7 && listBox2.SelectedIndex == 4)
            {
                textBox8.Text = textBox6.Text;

                if (textBox9.Text.Length == 2 && textBox8.Text.Length == 2)
                {
                    textBox3.Text = textBox9.Text + textBox8.Text;
                }
                else
                {
                    textBox3.Text = "Niepoprawne";
                }
            }
            if (listBox1.SelectedIndex == 7 && listBox2.SelectedIndex == 5)
            {
                textBox8.Text = textBox7.Text;

                if (textBox9.Text.Length == 2 && textBox8.Text.Length == 2)
                {
                    textBox3.Text = textBox9.Text + textBox8.Text;
                }
                else
                {
                    textBox3.Text = "Niepoprawne";
                }
            }
            if (listBox1.SelectedIndex == 7 && listBox2.SelectedIndex == 6)
            {
                textBox8.Text = textBox9.Text;

                if (textBox9.Text.Length == 2 && textBox8.Text.Length == 2)
                {
                    textBox3.Text = textBox9.Text + textBox8.Text;
                }
                else
                {
                    textBox3.Text = "Niepoprawne";
                }
            }
            if (listBox1.SelectedIndex == 7 && listBox2.SelectedIndex == 8)
            {
                textBox8.Text = textBox11.Text;

                if (textBox9.Text.Length == 2 && textBox8.Text.Length == 2)
                {
                    textBox3.Text = textBox9.Text + textBox8.Text;
                }
                else
                {
                    textBox3.Text = "Niepoprawne";
                }
            }
            if (listBox1.SelectedIndex == 7 && listBox2.SelectedIndex == 9)
            {
                textBox8.Text = textBox10.Text;

                if (textBox9.Text.Length == 2 && textBox8.Text.Length == 2)
                {
                    textBox3.Text = textBox9.Text + textBox8.Text;
                }
                else
                {
                    textBox3.Text = "Niepoprawne";
                }
            }
            if (listBox1.SelectedIndex == 7 && listBox2.SelectedIndex == 10)
            {
                textBox8.Text = textBox13.Text;

                if (textBox9.Text.Length == 2 && textBox8.Text.Length == 2)
                {
                    textBox3.Text = textBox9.Text + textBox8.Text;
                }
                else
                {
                    textBox3.Text = "Niepoprawne";
                }
            }
            if (listBox1.SelectedIndex == 7 && listBox2.SelectedIndex == 11)
            {
                textBox8.Text = textBox12.Text;

                if (textBox9.Text.Length == 2 && textBox8.Text.Length == 2)
                {
                    textBox3.Text = textBox9.Text + textBox8.Text;
                }
                else
                {
                    textBox3.Text = "Niepoprawne";
                }
            }
            //CH
            if (listBox1.SelectedIndex == 8 && listBox2.SelectedIndex == 4)
            {
                textBox11.Text = textBox6.Text;

                if (textBox11.Text.Length == 2 && textBox10.Text.Length == 2)
                {
                    textBox4.Text = textBox11.Text + textBox10.Text;
                }
                else
                {
                    textBox4.Text = "Niepoprawne";
                }
            }
            if (listBox1.SelectedIndex == 8 && listBox2.SelectedIndex == 5)
            {
                textBox11.Text = textBox7.Text;

                if (textBox11.Text.Length == 2 && textBox10.Text.Length == 2)
                {
                    textBox4.Text = textBox11.Text + textBox10.Text;
                }
                else
                {
                    textBox4.Text = "Niepoprawne";
                }
            }
            if (listBox1.SelectedIndex == 8 && listBox2.SelectedIndex == 6)
            {
                textBox11.Text = textBox9.Text;

                if (textBox11.Text.Length == 2 && textBox10.Text.Length == 2)
                {
                    textBox4.Text = textBox11.Text + textBox10.Text;
                }
                else
                {
                    textBox4.Text = "Niepoprawne";
                }
            }
            if (listBox1.SelectedIndex == 8 && listBox2.SelectedIndex == 7)
            {
                textBox11.Text = textBox8.Text;

                if (textBox11.Text.Length == 2 && textBox10.Text.Length == 2)
                {
                    textBox4.Text = textBox11.Text + textBox10.Text;
                }
                else
                {
                    textBox4.Text = "Niepoprawne";
                }
            }
            if (listBox1.SelectedIndex == 8 && listBox2.SelectedIndex == 9)
            {
                textBox11.Text = textBox10.Text;

                if (textBox11.Text.Length == 2 && textBox10.Text.Length == 2)
                {
                    textBox4.Text = textBox11.Text + textBox10.Text;
                }
                else
                {
                    textBox4.Text = "Niepoprawne";
                }
            }
            if (listBox1.SelectedIndex == 8 && listBox2.SelectedIndex == 10)
            {
                textBox11.Text = textBox13.Text;

                if (textBox11.Text.Length == 2 && textBox10.Text.Length == 2)
                {
                    textBox4.Text = textBox11.Text + textBox10.Text;
                }
                else
                {
                    textBox4.Text = "Niepoprawne";
                }
            }
            if (listBox1.SelectedIndex == 8 && listBox2.SelectedIndex == 11)
            {
                textBox11.Text = textBox12.Text;

                if (textBox11.Text.Length == 2 && textBox10.Text.Length == 2)
                {
                    textBox4.Text = textBox11.Text + textBox10.Text;
                }
                else
                {
                    textBox4.Text = "Niepoprawne";
                }
            }
            //CL
            if (listBox1.SelectedIndex == 9 && listBox2.SelectedIndex == 4)
            {
                textBox10.Text = textBox6.Text;

                if (textBox11.Text.Length == 2 && textBox10.Text.Length == 2)
                {
                    textBox4.Text = textBox11.Text + textBox10.Text;
                }
                else
                {
                    textBox4.Text = "Niepoprawne";
                }
            }
            if (listBox1.SelectedIndex == 9 && listBox2.SelectedIndex == 5)
            {
                textBox10.Text = textBox7.Text;

                if (textBox11.Text.Length == 2 && textBox10.Text.Length == 2)
                {
                    textBox4.Text = textBox11.Text + textBox10.Text;
                }
                else
                {
                    textBox4.Text = "Niepoprawne";
                }
            }
            if (listBox1.SelectedIndex == 9 && listBox2.SelectedIndex == 6)
            {
                textBox10.Text = textBox9.Text;

                if (textBox11.Text.Length == 2 && textBox10.Text.Length == 2)
                {
                    textBox4.Text = textBox11.Text + textBox10.Text;
                }
                else
                {
                    textBox4.Text = "Niepoprawne";
                }
            }
            if (listBox1.SelectedIndex == 9 && listBox2.SelectedIndex == 7)
            {
                textBox10.Text = textBox8.Text;

                if (textBox11.Text.Length == 2 && textBox10.Text.Length == 2)
                {
                    textBox4.Text = textBox11.Text + textBox10.Text;
                }
                else
                {
                    textBox4.Text = "Niepoprawne";
                }
            }
            if (listBox1.SelectedIndex == 9 && listBox2.SelectedIndex == 8)
            {
                textBox10.Text = textBox11.Text;

                if (textBox11.Text.Length == 2 && textBox10.Text.Length == 2)
                {
                    textBox4.Text = textBox11.Text + textBox10.Text;
                }
                else
                {
                    textBox4.Text = "Niepoprawne";
                }
            }
            if (listBox1.SelectedIndex == 9 && listBox2.SelectedIndex == 10)
            {
                textBox10.Text = textBox13.Text;

                if (textBox11.Text.Length == 2 && textBox10.Text.Length == 2)
                {
                    textBox4.Text = textBox11.Text + textBox10.Text;
                }
                else
                {
                    textBox4.Text = "Niepoprawne";
                }
            }
            if (listBox1.SelectedIndex == 9 && listBox2.SelectedIndex == 11)
            {
                textBox10.Text = textBox12.Text;

                if (textBox11.Text.Length == 2 && textBox10.Text.Length == 2)
                {
                    textBox4.Text = textBox11.Text + textBox10.Text;
                }
                else
                {
                    textBox4.Text = "Niepoprawne";
                }
            }
            //DH
            if (listBox1.SelectedIndex == 10 && listBox2.SelectedIndex == 4)
            {
                textBox13.Text = textBox6.Text;

                if (textBox13.Text.Length == 2 && textBox12.Text.Length == 2)
                {
                    textBox5.Text = textBox13.Text + textBox12.Text;
                }
                else
                {
                    textBox5.Text = "Niepoprawne";
                }
            }
            if (listBox1.SelectedIndex == 10 && listBox2.SelectedIndex == 5)
            {
                textBox13.Text = textBox7.Text;

                if (textBox13.Text.Length == 2 && textBox12.Text.Length == 2)
                {
                    textBox5.Text = textBox13.Text + textBox12.Text;
                }
                else
                {
                    textBox5.Text = "Niepoprawne";
                }
            }
            if (listBox1.SelectedIndex == 10 && listBox2.SelectedIndex == 6)
            {
                textBox13.Text = textBox9.Text;

                if (textBox13.Text.Length == 2 && textBox12.Text.Length == 2)
                {
                    textBox5.Text = textBox13.Text + textBox12.Text;
                }
                else
                {
                    textBox5.Text = "Niepoprawne";
                }
            }
            if (listBox1.SelectedIndex == 10 && listBox2.SelectedIndex == 7)
            {
                textBox13.Text = textBox8.Text;

                if (textBox13.Text.Length == 2 && textBox12.Text.Length == 2)
                {
                    textBox5.Text = textBox13.Text + textBox12.Text;
                }
                else
                {
                    textBox5.Text = "Niepoprawne";
                }
            }
            if (listBox1.SelectedIndex == 10 && listBox2.SelectedIndex == 8)
            {
                textBox13.Text = textBox11.Text;

                if (textBox13.Text.Length == 2 && textBox12.Text.Length == 2)
                {
                    textBox5.Text = textBox13.Text + textBox12.Text;
                }
                else
                {
                    textBox5.Text = "Niepoprawne";
                }
            }
            if (listBox1.SelectedIndex == 10 && listBox2.SelectedIndex == 9)
            {
                textBox13.Text = textBox10.Text;

                if (textBox13.Text.Length == 2 && textBox12.Text.Length == 2)
                {
                    textBox5.Text = textBox13.Text + textBox12.Text;
                }
                else
                {
                    textBox5.Text = "Niepoprawne";
                }
            }
            if (listBox1.SelectedIndex == 10 && listBox2.SelectedIndex == 11)
            {
                textBox13.Text = textBox12.Text;

                if (textBox13.Text.Length == 2 && textBox12.Text.Length == 2)
                {
                    textBox5.Text = textBox13.Text + textBox12.Text;
                }
                else
                {
                    textBox5.Text = "Niepoprawne";
                }
            }
            //DL
            if (listBox1.SelectedIndex == 11 && listBox2.SelectedIndex == 4)
            {
                textBox12.Text = textBox6.Text;

                if (textBox13.Text.Length == 2 && textBox12.Text.Length == 2)
                {
                    textBox5.Text = textBox13.Text + textBox12.Text;
                }
                else
                {
                    textBox5.Text = "Niepoprawne";
                }
            }
            if (listBox1.SelectedIndex == 11 && listBox2.SelectedIndex == 5)
            {
                textBox12.Text = textBox7.Text;

                if (textBox13.Text.Length == 2 && textBox12.Text.Length == 2)
                {
                    textBox5.Text = textBox13.Text + textBox12.Text;
                }
                else
                {
                    textBox5.Text = "Niepoprawne";
                }
            }
            if (listBox1.SelectedIndex == 11 && listBox2.SelectedIndex == 6)
            {
                textBox12.Text = textBox9.Text;

                if (textBox13.Text.Length == 2 && textBox12.Text.Length == 2)
                {
                    textBox5.Text = textBox13.Text + textBox12.Text;
                }
                else
                {
                    textBox5.Text = "Niepoprawne";
                }
            }
            if (listBox1.SelectedIndex == 11 && listBox2.SelectedIndex == 7)
            {
                textBox12.Text = textBox8.Text;

                if (textBox13.Text.Length == 2 && textBox12.Text.Length == 2)
                {
                    textBox5.Text = textBox13.Text + textBox12.Text;
                }
                else
                {
                    textBox5.Text = "Niepoprawne";
                }
            }
            if (listBox1.SelectedIndex == 11 && listBox2.SelectedIndex == 8)
            {
                textBox12.Text = textBox11.Text;

                if (textBox13.Text.Length == 2 && textBox12.Text.Length == 2)
                {
                    textBox5.Text = textBox13.Text + textBox12.Text;
                }
                else
                {
                    textBox5.Text = "Niepoprawne";
                }
            }
            if (listBox1.SelectedIndex == 11 && listBox2.SelectedIndex == 9)
            {
                textBox12.Text = textBox10.Text;

                if (textBox13.Text.Length == 2 && textBox12.Text.Length == 2)
                {
                    textBox5.Text = textBox13.Text + textBox12.Text;
                }
                else
                {
                    textBox5.Text = "Niepoprawne";
                }
            }
            if (listBox1.SelectedIndex == 11 && listBox2.SelectedIndex == 10)
            {
                textBox12.Text = textBox13.Text;

                if (textBox13.Text.Length == 2 && textBox12.Text.Length == 2)
                {
                    textBox5.Text = textBox13.Text + textBox12.Text;
                }
                else
                {
                    textBox5.Text = "Niepoprawne";
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //AX
            if (listBox1.SelectedIndex == 0 && listBox2.SelectedIndex == 1)
            {
                if (textBox2 != null && !string.IsNullOrWhiteSpace(textBox2.Text) && textBox2.Text.Length == 4 && textBox3 != null && !string.IsNullOrWhiteSpace(textBox3.Text) && textBox3.Text.Length == 4)
                {
                    string tmp = textBox2.Text;
                    textBox2.Text = textBox3.Text;
                    textBox3.Text = tmp;
                    textBox6.Text = textBox2.Text.Substring(0, 2);
                    textBox7.Text = textBox2.Text.Substring(2, 2);
                    textBox9.Text = textBox3.Text.Substring(0, 2);
                    textBox8.Text = textBox3.Text.Substring(2, 2);
                }
            }
            if (listBox1.SelectedIndex == 0 && listBox2.SelectedIndex == 2)
            {
                if (textBox2 != null && !string.IsNullOrWhiteSpace(textBox2.Text) && textBox2.Text.Length == 4 && textBox4 != null && !string.IsNullOrWhiteSpace(textBox4.Text) && textBox4.Text.Length == 4)
                {
                    string tmp = textBox2.Text;
                    textBox2.Text = textBox4.Text;
                    textBox4.Text = tmp;
                    textBox6.Text = textBox2.Text.Substring(0, 2);
                    textBox7.Text = textBox2.Text.Substring(2, 2);
                    textBox11.Text = textBox4.Text.Substring(0, 2);
                    textBox10.Text = textBox4.Text.Substring(2, 2);
                }
            }
            if (listBox1.SelectedIndex == 0 && listBox2.SelectedIndex == 3)
            {
                if (textBox2 != null && !string.IsNullOrWhiteSpace(textBox2.Text) && textBox2.Text.Length == 4 && textBox5 != null && !string.IsNullOrWhiteSpace(textBox5.Text) && textBox5.Text.Length == 4)
                {
                    string tmp = textBox2.Text;
                    textBox2.Text = textBox5.Text;
                    textBox5.Text = tmp;
                    textBox6.Text = textBox2.Text.Substring(0, 2);
                    textBox7.Text = textBox2.Text.Substring(2, 2);
                    textBox13.Text = textBox5.Text.Substring(0, 2);
                    textBox12.Text = textBox5.Text.Substring(2, 2);
                }
            }
            //BX
            if (listBox1.SelectedIndex == 1 && listBox2.SelectedIndex == 0)
            {
                if (textBox2 != null && !string.IsNullOrWhiteSpace(textBox2.Text) && textBox2.Text.Length == 4 && textBox3 != null && !string.IsNullOrWhiteSpace(textBox3.Text) && textBox3.Text.Length == 4)
                {
                    string tmp = textBox3.Text;
                    textBox3.Text = textBox2.Text;
                    textBox2.Text = tmp;
                    textBox6.Text = textBox2.Text.Substring(0, 2);
                    textBox7.Text = textBox2.Text.Substring(2, 2);
                    textBox9.Text = textBox3.Text.Substring(0, 2);
                    textBox8.Text = textBox3.Text.Substring(2, 2);
                }
            }
            if (listBox1.SelectedIndex == 1 && listBox2.SelectedIndex == 2)
            {
                if (textBox4 != null && !string.IsNullOrWhiteSpace(textBox4.Text) && textBox4.Text.Length == 4 && textBox3 != null && !string.IsNullOrWhiteSpace(textBox3.Text) && textBox3.Text.Length == 4)
                {
                    string tmp = textBox4.Text;
                    textBox4.Text = textBox3.Text;
                    textBox3.Text = tmp;
                    textBox11.Text = textBox4.Text.Substring(0, 2);
                    textBox10.Text = textBox4.Text.Substring(2, 2);
                    textBox9.Text = textBox3.Text.Substring(0, 2);
                    textBox8.Text = textBox3.Text.Substring(2, 2);
                }
            }
            if (listBox1.SelectedIndex == 1 && listBox2.SelectedIndex == 3)
            {
                if (textBox5 != null && !string.IsNullOrWhiteSpace(textBox5.Text) && textBox5.Text.Length == 4 && textBox3 != null && !string.IsNullOrWhiteSpace(textBox3.Text) && textBox3.Text.Length == 4)
                {
                    string tmp = textBox5.Text;
                    textBox5.Text = textBox3.Text;
                    textBox3.Text = tmp;
                    textBox13.Text = textBox5.Text.Substring(0, 2);
                    textBox12.Text = textBox5.Text.Substring(2, 2);
                    textBox9.Text = textBox3.Text.Substring(0, 2);
                    textBox8.Text = textBox3.Text.Substring(2, 2);
                }
            }
            //CX
            if (listBox1.SelectedIndex == 2 && listBox2.SelectedIndex == 0)
            {
                if (textBox2 != null && !string.IsNullOrWhiteSpace(textBox2.Text) && textBox2.Text.Length == 4 && textBox4 != null && !string.IsNullOrWhiteSpace(textBox4.Text) && textBox4.Text.Length == 4)
                {
                    string tmp = textBox2.Text;
                    textBox2.Text = textBox4.Text;
                    textBox4.Text = tmp;
                    textBox6.Text = textBox2.Text.Substring(0, 2);
                    textBox7.Text = textBox2.Text.Substring(2, 2);
                    textBox11.Text = textBox4.Text.Substring(0, 2);
                    textBox10.Text = textBox4.Text.Substring(2, 2);
                }
            }
            if (listBox1.SelectedIndex == 2 && listBox2.SelectedIndex == 1)
            {
                if (textBox3 != null && !string.IsNullOrWhiteSpace(textBox3.Text) && textBox3.Text.Length == 4 && textBox4 != null && !string.IsNullOrWhiteSpace(textBox4.Text) && textBox4.Text.Length == 4)
                {
                    string tmp = textBox3.Text;
                    textBox3.Text = textBox4.Text;
                    textBox4.Text = tmp;
                    textBox9.Text = textBox3.Text.Substring(0, 2);
                    textBox8.Text = textBox3.Text.Substring(2, 2);
                    textBox11.Text = textBox4.Text.Substring(0, 2);
                    textBox10.Text = textBox4.Text.Substring(2, 2);
                }
            }
            if (listBox1.SelectedIndex == 2 && listBox2.SelectedIndex == 3)
            {
                if (textBox5 != null && !string.IsNullOrWhiteSpace(textBox5.Text) && textBox5.Text.Length == 4 && textBox4 != null && !string.IsNullOrWhiteSpace(textBox4.Text) && textBox4.Text.Length == 4)
                {
                    string tmp = textBox5.Text;
                    textBox5.Text = textBox4.Text;
                    textBox4.Text = tmp;
                    textBox13.Text = textBox5.Text.Substring(0, 2);
                    textBox12.Text = textBox5.Text.Substring(2, 2);
                    textBox11.Text = textBox4.Text.Substring(0, 2);
                    textBox10.Text = textBox4.Text.Substring(2, 2);
                }
            }
            //DX
            if (listBox1.SelectedIndex == 3 && listBox2.SelectedIndex == 0)
            {
                if (textBox2 != null && !string.IsNullOrWhiteSpace(textBox2.Text) && textBox2.Text.Length == 4 && textBox5 != null && !string.IsNullOrWhiteSpace(textBox5.Text) && textBox5.Text.Length == 4)
                {
                    string tmp = textBox2.Text;
                    textBox2.Text = textBox5.Text;
                    textBox5.Text = tmp;
                    textBox6.Text = textBox2.Text.Substring(0, 2);
                    textBox7.Text = textBox2.Text.Substring(2, 2);
                    textBox13.Text = textBox5.Text.Substring(0, 2);
                    textBox12.Text = textBox5.Text.Substring(2, 2);
                }
            }
            if (listBox1.SelectedIndex == 3 && listBox2.SelectedIndex == 1)
            {
                if (textBox3 != null && !string.IsNullOrWhiteSpace(textBox3.Text) && textBox3.Text.Length == 4 && textBox5 != null && !string.IsNullOrWhiteSpace(textBox5.Text) && textBox5.Text.Length == 4)
                {
                    string tmp = textBox3.Text;
                    textBox3.Text = textBox5.Text;
                    textBox5.Text = tmp;
                    textBox9.Text = textBox3.Text.Substring(0, 2);
                    textBox8.Text = textBox3.Text.Substring(2, 2);
                    textBox13.Text = textBox5.Text.Substring(0, 2);
                    textBox12.Text = textBox5.Text.Substring(2, 2);
                }
            }
            if (listBox1.SelectedIndex == 3 && listBox2.SelectedIndex == 2)
            {
                if (textBox4 != null && !string.IsNullOrWhiteSpace(textBox4.Text) && textBox4.Text.Length == 4 && textBox5 != null && !string.IsNullOrWhiteSpace(textBox5.Text) && textBox5.Text.Length == 4)
                {
                    string tmp = textBox4.Text;
                    textBox4.Text = textBox5.Text;
                    textBox5.Text = tmp;
                    textBox11.Text = textBox4.Text.Substring(0, 2);
                    textBox10.Text = textBox4.Text.Substring(2, 2);
                    textBox13.Text = textBox5.Text.Substring(0, 2);
                    textBox12.Text = textBox5.Text.Substring(2, 2);
                }
            }
            //AH
            if (listBox1.SelectedIndex == 4 && listBox2.SelectedIndex == 5)
            {
                if (textBox6.Text.Length == 2 && textBox7.Text.Length == 2)
                {
                    string tmp = textBox6.Text;
                    textBox6.Text = textBox7.Text;
                    textBox7.Text = tmp;
                    textBox2.Text = textBox6.Text + textBox7.Text;
                }
                else
                {
                    textBox2.Text = "Niepoprawne";
                }
            }
            if (listBox1.SelectedIndex == 4 && listBox2.SelectedIndex == 6)
            {
                if (textBox6.Text.Length == 2 && textBox7.Text.Length == 2 && textBox9.Text.Length == 2 && textBox8.Text.Length == 2)
                {
                    string tmp = textBox6.Text;
                    textBox6.Text = textBox9.Text;
                    textBox9.Text = tmp;
                    textBox2.Text = textBox6.Text + textBox7.Text;
                    textBox3.Text = textBox9.Text + textBox8.Text;
                }
                else
                {
                    textBox2.Text = "Niepoprawne";
                    textBox3.Text = "Niepoprawne";
                }
            }
            if (listBox1.SelectedIndex == 4 && listBox2.SelectedIndex == 7)
            {
                if (textBox6.Text.Length == 2 && textBox7.Text.Length == 2 && textBox9.Text.Length == 2 && textBox8.Text.Length == 2)
                {
                    string tmp = textBox6.Text;
                    textBox6.Text = textBox8.Text;
                    textBox8.Text = tmp;
                    textBox2.Text = textBox6.Text + textBox7.Text;
                    textBox3.Text = textBox9.Text + textBox8.Text;
                }
                else
                {
                    textBox2.Text = "Niepoprawne";
                    textBox3.Text = "Niepoprawne";
                }
            }
            if (listBox1.SelectedIndex == 4 && listBox2.SelectedIndex == 8)
            {
                if (textBox6.Text.Length == 2 && textBox7.Text.Length == 2 && textBox11.Text.Length == 2 && textBox10.Text.Length == 2)
                {
                    string tmp = textBox6.Text;
                    textBox6.Text = textBox11.Text;
                    textBox11.Text = tmp;
                    textBox2.Text = textBox6.Text + textBox7.Text;
                    textBox4.Text = textBox11.Text + textBox10.Text;
                }
                else
                {
                    textBox2.Text = "Niepoprawne";
                    textBox4.Text = "Niepoprawne";
                }
            }
            if (listBox1.SelectedIndex == 4 && listBox2.SelectedIndex == 9)
            {
                if (textBox6.Text.Length == 2 && textBox7.Text.Length == 2 && textBox11.Text.Length == 2 && textBox10.Text.Length == 2)
                {
                    string tmp = textBox6.Text;
                    textBox6.Text = textBox10.Text;
                    textBox10.Text = tmp;
                    textBox2.Text = textBox6.Text + textBox7.Text;
                    textBox4.Text = textBox11.Text + textBox10.Text;
                }
                else
                {
                    textBox2.Text = "Niepoprawne";
                    textBox4.Text = "Niepoprawne";
                }
            }
            if (listBox1.SelectedIndex == 4 && listBox2.SelectedIndex == 10)
            {
                if (textBox6.Text.Length == 2 && textBox7.Text.Length == 2 && textBox13.Text.Length == 2 && textBox12.Text.Length == 2)
                {
                    string tmp = textBox6.Text;
                    textBox6.Text = textBox13.Text;
                    textBox13.Text = tmp;
                    textBox5.Text = textBox13.Text + textBox12.Text;
                    textBox2.Text = textBox6.Text + textBox7.Text;
                }
                else
                {
                    textBox2.Text = "Niepoprawne";
                    textBox5.Text = "Niepoprawne";
                }
            }
            if (listBox1.SelectedIndex == 4 && listBox2.SelectedIndex == 11)
            {
                if (textBox6.Text.Length == 2 && textBox7.Text.Length == 2 && textBox13.Text.Length == 2 && textBox12.Text.Length == 2)
                {
                    string tmp = textBox6.Text;
                    textBox6.Text = textBox12.Text;
                    textBox12.Text = tmp;
                    textBox5.Text = textBox13.Text + textBox12.Text;
                    textBox2.Text = textBox6.Text + textBox7.Text;
                }
                else
                {
                    textBox2.Text = "Niepoprawne";
                    textBox5.Text = "Niepoprawne";
                }
            }
            //AL
            if (listBox1.SelectedIndex == 5 && listBox2.SelectedIndex == 4)
            {
                if (textBox6.Text.Length == 2 && textBox7.Text.Length == 2)
                {
                    string tmp = textBox7.Text;
                    textBox7.Text = textBox6.Text;
                    textBox6.Text = tmp;
                    textBox2.Text = textBox6.Text + textBox7.Text;
                }
                else
                {
                    textBox2.Text = "Niepoprawne";
                }
            }
            if (listBox1.SelectedIndex == 5 && listBox2.SelectedIndex == 6)
            {
                if (textBox6.Text.Length == 2 && textBox7.Text.Length == 2 && textBox9.Text.Length == 2 && textBox8.Text.Length == 2)
                {
                    string tmp = textBox7.Text;
                    textBox7.Text = textBox9.Text;
                    textBox9.Text = tmp;
                    textBox3.Text = textBox9.Text + textBox8.Text;
                    textBox2.Text = textBox6.Text + textBox7.Text;
                }
                else
                {
                    textBox2.Text = "Niepoprawne";
                    textBox3.Text = "Niepoprawne";
                }
            }
            if (listBox1.SelectedIndex == 5 && listBox2.SelectedIndex == 7)
            {
                if (textBox6.Text.Length == 2 && textBox7.Text.Length == 2 && textBox9.Text.Length == 2 && textBox8.Text.Length == 2)
                {
                    string tmp = textBox7.Text;
                    textBox7.Text = textBox8.Text;
                    textBox8.Text = tmp;
                    textBox3.Text = textBox9.Text + textBox8.Text;
                    textBox2.Text = textBox6.Text + textBox7.Text;
                }
                else
                {
                    textBox2.Text = "Niepoprawne";
                    textBox3.Text = "Niepoprawne";
                }
            }
            if (listBox1.SelectedIndex == 5 && listBox2.SelectedIndex == 8)
            {
                if (textBox6.Text.Length == 2 && textBox7.Text.Length == 2 && textBox11.Text.Length == 2 && textBox10.Text.Length == 2)
                {
                    string tmp = textBox7.Text;
                    textBox7.Text = textBox11.Text;
                    textBox11.Text = tmp;
                    textBox2.Text = textBox6.Text + textBox7.Text;
                    textBox4.Text = textBox11.Text + textBox10.Text;
                }
                else
                {
                    textBox2.Text = "Niepoprawne";
                    textBox4.Text = "Niepoprawne";
                }
            }
            if (listBox1.SelectedIndex == 5 && listBox2.SelectedIndex == 9)
            {
                if (textBox6.Text.Length == 2 && textBox7.Text.Length == 2 && textBox11.Text.Length == 2 && textBox10.Text.Length == 2)
                {
                    string tmp = textBox7.Text;
                    textBox7.Text = textBox10.Text;
                    textBox10.Text = tmp;
                    textBox2.Text = textBox6.Text + textBox7.Text;
                    textBox4.Text = textBox11.Text + textBox10.Text;
                }
                else
                {
                    textBox2.Text = "Niepoprawne";
                    textBox4.Text = "Niepoprawne";
                }
            }
            if (listBox1.SelectedIndex == 5 && listBox2.SelectedIndex == 10)
            {
                if (textBox6.Text.Length == 2 && textBox7.Text.Length == 2 && textBox13.Text.Length == 2 && textBox12.Text.Length == 2)
                {
                    string tmp = textBox7.Text;
                    textBox7.Text = textBox13.Text;
                    textBox13.Text = tmp;
                    textBox2.Text = textBox6.Text + textBox7.Text;
                    textBox5.Text = textBox13.Text + textBox12.Text;
                }
                else
                {
                    textBox2.Text = "Niepoprawne";
                    textBox5.Text = "Niepoprawne";
                }
            }
            if (listBox1.SelectedIndex == 5 && listBox2.SelectedIndex == 11)
            {
                if (textBox6.Text.Length == 2 && textBox7.Text.Length == 2 && textBox13.Text.Length == 2 && textBox12.Text.Length == 2)
                {
                    string tmp = textBox7.Text;
                    textBox7.Text = textBox12.Text;
                    textBox12.Text = tmp;
                    textBox2.Text = textBox6.Text + textBox7.Text;
                    textBox5.Text = textBox13.Text + textBox12.Text;
                }
                else
                {
                    textBox2.Text = "Niepoprawne";
                    textBox5.Text = "Niepoprawne";
                }
            }
            //BH
            if (listBox1.SelectedIndex == 6 && listBox2.SelectedIndex == 4)
            {
                if (textBox9.Text.Length == 2 && textBox8.Text.Length == 2 && textBox6.Text.Length == 2 && textBox7.Text.Length == 2)
                {
                    string tmp = textBox9.Text;
                    textBox9.Text = textBox6.Text;
                    textBox6.Text = tmp;
                    textBox3.Text = textBox9.Text + textBox8.Text;
                    textBox2.Text = textBox6.Text + textBox7.Text;
                }
                else
                {
                    textBox3.Text = "Niepoprawne";
                    textBox2.Text = "Niepoprawne";
                }
            }
            if (listBox1.SelectedIndex == 6 && listBox2.SelectedIndex == 5)
            {
                if (textBox9.Text.Length == 2 && textBox8.Text.Length == 2 && textBox6.Text.Length == 2 && textBox7.Text.Length == 2)
                {
                    string tmp = textBox9.Text;
                    textBox9.Text = textBox7.Text;
                    textBox7.Text = tmp;
                    textBox3.Text = textBox9.Text + textBox8.Text;
                    textBox2.Text = textBox6.Text + textBox7.Text;
                }
                else
                {
                    textBox3.Text = "Niepoprawne";
                    textBox2.Text = "Niepoprawne";
                }
            }
            if (listBox1.SelectedIndex == 6 && listBox2.SelectedIndex == 7)
            {
                if (textBox9.Text.Length == 2 && textBox8.Text.Length == 2)
                {
                    string tmp = textBox9.Text;
                    textBox9.Text = textBox8.Text;
                    textBox8.Text = tmp;
                    textBox3.Text = textBox9.Text + textBox8.Text;
                }
                else
                {
                    textBox3.Text = "Niepoprawne";
                }
            }
            if (listBox1.SelectedIndex == 6 && listBox2.SelectedIndex == 8)
            {
                if (textBox9.Text.Length == 2 && textBox8.Text.Length == 2 && textBox11.Text.Length == 2 && textBox10.Text.Length == 2)
                {
                    string tmp = textBox9.Text;
                    textBox9.Text = textBox11.Text;
                    textBox11.Text = tmp;
                    textBox4.Text = textBox11.Text + textBox10.Text;
                    textBox3.Text = textBox9.Text + textBox8.Text;
                }
                else
                {
                    textBox3.Text = "Niepoprawne";
                    textBox4.Text = "Niepoprawne";
                }
            }
            if (listBox1.SelectedIndex == 6 && listBox2.SelectedIndex == 9)
            {
                if (textBox9.Text.Length == 2 && textBox8.Text.Length == 2 && textBox11.Text.Length == 2 && textBox10.Text.Length == 2)
                {
                    string tmp = textBox9.Text;
                    textBox9.Text = textBox10.Text;
                    textBox10.Text = tmp;
                    textBox4.Text = textBox11.Text + textBox10.Text;
                    textBox3.Text = textBox9.Text + textBox8.Text;
                }
                else
                {
                    textBox3.Text = "Niepoprawne";
                    textBox4.Text = "Niepoprawne";
                }
            }
            if (listBox1.SelectedIndex == 6 && listBox2.SelectedIndex == 10)
            {
                if (textBox9.Text.Length == 2 && textBox8.Text.Length == 2 && textBox13.Text.Length == 2 && textBox12.Text.Length == 2)
                {
                    string tmp = textBox9.Text;
                    textBox9.Text = textBox13.Text;
                    textBox13.Text = tmp;
                    textBox5.Text = textBox13.Text + textBox12.Text;
                    textBox3.Text = textBox9.Text + textBox8.Text;
                }
                else
                {
                    textBox3.Text = "Niepoprawne";
                    textBox5.Text = "Niepoprawne";
                }
            }
            if (listBox1.SelectedIndex == 6 && listBox2.SelectedIndex == 11)
            {
                if (textBox9.Text.Length == 2 && textBox8.Text.Length == 2 && textBox13.Text.Length == 2 && textBox12.Text.Length == 2)
                {
                    string tmp = textBox9.Text;
                    textBox9.Text = textBox12.Text;
                    textBox12.Text = tmp;
                    textBox5.Text = textBox13.Text + textBox12.Text;
                    textBox3.Text = textBox9.Text + textBox8.Text;
                }
                else
                {
                    textBox3.Text = "Niepoprawne";
                    textBox5.Text = "Niepoprawne";
                }
            }
            //BL
            if (listBox1.SelectedIndex == 7 && listBox2.SelectedIndex == 4)
            {
                if (textBox9.Text.Length == 2 && textBox8.Text.Length == 2 && textBox6.Text.Length == 2 && textBox7.Text.Length == 2)
                {
                    string tmp = textBox8.Text;
                    textBox8.Text = textBox6.Text;
                    textBox6.Text = tmp;
                    textBox2.Text = textBox6.Text + textBox7.Text;
                    textBox3.Text = textBox9.Text + textBox8.Text;
                }
                else
                {
                    textBox3.Text = "Niepoprawne";
                    textBox2.Text = "Niepoprawne";
                }
            }
            if (listBox1.SelectedIndex == 7 && listBox2.SelectedIndex == 5)
            {
                if (textBox9.Text.Length == 2 && textBox8.Text.Length == 2 && textBox6.Text.Length == 2 && textBox7.Text.Length == 2)
                {
                    string tmp = textBox8.Text;
                    textBox8.Text = textBox7.Text;
                    textBox7.Text = tmp;
                    textBox2.Text = textBox6.Text + textBox7.Text;
                    textBox3.Text = textBox9.Text + textBox8.Text;
                }
                else
                {
                    textBox3.Text = "Niepoprawne";
                    textBox2.Text = "Niepoprawne";
                }
            }
            if (listBox1.SelectedIndex == 7 && listBox2.SelectedIndex == 6)
            {
                if (textBox9.Text.Length == 2 && textBox8.Text.Length == 2)
                {
                    string tmp = textBox8.Text;
                    textBox8.Text = textBox9.Text;
                    textBox9.Text = tmp;
                    textBox3.Text = textBox9.Text + textBox8.Text;
                }
                else
                {
                    textBox3.Text = "Niepoprawne";
                }
            }
            if (listBox1.SelectedIndex == 7 && listBox2.SelectedIndex == 8)
            {
                if (textBox9.Text.Length == 2 && textBox8.Text.Length == 2 && textBox11.Text.Length == 2 && textBox10.Text.Length == 2)
                {
                    string tmp = textBox8.Text;
                    textBox8.Text = textBox11.Text;
                    textBox11.Text = tmp;
                    textBox4.Text = textBox11.Text + textBox10.Text;
                    textBox3.Text = textBox9.Text + textBox8.Text;
                }
                else
                {
                    textBox3.Text = "Niepoprawne";
                    textBox4.Text = "Niepoprawne";
                }
            }
            if (listBox1.SelectedIndex == 7 && listBox2.SelectedIndex == 9)
            {
                if (textBox9.Text.Length == 2 && textBox8.Text.Length == 2 && textBox11.Text.Length == 2 && textBox10.Text.Length == 2)
                {
                    string tmp = textBox8.Text;
                    textBox8.Text = textBox10.Text;
                    textBox10.Text = tmp;
                    textBox4.Text = textBox11.Text + textBox10.Text;
                    textBox3.Text = textBox9.Text + textBox8.Text;
                }
                else
                {
                    textBox3.Text = "Niepoprawne";
                    textBox4.Text = "Niepoprawne";
                }
            }
            if (listBox1.SelectedIndex == 7 && listBox2.SelectedIndex == 10)
            {
                if (textBox9.Text.Length == 2 && textBox8.Text.Length == 2 && textBox13.Text.Length == 2 && textBox12.Text.Length == 2)
                {
                    string tmp = textBox8.Text;
                    textBox8.Text = textBox13.Text;
                    textBox13.Text = tmp;
                    textBox5.Text = textBox13.Text + textBox12.Text;
                    textBox3.Text = textBox9.Text + textBox8.Text;
                }
                else
                {
                    textBox3.Text = "Niepoprawne";
                    textBox5.Text = "Niepoprawne";
                }
            }
            if (listBox1.SelectedIndex == 7 && listBox2.SelectedIndex == 11)
            {
                if (textBox9.Text.Length == 2 && textBox8.Text.Length == 2 && textBox13.Text.Length == 2 && textBox12.Text.Length == 2)
                {
                    string tmp = textBox8.Text;
                    textBox8.Text = textBox12.Text;
                    textBox12.Text = tmp;
                    textBox5.Text = textBox13.Text + textBox12.Text;
                    textBox3.Text = textBox9.Text + textBox8.Text;
                }
                else
                {
                    textBox3.Text = "Niepoprawne";
                    textBox5.Text = "Niepoprawne";
                }
            }
            //CH
            if (listBox1.SelectedIndex == 8 && listBox2.SelectedIndex == 4)
            {
                if (textBox11.Text.Length == 2 && textBox10.Text.Length == 2 && textBox6.Text.Length == 2 && textBox7.Text.Length == 2)
                {
                    string tmp = textBox11.Text;
                    textBox11.Text = textBox6.Text;
                    textBox6.Text = textBox11.Text;
                    textBox4.Text = textBox11.Text + textBox10.Text;
                    textBox2.Text = textBox6.Text + textBox7.Text;
                }
                else
                {
                    textBox4.Text = "Niepoprawne";
                    textBox2.Text = "Niepoprawne";
                }
            }
            if (listBox1.SelectedIndex == 8 && listBox2.SelectedIndex == 5)
            {
                if (textBox11.Text.Length == 2 && textBox10.Text.Length == 2 && textBox6.Text.Length == 2 && textBox7.Text.Length == 2)
                {
                    string tmp = textBox11.Text;
                    textBox11.Text = textBox7.Text;
                    textBox7.Text = textBox11.Text;
                    textBox4.Text = textBox11.Text + textBox10.Text;
                    textBox2.Text = textBox6.Text + textBox7.Text;
                }
                else
                {
                    textBox4.Text = "Niepoprawne";
                    textBox2.Text = "Niepoprawne";
                }
            }
            if (listBox1.SelectedIndex == 8 && listBox2.SelectedIndex == 6)
            {
                if (textBox11.Text.Length == 2 && textBox10.Text.Length == 2 && textBox9.Text.Length == 2 && textBox8.Text.Length == 2)
                {
                    string tmp = textBox11.Text;
                    textBox11.Text = textBox9.Text;
                    textBox9.Text = textBox11.Text;
                    textBox4.Text = textBox11.Text + textBox10.Text;
                    textBox3.Text = textBox9.Text + textBox8.Text;
                }
                else
                {
                    textBox4.Text = "Niepoprawne";
                    textBox3.Text = "Niepoprawne";
                }
            }
            if (listBox1.SelectedIndex == 8 && listBox2.SelectedIndex == 7)
            {
                if (textBox11.Text.Length == 2 && textBox10.Text.Length == 2 && textBox9.Text.Length == 2 && textBox8.Text.Length == 2)
                {
                    string tmp = textBox11.Text;
                    textBox11.Text = textBox8.Text;
                    textBox8.Text = textBox11.Text;
                    textBox4.Text = textBox11.Text + textBox10.Text;
                    textBox3.Text = textBox9.Text + textBox8.Text;
                }
                else
                {
                    textBox4.Text = "Niepoprawne";
                    textBox3.Text = "Niepoprawne";
                }
            }
            if (listBox1.SelectedIndex == 8 && listBox2.SelectedIndex == 9)
            {
                if (textBox11.Text.Length == 2 && textBox10.Text.Length == 2)
                {
                    string tmp = textBox11.Text;
                    textBox11.Text = textBox10.Text;
                    textBox10.Text = tmp;
                    textBox4.Text = textBox11.Text + textBox10.Text;
                }
                else
                {
                    textBox4.Text = "Niepoprawne";
                }
            }
            if (listBox1.SelectedIndex == 8 && listBox2.SelectedIndex == 10)
            {
                if (textBox11.Text.Length == 2 && textBox10.Text.Length == 2 && textBox13.Text.Length == 2 && textBox12.Text.Length == 2)
                {
                    string tmp = textBox11.Text;
                    textBox11.Text = textBox13.Text;
                    textBox13.Text = textBox11.Text;
                    textBox4.Text = textBox11.Text + textBox10.Text;
                    textBox5.Text = textBox13.Text + textBox12.Text;
                }
                else
                {
                    textBox4.Text = "Niepoprawne";
                    textBox5.Text = "Niepoprawne";
                }
            }
            if (listBox1.SelectedIndex == 8 && listBox2.SelectedIndex == 11)
            {
                if (textBox11.Text.Length == 2 && textBox10.Text.Length == 2 && textBox13.Text.Length == 2 && textBox12.Text.Length == 2)
                {
                    string tmp = textBox11.Text;
                    textBox11.Text = textBox12.Text;
                    textBox12.Text = textBox11.Text;
                    textBox4.Text = textBox11.Text + textBox10.Text;
                    textBox5.Text = textBox13.Text + textBox12.Text;
                }
                else
                {
                    textBox4.Text = "Niepoprawne";
                    textBox5.Text = "Niepoprawne";
                }
            }
            //CL
            if (listBox1.SelectedIndex == 9 && listBox2.SelectedIndex == 4)
            {
                if (textBox11.Text.Length == 2 && textBox10.Text.Length == 2 && textBox6.Text.Length == 2 && textBox7.Text.Length == 2)
                {
                    string tmp = textBox10.Text;
                    textBox10.Text = textBox6.Text;
                    textBox6.Text = tmp;
                    textBox4.Text = textBox11.Text + textBox10.Text;
                    textBox2.Text = textBox6.Text + textBox7.Text;
                }
                else
                {
                    textBox4.Text = "Niepoprawne";
                    textBox2.Text = "Niepoprawne";
                }
            }
            if (listBox1.SelectedIndex == 9 && listBox2.SelectedIndex == 5)
            {
                if (textBox11.Text.Length == 2 && textBox10.Text.Length == 2 && textBox6.Text.Length == 2 && textBox7.Text.Length == 2)
                {
                    string tmp = textBox10.Text;
                    textBox10.Text = textBox7.Text;
                    textBox7.Text = tmp;
                    textBox4.Text = textBox11.Text + textBox10.Text;
                    textBox2.Text = textBox6.Text + textBox7.Text;
                }
                else
                {
                    textBox4.Text = "Niepoprawne";
                    textBox2.Text = "Niepoprawne";
                }
            }
            if (listBox1.SelectedIndex == 9 && listBox2.SelectedIndex == 6)
            {
                if (textBox11.Text.Length == 2 && textBox10.Text.Length == 2 && textBox9.Text.Length == 2 && textBox8.Text.Length == 2)
                {
                    string tmp = textBox10.Text;
                    textBox10.Text = textBox9.Text;
                    textBox9.Text = tmp;
                    textBox4.Text = textBox11.Text + textBox10.Text;
                    textBox3.Text = textBox9.Text + textBox8.Text;
                }
                else
                {
                    textBox4.Text = "Niepoprawne";
                    textBox3.Text = "Niepoprawne";
                }
            }
            if (listBox1.SelectedIndex == 9 && listBox2.SelectedIndex == 7)
            {
                if (textBox11.Text.Length == 2 && textBox10.Text.Length == 2 && textBox9.Text.Length == 2 && textBox8.Text.Length == 2)
                {
                    string tmp = textBox10.Text;
                    textBox10.Text = textBox8.Text;
                    textBox8.Text = tmp;
                    textBox4.Text = textBox11.Text + textBox10.Text;
                    textBox3.Text = textBox9.Text + textBox8.Text;
                }
                else
                {
                    textBox4.Text = "Niepoprawne";
                    textBox3.Text = "Niepoprawne";
                }
            }
            if (listBox1.SelectedIndex == 9 && listBox2.SelectedIndex == 8)
            {
                if (textBox11.Text.Length == 2 && textBox10.Text.Length == 2)
                {
                    string tmp = textBox10.Text;
                    textBox10.Text = textBox11.Text;
                    textBox11.Text = tmp;
                    textBox4.Text = textBox11.Text + textBox10.Text;
                }
                else
                {
                    textBox4.Text = "Niepoprawne";
                }
            }
            if (listBox1.SelectedIndex == 9 && listBox2.SelectedIndex == 10)
            {
                if (textBox11.Text.Length == 2 && textBox10.Text.Length == 2 && textBox13.Text.Length == 2 && textBox12.Text.Length == 2)
                {
                    string tmp = textBox10.Text;
                    textBox10.Text = textBox13.Text;
                    textBox13.Text = tmp;
                    textBox4.Text = textBox11.Text + textBox10.Text;
                    textBox5.Text = textBox13.Text + textBox12.Text;
                }
                else
                {
                    textBox4.Text = "Niepoprawne";
                    textBox5.Text = "Niepoprawne";
                }
            }
            if (listBox1.SelectedIndex == 9 && listBox2.SelectedIndex == 11)
            {
                if (textBox11.Text.Length == 2 && textBox10.Text.Length == 2 && textBox13.Text.Length == 2 && textBox12.Text.Length == 2)
                {
                    string tmp = textBox10.Text;
                    textBox10.Text = textBox12.Text;
                    textBox12.Text = tmp;
                    textBox4.Text = textBox11.Text + textBox10.Text;
                    textBox5.Text = textBox13.Text + textBox12.Text;
                }
                else
                {
                    textBox4.Text = "Niepoprawne";
                    textBox5.Text = "Niepoprawne";
                }
            }
            //DH
            if (listBox1.SelectedIndex == 10 && listBox2.SelectedIndex == 4)
            {
                if (textBox13.Text.Length == 2 && textBox12.Text.Length == 2 && textBox6.Text.Length == 2 && textBox7.Text.Length == 2)
                {
                    string tmp = textBox13.Text;
                    textBox13.Text = textBox6.Text;
                    textBox6.Text = tmp;
                    textBox5.Text = textBox13.Text + textBox12.Text;
                    textBox2.Text = textBox6.Text + textBox7.Text;
                }
                else
                {
                    textBox5.Text = "Niepoprawne";
                    textBox2.Text = "Niepoprawne";
                }
            }
            if (listBox1.SelectedIndex == 10 && listBox2.SelectedIndex == 5)
            {
                if (textBox13.Text.Length == 2 && textBox12.Text.Length == 2 && textBox6.Text.Length == 2 && textBox7.Text.Length == 2)
                {
                    string tmp = textBox13.Text;
                    textBox13.Text = textBox7.Text;
                    textBox7.Text = tmp;
                    textBox5.Text = textBox13.Text + textBox12.Text;
                    textBox2.Text = textBox6.Text + textBox7.Text;
                }
                else
                {
                    textBox5.Text = "Niepoprawne";
                    textBox2.Text = "Niepoprawne";
                }
            }
            if (listBox1.SelectedIndex == 10 && listBox2.SelectedIndex == 6)
            {
                if (textBox13.Text.Length == 2 && textBox12.Text.Length == 2 && textBox9.Text.Length == 2 && textBox8.Text.Length == 2)
                {
                    string tmp = textBox13.Text;
                    textBox13.Text = textBox9.Text;
                    textBox9.Text = tmp;
                    textBox5.Text = textBox13.Text + textBox12.Text;
                    textBox3.Text = textBox9.Text + textBox8.Text;
                }
                else
                {
                    textBox5.Text = "Niepoprawne";
                    textBox3.Text = "Niepoprawne";
                }
            }
            if (listBox1.SelectedIndex == 10 && listBox2.SelectedIndex == 7)
            {
                if (textBox13.Text.Length == 2 && textBox12.Text.Length == 2 && textBox9.Text.Length == 2 && textBox8.Text.Length == 2)
                {
                    string tmp = textBox13.Text;
                    textBox13.Text = textBox8.Text;
                    textBox8.Text = tmp;
                    textBox5.Text = textBox13.Text + textBox12.Text;
                    textBox3.Text = textBox9.Text + textBox8.Text;
                }
                else
                {
                    textBox5.Text = "Niepoprawne";
                    textBox3.Text = "Niepoprawne";
                }
            }
            if (listBox1.SelectedIndex == 10 && listBox2.SelectedIndex == 8)
            {
                if (textBox13.Text.Length == 2 && textBox12.Text.Length == 2 && textBox11.Text.Length == 2 && textBox10.Text.Length == 2)
                {
                    string tmp = textBox13.Text;
                    textBox13.Text = textBox11.Text;
                    textBox11.Text = tmp;
                    textBox5.Text = textBox13.Text + textBox12.Text;
                    textBox4.Text = textBox11.Text + textBox10.Text;
                }
                else
                {
                    textBox5.Text = "Niepoprawne";
                    textBox4.Text = "Niepoprawne";
                }
            }
            if (listBox1.SelectedIndex == 10 && listBox2.SelectedIndex == 9)
            {
                if (textBox13.Text.Length == 2 && textBox12.Text.Length == 2 && textBox11.Text.Length == 2 && textBox10.Text.Length == 2)
                {
                    string tmp = textBox13.Text;
                    textBox13.Text = textBox10.Text;
                    textBox10.Text = tmp;
                    textBox5.Text = textBox13.Text + textBox12.Text;
                    textBox4.Text = textBox11.Text + textBox10.Text;
                }
                else
                {
                    textBox5.Text = "Niepoprawne";
                    textBox4.Text = "Niepoprawne";
                }
            }
            if (listBox1.SelectedIndex == 10 && listBox2.SelectedIndex == 11)
            {
                if (textBox13.Text.Length == 2 && textBox12.Text.Length == 2)
                {
                    string tmp = textBox13.Text;
                    textBox13.Text = textBox12.Text;
                    textBox12.Text = tmp;
                    textBox5.Text = textBox13.Text + textBox12.Text;
                }
                else
                {
                    textBox5.Text = "Niepoprawne";
                }
            }
            //DL
            if (listBox1.SelectedIndex == 11 && listBox2.SelectedIndex == 4)
            {
                if (textBox13.Text.Length == 2 && textBox12.Text.Length == 2 && textBox6.Text.Length == 2 && textBox7.Text.Length == 2)
                {
                    string tmp = textBox12.Text;
                    textBox12.Text = textBox6.Text;
                    textBox6.Text = tmp;
                    textBox5.Text = textBox13.Text + textBox12.Text;
                    textBox2.Text = textBox6.Text + textBox7.Text;
                }
                else
                {
                    textBox5.Text = "Niepoprawne";
                    textBox2.Text = "Niepoprawne";
                }
            }
            if (listBox1.SelectedIndex == 11 && listBox2.SelectedIndex == 5)
            {
                if (textBox13.Text.Length == 2 && textBox12.Text.Length == 2 && textBox6.Text.Length == 2 && textBox7.Text.Length == 2)
                {
                    string tmp = textBox12.Text;
                    textBox12.Text = textBox7.Text;
                    textBox7.Text = tmp;
                    textBox5.Text = textBox13.Text + textBox12.Text;
                    textBox2.Text = textBox6.Text + textBox7.Text;
                }
                else
                {
                    textBox5.Text = "Niepoprawne";
                    textBox2.Text = "Niepoprawne";
                }
            }
            if (listBox1.SelectedIndex == 11 && listBox2.SelectedIndex == 6)
            {
                if (textBox13.Text.Length == 2 && textBox12.Text.Length == 2 && textBox9.Text.Length == 2 && textBox8.Text.Length == 2)
                {
                    string tmp = textBox12.Text;
                    textBox12.Text = textBox9.Text;
                    textBox9.Text = tmp;
                    textBox5.Text = textBox13.Text + textBox12.Text;
                    textBox3.Text = textBox9.Text + textBox8.Text;
                }
                else
                {
                    textBox5.Text = "Niepoprawne";
                    textBox3.Text = "Niepoprawne";
                }
            }
            if (listBox1.SelectedIndex == 11 && listBox2.SelectedIndex == 7)
            {
                if (textBox13.Text.Length == 2 && textBox12.Text.Length == 2 && textBox9.Text.Length == 2 && textBox8.Text.Length == 2)
                {
                    string tmp = textBox12.Text;
                    textBox12.Text = textBox8.Text;
                    textBox8.Text = tmp;
                    textBox5.Text = textBox13.Text + textBox12.Text;
                    textBox3.Text = textBox9.Text + textBox8.Text;
                }
                else
                {
                    textBox5.Text = "Niepoprawne";
                    textBox3.Text = "Niepoprawne";
                }
            }
            if (listBox1.SelectedIndex == 11 && listBox2.SelectedIndex == 8)
            {
                if (textBox13.Text.Length == 2 && textBox12.Text.Length == 2 && textBox11.Text.Length == 2 && textBox10.Text.Length == 2)
                {
                    string tmp = textBox12.Text;
                    textBox12.Text = textBox11.Text;
                    textBox11.Text = tmp;
                    textBox5.Text = textBox13.Text + textBox12.Text;
                    textBox4.Text = textBox11.Text + textBox10.Text;
                }
                else
                {
                    textBox5.Text = "Niepoprawne";
                    textBox4.Text = "Niepoprawne";
                }
            }
            if (listBox1.SelectedIndex == 11 && listBox2.SelectedIndex == 9)
            {
                if (textBox13.Text.Length == 2 && textBox12.Text.Length == 2 && textBox11.Text.Length == 2 && textBox10.Text.Length == 2)
                {
                    string tmp = textBox12.Text;
                    textBox12.Text = textBox10.Text;
                    textBox10.Text = tmp;
                    textBox5.Text = textBox13.Text + textBox12.Text;
                    textBox4.Text = textBox11.Text + textBox10.Text;
                }
                else
                {
                    textBox5.Text = "Niepoprawne";
                    textBox4.Text = "Niepoprawne";
                }
            }
            if (listBox1.SelectedIndex == 11 && listBox2.SelectedIndex == 10)
            {
                if (textBox13.Text.Length == 2 && textBox12.Text.Length == 2)
                {
                    string tmp = textBox12.Text;
                    textBox12.Text = textBox13.Text;
                    textBox13.Text = tmp;
                    textBox5.Text = textBox13.Text + textBox12.Text;
                }
                else
                {
                    textBox5.Text = "Niepoprawne";
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            static string getRandom()
            {
                const string chars = "ABCDEF0123456789";

                return new string(Enumerable.Repeat(chars, 2).Select(s => s[new Random().Next(s.Length)]).ToArray());
            }

            string[] tablica = new string[8];

            for (int i = 0; i < 8; i++)
            {
                string s = getRandom();
                tablica[i] = s;
            }

            textBox6.Text = tablica[0];
            textBox7.Text = tablica[1];
            textBox2.Text = textBox6.Text + textBox7.Text;
            textBox9.Text = tablica[2];
            textBox8.Text = tablica[3];
            textBox3.Text = textBox9.Text + textBox8.Text;
            textBox11.Text = tablica[4];
            textBox10.Text = tablica[5];
            textBox4.Text = textBox11.Text + textBox10.Text;
            textBox13.Text = tablica[6];
            textBox12.Text = tablica[7];
            textBox5.Text = textBox13.Text + textBox12.Text;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            textBox6.Text = "00";
            textBox7.Text = "00";
            textBox8.Text = "00";
            textBox9.Text = "00";
            textBox10.Text = "00";
            textBox11.Text = "00";
            textBox12.Text = "00";
            textBox13.Text = "00";
            textBox2.Text = textBox6.Text + textBox7.Text;
            textBox3.Text = textBox8.Text + textBox9.Text;
            textBox4.Text = textBox10.Text + textBox11.Text;
            textBox5.Text = textBox12.Text + textBox13.Text;
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2 != null && !string.IsNullOrWhiteSpace(textBox2.Text) && textBox2.Text.Length == 4)
            {
                textBox6.Text = textBox2.Text.Substring(0, 2);
                textBox7.Text = textBox2.Text.Substring(2, 2);
            }
            else
            {
                textBox6.Text = "Niepoprawnie";
                textBox7.Text = "Niepoprawnie";
            }

        }
        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3 != null && !string.IsNullOrWhiteSpace(textBox3.Text) && textBox3.Text.Length == 4)
            {
                textBox9.Text = textBox3.Text.Substring(0, 2);
                textBox8.Text = textBox3.Text.Substring(2, 2);
            }
            else
            {
                textBox9.Text = "Niepoprawnie";
                textBox8.Text = "Niepoprawnie";
            }
        }
        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4 != null && !string.IsNullOrWhiteSpace(textBox4.Text) && textBox4.Text.Length == 4)
            {
                textBox11.Text = textBox4.Text.Substring(0, 2);
                textBox10.Text = textBox4.Text.Substring(2, 2);
            }
            else
            {
                textBox11.Text = "Niepoprawnie";
                textBox10.Text = "Niepoprawnie";
            }
        }
        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (textBox5 != null && !string.IsNullOrWhiteSpace(textBox5.Text) && textBox5.Text.Length == 4)
            {
                textBox13.Text = textBox5.Text.Substring(0, 2);
                textBox12.Text = textBox5.Text.Substring(2, 2);
            }
            else
            {
                textBox13.Text = "Niepoprawnie";
                textBox12.Text = "Niepoprawnie";
            }
        }
        private void textBox6_Leave(object sender, EventArgs e)
        {
            if (textBox6.Text.Length == 2 && textBox7.Text.Length == 2)
            {
                textBox2.Text = textBox6.Text + textBox7.Text;
            }
            else
            {
                textBox2.Text = "Niepoprawnie";
            }
        }
        private void textBox7_Leave(object sender, EventArgs e)
        {
            if (textBox6.Text.Length == 2 && textBox7.Text.Length == 2)
            {
                textBox2.Text = textBox6.Text + textBox7.Text;
            }
            else
            {
                textBox2.Text = "Niepoprawnie";
            }
        }
        private void textBox9_Leave(object sender, EventArgs e)
        {
            if (textBox9.Text.Length == 2 && textBox8.Text.Length == 2)
            {
                textBox3.Text = textBox9.Text + textBox8.Text;
            }
            else
            {
                textBox3.Text = "Niepoprawnie";
            }
        }
        private void textBox8_Leave(object sender, EventArgs e)
        {
            if (textBox9.Text.Length == 2 && textBox8.Text.Length == 2)
            {
                textBox3.Text = textBox9.Text + textBox8.Text;
            }
            else
            {
                textBox3.Text = "Niepoprawnie";
            }
        }
        private void textBox11_Leave(object sender, EventArgs e)
        {
            if (textBox11.Text.Length == 2 && textBox10.Text.Length == 2)
            {
                textBox4.Text = textBox11.Text + textBox10.Text;
            }
            else
            {
                textBox4.Text = "Niepoprawnie";
            }
        }
        private void textBox10_Leave(object sender, EventArgs e)
        {
            if (textBox11.Text.Length == 2 && textBox10.Text.Length == 2)
            {
                textBox4.Text = textBox11.Text + textBox10.Text;
            }
            else
            {
                textBox4.Text = "Niepoprawnie";
            }
        }
        private void textBox13_Leave(object sender, EventArgs e)
        {
            if (textBox13.Text.Length == 2 && textBox12.Text.Length == 2)
            {
                textBox5.Text = textBox13.Text + textBox12.Text;
            }
            else
            {
                textBox5.Text = "Niepoprawnie";
            }
        }
        private void textBox12_Leave(object sender, EventArgs e)
        {
            if (textBox13.Text.Length == 2 && textBox12.Text.Length == 2)
            {
                textBox5.Text = textBox13.Text + textBox12.Text;
            }
            else
            {
                textBox5.Text = "Niepoprawnie";
            }
        }
    }
}
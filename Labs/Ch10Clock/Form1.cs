using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name: Aaron McArdle
 * 
 * Create a GUI application that demonstrates focus, keyboard, and mouse events.
 * - When the user clicks on a textbox change the background color to yellow
 * - When a textbox recieves focus change the background color to lightblue
 * - When a textbox loses focus change the background color to lightgray
 * - When the user presses down the up arrow on the keybaord, change the focus to textbox 1
 * - When the user presses down the right arrow on the keyboard, change the focus to textbox 3
 * - When the user presses down the down arrow on the keyboard, change the focus to textbox 5
 * - When the user presses down the left arrow on the keyboard, change the focus to textbox 7
 * 
 */

namespace Ch10Clock
{
    public partial class FormClock : Form
    {
        public FormClock()
        {
            InitializeComponent();
        }

        // Focus, LoseFocus and Click events for TextBox1

        private void TextBox1_Focus(object sender, EventArgs e)
        {

            textBox1.BackColor = Color.LightBlue;
        }

        private void TextBox1_LoseFocus(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.LightGray;
        }

        private void TextBox1_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Yellow;
        }

        // Focus, LoseFocus and Click events for TextBox2

        private void TextBox2_Focus(object sender, EventArgs e)
        {

            textBox2.BackColor = Color.LightBlue;
        }

        private void TextBox2_LoseFocus(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.LightGray;
        }

        private void TextBox2_Click(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.Yellow;
        }

        // Focus, LoseFocus and Click events for TextBox3

        private void TextBox3_Focus(object sender, EventArgs e)
        {

            textBox3.BackColor = Color.LightBlue;
        }

        private void TextBox3_LoseFocus(object sender, EventArgs e)
        {
            textBox3.BackColor = Color.LightGray;
        }

        private void TextBox3_Click(object sender, EventArgs e)
        {
            textBox3.BackColor = Color.Yellow;
        }

        // Focus, LoseFocus and Click events for TextBox4

        private void TextBox4_Focus(object sender, EventArgs e)
        {

            textBox4.BackColor = Color.LightBlue;
        }

        private void TextBox4_LoseFocus(object sender, EventArgs e)
        {
            textBox4.BackColor = Color.LightGray;
        }

        private void TextBox4_Click(object sender, EventArgs e)
        {
            textBox4.BackColor = Color.Yellow;
        }

        // Focus, LoseFocus and Click events for TextBox5

        private void TextBox5_Focus(object sender, EventArgs e)
        {

            textBox5.BackColor = Color.LightBlue;
        }

        private void TextBox5_LoseFocus(object sender, EventArgs e)
        {
            textBox5.BackColor = Color.LightGray;
        }

        private void TextBox5_Click(object sender, EventArgs e)
        {
            textBox5.BackColor = Color.Yellow;
        }

        // Focus, LoseFocus and Click events for TextBox6

        private void TextBox6_Focus(object sender, EventArgs e)
        {

            textBox6.BackColor = Color.LightBlue;
        }

        private void TextBox6_LoseFocus(object sender, EventArgs e)
        {
            textBox6.BackColor = Color.LightGray;
        }

        private void TextBox6_Click(object sender, EventArgs e)
        {
            textBox6.BackColor = Color.Yellow;
        }

        // Focus, LoseFocus and Click events for TextBox7

        private void TextBox7_Focus(object sender, EventArgs e)
        {

            textBox7.BackColor = Color.LightBlue;
        }

        private void TextBox7_LoseFocus(object sender, EventArgs e)
        {
            textBox7.BackColor = Color.LightGray;
        }

        private void TextBox7_Click(object sender, EventArgs e)
        {
            textBox7.BackColor = Color.Yellow;
        }

        // Focus, LoseFocus and Click events for TextBox8

        private void TextBox8_Focus(object sender, EventArgs e)
        {

            textBox8.BackColor = Color.LightBlue;
        }

        private void TextBox8_LoseFocus(object sender, EventArgs e)
        {
            textBox8.BackColor = Color.LightGray;
        }

        private void TextBox8_Click(object sender, EventArgs e)
        {
            textBox8.BackColor = Color.Yellow;
        }

        // Code for Key Press Event

        private void KeyPressEvent(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Up)
            {
                textBox1.Focus();
            }

            if (e.KeyData == Keys.Down)
            {
                textBox5.Focus();
            }

            if (e.KeyData == Keys.Left)
            {
                textBox7.Focus();
            }

            if (e.KeyData == Keys.Right)
            {
                textBox3.Focus();
            }
        }
    }
}

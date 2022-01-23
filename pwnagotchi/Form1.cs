using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pwnagotchi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void wait(int milliseconds)
        {
            var timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;

            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();

            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
            };

            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {
            label2.Text = "AUTO";
        }

        private void button25_Click(object sender, EventArgs e)
        {
            label2.Text = "MANU";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            label2.Text = "  AI";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button26_Click(object sender, EventArgs e)
        {
            label4.Text = textBox1.Text + " >";
            label5.Text = richTextBox1.Text;
            label3.Text = "PWND " + textBox2.Text + " | (00)";
            label7.Text = "UP " + textBox3.Text;
            label28.Text = textBox8.Text + "W " + textBox9.Text + "V | " + textBox11.Text + "/" + textBox10.Text + " mAh Li-ion";
            label30.Text = "CPU: " + textBox4.Text + "%";
            label32.Text = "MEM: " + textBox6.Text + "%";
            label33.Text = "TEMP: " + textBox7.Text + "C°";
            label36.Text = textBox12.Text;
            label37.Text = textBox13.Text + " AM";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {
            label1.Text = "(✦‿‿✦)";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            label1.Text = "(#__#)";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "(⇀‿‿↼)";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "(≖‿‿≖)";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "(◕‿‿◕)";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "( ⚆_⚆)";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = "(⚆_⚆ )";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = " (◕‿◕)";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text = "(◕‿◕) ";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text = "(°▃▃°)";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text = "(⌐■_■)";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label1.Text = "(•‿‿•)";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            label1.Text = "(ᵔ◡◡ᵔ)";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label1.Text = "(^‿‿^)";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            label1.Text = "(✜‿‿✜)";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            label1.Text = "(♥‿‿♥)";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            label1.Text = "(☼‿‿☼)";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            label1.Text = "(≖__≖)";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            label1.Text = "(-__-)";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            label1.Text = "(╥☁╥ )";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            label1.Text = "(ب__ب)";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            label1.Text = "(☓‿‿☓)";
        }

        private void button27_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://pastebin.com/raw/JyZjtFHn");
        }

        private void button28_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            label5.Text = "Looking for (0 seconds)";
            label1.Text = "( ◕‿◕)";
            wait(500);
            label5.Text = "Looking for (1 seconds)";
            label1.Text = "(◕‿◕ )";
            wait(500);
            label5.Text = "Looking for (2 seconds)";
            label1.Text = "( ◕‿◕)";
            wait(500);
            label5.Text = "Looking for (3 seconds)";
            label1.Text = "(◕‿◕ )";
            wait(500);
            label5.Text = "Looking for (4 seconds)";
            label1.Text = "( ◕‿◕)";
            wait(500);
            label5.Text = "Looking for (5 seconds)";
            label1.Text = "(◕‿◕ )";
            wait(500);
            label5.Text = "Looking for (6 seconds)";
            label1.Text = "( ◕‿◕)";
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            label5.Text = "Looking for (0 seconds)";
            label1.Text = "( ☉_☉)";
            wait(500);
            label5.Text = "Looking for (1 seconds)";
            label1.Text = "(☉_☉ )";
            wait(500);
            label5.Text = "Looking for (2 seconds)";
            label1.Text = "( ☉_☉)";
            wait(500);
            label5.Text = "Looking for (3 seconds)";
            label1.Text = "(☉_☉ )";
            wait(500);
            label5.Text = "Looking for (4 seconds)";
            label1.Text = "( ☉_☉)";
            wait(500);
            label5.Text = "Looking for (5 seconds)";
            label1.Text = "(☉_☉ )";
            wait(500);
            label5.Text = "Looking for (6 seconds)";
            label1.Text = "( ☉_☉)";

        }

        private void label28_Click(object sender, EventArgs e)
        {
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton6_Click(object sender, EventArgs e)
        {
            label28.Text = textBox8.Text + "W " + textBox9.Text + "V | " + textBox11.Text + "/" + textBox10.Text + " mAh" + " Li-ion";
        }

        private void radioButton7_Click(object sender, EventArgs e)
        {
            label28.Text = textBox8.Text + "W " + textBox9.Text + "V | " + textBox11.Text + "/" + textBox10.Text + " mAh" + " Li-po";
        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_Click(object sender, EventArgs e)
        {
            label33.Text = "TEMP: " + textBox7.Text + "C°";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_Click(object sender, EventArgs e)
        {
            label33.Text = "TEMP: " + textBox7.Text + "F°";
        }

        private void radioButton8_Click(object sender, EventArgs e)
        {
            label37.Text = textBox13.Text + " AM";
        }

        private void radioButton9_Click(object sender, EventArgs e)
        {
            label37.Text = textBox13.Text + " PM";
        }

        private void button30_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"docs.html");
        }

        private void button31_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://pwnagotchi.ai/");
        }
    }
}

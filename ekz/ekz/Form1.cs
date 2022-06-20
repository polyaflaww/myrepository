using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ekz
{
    public partial class Form15 : Form
    {
        Game15 game;
        public Form15()
        {
            InitializeComponent();
            game = new Game15(4);
        }

        DateTime timestart = new DateTime(0,0);

        private void StartTheGame()
        {
            game.Beginning();
            for (int j = 0; j < 100; j++)
                game.Moving_randomly();
            game.EmptyCell();
            Reset();
        }
        private void Reset ()
        {
            for (int position = 0; position < 16; position++)
            {
                button(position).Text = game.GetNumber(position).ToString();
                button(position).Visible = game.GetNumber(position) > 0;
            }
        }

        private Button button (int point)
        {
            switch (point)
            {
                case 0: return button0;
                case 1: return button1;
                case 2: return button2;
                case 3: return button3;
                case 4: return button4;
                case 5: return button5;
                case 6: return button6;
                case 7: return button7;
                case 8: return button8;
                case 9: return button9;
                case 10: return button10;
                case 11: return button11;
                case 12: return button12;
                case 13: return button13;
                case 14: return button14;
                case 15: return button15;
                default: return null;
            }
        }

        

        private void Form15_Load(object sender, EventArgs e)
        {
            game.Beginning();
            Reset();
            button0.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            int position = Convert.ToInt32(((Button)sender).Tag);
            game.Moving(position);
            Reset();

            if (game.CheckNumbers())
            {
                MessageBox.Show("Поздравляю, вы победили!\nВремя:\n" + (DateTime.Now - timestart).ToString());
                button0.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button11.Enabled = false;
                button12.Enabled = false;
                button13.Enabled = false;
                button14.Enabled = false;
                button15.Enabled = false;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            StartTheGame();
            timestart = DateTime.Now;
            button0.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

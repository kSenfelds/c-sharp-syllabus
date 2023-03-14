using System;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace MatchingGame
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        List<string> icons = new List<string>()
        {
            "!", "!", "N", "N", ",", ",", "k", "k",
            "b", "b", "v", "v", "w", "w", "z", "z"
        };
        Label firstClicked = null;
        Label secondClicked = null;
        int timeTaken = 0;
        SoundPlayer miss = new SoundPlayer("boing_x.wav");
        SoundPlayer correct = new SoundPlayer("buzzer_x.wav");
        SoundPlayer hideIcons = new SoundPlayer("fart_z.wav");

        public Form1()
        {
            InitializeComponent();
            AssignIconsToSqares();
        }

        private void AssignIconsToSqares()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    int randomNumber = random.Next(icons.Count);
                    iconLabel.Text = icons[randomNumber];
                    iconLabel.ForeColor = iconLabel.BackColor;
                    icons.RemoveAt(randomNumber);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
                return;

            Label clickedLabel = sender as Label;
            if (clickedLabel != null)
            {
                if (clickedLabel.ForeColor == Color.Black)
                {
                    return;
                }
                else if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    timer2.Start();

                    return;
                }
            }

            secondClicked = clickedLabel;
            secondClicked.ForeColor = Color.Black;

            CheckForWinner();

            if (firstClicked.Text == secondClicked.Text)
            {
                correct.Play();
                firstClicked = null;
                secondClicked = null;

                return;
            }

            timer1.Start();
            miss.Play();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            hideIcons.Play();

            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;

            firstClicked = null;
            secondClicked = null;
        }

        private void CheckForWinner()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;

                if (iconLabel != null)
                {
                    if (iconLabel.ForeColor == iconLabel.BackColor)
                    {
                        return;
                    }
                }
            }

            timer2.Stop();
            MessageBox.Show("You WIN!");
            Close();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = timeTaken.ToString();
            timeTaken++;
        }
    }
}
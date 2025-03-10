﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace Hang_Man_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string word = "";
        List<Label> labels = new List<Label>();
        int amount = 0;
        enum BodyParts
        {
            Head,
            Left_Eye,
            Right_Eye,
            Mouth,
            Body,
            Left_Arm,
            Right_Arm,
            Left_Leg,
            Right_Leg,
        }
        void DrawHangPost()
        {
            Graphics g = panel1.CreateGraphics();
            Pen p = new Pen(Color.Brown, 10);
            g.DrawLine(p, new Point(130, 218), new Point(130, 5));
            g.DrawLine(p, new Point(135, 5), new Point(65, 5));
            g.DrawLine(p, new Point(60, 0), new Point(60, 50));
          
        }

        void DrawBodyPart(BodyParts bp)
        {
            Graphics g = panel1.CreateGraphics();
            Pen p = new Pen(Color.Blue, 2);
            if (bp == BodyParts.Head)
            {
                g.DrawEllipse(p, 40, 50, 40, 40);
            }
            else if (bp == BodyParts.Left_Eye)
            {
                SolidBrush s = new SolidBrush(Color.Black);
                g.FillEllipse(s, 50, 60, 5, 5);
            }
            else if (bp == BodyParts.Right_Eye)
            {
                SolidBrush s = new SolidBrush(Color.Black);
                g.FillEllipse(s, 63, 60, 5, 5);
            }
            else if (bp == BodyParts.Mouth)
            {
                g.DrawArc(p, 50, 60, 20, 20, 45, 90);
            }
            else if (bp == BodyParts.Body)
            {
                g.DrawLine(p, new Point(60, 90), new Point(60, 170));
            }
            else if (bp == BodyParts.Left_Arm)
            {
                g.DrawLine(p, new Point(60, 100), new Point(30, 85));
            }
            else if (bp == BodyParts.Right_Arm)
            {
                g.DrawLine(p, new Point(60, 100), new Point(90, 85));
            }
            else if (bp == BodyParts.Left_Leg)
            {
                g.DrawLine(p, new Point(60, 170), new Point(30, 190));
            }
            else if (bp == BodyParts.Right_Leg)
            {
                g.DrawLine(p, new Point(60, 170), new Point(90, 190));
            }
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text==word)
            {
                MessageBox.Show("You win!", "Congrats");
                ResetGame();
            }
            else
            {
                MessageBox.Show("Sorry, but the word you guessed is wrong!");
                DrawBodyPart((BodyParts)amount);
                amount++;
                if (amount == 9)
                {
                    MessageBox.Show("Sorry, but you lost! The word was " + word);
                    ResetGame();
                }
            }
        }

        void MakeLabels()
        {
            word = GetRandomWord();
            
            char[] chars = word.ToCharArray();
            int between = 330 / chars.Length;
            for (int i = 0; i < chars.Length; i++)
            {
                labels.Add(new Label());
                labels[i].Location = new Point((i * between) + 10, 80);
                labels[i].Text = "_";
                labels[i].Parent = groupBox1;
                labels[i].BringToFront();
                labels[i].CreateControl();
            }
            label1.Text = "Word Lenght: " + (chars.Length).ToString();
        }
        string GetRandomWord()
        {
            WebClient wc = new WebClient();
            string wordList = wc.DownloadString("https://www.mit.edu/~ecprice/wordlist.10000");
            string[] words = wordList.Split('\n');
            Random ran = new Random();
            return words[ran.Next(0, words.Length)];
        }
        private void Form1_Shown(object sender, EventArgs e)
        {
            DrawHangPost();
            MakeLabels();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char letter = textBox1.Text.ToLower().ToCharArray()[0];
            if (!char.IsLetter(letter))
            {
                MessageBox.Show("You can submit only letter!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (word.Contains(letter))
            {
                char[] letters = word.ToCharArray();
                for (int i = 0; i < letters.Length; i++)
                {
                    if (letters[i] == letter)
                    {
                        labels[i].Text = letter.ToString();
                    }
                }
                foreach (Label l in labels)
                {
                    if (l.Text == "_")
                    {
                        return;
                    }
                }
                MessageBox.Show("You win!", "Congrats");
                ResetGame();
            }
            else
            {
                MessageBox.Show("The letter that you guessed is not in the word!", "Sorry");
                label2.Text += " " + letter.ToString() + ",";
                DrawBodyPart((BodyParts)amount);
                amount++;
                if (amount == 9)
                {
                    MessageBox.Show("Sorry, but you lost! The word was " + word);
                    ResetGame();
                }
            }
        }
        void ResetGame()
        {
            Graphics g = panel1.CreateGraphics();
            g.Clear(panel1.BackColor);
            GetRandomWord();
            MakeLabels();
            DrawHangPost();
            label2.Text = "Missed: ";
            textBox1.Text = "";
            amount = 0;

        }
    }
}

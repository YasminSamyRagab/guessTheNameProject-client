using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client
{
    public partial class Spectate : Form
    {
        string word;
        int word_without_space = 0;
        string word_without_space_string = "";
        List<Label> word_labels;
        ArrayList gussedLetters;
        GroupBox labelsGroup;
        string player1;
        string player2;

        public Spectate(string p1, string p2)
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            player1 = p1;
            player2 = p2;
            loadform();
        }
        public void loadform()
        {
            Player1lbl.Text = player1;
            Player2lbl.Text = player2;
            word = playerInfo.word;
            word_labels = new List<Label>();
            word_label.Text = word;

            drawWord();

            gussedLetters = new ArrayList();
            foreach (var item in playerInfo.char_to_Watch)
            {
                string[] recievedString = item.Split('_');
                switch (recievedString[0])
                {
                    case "right":
                        string[] recievedIndex = recievedString[2].Split(',');
                        for (int i = 0; i < recievedIndex.Length; i++)
                        {

                            word_labels[int.Parse(recievedIndex[i])].Text = word[int.Parse(recievedIndex[i])].ToString();
                            word_without_space--;
                        }
                        word_without_space = int.Parse(recievedString[3]);
                        log.Text = recievedString[4] + " pressed " + recievedString[1];
                        if (recievedString[4]==playerInfo.player1)
                        {
                            
                            Stat1lbl.Text = "Playing...";
                            Stat2lbl.Text = "Waiting...";

                        }
                        else if (recievedString[4] == playerInfo.player2)
                        {
                            Stat2lbl.Text = "Playing...";
                            Stat1lbl.Text = "Waiting...";
                        }
                        if (word_without_space == 0)
                        {

                            MessageBox.Show(recievedString[4] + " Is the winner");

                        }
                        break;
                    
                }
            }


            if (playerInfo.th.ThreadState == ThreadState.Running)
                playerInfo.th.Abort();
            playerInfo.th = new Thread(Game);
            playerInfo.th.Start();
        }

        public void drawWord()
        {
            word_labels.Clear();

            word_labels = new List<Label>();
            labelsGroup = new GroupBox();
            labelsGroup.AutoSize = true;
            labelsGroup.ForeColor = Color.Maroon;
            labelsGroup.Location = new Point(80, 100);

            for (int i = 0; i < word.Length; i++)
            {
                word_labels.Add(new Label
                {
                    Name = "label" + i,
                    Location = new Point(i * 50 + 20, 10),
                    Size = new System.Drawing.Size(30, 30),
                    Font = new Font("Pristina", 20, FontStyle.Bold),
                    BorderStyle = BorderStyle.FixedSingle,
                    Text = "__"
                });
                if (word[i].ToString() == " ")
                {
                    word_labels[i].Text = "    ";
                    word_labels[i].BorderStyle = BorderStyle.None;
                }
                else
                {
                    word_without_space++;
                    word_without_space_string += word[i];
                }
                labelsGroup.Controls.Add(word_labels[i]);

            }
            this.Controls.Add(labelsGroup);
        }
        public void Game()
        {
            while (true)
            {
                Application.DoEvents();
                if (playerInfo.nt.DataAvailable)
                {
                    string x = playerInfo.br.ReadString();

                    string[] recievedString = x.Split('_');
                    switch (recievedString[0])
                    {
                        case "right":
                            string[] recievedIndex = recievedString[2].Split(',');
                            for (int i = 0; i < recievedIndex.Length; i++)
                            {

                                word_labels[int.Parse(recievedIndex[i])].Text = word[int.Parse(recievedIndex[i])].ToString();
                                word_without_space--;
                            }
                            word_without_space = int.Parse(recievedString[3]);
                            log.Text = recievedString[4] + " pressed " + recievedString[1];
                            if (recievedString[4] == playerInfo.player1)
                            {

                                Stat1lbl.Text = "Playing...";
                                Stat1lbl.BackColor = Color.Red;
                                Stat2lbl.Text = "Waiting...";
                                Stat2lbl.BackColor = Color.Bisque;

                            }
                            else if (recievedString[4] == playerInfo.player2)
                            {
                                Stat2lbl.Text = "Playing...";
                                Stat2lbl.BackColor = Color.Red;
                                Stat1lbl.Text = "Waiting...";
                                Stat1lbl.BackColor = Color.Bisque;
                            }
                            if (word_without_space == 0)
                            {

                                MessageBox.Show(recievedString[4] + " Is the winner");

                            }
                            break;

                        
                        case "newWord":
                            word = recievedString[1];
                            this.Controls.Remove(labelsGroup);
                            playerInfo.word = word;
                            word_label.Text = word;
                            labelsGroup.Invoke((MethodInvoker)delegate
                            {
                                drawWord();
                            });


                            break;
                    }



                }

            }
        }

        private void Spectate_FormClosing(object sender, FormClosingEventArgs e)
        {
            Thread Wth = new Thread(() =>
            {

                Application.Run(new Form1());
            });
            Wth.SetApartmentState(ApartmentState.STA);
            Wth.Start();
        }

        
    }
}

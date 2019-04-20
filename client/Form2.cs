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
    public partial class Form2 : Form
    {
        string word;
        int word_without_space = 0;
        int positionCount=0;
        List <Label>word_labels;
        ArrayList gussedLetters;
        GroupBox labelsGroup;
        public Dictionary<char, Button> letters = new Dictionary<char, Button>();
        public Form2(string ownerPlayer)
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            roomname.Text = "Room: "+playerInfo.RoomName;
            groupBox1.Enabled = false;
             if(playerInfo.owner)
            {
                pl1.Text = playerInfo.playerName;

            }
            else
            {
                pl1.Text = ownerPlayer;
                pl2.Text = playerInfo.playerName;
            }

            word = playerInfo.word;
            word_labels = new List<Label>();
            //word_label.Text = word;
            gussedLetters = new ArrayList();
            drawWord();
            drawLetters();

            
            if(playerInfo.th.ThreadState == ThreadState.Running)
            playerInfo.th.Abort();
            playerInfo.th = new Thread(Game);
            playerInfo.th.Start();
        }
        public void drawLetters()
        {
            char ch = 'A';
            int y_axis = 40;
            int x_axis = 70;
            for (int i = 0; i < 26; i++)
            {
                x_axis = i;
                if (i == 13) { x_axis = 0; y_axis = 40 + 50; }
                if (i > 13) {  x_axis = i - 13;  }
               

                letters.Add(ch, new Button
                {
                    Name = ch.ToString(),
                  
                    Location = new Point(x_axis * 40 + 60, y_axis),
                    Size = new System.Drawing.Size(40, 40),
                    Text = ch.ToString()
                });
                letters[ch].Click += new EventHandler(btn_clicked);
                groupBox1.Controls.Add(letters[ch]);
                
                ch++;
            }
            groupBox1.AutoSize = true;


        }            
        public void btn_clicked(Object sender,EventArgs e)
        {

            Button btn = (Button)sender;
            Guessed_Letters(btn.Text);

            btn.Enabled = false;
        }
        public void Guessed_Letters(string s)
        {
            int j = 0;
            string letterPosition="";
            
            if(word.ToLower().Contains(s.ToLower()))
            {
                gussedLetters.Add(s);
                positionCount = 0;
                while ((j=word.ToLower().IndexOf(s.ToLower(), j))!=-1)
                {
                    word_labels[j].Text = word[j].ToString();
                    letterPosition += j+",";
                    j++;
                    positionCount++;
                }

                letterPosition = letterPosition.Remove(letterPosition.LastIndexOf(""));
                word_without_space -= positionCount;
                
                playerInfo.bw.Write("right" + "_" + s + "_" + letterPosition + "_" + word_without_space+"_"+playerInfo.playerName);
                
                if (word_without_space == 0)
                {

                    DialogResult dr = MessageBox.Show("Winner!!.... do you want to play again?", " Request", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        playerInfo.score++;

                        playerInfo.bw.Write("acceptNewGame"+"_"+playerInfo.score);

                    }
                    else 
                    {
                        playerInfo.bw.Write("RejectNewGame"+"_"+playerInfo.score);
                        playerInfo.score = 0;
                    }

                }

               
            }
            else
            {
                groupBox1.Enabled = false;
                playerInfo.bw.Write("wrong" + "_" + s);


            }
    
        }


        public void drawWord()
        {
            word_labels.Clear();
            
            word_labels = new List<Label>();
            labelsGroup = new GroupBox();
            labelsGroup.AutoSize = true;
   
            labelsGroup.ForeColor = Color.Maroon;
            labelsGroup.Location = new Point(220, 130);
          
            for (int i = 0; i < word.Length; i++)
            {
                word_labels.Add(new Label
                {
                    Name = "label" + i,
                    
                    Location = new Point(i * 60 + 20, 25),
                    Size = new System.Drawing.Size(40, 40),
                    Font = new Font("Pristina",20,FontStyle.Bold),
                    BorderStyle = BorderStyle.FixedSingle,
                    
                    Text = "__"
                });

                if (word[i].ToString() == " ")
                {
                    word_labels[i].Text = "    ";
                    word_labels[i].BorderStyle = BorderStyle.None;
                }
                else { word_without_space++; }
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
                                       
                    string [] recievedString=x.Split('_');
                    
                    switch (recievedString[0])

                    {
                       
                        case "Request":
                            string player2Name = recievedString[1];
                            DialogResult dr = MessageBox.Show(player2Name+" wants to join you...", " Request", MessageBoxButtons.YesNo);
                            if (dr == DialogResult.Yes)
                            {
                                pl2.Text = player2Name;
                                playerInfo.bw.Write("RequestYes" + "_" + playerInfo.playerName);
                                if (playerInfo.owner)
                                {
                                    groupBox1.Enabled = true;
                                }
                            }
                            else
                            {
                                playerInfo.bw.Write("RequestNon");
                            }
                            break;
                        case "right":
                            string[] recievedIndex = recievedString[2].Split(',');
                            for (int i = 0; i < recievedIndex.Length; i++)
                            {

                                word_labels[int.Parse(recievedIndex[i])].Text = word[int.Parse(recievedIndex[i])].ToString();

                            }
                            letters[recievedString[1].ToUpper().ToCharArray()[0]].Enabled = false;
                            if (groupBox1.Enabled == true)
                            {
                                groupBox1.Enabled = false;
                            }
                            break;

                        case "wrong":

                            if (groupBox1.Enabled == false)
                            {
                                groupBox1.Enabled = true;
                            }
                            letters[recievedString[1].ToUpper().ToCharArray()[0]].Enabled = false;

                            break;

                        case "newWord":
                            if (recievedString.Length > 2)
                            {
                                if (recievedString[2] == "switch")
                                {
                                    pl1.Text = playerInfo.playerName;
                                    pl2.Text = "Waiting";
                                    playerInfo.owner = true;

                                }
                                if (recievedString[2] == "opponentLeft")
                                {
                                    pl2.Text = "Waiting";
                                }
                            }

                            word = recievedString[1];
                            this.Controls.Remove(labelsGroup);
                            playerInfo.word = word;
                            //word_label.Text = word;
                            labelsGroup.Invoke((MethodInvoker)delegate
                            {
                                drawWord();

                            });
                            groupBox1.Invoke((MethodInvoker)delegate
                            {
                                foreach (var item in letters.Values)
                                {
                                    item.Enabled = true;
                                }

                            });
                            break;

                        case "closeP2":
                            playerInfo.owner = false;
                            Thread Wth = new Thread(() =>
                            {
                                Application.Run(new Form1());
                            });
                            Wth.SetApartmentState(ApartmentState.STA);
                            Wth.Start();
                            Application.Exit();
                            break;
                    }
                                      
                    if (recievedString.Length  > 3)
                    {
                        word_without_space = int.Parse(recievedString[3]);

                        if (word_without_space == 0)
                        {
                            DialogResult dr = MessageBox.Show("loser do you want to play again?", " Request", MessageBoxButtons.YesNo);
                            if (dr == DialogResult.Yes)
                            {
                                foreach (var item in word_labels)
                                {
                                    this.Controls.Remove(item);


                                }
                                playerInfo.bw.Write("acceptNewGame"+"_"+playerInfo.score);

                            }
                            else
                            {
                                playerInfo.bw.Write("RejectNewGame"+ "_" + playerInfo.score);
                            }

                            


                        }

                        
                    }

                    

                }
                
            }
        }
        

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            if (e.CloseReason!=CloseReason.ApplicationExitCall)
            {
                playerInfo.bw.Write("CloseForm2" + "_" + playerInfo.score);
                playerInfo.score = 0;
            }

        }
    }
}

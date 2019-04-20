using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.Sockets;
using System.Threading;
using System.Runtime.Serialization.Formatters.Binary;

namespace client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            welcomeForm wf = new welcomeForm();
            this.BackgroundImage = wf.BackgroundImage;
            categ.Items.AddRange(new string[] { "Players", "Movies", "Actors" });
            categ.Height = categ.PreferredHeight;
            diff.Items.AddRange(new string[] { "Hard", "Medium", "Easy" });
            diff.Height= diff.PreferredHeight;
            
            welcome_label.Text = "Welcome  " + playerInfo.playerName;
            
            CheckForIllegalCrossThreadCalls = false;
            try
            {
                
                if (playerInfo.th==null)
                {

                    playerInfo.th = new Thread(read);
                    playerInfo.th.Start();
                }
                else
                {
                    if (playerInfo.th.ThreadState == ThreadState.Running)
                    {
                        playerInfo.th.Abort();
                        playerInfo.th = new Thread(read);
                        playerInfo.th.Start();
                    }
                }
                

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void read()
        {
            while(true)
            {
                if (playerInfo.nt != null)
                {
                    if (playerInfo.nt.DataAvailable)
                    {
                        string message = playerInfo.br.ReadString();
                        string[] came_action = message.Split('_');
                        string action = came_action[0];
                        if (action == "New")
                        {
                            try
                            {
                                playerInfo.word = came_action[1];
                                Thread Wth = new Thread(() =>
                                {

                                    Application.Run(new Form2(""));
                                });
                                Wth.SetApartmentState(ApartmentState.STA);
                                Wth.Start();
                                this.Close();
                            }
                            catch (Exception e) { MessageBox.Show(e.ToString()); }
                        }
                        else if (action == "avaliable")
                        {
                            rooms_list.Items.Clear();
                            came_action=came_action.Skip(1).ToArray();
                            foreach (var i in came_action)
                            {
                                rooms_list.Items.Add(i);
                            }
                        }
                        else if (action == "Join")
                        {
                            playerInfo.bw.Write("Request"+"_"+playerInfo.playerName);//joinned player
                            playerInfo.word = came_action[1];
                        }
                        else if (action == "RequestYes")
                        {

                            Thread Wth2 = new Thread(() =>
                            {
                                Application.Run(new Form2(came_action[1]));//owner name
                            });
                            Wth2.SetApartmentState(ApartmentState.STA);
                            Wth2.Start();
                            this.Close();
                        }
                        else if (action == "RequestNon")
                        {
                            MessageBox.Show("Owner Refused");
                        }
                        else if(action=="Watch")
                        {

                            playerInfo.word = came_action[1];
                            playerInfo.player1 = came_action[2];
                            playerInfo.player2 = came_action[3];
                            BinaryFormatter bf = new BinaryFormatter();
                            playerInfo.char_to_Watch = (List<string>)bf.Deserialize(playerInfo.nt);
                            

                            Thread Wth2 = new Thread(() =>
                            {
                                Application.Run(new Spectate(came_action[2], came_action[3]));
                            });
                            Wth2.SetApartmentState(ApartmentState.STA);
                            Wth2.Start();
                            this.Close();

                        }
                        
                    }
                }
            }
        }
        private void new_room_btn_Click(object sender, EventArgs e)
        {
            if (RoomName_txt.Text != "" && categ.SelectedItem != null && categ.SelectedItem.ToString() != "" && diff.SelectedItem != null && diff.SelectedItem.ToString() != "")
            {
                playerInfo.client = new TcpClient("127.0.0.1", 14015);
                playerInfo.nt = playerInfo.client.GetStream();
                playerInfo.br = new BinaryReader(playerInfo.nt);
                playerInfo.bw = new BinaryWriter(playerInfo.nt);
                playerInfo.owner = true;
                playerInfo.RoomName = RoomName_txt.Text;
                playerInfo.diff = diff.SelectedItem.ToString();
                playerInfo.categ = categ.SelectedItem.ToString();
                playerInfo.bw.Write("New_" + RoomName_txt.Text + "," + playerInfo.categ + "," + playerInfo.diff + "_" + playerInfo.playerName);
                new_room_btn.Enabled = false;
            }                                                              
            else
            {
                MessageBox.Show("Enter all fields");

            }
        }

        private void show_btn_Click(object sender, EventArgs e)
        {
            
                playerInfo.client = new TcpClient("127.0.0.1", 14015);
                playerInfo.nt = playerInfo.client.GetStream();
                playerInfo.br = new BinaryReader(playerInfo.nt);
                playerInfo.bw = new BinaryWriter(playerInfo.nt);
                playerInfo.bw.Write("Show_");          

            
        }

        private void join_btn_Click(object sender, EventArgs e)
        {
            if (rooms_list.SelectedItem != null && rooms_list.SelectedItem.ToString() !="")
            {
                playerInfo.client = new TcpClient("127.0.0.1", 14015);
                playerInfo.nt = playerInfo.client.GetStream();
                playerInfo.br = new BinaryReader(playerInfo.nt);
                playerInfo.bw = new BinaryWriter(playerInfo.nt);
                var txt = rooms_list.SelectedItem.ToString();
                txt = txt.Remove(txt.LastIndexOf(""));
                txt = txt.Remove(txt.LastIndexOf(""));
                playerInfo.bw.Write("Join_" + txt + "_" + playerInfo.playerName);
            }
            else
            {
                MessageBox.Show("please select the room");
            }
        }

        private void rooms_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rooms_list.SelectedItem.ToString() != "" && rooms_list.SelectedItem != null)
            {
                if (int.TryParse(rooms_list.SelectedItem.ToString().Split(',')[3], out int result))
                {
                    if (result >= 2)
                    {
                        join_btn.Enabled = false;
                        btn_watch.Enabled = true;
                    }

                    else
                    {
                        btn_watch.Enabled = false;
                        join_btn.Enabled = true;

                    }
                }

            }
            else
            {
                MessageBox.Show("please select the room");
            }
        }
        private void btn_watch_Click(object sender, EventArgs e)
        {
            if (rooms_list.SelectedItem != null && rooms_list.SelectedItem.ToString() !="")
            {
            playerInfo.client = new TcpClient("127.0.0.1", 14015);
            playerInfo.nt = playerInfo.client.GetStream();
            playerInfo.br = new BinaryReader(playerInfo.nt);
            playerInfo.bw = new BinaryWriter(playerInfo.nt);
            var txt = rooms_list.SelectedItem.ToString();
            txt = txt.Remove(txt.LastIndexOf(""));
            txt = txt.Remove(txt.LastIndexOf(""));
            playerInfo.bw.Write("Watch_" + txt);
            }
            else
            {
                MessageBox.Show("please select the room");
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client
{
    public partial class welcomeForm : Form
    {
        public welcomeForm()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            if (username.Text != "")
            {
                playerInfo.playerName = username.Text;
                Form1 form1 = new Form1();
                
                welcomeForm.ActiveForm.Hide();
                form1.Show();
            }
            else
            {
                MessageBox.Show("please enter user name");
            }
        }

        
    }
}

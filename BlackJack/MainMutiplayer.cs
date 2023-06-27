using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
    public partial class MainMutiplayer : Form
    {
        public MainMutiplayer()
        {
            InitializeComponent();
            
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)  
        {
            Muti_Server muti_Server = new Muti_Server();
            muti_Server.Show();
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void MainMutiplayer_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void playButton_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection("Server=.\\SQLEXPRESS;database=Client;Integrated Security=True");
            string acc = accBox.Text;
            string pas = pasBox.Text;
            
            SqlDataAdapter dap = new SqlDataAdapter($"select passwd from account where accnt = '{acc}' and passwd = '{pas}'", conn);
            DataTable dt = new DataTable();
            dap.Fill(dt);

            if (dt.Rows.Count > 0 )
            {
                if (pas == dt.Rows[0][0].ToString())
                {
                    Multi_Client mt = new Multi_Client();
                    mt.Show();
                    this.Hide();
                }
            }
            else MessageBox.Show("Dang nhap sai! Vui long kiem tra lai tai khoan va mat khau!");
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

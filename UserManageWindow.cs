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

namespace InventoryManagementSystem
{
    public partial class UserManageWindow : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\IMS\database\dbIMS.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd = new SqlCommand();

        public UserManageWindow()
        {
            InitializeComponent();
        }

        private void CustomButtonClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to save this user information?", "Saving information!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    cmd = new SqlCommand("INSERT INTO tableUser(username, fullname, password, phone)VALUES(@username, @fullname, @password, @phone)", con);

                    cmd.Parameters.AddWithValue("@username", textBoxUsername.Text);
                    cmd.Parameters.AddWithValue("@fullname", textBoxFullName.Text);
                    cmd.Parameters.AddWithValue("@password", textBoxPassword.Text);
                    cmd.Parameters.AddWithValue("@phone", textBoxPhone.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("User information saved successfully!");

                    Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {

        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public void Clear()
        {
            textBoxUsername.Clear();
            textBoxFullName.Clear();
            textBoxPassword.Clear();
            textBoxPhone.Clear();
        }
    }
}

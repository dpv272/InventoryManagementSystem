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
    public partial class UserWindow : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\IMS\database\dbIMS.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;

        public UserWindow()
        {
            InitializeComponent();
            LoadUser();
        }

        public void LoadUser()
        {
            int i = 0;

            dataGridViewUser.Rows.Clear();

            cmd = new SqlCommand("SELECT * FROM tableUser", con);

            con.Open();
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                i++;

                dataGridViewUser.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString());
            }

            dr.Close();
            con.Close();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            UserManageWindow userManageWindow = new UserManageWindow();

            userManageWindow.buttonSave.Enabled = true;
            userManageWindow.buttonUpdate.Enabled = false;
            userManageWindow.ShowDialog();
        }
    }
}

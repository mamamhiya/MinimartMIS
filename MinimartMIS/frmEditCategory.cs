using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MinimartMIS
{
    public partial class frmEditCategory : Form
    {
        public frmEditCategory()
        {
            InitializeComponent();
        }
        SqlConnection? conn;

        public int CategoryID = 0;
        public string Categoryname = string.Empty;
        public string Description = string.Empty;
        public string Status = string.Empty;


        private void btnClear_Click(object sender, EventArgs e)
        {
            clearfrm();
        }

        private void UpdateDate()
        {
            string sql = "Update  Categories CategoryName =@CategoryName ,Description = @Description where CategoryID = @ CategoryID";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@CategoryName", txtCategoryName.Text.Trim());
            cmd.Parameters.AddWithValue("@Description", txtDescription.Text.Trim());
            cmd.Parameters.AddWithValue("@CategoryID", Convert.ToInt32(txtCategoryID.Text));
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            int row = cmd.ExecuteNonQuery();
            if (row > 0)
            {
                MessageBox.Show("แก้ใขข้อมูลสำเร็จ");
            }
            else
            {
                MessageBox.Show("ไม่สามารถแก้ใขข้อมูลได้");
            }
            this.Close();
        }

        private void InsertData()
        {
            string sql = "INSERT into Categories (CategoryName, Description) Values(@CategoryName,@Description)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@CategoryName", txtCategoryName.Text.Trim());
            cmd.Parameters.AddWithValue("@Description", txtDescription.Text.Trim());
            if (conn.State != ConnectionState.Open) 
            {
                conn.Open();
            }
            int row = cmd.ExecuteNonQuery();
            if (row > 0)
            {
                MessageBox.Show("เพิ่มข้อมูลสำเร็จ");
            }
            else 
            {
                MessageBox.Show("ไม่สามารถเพิ่มข้อมูลได้");
            }
            this.Close();
        }

        private void frmEditCategory_Load(object sender, EventArgs e)
        {
            conn = connectDB.ConnectMinimart();
            clearfrm();

            txtCategoryID.Enabled = false;
            txtCategoryName.Focus();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Status == "Insert")
            {
                InsertData();
            }
            else if (Status == "Update")
            {
                UpdateDate();
            }
        }

        private void clearfrm()
        {
            txtCategoryID.Text = CategoryID.ToString();
            txtCategoryName.Text = Categoryname;
            txtDescription.Text = Description;
        }
    }
}

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
    public partial class frmCategory : Form
    {
        public frmCategory()
        {
            InitializeComponent();
        }

        SqlConnection? conn;

        int categoryID = 0;
        string categoryname = string.Empty;
        string description = string.Empty;

        private void btnInsert_Click(object sender, EventArgs e)
        {
            frmEditCategory frm = new frmEditCategory();
            frm.CategoryID = 0;
            frm.Categoryname = string.Empty;
            frm.Description = string.Empty;
            frm.Status = "Insert";
            frm.ShowDialog();
            showdata("");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (categoryID == 0) 
            {
                MessageBox.Show("กรุณาเลือกรายการที่ต้องการลบ");
                return;
            }
            DialogResult dr = MessageBox.Show("คุณต้องการลบข้อมูลใช่หรือไม่","โปรดยืนยันการลบ", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    string sql = "DELETE FROM Category WHERE CategoryID = @CategoryID";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@CategoryID", categoryID);
                    int row = cmd.ExecuteNonQuery();
                    if (row > 0)
                    {
                        MessageBox.Show("ลบข้อมูลเรียบร้อยแล้ว");
                        showdata("");
                    }
                    else
                    {
                        MessageBox.Show("ลบข้อมูลไม่สำเร็จ");
                    }
                }
                catch (SqlException ex)
                {

                    MessageBox.Show("ไม่สามารถลบข้อมูลได้ เนื่องจากมีข้อมูลในตารางอื่นอ้างอิงถึง" + "\n" + ex.Message);
                    return;
                }
            }
        }



        private void frmCategory_Load(object sender, EventArgs e)
        {
            conn = connectDB.ConnectMinimart();
            showdata("");
        }

        private void showdata(string str)
        {
            string sql = "select * from Categories where CategoryName  Like @search or Description Like @search";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@search", "%" + str + "%");
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvCategory.DataSource = ds.Tables[0];

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            showdata(txtSearch.Text.Trim());
        }

        private void dgvCategory_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            categoryID = Convert.ToInt32(dgvCategory.Rows[e.RowIndex].Cells[0].Value);
            categoryname = dgvCategory.Rows[e.RowIndex].Cells[1].Value.ToString() ?? string.Empty;
            description = dgvCategory.Rows[e.RowIndex].Cells[2].Value.ToString() ?? string.Empty;

            //string s = categoryID.ToString()+"\n"+categoryname.ToString()+"\n"+description;
            //MessageBox.Show(s);
        }

        private void dgvCategory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmEditCategory frm = new frmEditCategory();
            frm.CategoryID = categoryID;
            frm.Categoryname = categoryname;
            frm.Description = description;
            frm.Status = "Update";
            frm.ShowDialog();
            showdata("");
        }
    }
}

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
    public partial class frmProducts : Form
    {
        public frmProducts()
        {
            InitializeComponent();
        }

        SqlConnection? conn;
        string productID = string.Empty;
        string productName = string.Empty;
        double unitPrice = 0;
        int unitsInStock = 0;
        int categoryID = 0;
        string categoryName = string.Empty;
        int discontinued = 0;

        private void frmEditProducts_Load(object sender, EventArgs e)
        {
            conn = connectDB.ConnectMinimart();
            string sql = "Select productID, productName, UnitPrice, UnitsInStock, "
            + " p.CategoryID, CategoryName, Discontinued"
            + " from products p inner join Categories c on p.CategoryID = c.CategoryID";
            ShowData(sql, dgvProducts);
        }
        void ShowData(string sql, DataGridView dgv)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);

            DataSet ds = new DataSet();
            da.Fill(ds);
            dgv.DataSource = ds.Tables[0];
        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            SearchProduct(txtSearch.Text);
        }
        void SearchProduct(string searchKeyWord)
        {
            string sql = "Select productID,productName,UnitPrice,UnitsInStock, "
            + " p.CategoryID, CategoryName,Discontinued"
            + " from products p inner join Categories c on p.CategoryID = c.CategoryID"
            + " where productID like '%'+@str+'%' "
            + " or ProductName like '%'+@str+'%'"
            + " or CategoryName like '%'+@str+'%'";
            SqlCommand comm = new SqlCommand(sql, conn);
            comm.Parameters.AddWithValue("@str", searchKeyWord);
            SqlDataAdapter da = new SqlDataAdapter(comm);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvProducts.DataSource = ds.Tables[0];
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmEditProducts f = new frmEditProducts();
            f.status = "insert";
            f.ShowDialog();
            string sql = "Select productID, productName, UnitPrice, UnitsInStock, "
            + " p.CategoryID, CategoryName, Discontinued"

            + " from products p inner join Categories c on p.CategoryID = c.CategoryID";
            ShowData(sql, dgvProducts);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            //ปุ่มลบ
            if (productID == string.Empty)
            {
                MessageBox.Show("โปรดคลิกเลือกข้อมูลที่ต้องการลบก่อน", "เกิดข้อผิดพลาด");
                return;
            }
            string msg = "รหัสสินค้า :" + productID + Environment.NewLine
            + "ชื่อสินค้า :" + productName;
            DialogResult ans = MessageBox.Show(msg, "โปรดยืนยันการลบ", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);
            if (ans == DialogResult.Yes)
            {
                string sql = "Delete From Products Where ProductID = @ProductID";
                SqlCommand comm = new SqlCommand(sql, conn);
                comm.Parameters.AddWithValue("@ProductID", productID);
                conn.Open();
                try
                {
                    comm.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "เกิดข้อผิดพลาด");
                }
                conn.Close();
            }
            string sql2 = "Select productID, productName, UnitPrice, UnitsInStock, "
            + " p.CategoryID, CategoryName, Discontinued"
            + " from products p inner join Categories c on p.CategoryID = c.CategoryID";
            ShowData(sql2, dgvProducts);
        }

        private void dgvProducts_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            productID = dgvProducts.CurrentRow.Cells[0].Value.ToString();
            productName = dgvProducts.CurrentRow.Cells[1].Value.ToString();
            unitPrice = Convert.ToDouble(dgvProducts.CurrentRow.Cells[2].Value);
            unitsInStock = Convert.ToInt16(dgvProducts.CurrentRow.Cells[3].Value);
            categoryID = Convert.ToInt16(dgvProducts.CurrentRow.Cells[4].Value);
            categoryName = dgvProducts.CurrentRow.Cells[5].Value.ToString();
            discontinued = Convert.ToInt16(dgvProducts.CurrentRow.Cells[6].Value);
        }

        private void dgvProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            productID = dgvProducts.CurrentRow.Cells[0].Value.ToString();
            productName = dgvProducts.CurrentRow.Cells[1].Value.ToString();
            unitPrice = Convert.ToDouble(dgvProducts.CurrentRow.Cells[2].Value);
            unitsInStock = Convert.ToInt16(dgvProducts.CurrentRow.Cells[3].Value);
            categoryID = Convert.ToInt16(dgvProducts.CurrentRow.Cells[4].Value);
            categoryName = dgvProducts.CurrentRow.Cells[5].Value.ToString();
            discontinued = Convert.ToInt16(dgvProducts.CurrentRow.Cells[6].Value);
            frmEditProducts f = new frmEditProducts();
            f.productID = productID;
            f.productName = productName;
            f.unitPrice = unitPrice;
            f.unitsInStock = unitsInStock;
            f.categoryID = categoryID;
            f.categoryName = categoryName;
            f.discontinued = discontinued;
            f.status = "update";
            f.ShowDialog();
            string sql = "Select productID, productName, UnitPrice, UnitsInStock, "
            + " p.CategoryID, CategoryName, Discontinued"
            + " from products p inner join Categories c on p.CategoryID = c.CategoryID";
            ShowData(sql, dgvProducts);
        }
    }
}

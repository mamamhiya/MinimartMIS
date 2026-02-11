using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinimartMIS
{
    public partial class frmEditProducts : Form
    {
        public frmEditProducts()
        {
            InitializeComponent();
        }
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string productID { get; set; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string productName { get; set; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public double unitPrice { get; set; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int unitsInStock { get; set; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int categoryID { get; set; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string categoryName { get; set; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int discontinued { get; set; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string status { get; set; }

        SqlConnection conn;

        private void frmEditProducts_Load(object sender, EventArgs e)
        {

            conn = connectDB.ConnectMinimart();
            setCbo();
            txtProductID.Text = productID;
            txtProductName.Text = productName;
            txtUnitPrice.Text = unitPrice.ToString();
            txtUnitsInStock.Text = unitsInStock.ToString();
            cboCategory.SelectedValue = categoryID;
            if (discontinued == 1)
            {
                radDiscontinued.Checked = true;
            }
            else
            {
                radContinued.Checked = true;
            }
        }

        private void setCbo()
        {
            string sql = "Select CategoryID,CategoryName from Categories";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cboCategory.DataSource = ds.Tables[0];
            cboCategory.ValueMember = "CategoryID";
            cboCategory.DisplayMember = "CategoryName";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (status == "insert")
            {
                insertData();
            }
            else if (status == "update")
            {
                updateData();
            }
            this.Close();
        }

        private void updateData()
        {

            if (!checkInputData())
            {
                return; //หมายความว่า ถ้า checkInputData() มีค่าเป็น False จะจบโค้ดตรงนี้
            }
            string sql = "update products set productName = @productName, UnitPrice= @unitPrice,"
            + " UnitsInStock =@UnitsInStock,CategoryID=@CategoryID,Discontinued = @Discontinued"
+ " where productID = @productID";
            SqlCommand comm = new SqlCommand(sql, conn);
            comm.Parameters.AddWithValue("@productID", txtProductID.Text.Trim());
            comm.Parameters.AddWithValue("@productName", txtProductName.Text.Trim());
            comm.Parameters.AddWithValue("@unitPrice", txtUnitPrice.Text);
            comm.Parameters.AddWithValue("@UnitsInStock", txtUnitsInStock.Text);

            comm.Parameters.AddWithValue("@CategoryID", cboCategory.SelectedValue);
            if (radContinued.Checked)
            {
                comm.Parameters.AddWithValue("@Discontinued", 0);
            }
            else if (radDiscontinued.Checked)
            {
                comm.Parameters.AddWithValue("@Discontinued", 1);
            }

            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }

            try
            {
                comm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                MessageBox.Show(msg, "เกิดข้อผิดพลาด");
            }
            conn.Close();
        }
        private void insertData()
        {
            if (!checkInputData())
            {
                return; //หมายความว่า ถ้า checkInputData() มีค่าเป็น False จะจบโค้ดตรงนี้
            }
            string sql = "insert into Products "
            + "values(@productID, @productName, @unitPrice, @UnitsInStock, @CategoryID, @Discontinued)";
            SqlCommand comm = new SqlCommand(sql, conn);
            comm.Parameters.AddWithValue("@productID", txtProductID.Text.Trim());
            comm.Parameters.AddWithValue("@productName", txtProductName.Text.Trim());
            comm.Parameters.AddWithValue("@unitPrice", txtUnitPrice.Text);
            comm.Parameters.AddWithValue("@UnitsInStock", txtUnitsInStock.Text);
            comm.Parameters.AddWithValue("@CategoryID", cboCategory.SelectedValue);
            if (radContinued.Checked)
            {
                comm.Parameters.AddWithValue("@Discontinued", 0);
            }
            else if (radDiscontinued.Checked)
            {
                comm.Parameters.AddWithValue("@Discontinued", 1);
            }
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            try
            {
                comm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                MessageBox.Show(msg, "เกิดข้อผิดพลาด");
            }
            conn.Close();
        }

        private bool checkInputData()
        {
            if (txtProductID.Text.Trim() == "")
            {
                MessageBox.Show("รหัสสินค้าต้องไม่เป็นที่ว่าง", "เกิดข้อผิดพลาด");
                return false;
            }

            if (txtProductName.Text.Trim() == "")
            {
                MessageBox.Show("ชื่อสินค้าต้องไม่เป็นที่ว่าง", "เกิดข้อผิดพลาด");
                return false;
            }

            double x = 0.00;
            if (!double.TryParse(txtUnitPrice.Text, out x))
            {
                MessageBox.Show("ราคาสินค้าต้องไม่เป็นที่ว่าง", "เกิดข้อผิดพลาด");
                return false;
            }

            int y = 0;
            if (!int.TryParse(txtUnitsInStock.Text, out y))
            {
                MessageBox.Show("จำนวนสินค้าต้องไม่เป็นที่ว่าง", "เกิดข้อผิดพลาด");
                return false;
            }
            return true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newstar;
using Models;
using NewBLL;
using System.Drawing.Imaging;

namespace Commodity
{
    public partial class Form1 : Form
    {
        private byte[] bytes = null;
        private OpenFileDialog dialog = null;
        private int productId = 1007;//默认第一个商品id
        private int Sanf = 1007;
        private int pageIndex = 1;
        private int pageSize = 5;
        private int pageMax = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int pageMax = new ProductsService().getProductSum(pageSize);
            this.MaxSize.Text = pageMax.ToString();
            Default(Sanf);
            DataDefailr(pageIndex);
        }
        //dataGridView
        public void DataDefailr(int index)
        {
            this.index.Text = index.ToString();
            dataGridView.DataSource = new ProductsService().getProductsList(index,pageSize);
        }


        public void Default(int proid)
        {
           ///String Sql = "select * from T_Products where ProductID=@ProductID";

            Models.Products products = new ProductsService().getByproducts(proid);
            this.productidi.Text = products.ProductId.ToString();
            this.pname.Text = products.Pname;
            this.price.Text = products.Price.ToString();
            this.showText.Text = products.ShowText;
            this.bytes = products.Photo;
            this.Photo.Image = NewImages(products.Photo);
            SaveImage(bytes, proid.ToString());
        }

        ///ImageData：图片的byte数组数据
        ///imageName：图片保存的路径
        private void SaveImage(byte[] ImageData, string imageName)
        {

            string m_ImagrRootDir = "E:\\home\\uploads\\";
            try
            {
                //保存图片到本地文件夹
                MemoryStream ms = new MemoryStream(ImageData);
                Image img = Image.FromStream(ms);
                //保存到磁盘文件
                string imagePath = Path.Combine(m_ImagrRootDir, "图像", DateTime.Now.ToString("yyyyMMdd"));
                if (!Directory.Exists(imagePath))
                    Directory.CreateDirectory(imagePath);
                img.Save(Path.Combine(imagePath, imageName+ ".jpeg"), ImageFormat.Jpeg);
                ms.Dispose();
                MessageBox.Show("图片已保存至：" + m_ImagrRootDir);
                //MessageBox.Show("图片已保存至：" + imagePath);
            }
            catch (Exception exception)
            {
            }
        }


        //字节转图片
        public Bitmap NewImages(byte[] Byte)
        {
            Image image = Image.FromStream(new MemoryStream(Byte));
            return new Bitmap(image, Photo.Width, Photo.Height);
        }

        public Models.Products GetProducts()
        {
            Models.Products products = new Models.Products();
            if(this.productidi.Text != "")
            products.ProductId = int.Parse(this.productidi.Text);
            products.Pname = this.pname.Text;
            products.Price = float.Parse(this.price.Text);
            products.ShowText = this.showText.Text;
            products.Unit = "个";
            products.Photo = bytes;
            return products;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


 

        private void button2_Click(object sender, EventArgs e)
        {
            dialog = new OpenFileDialog();
            dialog.Filter = "图片文件|*.jpg;*.gif;*.jpeg;*.png";
            string ConnStr = ConfigurationManager.ConnectionStrings["conStr01"].ToString();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileInfo fileInfo = new FileInfo(dialog.FileName);
                    if (fileInfo.Length > 1024 * 500)
                    {
                        MessageBox.Show("文件大小不超过500K");
                        bytes = null;
                        return;
                    }
                    FileStream fs = new FileStream(dialog.FileName, FileMode.Open, FileAccess.Read);
                    bytes = new byte[fileInfo.Length];
                    fs.Read(bytes, 0, (int)fileInfo.Length);
                    fs.Close();
                    Bitmap bm = new Bitmap(Image.FromFile(dialog.FileName), Photo.Width, Photo.Height);
                    Photo.Image = bm;

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void clearbutt_Click(object sender, EventArgs e)
        {
            productId = Sanf + 1;
            this.productidi.Text = "";
            this.pname.Text = "";
            this.price.Text = "";
            this.showText.Text = "";
            this.Photo.Image = null;
        }


        //public bool ChannelExecuteNonQuery(SqlParameter[] param, String Sql)
        //{
        //    int rows;
        //    string ConnStr = ConfigurationManager.ConnectionStrings["conStr01"].ToString();
        //    using (SqlConnection conn = new SqlConnection(ConnStr))
        //    {
        //        conn.Open();
        //        SqlCommand sqlcom = new SqlCommand(Sql, conn);
        //        sqlcom.Parameters.AddRange(param);
        //        rows = sqlcom.ExecuteNonQuery();
        //    }
        //    if (rows != 0)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        //public SqlDataReader ChannelExecuteReader(SqlParameter[] param, String Sql)
        //{
        //    string ConnStr = ConfigurationManager.ConnectionStrings["conStr01"].ToString();
        //    SqlConnection conn = new SqlConnection(ConnStr);
            
        //        conn.Open();
        //        SqlCommand sqlcom = new SqlCommand(Sql, conn);
        //        sqlcom.Parameters.AddRange(param);
        //        return sqlcom.ExecuteReader(CommandBehavior.CloseConnection);
                
        //}


        private void adder_Click(object sender, EventArgs e)
        {
            Models.Products products = GetProducts();

            bool rows = new ProductsService().inputProducts(products);
            
            if (rows)
            {
                MessageBox.Show("添加成功");
            }
            else
            {
                MessageBox.Show("添加失败");
            }

            this.productId = 1007;
            Default(Sanf);
        }

        private void selectbutton_Click(object sender, EventArgs e)
        {
            if(this.productidi.Text == "")
            {
                MessageBox.Show("输入查找商品编号");
                return;
            }
            Default(int.Parse(this.productidi.Text));
        }

        private void updatabutt_Click(object sender, EventArgs e)
        {
            // Newstar.Products products = GetProducts();
            Models.Products products = GetProducts();
            bool rows = new ProductsService().undataProducts(products);
            if (rows)
            {
                MessageBox.Show("操作成功");
            }                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    
            else
            {
                MessageBox.Show("操作成功");
            }

            DataDefailr(pageIndex);

        }

        private void butt_Click(object sender, EventArgs e)
        {
            DataDefailr(++pageIndex);
        }

        private void quan_Click(object sender, EventArgs e)
        {
            DataDefailr(--pageIndex);
        }

        private void delectbutt_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount =
        dataGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (selectedRowCount > 0)
            {
                StringBuilder sb = new StringBuilder();
                int index = 0;
                for (int i = 0; i < selectedRowCount; i++)
                {
                    //sb.Append("Row: ");
                    //sb.Append(dataGridView.SelectedRows[i].Index.ToString());
                    //sb.Append(Environment.NewLine);
                    index = dataGridView.SelectedRows[i].Index;
                }

               //MessageBox.Show(dataGridView.Rows[index].Cells[0].Value.ToString());
               Default(int.Parse(dataGridView.Rows[index].Cells[0].Value.ToString()));
            }

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

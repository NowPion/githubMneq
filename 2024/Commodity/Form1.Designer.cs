
namespace Commodity
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Photo = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pname = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.showText = new System.Windows.Forms.RichTextBox();
            this.clearbutt = new System.Windows.Forms.Button();
            this.adder = new System.Windows.Forms.Button();
            this.selectbutton = new System.Windows.Forms.Button();
            this.updatabutt = new System.Windows.Forms.Button();
            this.delectbutt = new System.Windows.Forms.Button();
            this.butt = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.MaxSize = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.index = new System.Windows.Forms.Label();
            this.quan = new System.Windows.Forms.Button();
            this.productidi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Photo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Photo
            // 
            this.Photo.Location = new System.Drawing.Point(511, 293);
            this.Photo.Name = "Photo";
            this.Photo.Size = new System.Drawing.Size(128, 176);
            this.Photo.TabIndex = 1;
            this.Photo.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(657, 350);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 45);
            this.button2.TabIndex = 3;
            this.button2.Text = "上传";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(294, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "商品名称";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "商品编号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(294, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "商品价格";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(294, 427);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "商品介绍";
            // 
            // pname
            // 
            this.pname.Location = new System.Drawing.Point(381, 333);
            this.pname.Name = "pname";
            this.pname.Size = new System.Drawing.Size(100, 25);
            this.pname.TabIndex = 9;
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(381, 377);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(100, 25);
            this.price.TabIndex = 10;
            // 
            // showText
            // 
            this.showText.Location = new System.Drawing.Point(381, 424);
            this.showText.Name = "showText";
            this.showText.Size = new System.Drawing.Size(100, 57);
            this.showText.TabIndex = 11;
            this.showText.Text = "";
            // 
            // clearbutt
            // 
            this.clearbutt.Location = new System.Drawing.Point(105, 427);
            this.clearbutt.Name = "clearbutt";
            this.clearbutt.Size = new System.Drawing.Size(75, 45);
            this.clearbutt.TabIndex = 15;
            this.clearbutt.Text = "清空";
            this.clearbutt.UseVisualStyleBackColor = true;
            this.clearbutt.Click += new System.EventHandler(this.clearbutt_Click);
            // 
            // adder
            // 
            this.adder.Location = new System.Drawing.Point(12, 376);
            this.adder.Name = "adder";
            this.adder.Size = new System.Drawing.Size(75, 45);
            this.adder.TabIndex = 16;
            this.adder.Text = "添加";
            this.adder.UseVisualStyleBackColor = true;
            this.adder.Click += new System.EventHandler(this.adder_Click);
            // 
            // selectbutton
            // 
            this.selectbutton.Location = new System.Drawing.Point(12, 427);
            this.selectbutton.Name = "selectbutton";
            this.selectbutton.Size = new System.Drawing.Size(75, 45);
            this.selectbutton.TabIndex = 18;
            this.selectbutton.Text = "查找";
            this.selectbutton.UseVisualStyleBackColor = true;
            this.selectbutton.Click += new System.EventHandler(this.selectbutton_Click);
            // 
            // updatabutt
            // 
            this.updatabutt.Location = new System.Drawing.Point(203, 427);
            this.updatabutt.Name = "updatabutt";
            this.updatabutt.Size = new System.Drawing.Size(75, 45);
            this.updatabutt.TabIndex = 19;
            this.updatabutt.Text = "修改";
            this.updatabutt.UseVisualStyleBackColor = true;
            this.updatabutt.Click += new System.EventHandler(this.updatabutt_Click);
            // 
            // delectbutt
            // 
            this.delectbutt.Location = new System.Drawing.Point(203, 376);
            this.delectbutt.Name = "delectbutt";
            this.delectbutt.Size = new System.Drawing.Size(75, 45);
            this.delectbutt.TabIndex = 20;
            this.delectbutt.Text = "删除";
            this.delectbutt.UseVisualStyleBackColor = true;
            this.delectbutt.Click += new System.EventHandler(this.delectbutt_Click);
            // 
            // butt
            // 
            this.butt.Location = new System.Drawing.Point(146, 327);
            this.butt.Name = "butt";
            this.butt.Size = new System.Drawing.Size(75, 31);
            this.butt.TabIndex = 21;
            this.butt.Text = "下一页";
            this.butt.UseVisualStyleBackColor = true;
            this.butt.Click += new System.EventHandler(this.butt_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 27;
            this.dataGridView.Size = new System.Drawing.Size(720, 263);
            this.dataGridView.TabIndex = 22;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            this.dataGridView.Click += new System.EventHandler(this.dataGridView_Click);
            // 
            // MaxSize
            // 
            this.MaxSize.AutoSize = true;
            this.MaxSize.Location = new System.Drawing.Point(216, 296);
            this.MaxSize.Name = "MaxSize";
            this.MaxSize.Size = new System.Drawing.Size(15, 15);
            this.MaxSize.TabIndex = 23;
            this.MaxSize.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(145, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 24;
            this.label5.Text = "最大页";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 25;
            this.label6.Text = "当前页";
            // 
            // index
            // 
            this.index.AutoSize = true;
            this.index.Location = new System.Drawing.Point(102, 296);
            this.index.Name = "index";
            this.index.Size = new System.Drawing.Size(15, 15);
            this.index.TabIndex = 26;
            this.index.Text = "0";
            // 
            // quan
            // 
            this.quan.Location = new System.Drawing.Point(42, 327);
            this.quan.Name = "quan";
            this.quan.Size = new System.Drawing.Size(75, 31);
            this.quan.TabIndex = 27;
            this.quan.Text = "上一页";
            this.quan.UseVisualStyleBackColor = true;
            this.quan.Click += new System.EventHandler(this.quan_Click);
            // 
            // productidi
            // 
            this.productidi.Location = new System.Drawing.Point(381, 293);
            this.productidi.Name = "productidi";
            this.productidi.Size = new System.Drawing.Size(104, 25);
            this.productidi.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 479);
            this.Controls.Add(this.productidi);
            this.Controls.Add(this.quan);
            this.Controls.Add(this.index);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MaxSize);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.butt);
            this.Controls.Add(this.delectbutt);
            this.Controls.Add(this.updatabutt);
            this.Controls.Add(this.selectbutton);
            this.Controls.Add(this.adder);
            this.Controls.Add(this.clearbutt);
            this.Controls.Add(this.showText);
            this.Controls.Add(this.price);
            this.Controls.Add(this.pname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Photo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Photo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox Photo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pname;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.RichTextBox showText;
        private System.Windows.Forms.Button clearbutt;
        private System.Windows.Forms.Button adder;
        private System.Windows.Forms.Button selectbutton;
        private System.Windows.Forms.Button updatabutt;
        private System.Windows.Forms.Button delectbutt;
        private System.Windows.Forms.Button butt;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label MaxSize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label index;
        private System.Windows.Forms.Button quan;
        private System.Windows.Forms.TextBox productidi;
    }
}


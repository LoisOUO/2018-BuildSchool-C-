namespace HW01
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Name01 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pencil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eraser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ruler = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.white = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.業務員的業績 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name01,
            this.Pen,
            this.Pencil,
            this.Eraser,
            this.Ruler,
            this.white,
            this.total});
            this.dataGridView1.Location = new System.Drawing.Point(12, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(994, 165);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Name01
            // 
            this.Name01.DataPropertyName = "Name01";
            this.Name01.HeaderText = "姓名";
            this.Name01.Name = "Name01";
            // 
            // Pen
            // 
            this.Pen.DataPropertyName = "Pen";
            this.Pen.HeaderText = "原子筆";
            this.Pen.Name = "Pen";
            // 
            // Pencil
            // 
            this.Pencil.DataPropertyName = "Pencil";
            this.Pencil.HeaderText = "鉛筆";
            this.Pencil.Name = "Pencil";
            // 
            // Eraser
            // 
            this.Eraser.DataPropertyName = "Eraser";
            this.Eraser.HeaderText = "橡皮擦";
            this.Eraser.Name = "Eraser";
            // 
            // Ruler
            // 
            this.Ruler.DataPropertyName = "Ruler";
            this.Ruler.HeaderText = "直尺";
            this.Ruler.Name = "Ruler";
            // 
            // white
            // 
            this.white.DataPropertyName = "white";
            this.white.HeaderText = "立可白";
            this.white.Name = "white";
            // 
            // total
            // 
            this.total.DataPropertyName = "total";
            this.total.HeaderText = "總額";
            this.total.Name = "total";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.product,
            this.Price,
            this.sum,
            this.Sales});
            this.dataGridView2.Location = new System.Drawing.Point(12, 259);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 27;
            this.dataGridView2.Size = new System.Drawing.Size(601, 196);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // 業務員的業績
            // 
            this.業務員的業績.AutoSize = true;
            this.業務員的業績.Location = new System.Drawing.Point(12, 9);
            this.業務員的業績.Name = "業務員的業績";
            this.業務員的業績.Size = new System.Drawing.Size(97, 15);
            this.業務員的業績.TabIndex = 2;
            this.業務員的業績.Text = "業務員的業績";
            this.業務員的業績.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "各產品銷售金額";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(698, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "最佳業務員";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(813, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(698, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "最佳產品";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(813, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 15);
            this.label5.TabIndex = 7;
            // 
            // product
            // 
            this.product.DataPropertyName = "product";
            this.product.HeaderText = "產品";
            this.product.Name = "product";
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "售價";
            this.Price.Name = "Price";
            // 
            // sum
            // 
            this.sum.DataPropertyName = "sum";
            this.sum.HeaderText = "總數量";
            this.sum.Name = "sum";
            // 
            // Sales
            // 
            this.Sales.DataPropertyName = "Sales";
            this.Sales.HeaderText = "總金額";
            this.Sales.Name = "Sales";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 575);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.業務員的業績);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label 業務員的業績;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name01;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pencil;
        private System.Windows.Forms.DataGridViewTextBoxColumn Eraser;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ruler;
        private System.Windows.Forms.DataGridViewTextBoxColumn white;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn sum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sales;
    }
}


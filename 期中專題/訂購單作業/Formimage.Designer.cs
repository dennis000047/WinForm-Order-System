namespace 訂購單作業
{
    partial class Formimage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formimage));
            this.label1 = new System.Windows.Forms.Label();
            this.btn重新載入 = new System.Windows.Forms.Button();
            this.btn新增商品 = new System.Windows.Forms.Button();
            this.btn列表模式 = new System.Windows.Forms.Button();
            this.btn圖片模式 = new System.Windows.Forms.Button();
            this.listView商品展示 = new System.Windows.Forms.ListView();
            this.imageList商品圖檔 = new System.Windows.Forms.ImageList(this.components);
            this.btn刪除商品 = new System.Windows.Forms.Button();
            this.btn會員維護 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(52, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "商品內部管理";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn重新載入
            // 
            this.btn重新載入.BackColor = System.Drawing.Color.Transparent;
            this.btn重新載入.FlatAppearance.BorderSize = 0;
            this.btn重新載入.Font = new System.Drawing.Font("微軟正黑體", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn重新載入.Location = new System.Drawing.Point(606, 344);
            this.btn重新載入.Name = "btn重新載入";
            this.btn重新載入.Size = new System.Drawing.Size(163, 54);
            this.btn重新載入.TabIndex = 9;
            this.btn重新載入.Text = "重新載入";
            this.btn重新載入.UseVisualStyleBackColor = false;
            this.btn重新載入.Click += new System.EventHandler(this.btn重新載入_Click);
            // 
            // btn新增商品
            // 
            this.btn新增商品.BackColor = System.Drawing.Color.Transparent;
            this.btn新增商品.FlatAppearance.BorderSize = 0;
            this.btn新增商品.Font = new System.Drawing.Font("微軟正黑體", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn新增商品.Location = new System.Drawing.Point(606, 240);
            this.btn新增商品.Name = "btn新增商品";
            this.btn新增商品.Size = new System.Drawing.Size(163, 54);
            this.btn新增商品.TabIndex = 8;
            this.btn新增商品.Text = "新增商品";
            this.btn新增商品.UseVisualStyleBackColor = false;
            this.btn新增商品.Click += new System.EventHandler(this.btn新增商品_Click);
            // 
            // btn列表模式
            // 
            this.btn列表模式.BackColor = System.Drawing.Color.Transparent;
            this.btn列表模式.FlatAppearance.BorderSize = 0;
            this.btn列表模式.Font = new System.Drawing.Font("微軟正黑體", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn列表模式.Location = new System.Drawing.Point(606, 147);
            this.btn列表模式.Name = "btn列表模式";
            this.btn列表模式.Size = new System.Drawing.Size(163, 54);
            this.btn列表模式.TabIndex = 7;
            this.btn列表模式.Text = "列表模式";
            this.btn列表模式.UseVisualStyleBackColor = false;
            this.btn列表模式.Click += new System.EventHandler(this.btn列表模式_Click);
            // 
            // btn圖片模式
            // 
            this.btn圖片模式.BackColor = System.Drawing.Color.Transparent;
            this.btn圖片模式.Font = new System.Drawing.Font("微軟正黑體", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn圖片模式.Location = new System.Drawing.Point(606, 68);
            this.btn圖片模式.Name = "btn圖片模式";
            this.btn圖片模式.Size = new System.Drawing.Size(163, 54);
            this.btn圖片模式.TabIndex = 6;
            this.btn圖片模式.Text = "圖片模式";
            this.btn圖片模式.UseVisualStyleBackColor = false;
            this.btn圖片模式.Click += new System.EventHandler(this.btn圖片模式_Click);
            // 
            // listView商品展示
            // 
            this.listView商品展示.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.listView商品展示.HideSelection = false;
            this.listView商品展示.Location = new System.Drawing.Point(58, 47);
            this.listView商品展示.Name = "listView商品展示";
            this.listView商品展示.Size = new System.Drawing.Size(518, 453);
            this.listView商品展示.TabIndex = 1;
            this.listView商品展示.UseCompatibleStateImageBehavior = false;
            this.listView商品展示.ItemActivate += new System.EventHandler(this.listView商品展示_ItemActivate);
            // 
            // imageList商品圖檔
            // 
            this.imageList商品圖檔.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList商品圖檔.ImageSize = new System.Drawing.Size(256, 256);
            this.imageList商品圖檔.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btn刪除商品
            // 
            this.btn刪除商品.BackColor = System.Drawing.Color.Transparent;
            this.btn刪除商品.FlatAppearance.BorderSize = 0;
            this.btn刪除商品.Font = new System.Drawing.Font("微軟正黑體", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn刪除商品.Location = new System.Drawing.Point(606, 443);
            this.btn刪除商品.Name = "btn刪除商品";
            this.btn刪除商品.Size = new System.Drawing.Size(163, 54);
            this.btn刪除商品.TabIndex = 10;
            this.btn刪除商品.Text = "刪除商品";
            this.btn刪除商品.UseVisualStyleBackColor = false;
            this.btn刪除商品.Click += new System.EventHandler(this.btn刪除商品_Click);
            // 
            // btn會員維護
            // 
            this.btn會員維護.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn會員維護.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn會員維護.Location = new System.Drawing.Point(634, 12);
            this.btn會員維護.Name = "btn會員維護";
            this.btn會員維護.Size = new System.Drawing.Size(104, 45);
            this.btn會員維護.TabIndex = 137;
            this.btn會員維護.Text = "會員維護";
            this.btn會員維護.UseVisualStyleBackColor = false;
            this.btn會員維護.Click += new System.EventHandler(this.btn會員維護_Click);
            // 
            // Formimage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(817, 534);
            this.Controls.Add(this.btn會員維護);
            this.Controls.Add(this.btn刪除商品);
            this.Controls.Add(this.listView商品展示);
            this.Controls.Add(this.btn重新載入);
            this.Controls.Add(this.btn新增商品);
            this.Controls.Add(this.btn列表模式);
            this.Controls.Add(this.btn圖片模式);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Formimage";
            this.Text = "商品展示";
            this.Load += new System.EventHandler(this.Formimage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn重新載入;
        private System.Windows.Forms.Button btn新增商品;
        private System.Windows.Forms.Button btn列表模式;
        private System.Windows.Forms.Button btn圖片模式;
        private System.Windows.Forms.ListView listView商品展示;
        private System.Windows.Forms.ImageList imageList商品圖檔;
        private System.Windows.Forms.Button btn刪除商品;
        private System.Windows.Forms.Button btn會員維護;
    }
}
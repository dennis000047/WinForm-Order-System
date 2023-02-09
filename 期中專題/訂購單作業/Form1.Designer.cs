namespace 訂購單作業
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
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox滷味品項 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt數量 = new System.Windows.Forms.TextBox();
            this.lbl單價 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn加入購物車 = new System.Windows.Forms.Button();
            this.comboBox單點飲料 = new System.Windows.Forms.ComboBox();
            this.label38 = new System.Windows.Forms.Label();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            this.btn查看購物車 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.lbl品項總價 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.btn內部商品管理 = new System.Windows.Forms.Button();
            this.listView商品展示 = new System.Windows.Forms.ListView();
            this.imageList商品圖檔 = new System.Windows.Forms.ImageList(this.components);
            this.btn重新載入 = new System.Windows.Forms.Button();
            this.btn查看商品介紹 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btn登出 = new System.Windows.Forms.Button();
            this.btn登入 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.timer跑燈 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox滷味品項
            // 
            this.listBox滷味品項.BackColor = System.Drawing.Color.White;
            this.listBox滷味品項.Font = new System.Drawing.Font("Ink Free", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox滷味品項.FormattingEnabled = true;
            this.listBox滷味品項.ItemHeight = 30;
            this.listBox滷味品項.Location = new System.Drawing.Point(188, 103);
            this.listBox滷味品項.Name = "listBox滷味品項";
            this.listBox滷味品項.Size = new System.Drawing.Size(185, 34);
            this.listBox滷味品項.TabIndex = 1;
            this.listBox滷味品項.Visible = false;
            this.listBox滷味品項.SelectedIndexChanged += new System.EventHandler(this.listBox滷味品項_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(529, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "數量";
            // 
            // txt數量
            // 
            this.txt數量.BackColor = System.Drawing.Color.White;
            this.txt數量.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt數量.Location = new System.Drawing.Point(648, 184);
            this.txt數量.Name = "txt數量";
            this.txt數量.Size = new System.Drawing.Size(121, 36);
            this.txt數量.TabIndex = 3;
            this.txt數量.TextChanged += new System.EventHandler(this.txt數量_TextChanged);
            // 
            // lbl單價
            // 
            this.lbl單價.AutoSize = true;
            this.lbl單價.BackColor = System.Drawing.Color.Transparent;
            this.lbl單價.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl單價.Location = new System.Drawing.Point(679, 228);
            this.lbl單價.Name = "lbl單價";
            this.lbl單價.Size = new System.Drawing.Size(89, 40);
            this.lbl單價.TabIndex = 7;
            this.lbl單價.Text = "         ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(529, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 31);
            this.label7.TabIndex = 10;
            this.label7.Text = "單點飲料";
            // 
            // btn加入購物車
            // 
            this.btn加入購物車.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn加入購物車.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn加入購物車.Location = new System.Drawing.Point(609, 432);
            this.btn加入購物車.Name = "btn加入購物車";
            this.btn加入購物車.Size = new System.Drawing.Size(147, 43);
            this.btn加入購物車.TabIndex = 12;
            this.btn加入購物車.Text = "加入購物車";
            this.btn加入購物車.UseVisualStyleBackColor = false;
            this.btn加入購物車.Click += new System.EventHandler(this.btn加入購物車_Click);
            // 
            // comboBox單點飲料
            // 
            this.comboBox單點飲料.BackColor = System.Drawing.Color.White;
            this.comboBox單點飲料.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox單點飲料.FormattingEnabled = true;
            this.comboBox單點飲料.Location = new System.Drawing.Point(645, 291);
            this.comboBox單點飲料.Name = "comboBox單點飲料";
            this.comboBox單點飲料.Size = new System.Drawing.Size(121, 29);
            this.comboBox單點飲料.TabIndex = 48;
            this.comboBox單點飲料.SelectedIndexChanged += new System.EventHandler(this.comboBox單點飲料_SelectedIndexChanged);
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.BackColor = System.Drawing.Color.Transparent;
            this.label38.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.Location = new System.Drawing.Point(629, 236);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(44, 28);
            this.label38.TabIndex = 64;
            this.label38.Text = "NT";
            // 
            // pictureBox18
            // 
            this.pictureBox18.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox18.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox18.BackgroundImage")));
            this.pictureBox18.Location = new System.Drawing.Point(314, 9);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(186, 63);
            this.pictureBox18.TabIndex = 65;
            this.pictureBox18.TabStop = false;
            // 
            // pictureBox19
            // 
            this.pictureBox19.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox19.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox19.BackgroundImage")));
            this.pictureBox19.Location = new System.Drawing.Point(-1, 105);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Size = new System.Drawing.Size(141, 32);
            this.pictureBox19.TabIndex = 66;
            this.pictureBox19.TabStop = false;
            // 
            // btn查看購物車
            // 
            this.btn查看購物車.BackColor = System.Drawing.Color.Transparent;
            this.btn查看購物車.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn查看購物車.BackgroundImage")));
            this.btn查看購物車.FlatAppearance.BorderSize = 0;
            this.btn查看購物車.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn查看購物車.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn查看購物車.Location = new System.Drawing.Point(756, 67);
            this.btn查看購物車.Name = "btn查看購物車";
            this.btn查看購物車.Size = new System.Drawing.Size(57, 51);
            this.btn查看購物車.TabIndex = 67;
            this.btn查看購物車.UseVisualStyleBackColor = false;
            this.btn查看購物車.Click += new System.EventHandler(this.btn查看購物車_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(529, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 31);
            this.label1.TabIndex = 70;
            this.label1.Text = "目前總價";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.BackColor = System.Drawing.Color.Transparent;
            this.label39.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.Location = new System.Drawing.Point(638, 353);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(44, 28);
            this.label39.TabIndex = 72;
            this.label39.Text = "NT";
            // 
            // lbl品項總價
            // 
            this.lbl品項總價.AutoSize = true;
            this.lbl品項總價.BackColor = System.Drawing.Color.Transparent;
            this.lbl品項總價.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl品項總價.Location = new System.Drawing.Point(688, 343);
            this.lbl品項總價.Name = "lbl品項總價";
            this.lbl品項總價.Size = new System.Drawing.Size(89, 40);
            this.lbl品項總價.TabIndex = 71;
            this.lbl品項總價.Text = "         ";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.BackColor = System.Drawing.Color.Transparent;
            this.label41.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label41.Location = new System.Drawing.Point(529, 238);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(62, 31);
            this.label41.TabIndex = 73;
            this.label41.Text = "單價";
            // 
            // btn內部商品管理
            // 
            this.btn內部商品管理.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn內部商品管理.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn內部商品管理.Location = new System.Drawing.Point(6, 45);
            this.btn內部商品管理.Name = "btn內部商品管理";
            this.btn內部商品管理.Size = new System.Drawing.Size(176, 43);
            this.btn內部商品管理.TabIndex = 77;
            this.btn內部商品管理.Text = "內部商品管理";
            this.btn內部商品管理.UseVisualStyleBackColor = false;
            this.btn內部商品管理.Visible = false;
            this.btn內部商品管理.Click += new System.EventHandler(this.btn內部商品管理_Click);
            // 
            // listView商品展示
            // 
            this.listView商品展示.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView商品展示.HideSelection = false;
            this.listView商品展示.Location = new System.Drawing.Point(-1, 136);
            this.listView商品展示.Name = "listView商品展示";
            this.listView商品展示.Size = new System.Drawing.Size(516, 339);
            this.listView商品展示.TabIndex = 124;
            this.listView商品展示.UseCompatibleStateImageBehavior = false;
            this.listView商品展示.ItemActivate += new System.EventHandler(this.listView商品展示_ItemActivate);
            // 
            // imageList商品圖檔
            // 
            this.imageList商品圖檔.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList商品圖檔.ImageSize = new System.Drawing.Size(256, 256);
            this.imageList商品圖檔.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btn重新載入
            // 
            this.btn重新載入.BackColor = System.Drawing.Color.Transparent;
            this.btn重新載入.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn重新載入.BackgroundImage")));
            this.btn重新載入.FlatAppearance.BorderSize = 0;
            this.btn重新載入.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn重新載入.Font = new System.Drawing.Font("微軟正黑體", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn重新載入.ForeColor = System.Drawing.Color.Transparent;
            this.btn重新載入.Location = new System.Drawing.Point(464, 95);
            this.btn重新載入.Name = "btn重新載入";
            this.btn重新載入.Size = new System.Drawing.Size(57, 40);
            this.btn重新載入.TabIndex = 125;
            this.btn重新載入.UseVisualStyleBackColor = false;
            this.btn重新載入.Click += new System.EventHandler(this.btn重新載入_Click);
            // 
            // btn查看商品介紹
            // 
            this.btn查看商品介紹.BackColor = System.Drawing.Color.Transparent;
            this.btn查看商品介紹.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn查看商品介紹.BackgroundImage")));
            this.btn查看商品介紹.FlatAppearance.BorderSize = 0;
            this.btn查看商品介紹.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn查看商品介紹.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn查看商品介紹.Location = new System.Drawing.Point(146, 103);
            this.btn查看商品介紹.Name = "btn查看商品介紹";
            this.btn查看商品介紹.Size = new System.Drawing.Size(36, 32);
            this.btn查看商品介紹.TabIndex = 126;
            this.btn查看商品介紹.UseVisualStyleBackColor = false;
            this.btn查看商品介紹.Click += new System.EventHandler(this.btn查看商品介紹_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(379, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 19);
            this.label3.TabIndex = 127;
            this.label3.Text = "刷新圖片";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(522, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(188, 19);
            this.label9.TabIndex = 129;
            this.label9.Text = "會員登入註冊/登出";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(594, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 19);
            this.label10.TabIndex = 130;
            this.label10.Text = "查看購物車";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(704, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 19);
            this.label11.TabIndex = 131;
            this.label11.Text = "→";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.Location = new System.Drawing.Point(717, 92);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 19);
            this.label12.TabIndex = 132;
            this.label12.Text = "→";
            // 
            // btn登出
            // 
            this.btn登出.BackColor = System.Drawing.Color.Transparent;
            this.btn登出.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn登出.BackgroundImage")));
            this.btn登出.FlatAppearance.BorderSize = 0;
            this.btn登出.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn登出.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn登出.ForeColor = System.Drawing.Color.Red;
            this.btn登出.Location = new System.Drawing.Point(753, 9);
            this.btn登出.Name = "btn登出";
            this.btn登出.Size = new System.Drawing.Size(60, 60);
            this.btn登出.TabIndex = 133;
            this.btn登出.UseVisualStyleBackColor = false;
            this.btn登出.Click += new System.EventHandler(this.btn登出_Click);
            // 
            // btn登入
            // 
            this.btn登入.BackColor = System.Drawing.Color.Transparent;
            this.btn登入.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn登入.BackgroundImage")));
            this.btn登入.FlatAppearance.BorderSize = 0;
            this.btn登入.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn登入.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn登入.ForeColor = System.Drawing.Color.Transparent;
            this.btn登入.Location = new System.Drawing.Point(753, 9);
            this.btn登入.Name = "btn登入";
            this.btn登入.Size = new System.Drawing.Size(60, 60);
            this.btn登入.TabIndex = 134;
            this.btn登入.UseVisualStyleBackColor = false;
            this.btn登入.Click += new System.EventHandler(this.btn登入_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Salmon;
            this.label4.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(43, 478);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 16);
            this.label4.TabIndex = 135;
            this.label4.Text = "加入會員享95折優惠~";
            // 
            // timer跑燈
            // 
            this.timer跑燈.Enabled = true;
            this.timer跑燈.Tick += new System.EventHandler(this.timer跑燈_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(188, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 45);
            this.button1.TabIndex = 136;
            this.button1.Text = "會員維護";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(817, 534);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn登入);
            this.Controls.Add(this.btn登出);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn查看商品介紹);
            this.Controls.Add(this.btn重新載入);
            this.Controls.Add(this.listView商品展示);
            this.Controls.Add(this.btn內部商品管理);
            this.Controls.Add(this.label41);
            this.Controls.Add(this.label39);
            this.Controls.Add(this.lbl品項總價);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn查看購物車);
            this.Controls.Add(this.pictureBox19);
            this.Controls.Add(this.pictureBox18);
            this.Controls.Add(this.label38);
            this.Controls.Add(this.comboBox單點飲料);
            this.Controls.Add(this.btn加入購物車);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl單價);
            this.Controls.Add(this.txt數量);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox滷味品項);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox滷味品項;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt數量;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn加入購物車;
        private System.Windows.Forms.ComboBox comboBox單點飲料;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.PictureBox pictureBox18;
        private System.Windows.Forms.PictureBox pictureBox19;
        private System.Windows.Forms.Button btn查看購物車;
        private System.Windows.Forms.Label lbl單價;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label lbl品項總價;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Button btn內部商品管理;
        private System.Windows.Forms.ListView listView商品展示;
        private System.Windows.Forms.ImageList imageList商品圖檔;
        private System.Windows.Forms.Button btn重新載入;
        private System.Windows.Forms.Button btn查看商品介紹;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn登出;
        private System.Windows.Forms.Button btn登入;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer跑燈;
        private System.Windows.Forms.Button button1;
    }
}


namespace 訂購單作業
{
    partial class FromOrderList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FromOrderList));
            this.label1 = new System.Windows.Forms.Label();
            this.lbl訂購人資料 = new System.Windows.Forms.Label();
            this.listBox訂購品項列表 = new System.Windows.Forms.ListBox();
            this.lbl訂單總價 = new System.Windows.Forms.Label();
            this.btn清除所有品項 = new System.Windows.Forms.Button();
            this.btn移除所選品項 = new System.Windows.Forms.Button();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.txt訂購人手機 = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.txt訂購人姓名 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn送出訂單 = new System.Windows.Forms.Button();
            this.comboBox額外配料 = new System.Windows.Forms.ComboBox();
            this.comboBox醬料 = new System.Windows.Forms.ComboBox();
            this.comboBox辣度 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timer跑燈2 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("標楷體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(14, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "訂購品項列表";
            // 
            // lbl訂購人資料
            // 
            this.lbl訂購人資料.AutoSize = true;
            this.lbl訂購人資料.BackColor = System.Drawing.Color.Transparent;
            this.lbl訂購人資料.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl訂購人資料.Location = new System.Drawing.Point(93, 327);
            this.lbl訂購人資料.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl訂購人資料.Name = "lbl訂購人資料";
            this.lbl訂購人資料.Size = new System.Drawing.Size(125, 21);
            this.lbl訂購人資料.TabIndex = 2;
            this.lbl訂購人資料.Text = "訂購人資料";
            // 
            // listBox訂購品項列表
            // 
            this.listBox訂購品項列表.BackColor = System.Drawing.Color.LightGray;
            this.listBox訂購品項列表.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listBox訂購品項列表.FormattingEnabled = true;
            this.listBox訂購品項列表.ItemHeight = 16;
            this.listBox訂購品項列表.Location = new System.Drawing.Point(14, 117);
            this.listBox訂購品項列表.Margin = new System.Windows.Forms.Padding(5);
            this.listBox訂購品項列表.Name = "listBox訂購品項列表";
            this.listBox訂購品項列表.Size = new System.Drawing.Size(789, 100);
            this.listBox訂購品項列表.TabIndex = 3;
            this.listBox訂購品項列表.SelectedIndexChanged += new System.EventHandler(this.listBox訂購品項列表_SelectedIndexChanged);
            // 
            // lbl訂單總價
            // 
            this.lbl訂單總價.AutoSize = true;
            this.lbl訂單總價.BackColor = System.Drawing.Color.Transparent;
            this.lbl訂單總價.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl訂單總價.Location = new System.Drawing.Point(576, 297);
            this.lbl訂單總價.Name = "lbl訂單總價";
            this.lbl訂單總價.Size = new System.Drawing.Size(222, 28);
            this.lbl訂單總價.TabIndex = 73;
            this.lbl訂單總價.Text = "訂單總價 NT XXXX";
            // 
            // btn清除所有品項
            // 
            this.btn清除所有品項.BackColor = System.Drawing.Color.DarkGray;
            this.btn清除所有品項.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn清除所有品項.Location = new System.Drawing.Point(625, 333);
            this.btn清除所有品項.Margin = new System.Windows.Forms.Padding(5);
            this.btn清除所有品項.Name = "btn清除所有品項";
            this.btn清除所有品項.Size = new System.Drawing.Size(173, 56);
            this.btn清除所有品項.TabIndex = 75;
            this.btn清除所有品項.Text = "清除所有品項";
            this.btn清除所有品項.UseVisualStyleBackColor = false;
            this.btn清除所有品項.Click += new System.EventHandler(this.btn清除所有品項_Click);
            // 
            // btn移除所選品項
            // 
            this.btn移除所選品項.BackColor = System.Drawing.Color.DarkGray;
            this.btn移除所選品項.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn移除所選品項.Location = new System.Drawing.Point(441, 333);
            this.btn移除所選品項.Margin = new System.Windows.Forms.Padding(5);
            this.btn移除所選品項.Name = "btn移除所選品項";
            this.btn移除所選品項.Size = new System.Drawing.Size(173, 56);
            this.btn移除所選品項.TabIndex = 74;
            this.btn移除所選品項.Text = "移除所選品項";
            this.btn移除所選品項.UseVisualStyleBackColor = false;
            this.btn移除所選品項.Click += new System.EventHandler(this.btn移除所選品項_Click);
            // 
            // pictureBox18
            // 
            this.pictureBox18.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox18.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox18.BackgroundImage")));
            this.pictureBox18.Location = new System.Drawing.Point(316, 12);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(186, 63);
            this.pictureBox18.TabIndex = 76;
            this.pictureBox18.TabStop = false;
            // 
            // txt訂購人手機
            // 
            this.txt訂購人手機.BackColor = System.Drawing.Color.White;
            this.txt訂購人手機.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt訂購人手機.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt訂購人手機.Location = new System.Drawing.Point(97, 399);
            this.txt訂購人手機.Margin = new System.Windows.Forms.Padding(5);
            this.txt訂購人手機.Name = "txt訂購人手機";
            this.txt訂購人手機.Size = new System.Drawing.Size(301, 33);
            this.txt訂購人手機.TabIndex = 77;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.BackColor = System.Drawing.Color.Transparent;
            this.lbl2.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl2.Location = new System.Drawing.Point(23, 366);
            this.lbl2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(56, 21);
            this.lbl2.TabIndex = 78;
            this.lbl2.Text = "姓名";
            // 
            // txt訂購人姓名
            // 
            this.txt訂購人姓名.BackColor = System.Drawing.Color.White;
            this.txt訂購人姓名.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt訂購人姓名.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt訂購人姓名.Location = new System.Drawing.Point(97, 354);
            this.txt訂購人姓名.Margin = new System.Windows.Forms.Padding(5);
            this.txt訂購人姓名.Name = "txt訂購人姓名";
            this.txt訂購人姓名.Size = new System.Drawing.Size(301, 33);
            this.txt訂購人姓名.TabIndex = 79;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(23, 402);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 21);
            this.label3.TabIndex = 80;
            this.label3.Text = "手機";
            // 
            // btn送出訂單
            // 
            this.btn送出訂單.BackColor = System.Drawing.Color.DarkGray;
            this.btn送出訂單.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn送出訂單.Location = new System.Drawing.Point(625, 399);
            this.btn送出訂單.Margin = new System.Windows.Forms.Padding(5);
            this.btn送出訂單.Name = "btn送出訂單";
            this.btn送出訂單.Size = new System.Drawing.Size(173, 56);
            this.btn送出訂單.TabIndex = 81;
            this.btn送出訂單.Text = "確認送出";
            this.btn送出訂單.UseVisualStyleBackColor = false;
            this.btn送出訂單.Click += new System.EventHandler(this.btn送出訂單_Click);
            // 
            // comboBox額外配料
            // 
            this.comboBox額外配料.BackColor = System.Drawing.Color.White;
            this.comboBox額外配料.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox額外配料.FormattingEnabled = true;
            this.comboBox額外配料.Location = new System.Drawing.Point(670, 225);
            this.comboBox額外配料.Name = "comboBox額外配料";
            this.comboBox額外配料.Size = new System.Drawing.Size(121, 29);
            this.comboBox額外配料.TabIndex = 87;
            this.comboBox額外配料.SelectedIndexChanged += new System.EventHandler(this.comboBox額外配料_SelectedIndexChanged);
            // 
            // comboBox醬料
            // 
            this.comboBox醬料.BackColor = System.Drawing.Color.White;
            this.comboBox醬料.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox醬料.FormattingEnabled = true;
            this.comboBox醬料.Location = new System.Drawing.Point(358, 223);
            this.comboBox醬料.Name = "comboBox醬料";
            this.comboBox醬料.Size = new System.Drawing.Size(121, 29);
            this.comboBox醬料.TabIndex = 86;
            this.comboBox醬料.SelectedIndexChanged += new System.EventHandler(this.comboBox醬料_SelectedIndexChanged);
            // 
            // comboBox辣度
            // 
            this.comboBox辣度.BackColor = System.Drawing.Color.White;
            this.comboBox辣度.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox辣度.FormattingEnabled = true;
            this.comboBox辣度.Location = new System.Drawing.Point(92, 225);
            this.comboBox辣度.Name = "comboBox辣度";
            this.comboBox辣度.Size = new System.Drawing.Size(121, 29);
            this.comboBox辣度.TabIndex = 85;
            this.comboBox辣度.SelectedIndexChanged += new System.EventHandler(this.comboBox辣度_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(553, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 31);
            this.label8.TabIndex = 84;
            this.label8.Text = "額外配料";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(290, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 31);
            this.label6.TabIndex = 83;
            this.label6.Text = "醬料";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(21, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 31);
            this.label5.TabIndex = 82;
            this.label5.Text = "辣度";
            // 
            // timer跑燈2
            // 
            this.timer跑燈2.Enabled = true;
            this.timer跑燈2.Tick += new System.EventHandler(this.timer跑燈2_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Salmon;
            this.label2.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(656, 276);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 21);
            this.label2.TabIndex = 88;
            this.label2.Text = "~~會員95折~~";
            // 
            // FromOrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(821, 474);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox額外配料);
            this.Controls.Add(this.comboBox醬料);
            this.Controls.Add(this.comboBox辣度);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn送出訂單);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt訂購人姓名);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.txt訂購人手機);
            this.Controls.Add(this.pictureBox18);
            this.Controls.Add(this.btn清除所有品項);
            this.Controls.Add(this.btn移除所選品項);
            this.Controls.Add(this.lbl訂單總價);
            this.Controls.Add(this.listBox訂購品項列表);
            this.Controls.Add(this.lbl訂購人資料);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FromOrderList";
            this.Text = "FromOrderList";
            this.Load += new System.EventHandler(this.FromOrderList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl訂購人資料;
        private System.Windows.Forms.ListBox listBox訂購品項列表;
        private System.Windows.Forms.Label lbl訂單總價;
        private System.Windows.Forms.Button btn清除所有品項;
        private System.Windows.Forms.Button btn移除所選品項;
        private System.Windows.Forms.PictureBox pictureBox18;
        private System.Windows.Forms.TextBox txt訂購人手機;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox txt訂購人姓名;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn送出訂單;
        private System.Windows.Forms.ComboBox comboBox額外配料;
        private System.Windows.Forms.ComboBox comboBox醬料;
        private System.Windows.Forms.ComboBox comboBox辣度;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer跑燈2;
        private System.Windows.Forms.Label label2;
    }
}
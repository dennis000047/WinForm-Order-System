namespace 訂購單作業
{
    partial class Form1Detail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1Detail));
            this.pictureBox商品圖檔 = new System.Windows.Forms.PictureBox();
            this.txt商品描述 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox商品圖檔)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox商品圖檔
            // 
            this.pictureBox商品圖檔.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox商品圖檔.Location = new System.Drawing.Point(141, 5);
            this.pictureBox商品圖檔.Name = "pictureBox商品圖檔";
            this.pictureBox商品圖檔.Size = new System.Drawing.Size(256, 256);
            this.pictureBox商品圖檔.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox商品圖檔.TabIndex = 16;
            this.pictureBox商品圖檔.TabStop = false;
            // 
            // txt商品描述
            // 
            this.txt商品描述.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt商品描述.Location = new System.Drawing.Point(65, 271);
            this.txt商品描述.Multiline = true;
            this.txt商品描述.Name = "txt商品描述";
            this.txt商品描述.ReadOnly = true;
            this.txt商品描述.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt商品描述.Size = new System.Drawing.Size(332, 163);
            this.txt商品描述.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(12, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 35);
            this.label3.TabIndex = 17;
            this.label3.Text = "商品描述";
            // 
            // lblID
            // 
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Font = new System.Drawing.Font("微軟正黑體", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblID.Location = new System.Drawing.Point(12, 40);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(92, 31);
            this.lblID.TabIndex = 20;
            this.lblID.Text = "0000000000";
            this.lblID.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(12, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 35);
            this.label2.TabIndex = 19;
            this.label2.Text = "id";
            this.label2.Visible = false;
            // 
            // Form1Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(436, 446);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt商品描述);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox商品圖檔);
            this.Name = "Form1Detail";
            this.Text = "Form1Detail";
            this.Load += new System.EventHandler(this.Form1Detail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox商品圖檔)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox商品圖檔;
        private System.Windows.Forms.TextBox txt商品描述;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label2;
    }
}
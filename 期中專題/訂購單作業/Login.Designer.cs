namespace 訂購單作業
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn登入 = new System.Windows.Forms.Button();
            this.btn註冊會員 = new System.Windows.Forms.Button();
            this.txt帳號 = new System.Windows.Forms.TextBox();
            this.txt密碼 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("標楷體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(125, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "會員/廠商登入";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("標楷體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(35, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "帳號(手機)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("標楷體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(35, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "密碼";
            // 
            // btn登入
            // 
            this.btn登入.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn登入.Location = new System.Drawing.Point(25, 326);
            this.btn登入.Name = "btn登入";
            this.btn登入.Size = new System.Drawing.Size(155, 44);
            this.btn登入.TabIndex = 3;
            this.btn登入.Text = "登入";
            this.btn登入.UseVisualStyleBackColor = true;
            this.btn登入.Click += new System.EventHandler(this.btn登入_Click);
            // 
            // btn註冊會員
            // 
            this.btn註冊會員.BackColor = System.Drawing.Color.White;
            this.btn註冊會員.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn註冊會員.Location = new System.Drawing.Point(225, 326);
            this.btn註冊會員.Name = "btn註冊會員";
            this.btn註冊會員.Size = new System.Drawing.Size(183, 44);
            this.btn註冊會員.TabIndex = 4;
            this.btn註冊會員.Text = "還沒加入會員?";
            this.btn註冊會員.UseVisualStyleBackColor = false;
            this.btn註冊會員.Click += new System.EventHandler(this.btn註冊會員_Click);
            // 
            // txt帳號
            // 
            this.txt帳號.BackColor = System.Drawing.Color.White;
            this.txt帳號.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt帳號.Location = new System.Drawing.Point(48, 149);
            this.txt帳號.Name = "txt帳號";
            this.txt帳號.Size = new System.Drawing.Size(305, 35);
            this.txt帳號.TabIndex = 5;
            this.txt帳號.TextChanged += new System.EventHandler(this.txt帳號_TextChanged);
            // 
            // txt密碼
            // 
            this.txt密碼.BackColor = System.Drawing.Color.White;
            this.txt密碼.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt密碼.Location = new System.Drawing.Point(48, 247);
            this.txt密碼.Name = "txt密碼";
            this.txt密碼.Size = new System.Drawing.Size(305, 35);
            this.txt密碼.TabIndex = 6;
            this.txt密碼.TextChanged += new System.EventHandler(this.txt密碼_TextChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(436, 446);
            this.Controls.Add(this.txt密碼);
            this.Controls.Add(this.txt帳號);
            this.Controls.Add(this.btn註冊會員);
            this.Controls.Add(this.btn登入);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn登入;
        private System.Windows.Forms.Button btn註冊會員;
        private System.Windows.Forms.TextBox txt帳號;
        private System.Windows.Forms.TextBox txt密碼;
    }
}
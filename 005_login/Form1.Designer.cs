namespace _005_login
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblID = new System.Windows.Forms.Label();
            this.lblPW = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtPW = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtRes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblID.Location = new System.Drawing.Point(80, 100);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(79, 30);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "아이디";
            // 
            // lblPW
            // 
            this.lblPW.AutoSize = true;
            this.lblPW.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblPW.Location = new System.Drawing.Point(80, 181);
            this.lblPW.Name = "lblPW";
            this.lblPW.Size = new System.Drawing.Size(101, 30);
            this.lblPW.TabIndex = 1;
            this.lblPW.Text = "패스워드";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtID.Location = new System.Drawing.Point(249, 89);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(165, 37);
            this.txtID.TabIndex = 2;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // txtPW
            // 
            this.txtPW.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPW.Location = new System.Drawing.Point(249, 181);
            this.txtPW.Name = "txtPW";
            this.txtPW.PasswordChar = '●';
            this.txtPW.Size = new System.Drawing.Size(165, 37);
            this.txtPW.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnLogin.Location = new System.Drawing.Point(249, 262);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(118, 47);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "로그인";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtRes
            // 
            this.txtRes.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtRes.Location = new System.Drawing.Point(223, 334);
            this.txtRes.Name = "txtRes";
            this.txtRes.ReadOnly = true;
            this.txtRes.Size = new System.Drawing.Size(191, 37);
            this.txtRes.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 414);
            this.Controls.Add(this.txtRes);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPW);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblPW);
            this.Controls.Add(this.lblID);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblPW;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtPW;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtRes;
    }
}


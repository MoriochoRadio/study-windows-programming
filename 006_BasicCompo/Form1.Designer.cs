namespace _006_BasicCompo
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtbName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblRes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(79, 51);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(62, 18);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "이름 : ";
            this.lbl1.Click += new System.EventHandler(this.lbl1_Click);
            // 
            // txtbName
            // 
            this.txtbName.Location = new System.Drawing.Point(172, 46);
            this.txtbName.Name = "txtbName";
            this.txtbName.Size = new System.Drawing.Size(134, 28);
            this.txtbName.TabIndex = 1;
            this.txtbName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbName.TextChanged += new System.EventHandler(this.txtbName_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(331, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "클릭";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Location = new System.Drawing.Point(207, 143);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(0, 18);
            this.lblRes.TabIndex = 3;
            this.lblRes.Click += new System.EventHandler(this.lblRes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 199);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtbName);
            this.Controls.Add(this.lbl1);
            this.Name = "Form1";
            this.Text = "Basic Controls";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtbName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblRes;
    }
}


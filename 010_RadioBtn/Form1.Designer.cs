namespace _010_RadioBtn
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
            this.rbKorea = new System.Windows.Forms.RadioButton();
            this.rbChina = new System.Windows.Forms.RadioButton();
            this.rbJapan = new System.Windows.Forms.RadioButton();
            this.rbEtc = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbKorea
            // 
            this.rbKorea.AutoSize = true;
            this.rbKorea.Location = new System.Drawing.Point(20, 47);
            this.rbKorea.Name = "rbKorea";
            this.rbKorea.Size = new System.Drawing.Size(105, 22);
            this.rbKorea.TabIndex = 0;
            this.rbKorea.TabStop = true;
            this.rbKorea.Text = "대한민국";
            this.rbKorea.UseVisualStyleBackColor = true;
            this.rbKorea.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbChina
            // 
            this.rbChina.AutoSize = true;
            this.rbChina.Location = new System.Drawing.Point(20, 94);
            this.rbChina.Name = "rbChina";
            this.rbChina.Size = new System.Drawing.Size(69, 22);
            this.rbChina.TabIndex = 1;
            this.rbChina.TabStop = true;
            this.rbChina.Text = "중국";
            this.rbChina.UseVisualStyleBackColor = true;
            // 
            // rbJapan
            // 
            this.rbJapan.AutoSize = true;
            this.rbJapan.Location = new System.Drawing.Point(20, 140);
            this.rbJapan.Name = "rbJapan";
            this.rbJapan.Size = new System.Drawing.Size(69, 22);
            this.rbJapan.TabIndex = 2;
            this.rbJapan.TabStop = true;
            this.rbJapan.Text = "일본";
            this.rbJapan.UseVisualStyleBackColor = true;
            // 
            // rbEtc
            // 
            this.rbEtc.AutoSize = true;
            this.rbEtc.Location = new System.Drawing.Point(20, 190);
            this.rbEtc.Name = "rbEtc";
            this.rbEtc.Size = new System.Drawing.Size(117, 22);
            this.rbEtc.TabIndex = 3;
            this.rbEtc.TabStop = true;
            this.rbEtc.Text = "그 외 국가";
            this.rbEtc.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbKorea);
            this.groupBox1.Controls.Add(this.rbEtc);
            this.groupBox1.Controls.Add(this.rbChina);
            this.groupBox1.Controls.Add(this.rbJapan);
            this.groupBox1.Location = new System.Drawing.Point(29, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 257);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "국적";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbFemale);
            this.groupBox2.Controls.Add(this.rbMale);
            this.groupBox2.Location = new System.Drawing.Point(417, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(198, 78);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "성별";
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(27, 34);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(51, 22);
            this.rbMale.TabIndex = 0;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "남";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(117, 34);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(51, 22);
            this.rbFemale.TabIndex = 1;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "여";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(417, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 58);
            this.button1.TabIndex = 6;
            this.button1.Text = "제출";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 329);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "RadioBtn";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbKorea;
        private System.Windows.Forms.RadioButton rbChina;
        private System.Windows.Forms.RadioButton rbJapan;
        private System.Windows.Forms.RadioButton rbEtc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.Button button1;
    }
}


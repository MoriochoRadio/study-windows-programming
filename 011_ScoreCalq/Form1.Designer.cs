namespace _011_ScoreCalq
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbKor = new System.Windows.Forms.TextBox();
            this.txtbMath = new System.Windows.Forms.TextBox();
            this.txtbEng = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbSum = new System.Windows.Forms.TextBox();
            this.txtbAvg = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtbEng);
            this.groupBox1.Controls.Add(this.txtbMath);
            this.groupBox1.Controls.Add(this.txtbKor);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(63, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 251);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "성적입력";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(23, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "국어";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(23, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "수학";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(23, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "영어";
            // 
            // txtbKor
            // 
            this.txtbKor.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtbKor.Location = new System.Drawing.Point(143, 48);
            this.txtbKor.Name = "txtbKor";
            this.txtbKor.Size = new System.Drawing.Size(100, 31);
            this.txtbKor.TabIndex = 3;
            this.txtbKor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtbMath
            // 
            this.txtbMath.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtbMath.Location = new System.Drawing.Point(143, 103);
            this.txtbMath.Name = "txtbMath";
            this.txtbMath.Size = new System.Drawing.Size(100, 31);
            this.txtbMath.TabIndex = 4;
            this.txtbMath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtbEng
            // 
            this.txtbEng.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtbEng.Location = new System.Drawing.Point(143, 158);
            this.txtbEng.Name = "txtbEng";
            this.txtbEng.Size = new System.Drawing.Size(100, 31);
            this.txtbEng.TabIndex = 5;
            this.txtbEng.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtbAvg);
            this.groupBox2.Controls.Add(this.txtbSum);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.Location = new System.Drawing.Point(493, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(252, 171);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "결과";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(33, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "총점";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(33, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "평균";
            // 
            // txtbSum
            // 
            this.txtbSum.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtbSum.Location = new System.Drawing.Point(113, 35);
            this.txtbSum.Name = "txtbSum";
            this.txtbSum.ReadOnly = true;
            this.txtbSum.Size = new System.Drawing.Size(100, 31);
            this.txtbSum.TabIndex = 5;
            this.txtbSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtbAvg
            // 
            this.txtbAvg.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtbAvg.Location = new System.Drawing.Point(113, 99);
            this.txtbAvg.Name = "txtbAvg";
            this.txtbAvg.ReadOnly = true;
            this.txtbAvg.Size = new System.Drawing.Size(100, 31);
            this.txtbAvg.TabIndex = 6;
            this.txtbAvg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(493, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(252, 71);
            this.button1.TabIndex = 2;
            this.button1.Text = "계산";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "성적계산기";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbEng;
        private System.Windows.Forms.TextBox txtbMath;
        private System.Windows.Forms.TextBox txtbKor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtbAvg;
        private System.Windows.Forms.TextBox txtbSum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}


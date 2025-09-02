namespace _022_FireBase
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtSid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnViewall = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnRetreve = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(641, 376);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(13, 411);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "id";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtId.Location = new System.Drawing.Point(103, 410);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 31);
            this.txtId.TabIndex = 2;
            // 
            // txtSid
            // 
            this.txtSid.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtSid.Location = new System.Drawing.Point(103, 459);
            this.txtSid.Name = "txtSid";
            this.txtSid.Size = new System.Drawing.Size(100, 31);
            this.txtSid.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(13, 460);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "학번";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtName.Location = new System.Drawing.Point(103, 508);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 31);
            this.txtName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(13, 509);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "이름";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPhone.Location = new System.Drawing.Point(103, 557);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 31);
            this.txtPhone.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(13, 558);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "전화번호";
            // 
            // btnViewall
            // 
            this.btnViewall.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnViewall.Location = new System.Drawing.Point(245, 407);
            this.btnViewall.Name = "btnViewall";
            this.btnViewall.Size = new System.Drawing.Size(108, 35);
            this.btnViewall.TabIndex = 9;
            this.btnViewall.Text = "ViewAll";
            this.btnViewall.UseVisualStyleBackColor = true;
            this.btnViewall.Click += new System.EventHandler(this.btnViewall_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnInsert.Location = new System.Drawing.Point(245, 456);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(108, 35);
            this.btnInsert.TabIndex = 10;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnRetreve
            // 
            this.btnRetreve.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnRetreve.Location = new System.Drawing.Point(245, 505);
            this.btnRetreve.Name = "btnRetreve";
            this.btnRetreve.Size = new System.Drawing.Size(108, 35);
            this.btnRetreve.TabIndex = 11;
            this.btnRetreve.Text = "Retreve";
            this.btnRetreve.UseVisualStyleBackColor = true;
            this.btnRetreve.Click += new System.EventHandler(this.btnRetreve_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnClear.Location = new System.Drawing.Point(245, 554);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(108, 35);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnExit.Location = new System.Drawing.Point(398, 552);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(111, 37);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnUpdate.Location = new System.Drawing.Point(398, 503);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(111, 37);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDelete.Location = new System.Drawing.Point(398, 454);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(111, 37);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDeleteAll.Location = new System.Drawing.Point(398, 405);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(111, 37);
            this.btnDeleteAll.TabIndex = 13;
            this.btnDeleteAll.Text = "DeleteAll";
            this.btnDeleteAll.UseVisualStyleBackColor = true;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(100, 391);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(382, 18);
            this.label5.TabIndex = 17;
            this.label5.Text = "※id auto increse 이므로 insert 시 쓰지 않는다";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 713);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnDeleteAll);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRetreve);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnViewall);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "FireBasePhoneBook";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtSid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnViewall;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnRetreve;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnDeleteAll;
        private System.Windows.Forms.Label label5;
    }
}


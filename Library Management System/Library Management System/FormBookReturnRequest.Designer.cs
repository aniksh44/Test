
namespace Library_Management_System
{
    partial class FormBookReturnRequest
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDashBoard = new System.Windows.Forms.Button();
            this.LblManageBorrowReq = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnReturnReqBookId = new System.Windows.Forms.Button();
            this.txtBorrowkId = new System.Windows.Forms.TextBox();
            this.LblReturnReqBookId = new System.Windows.Forms.Label();
            this.BtnReturnReqReturn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dtpBorrowDate = new System.Windows.Forms.DateTimePicker();
            this.textMemberName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblReturnBorrowedDate = new System.Windows.Forms.Label();
            this.lblReturnBookReturningDate = new System.Windows.Forms.Label();
            this.TxtReturnBookName = new System.Windows.Forms.TextBox();
            this.lblRetunBookName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.btnDashBoard);
            this.panel1.Controls.Add(this.LblManageBorrowReq);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1181, 151);
            this.panel1.TabIndex = 5;
            // 
            // btnDashBoard
            // 
            this.btnDashBoard.Location = new System.Drawing.Point(960, 61);
            this.btnDashBoard.Name = "btnDashBoard";
            this.btnDashBoard.Size = new System.Drawing.Size(177, 45);
            this.btnDashBoard.TabIndex = 2;
            this.btnDashBoard.Text = "DashBoard";
            this.btnDashBoard.UseVisualStyleBackColor = true;
            this.btnDashBoard.Click += new System.EventHandler(this.btnDashBoard_Click);
            // 
            // LblManageBorrowReq
            // 
            this.LblManageBorrowReq.AutoSize = true;
            this.LblManageBorrowReq.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblManageBorrowReq.ForeColor = System.Drawing.Color.White;
            this.LblManageBorrowReq.Location = new System.Drawing.Point(57, 45);
            this.LblManageBorrowReq.Name = "LblManageBorrowReq";
            this.LblManageBorrowReq.Size = new System.Drawing.Size(533, 72);
            this.LblManageBorrowReq.TabIndex = 0;
            this.LblManageBorrowReq.Text = "RETURN REQUEST...";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Controls.Add(this.btnReturnReqBookId);
            this.panel3.Controls.Add(this.txtBorrowkId);
            this.panel3.Controls.Add(this.LblReturnReqBookId);
            this.panel3.Location = new System.Drawing.Point(58, 195);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1061, 117);
            this.panel3.TabIndex = 7;
            // 
            // btnReturnReqBookId
            // 
            this.btnReturnReqBookId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnReturnReqBookId.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReturnReqBookId.Location = new System.Drawing.Point(770, 55);
            this.btnReturnReqBookId.Name = "btnReturnReqBookId";
            this.btnReturnReqBookId.Size = new System.Drawing.Size(128, 44);
            this.btnReturnReqBookId.TabIndex = 2;
            this.btnReturnReqBookId.Text = "ENTER";
            this.btnReturnReqBookId.UseVisualStyleBackColor = false;
            this.btnReturnReqBookId.Click += new System.EventHandler(this.btnReturnReqBookId_Click);
            // 
            // txtBorrowkId
            // 
            this.txtBorrowkId.Location = new System.Drawing.Point(456, 64);
            this.txtBorrowkId.Name = "txtBorrowkId";
            this.txtBorrowkId.Size = new System.Drawing.Size(260, 27);
            this.txtBorrowkId.TabIndex = 1;
            // 
            // LblReturnReqBookId
            // 
            this.LblReturnReqBookId.AutoSize = true;
            this.LblReturnReqBookId.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblReturnReqBookId.Location = new System.Drawing.Point(192, 55);
            this.LblReturnReqBookId.Name = "LblReturnReqBookId";
            this.LblReturnReqBookId.Size = new System.Drawing.Size(229, 37);
            this.LblReturnReqBookId.TabIndex = 0;
            this.LblReturnReqBookId.Text = "Enter Borrow ID ";
            // 
            // BtnReturnReqReturn
            // 
            this.BtnReturnReqReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnReturnReqReturn.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnReturnReqReturn.Location = new System.Drawing.Point(693, 325);
            this.BtnReturnReqReturn.Name = "BtnReturnReqReturn";
            this.BtnReturnReqReturn.Size = new System.Drawing.Size(138, 44);
            this.BtnReturnReqReturn.TabIndex = 8;
            this.BtnReturnReqReturn.Text = "RETURN.";
            this.BtnReturnReqReturn.UseVisualStyleBackColor = false;
            this.BtnReturnReqReturn.Click += new System.EventHandler(this.BtnReturnReqReturn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.lblReturnBookReturningDate);
            this.panel2.Controls.Add(this.BtnReturnReqReturn);
            this.panel2.Controls.Add(this.TxtReturnBookName);
            this.panel2.Controls.Add(this.lblRetunBookName);
            this.panel2.Location = new System.Drawing.Point(136, 332);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(856, 372);
            this.panel2.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(378, 263);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(261, 27);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dtpBorrowDate);
            this.panel4.Controls.Add(this.textMemberName);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.lblReturnBorrowedDate);
            this.panel4.Location = new System.Drawing.Point(25, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(817, 165);
            this.panel4.TabIndex = 11;
            // 
            // dtpBorrowDate
            // 
            this.dtpBorrowDate.CustomFormat = "yyyy-MM-dd";
            this.dtpBorrowDate.Enabled = false;
            this.dtpBorrowDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBorrowDate.Location = new System.Drawing.Point(353, 109);
            this.dtpBorrowDate.Name = "dtpBorrowDate";
            this.dtpBorrowDate.Size = new System.Drawing.Size(261, 27);
            this.dtpBorrowDate.TabIndex = 8;
            // 
            // textMemberName
            // 
            this.textMemberName.Location = new System.Drawing.Point(353, 45);
            this.textMemberName.Name = "textMemberName";
            this.textMemberName.ReadOnly = true;
            this.textMemberName.Size = new System.Drawing.Size(261, 27);
            this.textMemberName.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(89, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "Member Name";
            // 
            // lblReturnBorrowedDate
            // 
            this.lblReturnBorrowedDate.AutoSize = true;
            this.lblReturnBorrowedDate.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReturnBorrowedDate.Location = new System.Drawing.Point(89, 99);
            this.lblReturnBorrowedDate.Name = "lblReturnBorrowedDate";
            this.lblReturnBorrowedDate.Size = new System.Drawing.Size(212, 37);
            this.lblReturnBorrowedDate.TabIndex = 3;
            this.lblReturnBorrowedDate.Text = "Borrowed Date";
            // 
            // lblReturnBookReturningDate
            // 
            this.lblReturnBookReturningDate.AutoSize = true;
            this.lblReturnBookReturningDate.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReturnBookReturningDate.Location = new System.Drawing.Point(112, 253);
            this.lblReturnBookReturningDate.Name = "lblReturnBookReturningDate";
            this.lblReturnBookReturningDate.Size = new System.Drawing.Size(212, 37);
            this.lblReturnBookReturningDate.TabIndex = 9;
            this.lblReturnBookReturningDate.Text = "Returning Date";
            // 
            // TxtReturnBookName
            // 
            this.TxtReturnBookName.Location = new System.Drawing.Point(378, 207);
            this.TxtReturnBookName.Name = "TxtReturnBookName";
            this.TxtReturnBookName.ReadOnly = true;
            this.TxtReturnBookName.Size = new System.Drawing.Size(261, 27);
            this.TxtReturnBookName.TabIndex = 1;
            // 
            // lblRetunBookName
            // 
            this.lblRetunBookName.AutoSize = true;
            this.lblRetunBookName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRetunBookName.Location = new System.Drawing.Point(114, 197);
            this.lblRetunBookName.Name = "lblRetunBookName";
            this.lblRetunBookName.Size = new System.Drawing.Size(166, 37);
            this.lblRetunBookName.TabIndex = 0;
            this.lblRetunBookName.Text = "Book Name";
            // 
            // FormBookReturnRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 749);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "FormBookReturnRequest";
            this.Text = "BookReturnRequest";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblManageBorrowReq;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnReturnReqBookId;
        private System.Windows.Forms.TextBox txtBorrowkId;
        private System.Windows.Forms.Label LblReturnReqBookId;
        private System.Windows.Forms.Button BtnReturnReqReturn;
        private System.Windows.Forms.Button BtnReturnReq;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblReturnBorrowedDate;
        private System.Windows.Forms.TextBox TxtReturnBookName;
        private System.Windows.Forms.Label lblRetunBookName;
        private System.Windows.Forms.Label lblReturnReturningDate;
        private System.Windows.Forms.Label lblReturnBookReturningDate;
        private System.Windows.Forms.Button btnDashBoard;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textMemberName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dtpBorrowDate;
    }
}
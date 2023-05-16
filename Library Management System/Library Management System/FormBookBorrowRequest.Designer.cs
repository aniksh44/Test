
namespace Library_Management_System
{
    partial class FormBookBorrowRequest
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.textUserID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtBookId = new System.Windows.Forms.TextBox();
            this.LblReturnReqBookId = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dtpBorrowedDate = new System.Windows.Forms.DateTimePicker();
            this.TxtBookBorrowId = new System.Windows.Forms.TextBox();
            this.lblReturnBookReturningDate = new System.Windows.Forms.Label();
            this.TxtReturnBookAuthor = new System.Windows.Forms.TextBox();
            this.lblReturnBorrowedDate = new System.Windows.Forms.Label();
            this.lblReturnBookAuthor = new System.Windows.Forms.Label();
            this.TxtReturnBookName = new System.Windows.Forms.TextBox();
            this.lblRetunBookName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.btnDashBoard);
            this.panel1.Controls.Add(this.LblManageBorrowReq);
            this.panel1.Location = new System.Drawing.Point(-5, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1048, 164);
            this.panel1.TabIndex = 6;
            // 
            // btnDashBoard
            // 
            this.btnDashBoard.Location = new System.Drawing.Point(826, 61);
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
            this.LblManageBorrowReq.Size = new System.Drawing.Size(506, 72);
            this.LblManageBorrowReq.TabIndex = 0;
            this.LblManageBorrowReq.Text = "Borrow REQUEST...";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textUserID);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.txtBookId);
            this.panel2.Controls.Add(this.LblReturnReqBookId);
            this.panel2.Location = new System.Drawing.Point(-5, 173);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1048, 192);
            this.panel2.TabIndex = 7;
            // 
            // textUserID
            // 
            this.textUserID.Location = new System.Drawing.Point(293, 72);
            this.textUserID.Name = "textUserID";
            this.textUserID.Size = new System.Drawing.Size(399, 27);
            this.textUserID.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(87, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Member Id";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(293, 131);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(102, 44);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtBookId
            // 
            this.txtBookId.Location = new System.Drawing.Point(293, 27);
            this.txtBookId.Name = "txtBookId";
            this.txtBookId.Size = new System.Drawing.Size(399, 27);
            this.txtBookId.TabIndex = 2;
            // 
            // LblReturnReqBookId
            // 
            this.LblReturnReqBookId.AutoSize = true;
            this.LblReturnReqBookId.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblReturnReqBookId.Location = new System.Drawing.Point(87, 17);
            this.LblReturnReqBookId.Name = "LblReturnReqBookId";
            this.LblReturnReqBookId.Size = new System.Drawing.Size(116, 37);
            this.LblReturnReqBookId.TabIndex = 1;
            this.LblReturnReqBookId.Text = "Book Id";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.btnBorrow);
            this.panel3.Location = new System.Drawing.Point(-5, 675);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1048, 97);
            this.panel3.TabIndex = 9;
            // 
            // btnBorrow
            // 
            this.btnBorrow.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBorrow.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBorrow.Location = new System.Drawing.Point(449, 11);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(147, 51);
            this.btnBorrow.TabIndex = 0;
            this.btnBorrow.Text = "Borrow";
            this.btnBorrow.UseVisualStyleBackColor = true;
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel4.Controls.Add(this.dtpBorrowedDate);
            this.panel4.Controls.Add(this.TxtBookBorrowId);
            this.panel4.Controls.Add(this.lblReturnBookReturningDate);
            this.panel4.Controls.Add(this.TxtReturnBookAuthor);
            this.panel4.Controls.Add(this.lblReturnBorrowedDate);
            this.panel4.Controls.Add(this.lblReturnBookAuthor);
            this.panel4.Controls.Add(this.TxtReturnBookName);
            this.panel4.Controls.Add(this.lblRetunBookName);
            this.panel4.Location = new System.Drawing.Point(-5, 371);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1048, 299);
            this.panel4.TabIndex = 10;
            // 
            // dtpBorrowedDate
            // 
            this.dtpBorrowedDate.CustomFormat = "yyyy-MM-dd";
            this.dtpBorrowedDate.Enabled = false;
            this.dtpBorrowedDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBorrowedDate.Location = new System.Drawing.Point(520, 142);
            this.dtpBorrowedDate.Name = "dtpBorrowedDate";
            this.dtpBorrowedDate.Size = new System.Drawing.Size(271, 27);
            this.dtpBorrowedDate.TabIndex = 19;
            // 
            // TxtBookBorrowId
            // 
            this.TxtBookBorrowId.Location = new System.Drawing.Point(520, 199);
            this.TxtBookBorrowId.Name = "TxtBookBorrowId";
            this.TxtBookBorrowId.Size = new System.Drawing.Size(271, 27);
            this.TxtBookBorrowId.TabIndex = 18;
            // 
            // lblReturnBookReturningDate
            // 
            this.lblReturnBookReturningDate.AutoSize = true;
            this.lblReturnBookReturningDate.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReturnBookReturningDate.Location = new System.Drawing.Point(293, 189);
            this.lblReturnBookReturningDate.Name = "lblReturnBookReturningDate";
            this.lblReturnBookReturningDate.Size = new System.Drawing.Size(152, 37);
            this.lblReturnBookReturningDate.TabIndex = 17;
            this.lblReturnBookReturningDate.Text = "Borrow Id ";
            // 
            // TxtReturnBookAuthor
            // 
            this.TxtReturnBookAuthor.Location = new System.Drawing.Point(520, 84);
            this.TxtReturnBookAuthor.Name = "TxtReturnBookAuthor";
            this.TxtReturnBookAuthor.ReadOnly = true;
            this.TxtReturnBookAuthor.Size = new System.Drawing.Size(271, 27);
            this.TxtReturnBookAuthor.TabIndex = 15;
            // 
            // lblReturnBorrowedDate
            // 
            this.lblReturnBorrowedDate.AutoSize = true;
            this.lblReturnBorrowedDate.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReturnBorrowedDate.Location = new System.Drawing.Point(288, 132);
            this.lblReturnBorrowedDate.Name = "lblReturnBorrowedDate";
            this.lblReturnBorrowedDate.Size = new System.Drawing.Size(180, 37);
            this.lblReturnBorrowedDate.TabIndex = 14;
            this.lblReturnBorrowedDate.Text = "Borrow Date";
            // 
            // lblReturnBookAuthor
            // 
            this.lblReturnBookAuthor.AutoSize = true;
            this.lblReturnBookAuthor.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReturnBookAuthor.Location = new System.Drawing.Point(289, 75);
            this.lblReturnBookAuthor.Name = "lblReturnBookAuthor";
            this.lblReturnBookAuthor.Size = new System.Drawing.Size(180, 37);
            this.lblReturnBookAuthor.TabIndex = 13;
            this.lblReturnBookAuthor.Text = "Book Author";
            // 
            // TxtReturnBookName
            // 
            this.TxtReturnBookName.Location = new System.Drawing.Point(520, 33);
            this.TxtReturnBookName.Name = "TxtReturnBookName";
            this.TxtReturnBookName.ReadOnly = true;
            this.TxtReturnBookName.Size = new System.Drawing.Size(271, 27);
            this.TxtReturnBookName.TabIndex = 12;
            // 
            // lblRetunBookName
            // 
            this.lblRetunBookName.AutoSize = true;
            this.lblRetunBookName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRetunBookName.Location = new System.Drawing.Point(289, 24);
            this.lblRetunBookName.Name = "lblRetunBookName";
            this.lblRetunBookName.Size = new System.Drawing.Size(166, 37);
            this.lblRetunBookName.TabIndex = 11;
            this.lblRetunBookName.Text = "Book Name";
            // 
            // FormBookBorrowRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 749);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormBookBorrowRequest";
            this.Text = "BookBorrowRequest";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDashBoard;
        private System.Windows.Forms.Label LblManageBorrowReq;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtBookId;
        private System.Windows.Forms.Label LblReturnReqBookId;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblReturnBookReturningDate;
        private System.Windows.Forms.Label lblReturnBorrowedDate;
        private System.Windows.Forms.Label lblReturnBookAuthor;
        private System.Windows.Forms.Label lblRetunBookName;
        private System.Windows.Forms.TextBox TxtBookBorrowId;
        private System.Windows.Forms.TextBox TxtReturnBookAuthor;
        private System.Windows.Forms.TextBox TxtReturnBookName;
        private System.Windows.Forms.TextBox textUserID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpBorrowedDate;
    }
}
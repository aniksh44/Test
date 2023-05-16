
namespace Library_Management_System
{
    partial class FormLibrarianManageBooks
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
            this.LblLibrarianManageBooks = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnManageBooksReturnRequest = new System.Windows.Forms.Button();
            this.BtnManageBooksBorrowRequest = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.btnDashBoard);
            this.panel1.Controls.Add(this.LblLibrarianManageBooks);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1181, 151);
            this.panel1.TabIndex = 3;
            // 
            // btnDashBoard
            // 
            this.btnDashBoard.Location = new System.Drawing.Point(969, 74);
            this.btnDashBoard.Name = "btnDashBoard";
            this.btnDashBoard.Size = new System.Drawing.Size(177, 45);
            this.btnDashBoard.TabIndex = 3;
            this.btnDashBoard.Text = "DashBoard";
            this.btnDashBoard.UseVisualStyleBackColor = true;
            this.btnDashBoard.Click += new System.EventHandler(this.btnDashBoard_Click);
            // 
            // LblLibrarianManageBooks
            // 
            this.LblLibrarianManageBooks.AutoSize = true;
            this.LblLibrarianManageBooks.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblLibrarianManageBooks.ForeColor = System.Drawing.Color.White;
            this.LblLibrarianManageBooks.Location = new System.Drawing.Point(57, 45);
            this.LblLibrarianManageBooks.Name = "LblLibrarianManageBooks";
            this.LblLibrarianManageBooks.Size = new System.Drawing.Size(509, 72);
            this.LblLibrarianManageBooks.TabIndex = 0;
            this.LblLibrarianManageBooks.Text = "MANAGE BOOKS...";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.BtnManageBooksReturnRequest);
            this.panel2.Controls.Add(this.BtnManageBooksBorrowRequest);
            this.panel2.Location = new System.Drawing.Point(252, 237);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(662, 451);
            this.panel2.TabIndex = 4;
            // 
            // BtnManageBooksReturnRequest
            // 
            this.BtnManageBooksReturnRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnManageBooksReturnRequest.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnManageBooksReturnRequest.Location = new System.Drawing.Point(153, 261);
            this.BtnManageBooksReturnRequest.Name = "BtnManageBooksReturnRequest";
            this.BtnManageBooksReturnRequest.Size = new System.Drawing.Size(350, 96);
            this.BtnManageBooksReturnRequest.TabIndex = 1;
            this.BtnManageBooksReturnRequest.Text = "RETURN REQUEST";
            this.BtnManageBooksReturnRequest.UseVisualStyleBackColor = false;
            this.BtnManageBooksReturnRequest.Click += new System.EventHandler(this.BtnManageBooksReturnRequest_Click);
            // 
            // BtnManageBooksBorrowRequest
            // 
            this.BtnManageBooksBorrowRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnManageBooksBorrowRequest.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnManageBooksBorrowRequest.Location = new System.Drawing.Point(153, 60);
            this.BtnManageBooksBorrowRequest.Name = "BtnManageBooksBorrowRequest";
            this.BtnManageBooksBorrowRequest.Size = new System.Drawing.Size(350, 96);
            this.BtnManageBooksBorrowRequest.TabIndex = 0;
            this.BtnManageBooksBorrowRequest.Text = "BORROW REQUEST";
            this.BtnManageBooksBorrowRequest.UseVisualStyleBackColor = false;
            this.BtnManageBooksBorrowRequest.Click += new System.EventHandler(this.BtnManageBooksBorrowRequest_Click);
            // 
            // FormLibrarianManageBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormLibrarianManageBooks";
            this.Text = "LibrarianManageBooks";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblLibrarianManageBooks;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnManageBooksReturnRequest;
        private System.Windows.Forms.Button BtnManageBooksBorrowRequest;
        private System.Windows.Forms.Button btnDashBoard;
    }
}
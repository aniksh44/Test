
namespace Library_Management_System
{
    partial class FormAdminDashBoard
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
            this.AdminDashBoard = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.LblAdminDashBoard = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Panel();
            this.BtnAdminRemoveBooks = new System.Windows.Forms.Button();
            this.BtnAdminRemoveLibrarian = new System.Windows.Forms.Button();
            this.BtnAdminAddLibrarian = new System.Windows.Forms.Button();
            this.BtnAdminAddBooks = new System.Windows.Forms.Button();
            this.BtnAdminSearchBooks = new System.Windows.Forms.Button();
            this.AdminDashBoard.SuspendLayout();
            this.btnSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // AdminDashBoard
            // 
            this.AdminDashBoard.BackColor = System.Drawing.Color.Teal;
            this.AdminDashBoard.Controls.Add(this.btnLogOut);
            this.AdminDashBoard.Controls.Add(this.LblAdminDashBoard);
            this.AdminDashBoard.Location = new System.Drawing.Point(1, 1);
            this.AdminDashBoard.Name = "AdminDashBoard";
            this.AdminDashBoard.Size = new System.Drawing.Size(1180, 125);
            this.AdminDashBoard.TabIndex = 0;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(982, 55);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(136, 47);
            this.btnLogOut.TabIndex = 3;
            this.btnLogOut.Text = "LogOut";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // LblAdminDashBoard
            // 
            this.LblAdminDashBoard.AutoSize = true;
            this.LblAdminDashBoard.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblAdminDashBoard.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblAdminDashBoard.Location = new System.Drawing.Point(56, 32);
            this.LblAdminDashBoard.Name = "LblAdminDashBoard";
            this.LblAdminDashBoard.Size = new System.Drawing.Size(435, 54);
            this.LblAdminDashBoard.TabIndex = 0;
            this.LblAdminDashBoard.Text = "ADMIN DASH BOARD";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Silver;
            this.btnSearch.Controls.Add(this.BtnAdminRemoveBooks);
            this.btnSearch.Controls.Add(this.BtnAdminRemoveLibrarian);
            this.btnSearch.Controls.Add(this.BtnAdminAddLibrarian);
            this.btnSearch.Controls.Add(this.BtnAdminAddBooks);
            this.btnSearch.Controls.Add(this.BtnAdminSearchBooks);
            this.btnSearch.Location = new System.Drawing.Point(191, 188);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(878, 492);
            this.btnSearch.TabIndex = 1;
            // 
            // BtnAdminRemoveBooks
            // 
            this.BtnAdminRemoveBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnAdminRemoveBooks.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnAdminRemoveBooks.Location = new System.Drawing.Point(266, 178);
            this.BtnAdminRemoveBooks.Name = "BtnAdminRemoveBooks";
            this.BtnAdminRemoveBooks.Size = new System.Drawing.Size(381, 74);
            this.BtnAdminRemoveBooks.TabIndex = 5;
            this.BtnAdminRemoveBooks.Text = "REMOVE BOOKS";
            this.BtnAdminRemoveBooks.UseVisualStyleBackColor = false;
            this.BtnAdminRemoveBooks.Click += new System.EventHandler(this.BtnAdminRemoveBooks_Click);
            // 
            // BtnAdminRemoveLibrarian
            // 
            this.BtnAdminRemoveLibrarian.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnAdminRemoveLibrarian.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnAdminRemoveLibrarian.Location = new System.Drawing.Point(266, 363);
            this.BtnAdminRemoveLibrarian.Name = "BtnAdminRemoveLibrarian";
            this.BtnAdminRemoveLibrarian.Size = new System.Drawing.Size(381, 74);
            this.BtnAdminRemoveLibrarian.TabIndex = 4;
            this.BtnAdminRemoveLibrarian.Text = "REMOVE LIBRARIAN";
            this.BtnAdminRemoveLibrarian.UseVisualStyleBackColor = false;
            this.BtnAdminRemoveLibrarian.Click += new System.EventHandler(this.BtnAdminRemoveLibrarian_Click);
            // 
            // BtnAdminAddLibrarian
            // 
            this.BtnAdminAddLibrarian.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnAdminAddLibrarian.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnAdminAddLibrarian.Location = new System.Drawing.Point(266, 268);
            this.BtnAdminAddLibrarian.Name = "BtnAdminAddLibrarian";
            this.BtnAdminAddLibrarian.Size = new System.Drawing.Size(381, 74);
            this.BtnAdminAddLibrarian.TabIndex = 3;
            this.BtnAdminAddLibrarian.Text = "ADD LIBRARIAN";
            this.BtnAdminAddLibrarian.UseVisualStyleBackColor = false;
            this.BtnAdminAddLibrarian.Click += new System.EventHandler(this.BtnAdminAddLibrarian_Click);
            // 
            // BtnAdminAddBooks
            // 
            this.BtnAdminAddBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnAdminAddBooks.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnAdminAddBooks.Location = new System.Drawing.Point(266, 88);
            this.BtnAdminAddBooks.Name = "BtnAdminAddBooks";
            this.BtnAdminAddBooks.Size = new System.Drawing.Size(381, 74);
            this.BtnAdminAddBooks.TabIndex = 1;
            this.BtnAdminAddBooks.Text = "ADD BOOKS";
            this.BtnAdminAddBooks.UseVisualStyleBackColor = false;
            this.BtnAdminAddBooks.Click += new System.EventHandler(this.BtnAdminAddBooks_Click);
            // 
            // BtnAdminSearchBooks
            // 
            this.BtnAdminSearchBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnAdminSearchBooks.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnAdminSearchBooks.Location = new System.Drawing.Point(266, 0);
            this.BtnAdminSearchBooks.Name = "BtnAdminSearchBooks";
            this.BtnAdminSearchBooks.Size = new System.Drawing.Size(381, 68);
            this.BtnAdminSearchBooks.TabIndex = 0;
            this.BtnAdminSearchBooks.Text = "Search-Books";
            this.BtnAdminSearchBooks.UseVisualStyleBackColor = false;
            this.BtnAdminSearchBooks.Click += new System.EventHandler(this.BtnAdminSearchBooks_Click);
            // 
            // FormAdminDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1182, 721);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.AdminDashBoard);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "FormAdminDashBoard";
            this.Text = "AdminForm";
            this.AdminDashBoard.ResumeLayout(false);
            this.AdminDashBoard.PerformLayout();
            this.btnSearch.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel AdminDashBoard;
        private System.Windows.Forms.Label LblAdminDashBoard;
        private System.Windows.Forms.Panel btnSearch;
        private System.Windows.Forms.Button BtnAdminSearchBooks;
        private System.Windows.Forms.Button BtnAdminAddLibrarian;
        private System.Windows.Forms.Button BtnAdminAddBooks;
        private System.Windows.Forms.Button BtnAdminRemoveBooks;
        private System.Windows.Forms.Button BtnAdminRemoveLibrarian;
        private System.Windows.Forms.Button btnLogOut;
    }
}
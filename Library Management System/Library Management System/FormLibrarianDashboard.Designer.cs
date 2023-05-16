
namespace Library_Management_System
{
    partial class FormLibrarianDashboard
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
            this.lblLibrarian = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnLibrarianRemoveMember = new System.Windows.Forms.Button();
            this.BtnMangerBooks = new System.Windows.Forms.Button();
            this.BtnLibrarianAddMember = new System.Windows.Forms.Button();
            this.btnLibrarianSearchbooks = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.lblLibrarian);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1178, 147);
            this.panel1.TabIndex = 0;
            // 
            // lblLibrarian
            // 
            this.lblLibrarian.AutoSize = true;
            this.lblLibrarian.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLibrarian.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLibrarian.Location = new System.Drawing.Point(28, 43);
            this.lblLibrarian.Name = "lblLibrarian";
            this.lblLibrarian.Size = new System.Drawing.Size(475, 62);
            this.lblLibrarian.TabIndex = 1;
            this.lblLibrarian.Text = "Librarian Dashboard";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Controls.Add(this.BtnLibrarianRemoveMember);
            this.panel2.Controls.Add(this.BtnMangerBooks);
            this.panel2.Controls.Add(this.BtnLibrarianAddMember);
            this.panel2.Controls.Add(this.btnLibrarianSearchbooks);
            this.panel2.Location = new System.Drawing.Point(159, 203);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(914, 533);
            this.panel2.TabIndex = 1;
            // 
            // BtnLibrarianRemoveMember
            // 
            this.BtnLibrarianRemoveMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnLibrarianRemoveMember.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnLibrarianRemoveMember.Location = new System.Drawing.Point(252, 266);
            this.BtnLibrarianRemoveMember.Name = "BtnLibrarianRemoveMember";
            this.BtnLibrarianRemoveMember.Size = new System.Drawing.Size(360, 92);
            this.BtnLibrarianRemoveMember.TabIndex = 3;
            this.BtnLibrarianRemoveMember.Text = "REMOVE MEMBER";
            this.BtnLibrarianRemoveMember.UseVisualStyleBackColor = false;
            this.BtnLibrarianRemoveMember.Click += new System.EventHandler(this.BtnLibrarianRemoveMember_Click);
            // 
            // BtnMangerBooks
            // 
            this.BtnMangerBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnMangerBooks.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnMangerBooks.Location = new System.Drawing.Point(252, 398);
            this.BtnMangerBooks.Name = "BtnMangerBooks";
            this.BtnMangerBooks.Size = new System.Drawing.Size(360, 91);
            this.BtnMangerBooks.TabIndex = 2;
            this.BtnMangerBooks.Text = "MANAGE BOOKS";
            this.BtnMangerBooks.UseVisualStyleBackColor = false;
            this.BtnMangerBooks.Click += new System.EventHandler(this.BtnMangerBooks_Click);
            // 
            // BtnLibrarianAddMember
            // 
            this.BtnLibrarianAddMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnLibrarianAddMember.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnLibrarianAddMember.Location = new System.Drawing.Point(252, 144);
            this.BtnLibrarianAddMember.Name = "BtnLibrarianAddMember";
            this.BtnLibrarianAddMember.Size = new System.Drawing.Size(360, 92);
            this.BtnLibrarianAddMember.TabIndex = 1;
            this.BtnLibrarianAddMember.Text = "ADD MEMBER";
            this.BtnLibrarianAddMember.UseVisualStyleBackColor = false;
            this.BtnLibrarianAddMember.Click += new System.EventHandler(this.BtnLibrarianAddMember_Click);
            // 
            // btnLibrarianSearchbooks
            // 
            this.btnLibrarianSearchbooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnLibrarianSearchbooks.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLibrarianSearchbooks.Location = new System.Drawing.Point(252, 33);
            this.btnLibrarianSearchbooks.Name = "btnLibrarianSearchbooks";
            this.btnLibrarianSearchbooks.Size = new System.Drawing.Size(360, 90);
            this.btnLibrarianSearchbooks.TabIndex = 0;
            this.btnLibrarianSearchbooks.Text = "SEARCH BOOKS";
            this.btnLibrarianSearchbooks.UseVisualStyleBackColor = false;
            this.btnLibrarianSearchbooks.Click += new System.EventHandler(this.btnLibrarianSearchbooks_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(1006, 80);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(136, 47);
            this.btnLogOut.TabIndex = 2;
            this.btnLogOut.Text = "LogOut";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // FormLibrarianDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormLibrarianDashboard";
            this.Text = "FormLibrarian";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLibrarian;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnMangerBooks;
        private System.Windows.Forms.Button BtnLibrarianAddMember;
        private System.Windows.Forms.Button btnLibrarianSearchbooks;
        private System.Windows.Forms.Button BtnLibrarianRemoveMember;
        private System.Windows.Forms.Button btnLogOut;
    }
}

namespace Library_Management_System
{
    partial class FormRemoveLibrarian
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
            this.btnSearchById = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDashBoard = new System.Windows.Forms.Button();
            this.txtSearchById = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRemoveLibrarian = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.dcss = new System.Windows.Forms.Label();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.h = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Controls.Add(this.btnSearchById);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnDashBoard);
            this.panel1.Controls.Add(this.txtSearchById);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(894, 232);
            this.panel1.TabIndex = 0;
            // 
            // btnSearchById
            // 
            this.btnSearchById.Location = new System.Drawing.Point(421, 173);
            this.btnSearchById.Name = "btnSearchById";
            this.btnSearchById.Size = new System.Drawing.Size(94, 29);
            this.btnSearchById.TabIndex = 6;
            this.btnSearchById.Text = "Search";
            this.btnSearchById.UseVisualStyleBackColor = true;
            this.btnSearchById.Click += new System.EventHandler(this.btnSearchById_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(380, 50);
            this.label2.TabIndex = 5;
            this.label2.Text = "REMOVE LIBRARIAN";
            // 
            // btnDashBoard
            // 
            this.btnDashBoard.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDashBoard.Location = new System.Drawing.Point(747, 17);
            this.btnDashBoard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDashBoard.Name = "btnDashBoard";
            this.btnDashBoard.Size = new System.Drawing.Size(135, 31);
            this.btnDashBoard.TabIndex = 4;
            this.btnDashBoard.Text = "DASHBOARD";
            this.btnDashBoard.UseVisualStyleBackColor = true;
            this.btnDashBoard.Click += new System.EventHandler(this.btnDashBoard_Click);
            // 
            // txtSearchById
            // 
            this.txtSearchById.Location = new System.Drawing.Point(47, 173);
            this.txtSearchById.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearchById.Name = "txtSearchById";
            this.txtSearchById.Size = new System.Drawing.Size(333, 27);
            this.txtSearchById.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(47, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search By Librarian Id";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel2.Controls.Add(this.btnRemoveLibrarian);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 588);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(894, 137);
            this.panel2.TabIndex = 1;
            // 
            // btnRemoveLibrarian
            // 
            this.btnRemoveLibrarian.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveLibrarian.Location = new System.Drawing.Point(389, 59);
            this.btnRemoveLibrarian.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRemoveLibrarian.Name = "btnRemoveLibrarian";
            this.btnRemoveLibrarian.Size = new System.Drawing.Size(126, 48);
            this.btnRemoveLibrarian.TabIndex = 0;
            this.btnRemoveLibrarian.Text = "Remove";
            this.btnRemoveLibrarian.UseVisualStyleBackColor = true;
            this.btnRemoveLibrarian.Click += new System.EventHandler(this.btnRemoveLibrarian_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(0, 229);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(896, 360);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Controls.Add(this.txtPassword);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.txtEmail);
            this.panel4.Controls.Add(this.dcss);
            this.panel4.Controls.Add(this.txtGender);
            this.panel4.Controls.Add(this.txtName);
            this.panel4.Controls.Add(this.h);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(0, -7);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(896, 367);
            this.panel4.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(317, 115);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(407, 27);
            this.txtEmail.TabIndex = 10;
            // 
            // dcss
            // 
            this.dcss.AutoSize = true;
            this.dcss.BackColor = System.Drawing.Color.LightGray;
            this.dcss.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dcss.Location = new System.Drawing.Point(164, 119);
            this.dcss.Name = "dcss";
            this.dcss.Size = new System.Drawing.Size(54, 23);
            this.dcss.TabIndex = 11;
            this.dcss.Text = "Email";
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(317, 189);
            this.txtGender.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGender.Name = "txtGender";
            this.txtGender.ReadOnly = true;
            this.txtGender.Size = new System.Drawing.Size(407, 27);
            this.txtGender.TabIndex = 8;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(317, 52);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(407, 27);
            this.txtName.TabIndex = 3;
            // 
            // h
            // 
            this.h.AutoSize = true;
            this.h.BackColor = System.Drawing.Color.LightGray;
            this.h.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.h.Location = new System.Drawing.Point(150, 193);
            this.h.Name = "h";
            this.h.Size = new System.Drawing.Size(68, 23);
            this.h.TabIndex = 9;
            this.h.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightGray;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(156, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Name ";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(317, 266);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.ReadOnly = true;
            this.txtPassword.Size = new System.Drawing.Size(407, 27);
            this.txtPassword.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightGray;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(133, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "Password";
            // 
            // FormRemoveLibrarian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 725);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormRemoveLibrarian";
            this.Text = "RemoveLibrarian";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDashBoard;
        private System.Windows.Forms.TextBox txtSearchById;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRemoveLibrarian;
        private System.Windows.Forms.Button btnSearchById;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label dcss;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label h;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
    }
}
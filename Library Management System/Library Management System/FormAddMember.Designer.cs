
namespace Library_Management_System
{
    partial class FormAddMember
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDashBoard = new System.Windows.Forms.Button();
            this.LblAddMember = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioBtnFemale = new System.Windows.Forms.RadioButton();
            this.radioBtnMale = new System.Windows.Forms.RadioButton();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.LblAddLibrarianId = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.LblAddLibrarianName = new System.Windows.Forms.Label();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Teal;
            this.panel3.Controls.Add(this.btnDashBoard);
            this.panel3.Controls.Add(this.LblAddMember);
            this.panel3.Location = new System.Drawing.Point(1, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1181, 151);
            this.panel3.TabIndex = 1;
            // 
            // btnDashBoard
            // 
            this.btnDashBoard.Location = new System.Drawing.Point(953, 67);
            this.btnDashBoard.Name = "btnDashBoard";
            this.btnDashBoard.Size = new System.Drawing.Size(177, 45);
            this.btnDashBoard.TabIndex = 2;
            this.btnDashBoard.Text = "DashBoard";
            this.btnDashBoard.UseVisualStyleBackColor = true;
            this.btnDashBoard.Click += new System.EventHandler(this.btnDashBoard_Click);
            // 
            // LblAddMember
            // 
            this.LblAddMember.AutoSize = true;
            this.LblAddMember.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblAddMember.ForeColor = System.Drawing.Color.White;
            this.LblAddMember.Location = new System.Drawing.Point(57, 45);
            this.LblAddMember.Name = "LblAddMember";
            this.LblAddMember.Size = new System.Drawing.Size(344, 62);
            this.LblAddMember.TabIndex = 0;
            this.LblAddMember.Text = "ADD MEMBER";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtUserId);
            this.panel1.Controls.Add(this.LblAddLibrarianId);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.LblAddLibrarianName);
            this.panel1.Controls.Add(this.btnAddMember);
            this.panel1.Location = new System.Drawing.Point(170, 203);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(875, 469);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioBtnFemale);
            this.panel2.Controls.Add(this.radioBtnMale);
            this.panel2.Location = new System.Drawing.Point(351, 196);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(229, 120);
            this.panel2.TabIndex = 20;
            // 
            // radioBtnFemale
            // 
            this.radioBtnFemale.AutoSize = true;
            this.radioBtnFemale.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioBtnFemale.Location = new System.Drawing.Point(3, 68);
            this.radioBtnFemale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioBtnFemale.Name = "radioBtnFemale";
            this.radioBtnFemale.Size = new System.Drawing.Size(95, 27);
            this.radioBtnFemale.TabIndex = 1;
            this.radioBtnFemale.TabStop = true;
            this.radioBtnFemale.Text = "FEMALE";
            this.radioBtnFemale.UseVisualStyleBackColor = true;
            // 
            // radioBtnMale
            // 
            this.radioBtnMale.AutoSize = true;
            this.radioBtnMale.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioBtnMale.Location = new System.Drawing.Point(3, 16);
            this.radioBtnMale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioBtnMale.Name = "radioBtnMale";
            this.radioBtnMale.Size = new System.Drawing.Size(77, 27);
            this.radioBtnMale.TabIndex = 0;
            this.radioBtnMale.TabStop = true;
            this.radioBtnMale.Text = "MALE";
            this.radioBtnMale.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(351, 345);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(311, 27);
            this.txtEmail.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(198, 333);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 37);
            this.label1.TabIndex = 18;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(198, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 37);
            this.label2.TabIndex = 17;
            this.label2.Text = "Gender ";
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(351, 139);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(311, 27);
            this.txtUserId.TabIndex = 16;
            // 
            // LblAddLibrarianId
            // 
            this.LblAddLibrarianId.AutoSize = true;
            this.LblAddLibrarianId.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblAddLibrarianId.Location = new System.Drawing.Point(198, 129);
            this.LblAddLibrarianId.Name = "LblAddLibrarianId";
            this.LblAddLibrarianId.Size = new System.Drawing.Size(67, 37);
            this.LblAddLibrarianId.TabIndex = 15;
            this.LblAddLibrarianId.Text = " ID  ";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(351, 63);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(311, 27);
            this.txtName.TabIndex = 14;
            // 
            // LblAddLibrarianName
            // 
            this.LblAddLibrarianName.AutoSize = true;
            this.LblAddLibrarianName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblAddLibrarianName.Location = new System.Drawing.Point(198, 53);
            this.LblAddLibrarianName.Name = "LblAddLibrarianName";
            this.LblAddLibrarianName.Size = new System.Drawing.Size(93, 37);
            this.LblAddLibrarianName.TabIndex = 13;
            this.LblAddLibrarianName.Text = "Name";
            // 
            // btnAddMember
            // 
            this.btnAddMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAddMember.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddMember.Location = new System.Drawing.Point(351, 396);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(126, 52);
            this.btnAddMember.TabIndex = 6;
            this.btnAddMember.Text = "ADD";
            this.btnAddMember.UseVisualStyleBackColor = false;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // FormAddMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 749);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "FormAddMember";
            this.Text = "AddMember";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LblAddMember;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.Button btnDashBoard;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label LblAddLibrarianId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label LblAddLibrarianName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioBtnMale;
        private System.Windows.Forms.RadioButton radioBtnFemale;
    }
}

namespace Library_Management_System
{
    partial class FormRemoveBooks
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
            this.lblSearchByTitle = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.btnDashBoard = new System.Windows.Forms.Button();
            this.btnSearchBooks = new System.Windows.Forms.Button();
            this.txtSearchBooks = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRemoveBook = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtRemoveQuantity = new System.Windows.Forms.TextBox();
            this.dcss = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.h = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Controls.Add(this.lblSearchByTitle);
            this.panel1.Controls.Add(this.label);
            this.panel1.Controls.Add(this.btnDashBoard);
            this.panel1.Controls.Add(this.btnSearchBooks);
            this.panel1.Controls.Add(this.txtSearchBooks);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(896, 224);
            this.panel1.TabIndex = 0;
            // 
            // lblSearchByTitle
            // 
            this.lblSearchByTitle.AutoSize = true;
            this.lblSearchByTitle.BackColor = System.Drawing.Color.LightGray;
            this.lblSearchByTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSearchByTitle.Location = new System.Drawing.Point(43, 91);
            this.lblSearchByTitle.Name = "lblSearchByTitle";
            this.lblSearchByTitle.Size = new System.Drawing.Size(157, 23);
            this.lblSearchByTitle.TabIndex = 6;
            this.lblSearchByTitle.Text = "Search By Book ID";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.LightGray;
            this.label.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label.Location = new System.Drawing.Point(3, 3);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(284, 46);
            this.label.TabIndex = 5;
            this.label.Text = "REMOVE BOOKS";
            // 
            // btnDashBoard
            // 
            this.btnDashBoard.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDashBoard.Location = new System.Drawing.Point(753, 13);
            this.btnDashBoard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDashBoard.Name = "btnDashBoard";
            this.btnDashBoard.Size = new System.Drawing.Size(129, 39);
            this.btnDashBoard.TabIndex = 4;
            this.btnDashBoard.Text = "DashBoard";
            this.btnDashBoard.UseVisualStyleBackColor = true;
            this.btnDashBoard.Click += new System.EventHandler(this.btnDashBoard_Click);
            // 
            // btnSearchBooks
            // 
            this.btnSearchBooks.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearchBooks.Location = new System.Drawing.Point(491, 130);
            this.btnSearchBooks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearchBooks.Name = "btnSearchBooks";
            this.btnSearchBooks.Size = new System.Drawing.Size(95, 31);
            this.btnSearchBooks.TabIndex = 1;
            this.btnSearchBooks.Text = "Search";
            this.btnSearchBooks.UseVisualStyleBackColor = true;
            this.btnSearchBooks.Click += new System.EventHandler(this.btnSearchBooks_Click);
            // 
            // txtSearchBooks
            // 
            this.txtSearchBooks.Location = new System.Drawing.Point(43, 130);
            this.txtSearchBooks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearchBooks.Name = "txtSearchBooks";
            this.txtSearchBooks.Size = new System.Drawing.Size(407, 27);
            this.txtSearchBooks.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel2.Controls.Add(this.btnRemoveBook);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 583);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(896, 165);
            this.panel2.TabIndex = 1;
            // 
            // btnRemoveBook
            // 
            this.btnRemoveBook.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveBook.Location = new System.Drawing.Point(430, 44);
            this.btnRemoveBook.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRemoveBook.Name = "btnRemoveBook";
            this.btnRemoveBook.Size = new System.Drawing.Size(105, 40);
            this.btnRemoveBook.TabIndex = 0;
            this.btnRemoveBook.Text = "Remove";
            this.btnRemoveBook.UseVisualStyleBackColor = true;
            this.btnRemoveBook.Click += new System.EventHandler(this.btnRemoveBook_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.txtRemoveQuantity);
            this.panel3.Controls.Add(this.dcss);
            this.panel3.Controls.Add(this.txtQuantity);
            this.panel3.Controls.Add(this.txtBookName);
            this.panel3.Controls.Add(this.h);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(0, 221);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(896, 362);
            this.panel3.TabIndex = 2;
            // 
            // txtRemoveQuantity
            // 
            this.txtRemoveQuantity.Location = new System.Drawing.Point(317, 193);
            this.txtRemoveQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRemoveQuantity.Name = "txtRemoveQuantity";
            this.txtRemoveQuantity.ReadOnly = true;
            this.txtRemoveQuantity.Size = new System.Drawing.Size(407, 27);
            this.txtRemoveQuantity.TabIndex = 10;
            // 
            // dcss
            // 
            this.dcss.AutoSize = true;
            this.dcss.BackColor = System.Drawing.Color.LightGray;
            this.dcss.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dcss.Location = new System.Drawing.Point(115, 197);
            this.dcss.Name = "dcss";
            this.dcss.Size = new System.Drawing.Size(149, 23);
            this.dcss.TabIndex = 11;
            this.dcss.Text = "Remove Quantity";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(317, 119);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.ReadOnly = true;
            this.txtQuantity.Size = new System.Drawing.Size(407, 27);
            this.txtQuantity.TabIndex = 8;
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(317, 52);
            this.txtBookName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.ReadOnly = true;
            this.txtBookName.Size = new System.Drawing.Size(407, 27);
            this.txtBookName.TabIndex = 3;
            // 
            // h
            // 
            this.h.AutoSize = true;
            this.h.BackColor = System.Drawing.Color.LightGray;
            this.h.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.h.Location = new System.Drawing.Point(115, 123);
            this.h.Name = "h";
            this.h.Size = new System.Drawing.Size(80, 23);
            this.h.TabIndex = 9;
            this.h.Text = "Quantity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(115, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Book Name ";
            // 
            // FormRemoveBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 748);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormRemoveBooks";
            this.Text = "RemoveBooks";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSearchBooks;
        private System.Windows.Forms.TextBox txtSearchBooks;
        private System.Windows.Forms.Button btnRemoveBook;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button btnDashBoard;
        private System.Windows.Forms.Label lblSearchByTitle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtRemoveQuantity;
        private System.Windows.Forms.Label dcss;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Label h;
        private System.Windows.Forms.Label label1;
    }
}
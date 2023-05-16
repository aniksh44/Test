
namespace Library_Management_System
{
    partial class FormAddBooks
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
            this.lblAddBooks = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.dd = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBookAuthor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.LblAddBookName = new System.Windows.Forms.Label();
            this.txtBookId = new System.Windows.Forms.TextBox();
            this.LblAddBookId = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.btnDashBoard);
            this.panel1.Controls.Add(this.lblAddBooks);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1181, 172);
            this.panel1.TabIndex = 0;
            // 
            // btnDashBoard
            // 
            this.btnDashBoard.Location = new System.Drawing.Point(879, 99);
            this.btnDashBoard.Name = "btnDashBoard";
            this.btnDashBoard.Size = new System.Drawing.Size(137, 39);
            this.btnDashBoard.TabIndex = 2;
            this.btnDashBoard.Text = "DashBoard";
            this.btnDashBoard.UseVisualStyleBackColor = true;
            this.btnDashBoard.Click += new System.EventHandler(this.btnDashBoard_Click);
            // 
            // lblAddBooks
            // 
            this.lblAddBooks.AutoSize = true;
            this.lblAddBooks.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAddBooks.ForeColor = System.Drawing.Color.White;
            this.lblAddBooks.Location = new System.Drawing.Point(35, 29);
            this.lblAddBooks.Name = "lblAddBooks";
            this.lblAddBooks.Size = new System.Drawing.Size(308, 62);
            this.lblAddBooks.TabIndex = 0;
            this.lblAddBooks.Text = "ADD-BOOKS";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.txtPublisher);
            this.panel2.Controls.Add(this.dd);
            this.panel2.Controls.Add(this.txtQuantity);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtCategory);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtBookAuthor);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnAddBook);
            this.panel2.Controls.Add(this.txtBookName);
            this.panel2.Controls.Add(this.LblAddBookName);
            this.panel2.Controls.Add(this.txtBookId);
            this.panel2.Controls.Add(this.LblAddBookId);
            this.panel2.Location = new System.Drawing.Point(117, 180);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(830, 506);
            this.panel2.TabIndex = 1;
            // 
            // txtPublisher
            // 
            this.txtPublisher.Location = new System.Drawing.Point(301, 330);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(307, 27);
            this.txtPublisher.TabIndex = 14;
            // 
            // dd
            // 
            this.dd.AutoSize = true;
            this.dd.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dd.Location = new System.Drawing.Point(80, 377);
            this.dd.Name = "dd";
            this.dd.Size = new System.Drawing.Size(136, 37);
            this.dd.TabIndex = 13;
            this.dd.Text = " Quantity";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(301, 388);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(307, 27);
            this.txtQuantity.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(80, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 37);
            this.label3.TabIndex = 11;
            this.label3.Text = "Publisher";
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(301, 272);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(307, 27);
            this.txtCategory.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(80, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 37);
            this.label2.TabIndex = 9;
            this.label2.Text = "Category";
            // 
            // txtBookAuthor
            // 
            this.txtBookAuthor.Location = new System.Drawing.Point(301, 213);
            this.txtBookAuthor.Name = "txtBookAuthor";
            this.txtBookAuthor.Size = new System.Drawing.Size(307, 27);
            this.txtBookAuthor.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(80, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 37);
            this.label1.TabIndex = 7;
            this.label1.Text = "Book Author";
            // 
            // btnAddBook
            // 
            this.btnAddBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAddBook.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddBook.Location = new System.Drawing.Point(365, 444);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(189, 48);
            this.btnAddBook.TabIndex = 6;
            this.btnAddBook.Text = "ADD";
            this.btnAddBook.UseVisualStyleBackColor = false;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(301, 81);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(307, 27);
            this.txtBookName.TabIndex = 3;
            // 
            // LblAddBookName
            // 
            this.LblAddBookName.AutoSize = true;
            this.LblAddBookName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblAddBookName.Location = new System.Drawing.Point(80, 71);
            this.LblAddBookName.Name = "LblAddBookName";
            this.LblAddBookName.Size = new System.Drawing.Size(166, 37);
            this.LblAddBookName.TabIndex = 2;
            this.LblAddBookName.Text = "Book Name";
            // 
            // txtBookId
            // 
            this.txtBookId.Location = new System.Drawing.Point(301, 147);
            this.txtBookId.Name = "txtBookId";
            this.txtBookId.Size = new System.Drawing.Size(307, 27);
            this.txtBookId.TabIndex = 1;
            // 
            // LblAddBookId
            // 
            this.LblAddBookId.AutoSize = true;
            this.LblAddBookId.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblAddBookId.Location = new System.Drawing.Point(80, 135);
            this.LblAddBookId.Name = "LblAddBookId";
            this.LblAddBookId.Size = new System.Drawing.Size(116, 37);
            this.LblAddBookId.TabIndex = 0;
            this.LblAddBookId.Text = "Book Id";
            // 
            // FormAddBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 712);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormAddBooks";
            this.Text = "AddBooks";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAddBooks;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LblAddBookName;
        private System.Windows.Forms.TextBox txtBookId;
        private System.Windows.Forms.Label LblAddBookId;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Label LblBookId;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnDashBoard;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBookAuthor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPublisher;
        private System.Windows.Forms.Label dd;
    }
}
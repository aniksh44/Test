
namespace Library_Management_System
{
    partial class FormSearchBook
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
            this.dgvSearchBook = new System.Windows.Forms.DataGridView();
            this.BookId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Publisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSearchBook = new System.Windows.Forms.Label();
            this.btnDashBoard = new System.Windows.Forms.Button();
            this.txtSearchByName = new System.Windows.Forms.TextBox();
            this.lblSearchByTitle = new System.Windows.Forms.Label();
            this.btnSearchByName = new System.Windows.Forms.Button();
            this.btnSearchByCategory = new System.Windows.Forms.Button();
            this.txtSearchByCategory = new System.Windows.Forms.TextBox();
            this.txtSearchByBookId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearchByBookId = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchBook)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvSearchBook);
            this.panel1.Location = new System.Drawing.Point(-5, 248);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 371);
            this.panel1.TabIndex = 0;
            // 
            // dgvSearchBook
            // 
            this.dgvSearchBook.AllowUserToAddRows = false;
            this.dgvSearchBook.AllowUserToDeleteRows = false;
            this.dgvSearchBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookId,
            this.BookTitle,
            this.BookAuthor,
            this.BookCategory,
            this.Publisher,
            this.Quantity});
            this.dgvSearchBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSearchBook.Location = new System.Drawing.Point(0, 0);
            this.dgvSearchBook.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvSearchBook.Name = "dgvSearchBook";
            this.dgvSearchBook.ReadOnly = true;
            this.dgvSearchBook.RowHeadersWidth = 51;
            this.dgvSearchBook.RowTemplate.Height = 25;
            this.dgvSearchBook.Size = new System.Drawing.Size(794, 371);
            this.dgvSearchBook.TabIndex = 0;
            // 
            // BookId
            // 
            this.BookId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BookId.DataPropertyName = "BookId";
            this.BookId.HeaderText = "Book Id";
            this.BookId.MinimumWidth = 6;
            this.BookId.Name = "BookId";
            this.BookId.ReadOnly = true;
            // 
            // BookTitle
            // 
            this.BookTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BookTitle.DataPropertyName = "Name";
            this.BookTitle.HeaderText = "Book Title";
            this.BookTitle.MinimumWidth = 6;
            this.BookTitle.Name = "BookTitle";
            this.BookTitle.ReadOnly = true;
            // 
            // BookAuthor
            // 
            this.BookAuthor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BookAuthor.DataPropertyName = "Author";
            this.BookAuthor.HeaderText = "Book Author";
            this.BookAuthor.MinimumWidth = 6;
            this.BookAuthor.Name = "BookAuthor";
            this.BookAuthor.ReadOnly = true;
            // 
            // BookCategory
            // 
            this.BookCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BookCategory.DataPropertyName = "Category";
            this.BookCategory.HeaderText = "Category";
            this.BookCategory.MinimumWidth = 6;
            this.BookCategory.Name = "BookCategory";
            this.BookCategory.ReadOnly = true;
            // 
            // Publisher
            // 
            this.Publisher.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Publisher.DataPropertyName = "Publisher";
            this.Publisher.HeaderText = "Publisher";
            this.Publisher.MinimumWidth = 6;
            this.Publisher.Name = "Publisher";
            this.Publisher.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel2.Controls.Add(this.txtSearchByBookId);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnSearchByBookId);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblSearchBook);
            this.panel2.Controls.Add(this.btnDashBoard);
            this.panel2.Controls.Add(this.txtSearchByName);
            this.panel2.Controls.Add(this.lblSearchByTitle);
            this.panel2.Controls.Add(this.btnSearchByName);
            this.panel2.Controls.Add(this.btnSearchByCategory);
            this.panel2.Controls.Add(this.txtSearchByCategory);
            this.panel2.Location = new System.Drawing.Point(-5, 3);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(794, 251);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Search By Book Category";
            // 
            // lblSearchBook
            // 
            this.lblSearchBook.AutoSize = true;
            this.lblSearchBook.BackColor = System.Drawing.Color.LightGray;
            this.lblSearchBook.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSearchBook.Location = new System.Drawing.Point(6, 3);
            this.lblSearchBook.Name = "lblSearchBook";
            this.lblSearchBook.Size = new System.Drawing.Size(232, 46);
            this.lblSearchBook.TabIndex = 6;
            this.lblSearchBook.Text = "Search Books";
            // 
            // btnDashBoard
            // 
            this.btnDashBoard.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDashBoard.Location = new System.Drawing.Point(657, 13);
            this.btnDashBoard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDashBoard.Name = "btnDashBoard";
            this.btnDashBoard.Size = new System.Drawing.Size(115, 39);
            this.btnDashBoard.TabIndex = 5;
            this.btnDashBoard.Text = "DashBoard";
            this.btnDashBoard.UseVisualStyleBackColor = true;
            this.btnDashBoard.Click += new System.EventHandler(this.btnDashBoard_Click);
            // 
            // txtSearchByName
            // 
            this.txtSearchByName.Location = new System.Drawing.Point(517, 164);
            this.txtSearchByName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearchByName.Name = "txtSearchByName";
            this.txtSearchByName.Size = new System.Drawing.Size(158, 27);
            this.txtSearchByName.TabIndex = 4;
            // 
            // lblSearchByTitle
            // 
            this.lblSearchByTitle.AutoSize = true;
            this.lblSearchByTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSearchByTitle.Location = new System.Drawing.Point(508, 125);
            this.lblSearchByTitle.Name = "lblSearchByTitle";
            this.lblSearchByTitle.Size = new System.Drawing.Size(186, 23);
            this.lblSearchByTitle.TabIndex = 3;
            this.lblSearchByTitle.Text = "Search By Book Name";
            // 
            // btnSearchByName
            // 
            this.btnSearchByName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearchByName.Location = new System.Drawing.Point(517, 202);
            this.btnSearchByName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearchByName.Name = "btnSearchByName";
            this.btnSearchByName.Size = new System.Drawing.Size(94, 35);
            this.btnSearchByName.TabIndex = 2;
            this.btnSearchByName.Text = "Search";
            this.btnSearchByName.UseVisualStyleBackColor = true;
            this.btnSearchByName.Click += new System.EventHandler(this.btnSearchByName_Click);
            // 
            // btnSearchByCategory
            // 
            this.btnSearchByCategory.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearchByCategory.Location = new System.Drawing.Point(6, 201);
            this.btnSearchByCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearchByCategory.Name = "btnSearchByCategory";
            this.btnSearchByCategory.Size = new System.Drawing.Size(86, 31);
            this.btnSearchByCategory.TabIndex = 1;
            this.btnSearchByCategory.Text = "Search";
            this.btnSearchByCategory.UseVisualStyleBackColor = true;
            this.btnSearchByCategory.Click += new System.EventHandler(this.btnSearchByCategory_Click);
            // 
            // txtSearchByCategory
            // 
            this.txtSearchByCategory.Location = new System.Drawing.Point(6, 164);
            this.txtSearchByCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearchByCategory.Name = "txtSearchByCategory";
            this.txtSearchByCategory.Size = new System.Drawing.Size(158, 27);
            this.txtSearchByCategory.TabIndex = 0;
            // 
            // txtSearchByBookId
            // 
            this.txtSearchByBookId.Location = new System.Drawing.Point(246, 164);
            this.txtSearchByBookId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearchByBookId.Name = "txtSearchByBookId";
            this.txtSearchByBookId.Size = new System.Drawing.Size(198, 27);
            this.txtSearchByBookId.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(246, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Search By BookId";
            // 
            // btnSearchByBookId
            // 
            this.btnSearchByBookId.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearchByBookId.Location = new System.Drawing.Point(246, 199);
            this.btnSearchByBookId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearchByBookId.Name = "btnSearchByBookId";
            this.btnSearchByBookId.Size = new System.Drawing.Size(94, 35);
            this.btnSearchByBookId.TabIndex = 8;
            this.btnSearchByBookId.Text = "Search";
            this.btnSearchByBookId.UseVisualStyleBackColor = true;
            this.btnSearchByBookId.Click += new System.EventHandler(this.btnSearchByBookId_Click);
            // 
            // FormSearchBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 615);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormSearchBook";
            this.Text = "SearchBook";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchBook)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvSearchBook;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtSearchByName;
        private System.Windows.Forms.Label lblSearchByTitle;
        private System.Windows.Forms.Button btnSearchByName;
        private System.Windows.Forms.Button btnSearchByCategory;
        private System.Windows.Forms.TextBox txtSearchByCategory;
        private System.Windows.Forms.Label lblSearchBook;
        private System.Windows.Forms.Button btnDashBoard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookId;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Publisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.TextBox txtSearchByBookId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearchByBookId;
    }
}
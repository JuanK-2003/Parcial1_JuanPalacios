
namespace ParcialProgra3
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbIdBook = new System.Windows.Forms.TextBox();
            this.tbIdStudent = new System.Windows.Forms.TextBox();
            this.btnAddLoan = new System.Windows.Forms.Button();
            this.dtpLoan = new System.Windows.Forms.DateTimePicker();
            this.dtpReturn = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.lbNonReturned = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbBookTitle = new System.Windows.Forms.TextBox();
            this.tbBookId = new System.Windows.Forms.TextBox();
            this.tbStudentAddress = new System.Windows.Forms.TextBox();
            this.tbStudentName = new System.Windows.Forms.TextBox();
            this.tbStudentID = new System.Windows.Forms.TextBox();
            this.tbBookAuthor = new System.Windows.Forms.TextBox();
            this.dtpPublished = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id student";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id book";
            // 
            // tbIdBook
            // 
            this.tbIdBook.Location = new System.Drawing.Point(52, 105);
            this.tbIdBook.Name = "tbIdBook";
            this.tbIdBook.Size = new System.Drawing.Size(162, 22);
            this.tbIdBook.TabIndex = 2;
            // 
            // tbIdStudent
            // 
            this.tbIdStudent.Location = new System.Drawing.Point(52, 50);
            this.tbIdStudent.Name = "tbIdStudent";
            this.tbIdStudent.Size = new System.Drawing.Size(162, 22);
            this.tbIdStudent.TabIndex = 3;
            // 
            // btnAddLoan
            // 
            this.btnAddLoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddLoan.Location = new System.Drawing.Point(77, 306);
            this.btnAddLoan.Name = "btnAddLoan";
            this.btnAddLoan.Size = new System.Drawing.Size(90, 63);
            this.btnAddLoan.TabIndex = 4;
            this.btnAddLoan.Text = "Add Loan";
            this.btnAddLoan.UseVisualStyleBackColor = true;
            this.btnAddLoan.Click += new System.EventHandler(this.btnAddLoan_Click);
            // 
            // dtpLoan
            // 
            this.dtpLoan.Location = new System.Drawing.Point(28, 190);
            this.dtpLoan.Name = "dtpLoan";
            this.dtpLoan.Size = new System.Drawing.Size(200, 22);
            this.dtpLoan.TabIndex = 5;
            // 
            // dtpReturn
            // 
            this.dtpReturn.Location = new System.Drawing.Point(28, 251);
            this.dtpReturn.Name = "dtpReturn";
            this.dtpReturn.Size = new System.Drawing.Size(200, 22);
            this.dtpReturn.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Loan Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Return Date";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(338, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(524, 279);
            this.dataGridView1.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(469, 362);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Non returned books";
            // 
            // lbNonReturned
            // 
            this.lbNonReturned.AutoSize = true;
            this.lbNonReturned.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNonReturned.Location = new System.Drawing.Point(469, 383);
            this.lbNonReturned.Name = "lbNonReturned";
            this.lbNonReturned.Size = new System.Drawing.Size(21, 21);
            this.lbNonReturned.TabIndex = 11;
            this.lbNonReturned.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(910, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1093, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Author";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(910, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(910, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "Id";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1093, 129);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 17);
            this.label10.TabIndex = 16;
            this.label10.Text = "BookTitle";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1093, 86);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 17);
            this.label11.TabIndex = 17;
            this.label11.Text = "BoodId";
            // 
            // tbBookTitle
            // 
            this.tbBookTitle.Location = new System.Drawing.Point(1096, 146);
            this.tbBookTitle.Name = "tbBookTitle";
            this.tbBookTitle.Size = new System.Drawing.Size(100, 22);
            this.tbBookTitle.TabIndex = 18;
            // 
            // tbBookId
            // 
            this.tbBookId.Location = new System.Drawing.Point(1096, 104);
            this.tbBookId.Name = "tbBookId";
            this.tbBookId.Size = new System.Drawing.Size(100, 22);
            this.tbBookId.TabIndex = 19;
            // 
            // tbStudentAddress
            // 
            this.tbStudentAddress.Location = new System.Drawing.Point(913, 191);
            this.tbStudentAddress.Name = "tbStudentAddress";
            this.tbStudentAddress.Size = new System.Drawing.Size(100, 22);
            this.tbStudentAddress.TabIndex = 20;
            // 
            // tbStudentName
            // 
            this.tbStudentName.Location = new System.Drawing.Point(913, 146);
            this.tbStudentName.Name = "tbStudentName";
            this.tbStudentName.Size = new System.Drawing.Size(100, 22);
            this.tbStudentName.TabIndex = 21;
            // 
            // tbStudentID
            // 
            this.tbStudentID.Location = new System.Drawing.Point(913, 104);
            this.tbStudentID.Name = "tbStudentID";
            this.tbStudentID.Size = new System.Drawing.Size(100, 22);
            this.tbStudentID.TabIndex = 22;
            // 
            // tbBookAuthor
            // 
            this.tbBookAuthor.Location = new System.Drawing.Point(1096, 190);
            this.tbBookAuthor.Name = "tbBookAuthor";
            this.tbBookAuthor.Size = new System.Drawing.Size(100, 22);
            this.tbBookAuthor.TabIndex = 23;
            // 
            // dtpPublished
            // 
            this.dtpPublished.Location = new System.Drawing.Point(1096, 239);
            this.dtpPublished.Name = "dtpPublished";
            this.dtpPublished.Size = new System.Drawing.Size(200, 22);
            this.dtpPublished.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1096, 219);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(130, 17);
            this.label12.TabIndex = 25;
            this.label12.Text = "Date Of Publication";
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStudent.Location = new System.Drawing.Point(913, 231);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(100, 66);
            this.btnAddStudent.TabIndex = 26;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBook.Location = new System.Drawing.Point(1110, 286);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(116, 43);
            this.btnAddBook.TabIndex = 27;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1335, 461);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dtpPublished);
            this.Controls.Add(this.tbBookAuthor);
            this.Controls.Add(this.tbStudentID);
            this.Controls.Add(this.tbStudentName);
            this.Controls.Add(this.tbStudentAddress);
            this.Controls.Add(this.tbBookId);
            this.Controls.Add(this.tbBookTitle);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbNonReturned);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpReturn);
            this.Controls.Add(this.dtpLoan);
            this.Controls.Add(this.btnAddLoan);
            this.Controls.Add(this.tbIdStudent);
            this.Controls.Add(this.tbIdBook);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbIdBook;
        private System.Windows.Forms.TextBox tbIdStudent;
        private System.Windows.Forms.Button btnAddLoan;
        private System.Windows.Forms.DateTimePicker dtpLoan;
        private System.Windows.Forms.DateTimePicker dtpReturn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbNonReturned;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbBookTitle;
        private System.Windows.Forms.TextBox tbBookId;
        private System.Windows.Forms.TextBox tbStudentAddress;
        private System.Windows.Forms.TextBox tbStudentName;
        private System.Windows.Forms.TextBox tbStudentID;
        private System.Windows.Forms.TextBox tbBookAuthor;
        private System.Windows.Forms.DateTimePicker dtpPublished;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnAddBook;
    }
}


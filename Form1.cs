using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcialProgra3
{
    public partial class Form1 : Form
    {

        Library lib = new Library();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (lib.Loans != null)
            {
                dataGridView1.DataSource = lib.Loans.OrderBy(l => l.ReturnDate).ToList();
                dataGridView1.Refresh();
                lbNonReturned.Text = "" + lib.Loans.Where(l => l.ReturnDate < DateTime.Now).ToList().Count();
            }
        }

        private void btnAddLoan_Click(object sender, EventArgs e)
        {
            lib.CreateLoan(
                lib.Students.Where(s => s.Id == tbIdStudent.Text).First(),
                lib.Books.Where(b => b.Id == tbIdBook.Text).First(),
                dtpLoan.Value,
                dtpReturn.Value
                );
            lib.SaveAll();
            tbIdStudent.Text = "";
            tbIdBook.Text = "";
            dataGridView1.DataSource = lib.Loans.OrderBy(l => l.ReturnDate).ToList();
            dataGridView1.Refresh();
            lbNonReturned.Text = "" + lib.Loans.Where(l => l.ReturnDate < DateTime.Now).ToList().Count();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            lib.CreateStudent(
                tbStudentID.Text,
                tbStudentName.Text,
                tbStudentAddress.Text
                );
            lib.SaveAll();
            tbStudentID.Text = "";
            tbStudentName.Text = "";
            tbStudentAddress.Text = "";
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            lib.CreateBook(
                tbBookId.Text,
                tbBookTitle.Text,
                tbBookAuthor.Text,
                dtpPublished.Value
                );
            tbBookAuthor.Text = "";
            tbBookTitle.Text = "";
            tbBookId.Text = "";
            dtpPublished.Value = DateTime.Now;
            lib.SaveAll();
        }
    }
}

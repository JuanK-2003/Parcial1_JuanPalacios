using Newtonsoft.Json;
using ParcialProgra3.models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialProgra3
{
    class Library
    {
        public List<Student> Students = new List<Student>();
        public List<Book> Books = new List<Book>();
        public List<Loan> Loans = new List<Loan>();

        string StudentsFile = "students.txt";
        string BooksFile = "books.txt";
        string LoansFile = "loans.txt";

        public Library()
        {
            if (validateFiles())
            {
                using ( StreamReader sr = new StreamReader(StudentsFile))
                {
                    Students = JsonConvert.DeserializeObject<List<Student>>(sr.ReadToEnd());
                }
                using (StreamReader sr = new StreamReader(BooksFile))
                {
                    Books = JsonConvert.DeserializeObject<List<Book>>(sr.ReadToEnd());
                }
                using (StreamReader sr = new StreamReader(LoansFile))
                {
                    Loans = JsonConvert.DeserializeObject<List<Loan>>(sr.ReadToEnd());
                }

                if (Students == null || Books == null)
                {
                    Students = new List<Student>();
                    Books = new List<Book>();
                    Loans = new List<Loan>();
    }

            } else
            {
                using (StreamWriter sr = new StreamWriter(StudentsFile))
                {
                }
                using (StreamWriter sr = new StreamWriter(BooksFile))
                {
                }
                using (StreamWriter sr = new StreamWriter(LoansFile))
                {
                }
            }
        }

        public void CreateLoan(Student student, Book book, DateTime LoanDate, DateTime ReturnDate)
        {
            if (Loans.Where(l => l.BookId == book.Id).Count() < 1)
            {
                Loans.Add(
                    new Loan(
                        student.Id,
                        student.Name,
                        book.Id,
                        book.Title,
                        LoanDate,
                        ReturnDate
                    )
                    ) ;
            }
        }

        public void CreateStudent(string Id, string Name, string Address)
        {
            this.Students.Add(
                new Student(
                    Id,
                    Name,
                    Address
                    )
                );
        }

        public void CreateBook(string Id, string Title, string Author, DateTime YearOfPublication)
        {
            this.Books.Add(
                new Book(
                    Id,
                    Title,
                    Author,
                    YearOfPublication
                    )
                );
        }

        public void SaveAll()
        {
            using (StreamWriter sr = new StreamWriter(StudentsFile))
            {
                sr.Write(JsonConvert.SerializeObject(Students));
            }
            using (StreamWriter sr = new StreamWriter(BooksFile))
            {
                sr.Write(JsonConvert.SerializeObject(Books));
            }
            using (StreamWriter sr = new StreamWriter(LoansFile))
            {
                sr.Write(JsonConvert.SerializeObject(Loans));
            }
        }

        private bool validateFiles()
        {
            return File.Exists(LoansFile) &&
                File.Exists(StudentsFile) &&
                File.Exists(BooksFile);
        }
    }
}

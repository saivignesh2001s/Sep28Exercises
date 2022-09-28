using BusinessAcces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Dal
{
    public class Books1
    {
        public int Id
        {
            get; set; 
        }
        public string Name
        {
            get;
            set;
        }
        public string Author
        {
            get;
            set;
        }
        public double Cost
        {
            get;
            set;
        }
        public string Category
        {
            get;
            set;
        }
    }
    public class Operations
    {
        public void insertbook(Books1 b)
        {
            libraryEntities context = new libraryEntities();
            Book book = new Book();
            book.Book_No = b.Id;
            book.Book_Name = b.Name;
            book.Author = b.Author;
            book.Cost = (decimal)b.Cost;
            book.Category = b.Category;
            context.Books.Add(book);
            context.SaveChanges();

        }
        public void updatebook(int m,Books1 no)
        {
         libraryEntities context=new libraryEntities();
            List<Book> books = context.Books.ToList();
            Book k=books.Find(Book => Book.Book_No == m);
            k.Book_No=no.Id;
            k.Book_Name=no.Name;
            k.Author = no.Author;
            k.Cost =(int)no.Cost;
            k.Category = no.Category;
            context.SaveChanges();

        }
        public void deletebook(int k)
        {
            libraryEntities context = new libraryEntities();
            List<Book> b1 = context.Books.ToList();
            Book b=b1.Find(Book => Book.Book_No == k);
            context.Books.Remove(b);
            context.SaveChanges();
        }
        public Books1 findbook(int k)
        {
            libraryEntities context = new libraryEntities();
            List<Book> b1 = context.Books.ToList();
            Book b = b1.Find(Book => Book.Book_No == k);
            Books1 b11 = new Books1();
            b11.Id = (int)b.Book_No;
            b11.Name = b.Book_Name;
            b11.Author = b.Author;
            b11.Cost =(int) b.Cost;
            b11.Category = b.Category;
            return b11;
        }
        public int Bookcount()
        {
            List<Books1> j = new List<Books1>();
            j=list1();
            return j.Count;


        }
        public List<Books1> list1()
        {
           libraryEntities context= new libraryEntities();
            List<Book> books =context.Books.ToList();
            List<Books1> books1 = new List<Books1>();
            foreach(var item in books)
            {
                books1.Add(new Books1 { Id = (int)item.Book_No, Name = item.Book_Name, Author = item.Author, Cost =(double)item.Cost, Category = item.Category });
            }
            return books1;
        }
    }
}

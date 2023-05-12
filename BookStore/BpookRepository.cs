using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace BookStore
{
    public class BpookRepository
    {
        public List<Book> books = null;

        public void Load()
        {
            books.Clear();
            using (SqlConnection sqlconnection=new SqlConnection(ConfigurationManager.ConnectionStrings[BookStoreDB].ConnectionString))
            {
                sqlconnection.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Books", sqlconnection);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Book book = new Book();
                        book.bookname = reader["BookName"] as string;
                        book.ID = (int)reader["ID"];
                        book.publicationyear = (int)reader["PublicationYear"];
                        book.autor = (int)reader["Autor"];
                        books.Add(book);

                    }
                }
            }

        }
        public void Insert(Book book)
        {
            using (SqlConnection sqlconnection = new SqlConnection(ConfigurationManager.ConnectionStrings[BookStoreDB].ConnectionString))
            {
                sqlconnection.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO [Books](BookName,PublicationYear,Autor) VALUES(@BookName,@PublicationYear,@Autor)", sqlconnection);
                cmd.Parameters.AddWithValue("BookName", book.bookname);
                cmd.Parameters.AddWithValue("Publicationyear",book.publicationyear);
                cmd.Parameters.AddWithValue("Autor", book.autor);
                cmd.ExecuteNonQuery();
            }
        }
        public void Update()
        {

        }
        public void Add(Book book)
        {
            books.Add(book);
        } 
        public void Save
        {

        }

    }
}

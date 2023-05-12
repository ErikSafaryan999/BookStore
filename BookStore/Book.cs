using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    public class Book
    {
        bool IsValueChanged = false;

        public bool isvaluechanged
        {
            get { return isvaluechanged; }  
            set { isvaluechanged = value; }
        }

        public int ID { get; set; }

        private string? BookName;

        public string? bookname
        {
            get { return BookName; }
            set
            {
                if (BookName != value)
                {
                    IsValueChanged = true;
                    bookname = value;
                }
            }
        }
        private int? PublicationYear;
        public int? publicationyear
        {
            get { return PublicationYear; }

            set
            {
                if(PublicationYear != value)
                {
                    IsValueChanged = true;
                    PublicationYear = value;
                }
            }
        }
        private int? Autor;
        public int? autor
        {
            get { return PublicationYear; }

            set
            {
                if (PublicationYear != value)
                {
                    IsValueChanged = true;
                    PublicationYear = value;
                }
            }
        }

    }
}

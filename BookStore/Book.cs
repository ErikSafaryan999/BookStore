using System;
using System.Collections.Generic;
using System.Linq;
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

        public string? BookName;

        public string bookname
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

        public int? PublicationYear
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

        public int? Autor
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

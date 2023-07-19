using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    internal class Book
    {
        public string title;
        public string author;
        public int page;
        private int rating;
        public static int bookcount; // static work on class, not on instance

        public Book(string atitle, string aauthor, int apage, int aRating) // constructor
        {
            title = atitle;
            author = aauthor;
            page = apage;
            Rating = aRating;
            bookcount++;
        }
        public int Rating
        {
            get { return rating; }
            set { 
                if (value == 1 || value == 2 || value == 3)
                {
                    rating = value;
                }
                else
                {
                    rating = 0;
                }
            }
        }
        public bool HasHonor() // method
        {
            if (page > 200)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

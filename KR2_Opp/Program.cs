using System;

namespace KR2_Opp
{
    class Program
    {
        
            struct Book // книга
            {
                public string Book_name;
                public string Book_author;


                public void book_display()
                {
                    Console.WriteLine($"Book: {Book_name}");
                    Console.WriteLine($"Author: {Book_author}");

                }
            }
            struct publishing // видавництвo
            {
                public string pub_namepublishing;
                public int pub_YearOfIssue;
                public float pub_price;

                public void pub_display()
                {
                    
                    Console.WriteLine($"Publishing:{pub_namepublishing}"); // назва видавництва
                    Console.WriteLine($"Year of issue {pub_YearOfIssue}"); // рік випуску
                    Console.WriteLine($"Price: {pub_price}$"); // цінa
                }
            }

        struct bookstore // книгарня
        {
            struct Book 
            {
            }
            struct publishing 
            { 
            }

                }
            static void Main(string[] args)
        {
            // книга
            Book b1;
            b1.Book_name = "Dragon's Fury";
            b1.Book_author = "Christopher";
            b1.book_display();
            //видавництвo
            publishing pu1;
            pu1.pub_namepublishing = "St. Petersburg";
            pu1.pub_YearOfIssue = 2002;
            pu1.pub_price = 30.21f;
            pu1.pub_display();
            Console.WriteLine("_______________________");
            Book b2;
            b2.Book_name = "Azazel";
            b2.Book_author = "Boris";
            b2.book_display();
            publishing p2;
            p2.pub_namepublishing = "Moscow";
            p2.pub_YearOfIssue = 1998;
            p2.pub_price = 25.50f;
            p2.pub_display();
            Console.WriteLine("_______________________");
            Book b3;
            b3.Book_name = "Scarlet Sails";
            b3.Book_author = "Green";
            b3.book_display();
            publishing p3;
            p3.pub_namepublishing = "Moscow";
            p3.pub_YearOfIssue = 1998;
            p3.pub_price = 25.50f;
            p3.pub_display();
            Console.WriteLine("_______________________");
            Book b4;
            b4.Book_name = "Confessions of Maigret";
            b4.Book_author = "Georges";
            b4.book_display();
            publishing p4;
            p4.pub_namepublishing = "Moscow";
            p4.pub_YearOfIssue = 1982;
            p4.pub_price = 10.50f;
            p4.pub_display();
            Console.WriteLine("_______________________");
        }
    }
}

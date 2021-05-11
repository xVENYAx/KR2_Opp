using System;

namespace KR2_Opp
{
    class Program
    {

        struct bookstore // книгарня
        {
            public struct Book // книга
            {
                public string Book_name;
                public string Book_author;


                public void book_display()
                {
                    Console.WriteLine($"Book: {Book_name}");
                    Console.WriteLine($"Author: {Book_author}");

                }
            }
            public struct publishing // видавництвo
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

                }
            static void Main(string[] args)
        {
            Console.WriteLine("Bookstore:"); // Kнигарня

            // книга

            bookstore.Book b1;
            b1.Book_name = "Dragon's Fury";
            b1.Book_author = "Christopher";
            b1.book_display();

            //видавництвo

            bookstore.publishing p1;
            p1.pub_namepublishing = "St. Petersburg";
            p1.pub_YearOfIssue = 2002;
            p1.pub_price = 30.21f;
            p1.pub_display();
            
            Console.WriteLine("_______________________");

            bookstore.Book b2;
            b2.Book_name = "Azazel";
            b2.Book_author = "Boris";
            b2.book_display();
            bookstore.publishing p2;
            p2.pub_namepublishing = "Moscow";
            p2.pub_YearOfIssue = 1998;
            p2.pub_price = 25.50f;
            p2.pub_display();
            
            Console.WriteLine("_______________________");

            bookstore.Book b3;
            b3.Book_name = "Scarlet Sails";
            b3.Book_author = "Green";
            b3.book_display();
            bookstore.publishing p3;
            p3.pub_namepublishing = "Moscow";
            p3.pub_YearOfIssue = 1998;
            p3.pub_price = 25.50f;
            p3.pub_display();
            
            Console.WriteLine("_______________________");

            bookstore.Book b4;
            b4.Book_name = "Confessions of Maigret";
            b4.Book_author = "Georges";
            b4.book_display();
            bookstore.publishing p4;
            p4.pub_namepublishing = "Moscow";
            p4.pub_YearOfIssue = 2003;
            p4.pub_price = 10.50f;
            p4.pub_display();
            
            Console.WriteLine("_______________________");

            bookstore.Book b5;
            b5.Book_name = "Ragnaradi";
            b5.Book_author = "Random";
            b5.book_display();
            bookstore.publishing p5;
            p5.pub_namepublishing = "St. Petersburg";
            p5.pub_YearOfIssue = 1994;
            p5.pub_price = 15.50f;
            p5.pub_display();
           
            Console.WriteLine("_______________________");

            bookstore.Book b6;
            b6.Book_name = "Maigret tube";
            b6.Book_author = "Georges";
            b6.book_display();
            bookstore.publishing p6;
            p6.pub_namepublishing = "Kishinev";
            p6.pub_YearOfIssue = 1981;
            p6.pub_price = 11.50f;
            p6.pub_display();
           
            Console.WriteLine("_______________________");
            
            Console.WriteLine("Set a year for book output:"); // Задаємо рік для виводу книг
           
            int count = 0; 
          
            int k = Convert.ToInt32(Console.ReadLine());
          
            if (p1.pub_YearOfIssue >= k)
            {
                Console.WriteLine($"{b1.Book_name} - {p1.pub_YearOfIssue} year");
                count++;
            }
            if (p2.pub_YearOfIssue >= k)
            {
                Console.WriteLine($"{b2.Book_name} - {p2.pub_YearOfIssue} year");
                count++;
            }
            if (p3.pub_YearOfIssue >= k)
            {
                Console.WriteLine($"{b3.Book_name} - {p3.pub_YearOfIssue} year");
                count++;
            }
            if (p4.pub_YearOfIssue >= k)
            {
                Console.WriteLine($"{b4.Book_name} - {p4.pub_YearOfIssue} year");
                count++;
            }
            if (p5.pub_YearOfIssue >= k)
            {
                Console.WriteLine($"{b5.Book_name} - {p5.pub_YearOfIssue} year");
                count++;
            }
            if (p6.pub_YearOfIssue >= k)
            {
                Console.WriteLine($"{b6.Book_name} - {p6.pub_YearOfIssue} year");
                count++;
            }
           
            Console.WriteLine($"{count} books published after a given year."); // книги що вийшли з друку після заданого року.
        }
    }
}

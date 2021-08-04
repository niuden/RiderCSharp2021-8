﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpStudy
{
    class C17_Struct2ClassVSStruct
    {
    }
    struct Books
    {
        private string title;
        private string author;
        private string subject;
        private int book_id;
        public void setValues(string t, string a, string s, int id)
        {
            title = t;
            author = a;
            subject = s;
            book_id = id;
        }
        public void display()
        {
            Console.WriteLine("Title : {0}", title);
            Console.WriteLine("Author : {0}", author);
            Console.WriteLine("Subject : {0}", subject);
            Console.WriteLine("Book_id :{0}", book_id);
        }

    };

    public class testStructure
    {
        public void show()
        {

            Books Book1 = new Books(); /* 声明 Book1，类型为 Books */
            Books Book2 = new Books(); /* 声明 Book2，类型为 Books */

            /* book 1 详述 */
            Book1.setValues("C Programming",
            "Nuha Ali", "C Programming Tutorial", 6495407);

            /* book 2 详述 */
            Book2.setValues("Telecom Billing",
            "Zara Ali", "Telecom Billing Tutorial", 6495700);

            /* 打印 Book1 信息 */
            Book1.display();

            /* 打印 Book2 信息 */
            Book2.display();

            Console.ReadKey();

        }
    }
}

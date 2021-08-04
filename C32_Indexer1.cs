using System;

namespace RiderCSharp2021
{
    public class C32_Indexer1
    {
        private string[] namelist = new string[size];
        static public int size = 10;
        public C32_Indexer1()
        {
            for (int i = 0; i < size; i++)
                namelist[i] = "N. A.";
        }
        public string this[int index]
        {
            get
            {
                string tmp;
                if( index >= 0 && index <= size-1 )
                {
                    tmp = namelist[index];
                }
                else
                {
                    tmp = "";
                }
                return ( tmp );
            }
            set
            {
                if( index >= 0 && index <= size-1 )
                {
                    namelist[index] = value;
                }
            }
        }
        public void show()
        {
            C32_Indexer1 names = new C32_Indexer1();
            names[0] = "Zara";
            names[1] = "Riz";
            names[2] = "Nuha";
            names[3] = "Asif";
            names[4] = "Davinder";
            names[5] = "Sunil";
            names[6] = "Rubic";
            for ( int i = 0; i < C32_Indexer1.size; i++ )
            {
                Console.WriteLine(names[i]);
            }
            Console.ReadKey();
        }

    }
}
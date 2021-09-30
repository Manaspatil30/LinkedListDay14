using System;

namespace LinkedListDay14
{
    class Program
    {
        static void Main(string[] args)
        {
            #region UC2
            UC2AddToList list = new UC2AddToList();
            list.AddToFront(70);
            list.AddToFront(30);
            list.AddToFront(56);
            list.PrintList();
            #endregion

            Console.WriteLine("---------------------------------------------------------------------");

            #region UC3
            UC3Append Append = new UC3Append();
            Append.AddToEnd(56);
            Append.AddToEnd(30);
            Append.AddToEnd(70);
            Append.PrintList();
            #endregion

            Console.WriteLine("---------------------------------------------------------------------");

            #region UC4
            UC4AddInBetn Betwn = new UC4AddInBetn();
            Betwn.AddToEnd(56);
            Betwn.AddToEnd(70);
            Betwn.AddInBet(2, 30);
            Betwn.PrintList();
            #endregion

            Console.WriteLine("---------------------------------------------------------------------");

            #region UC5
            UC5DelElement Del = new UC5DelElement();
            Del.AddToEnd(56);
            Del.AddToEnd(30);
            Del.AddToEnd(70);
            Del.PopFirst();
            Del.PrintList();
            #endregion

            Console.WriteLine("---------------------------------------------------------------------");

            #region UC6
            UC6DelLast DelLast = new UC6DelLast();
            DelLast.AddToEnd(56);
            DelLast.AddToEnd(30);
            DelLast.AddToEnd(70);
            DelLast.PopLast();
            DelLast.PrintList();
            #endregion

            Console.WriteLine("---------------------------------------------------------------------");

            #region UC7
            UC7Search search = new UC7Search();
            search.AddToEnd(56);
            search.AddToEnd(30);
            search.AddToEnd(70);
            search.PrintList();
            Console.WriteLine("\nsearch for 30");
            search.SearchData(30);
            Console.WriteLine("Search result :");
            #endregion

            Console.WriteLine("---------------------------------------------------------------------");

            #region UC8
            UC8AddInBetwn2 addInBetwn2 = new UC8AddInBetwn2();
            addInBetwn2.AddToFront(70);
            addInBetwn2.AddToFront(30);
            addInBetwn2.AddToFront(56);
            addInBetwn2.AddInBet2(3, 40);
            addInBetwn2.PrintList();
            #endregion

            Console.WriteLine("---------------------------------------------------------------------");

            #region UC9
            UC9Delete2 delete2 = new UC9Delete2();
            delete2.AddToFront(70);
            delete2.AddToFront(30);
            delete2.AddToFront(56);
            delete2.AddInBet2(3, 40);
            delete2.PrintList();
            delete2.deleteNode(40);
            Console.WriteLine("\n 40 deleted from the list, new list :");
            delete2.PrintList();
            #endregion

            Console.WriteLine("---------------------------------------------------------------------");

            #region UC10
            UC10Sort sort = new UC10Sort();
            sort.AddToFront(70);
            sort.AddToFront(30);
            sort.AddToFront(56);
            sort.AddToFront(40);
            sort.PrintList();
            Console.WriteLine("\n Sorted list in ascending order");
            sort.sortList();
            sort.PrintList();
            #endregion

            Console.WriteLine("---------------------------------------------------------------------");
        }
    }
}

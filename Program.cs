using System;
using datastructure.Linkedlists;
using datastructure.Arraylists;
using datastructure.IListok;


namespace datastructure
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Arraylist a = new Arraylist (new int[] { 8,4,4 });
            // Arraylist AAA = new Arraylist();
            //  int[] prosto = new int[] {9,3 } ;
            // int[] q = AAA.AddattheEnd(2);
            // Console.Write(q);
            //  a.Addatthebeginning(prosto);
            //  a.Readscreen();
            //  a.Addbyindex(1, 7);
            //a.AccessByValue(2);
            //a.sortingDown();
           Linkedlist L = new Linkedlist(new int[] { 8, 4, 4 });

           L[0]=5;

           for (int i=0;i<L.returnlenght();i++ )
            { Console.Write(L[i] + " "); }
           // L.Addbyindex(0, 9);
            //L.AddattheEnd(1);
            //vuvod(L.Returnmassiv());
            //L.AddattheEnd(2);
            //vuvod(L.Returnmassiv());
            //L.AddattheEnd(3);
            //vuvod(L.Returnmassiv());
            //L.AddattheEnd(4);
            //vuvod(L.Returnmassiv());



        }
        //static void vuvod(int[]a)
        //{
        //    for (int i=0;i<a.Length; i++)
        //    {
        //        Console.Write(a[i] + " ");
        //    }
        //    Console.WriteLine();
        //}
    }
}

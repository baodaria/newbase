using System;
using System.Collections.Generic;
using System.Text;

namespace datastructure.IListok
{
    public interface IList
    {
         // int[] UpMassivSize();
          public void AddattheEnd(int a);
          public void AddattheEnd(int[] a);
        

          public void Addatthebeginning(int a);
          public void Addatthebeginning(int[] a);
          public void Addbyindex(int index, int a);
      //  public void Readscreen();
        public void Addmassivbyindex(int a, int[] c);
        public void Changebyindex(int index, int g);

        public void CancelItemfromEnd();

        public void CancelItemfromBegining();
        public void CancelItemByIndex(int index);

        public int AccessByIndex(int index);

        public int AccessByValue(int a);
        public int[] Returnmassiv();

        public void Reversemassiv();

        public int searchminimum();

        public int searchmaximum();
        public int searchindexofminimum();

        public int searchindexofmaximum();

        public void sortingUp();

        public void sortingDown();
        public void Cancelbyvalue(int a);

        public int returnlenght();

        public void CancelItemsfromEnd(int n);

        public void CancelItemsfrombeginning(int n);

        public void CancelItemsbyindex(int index, int n);
    }
}

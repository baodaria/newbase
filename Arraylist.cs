using System;
using System.Collections.Generic;
using System.Text;
using datastructure.IListok;

namespace datastructure.Arraylists
{
   public class Arraylist:IList

    {   public int[] massiv;
        private int lenght;
        public Arraylist()
        {   massiv = new int[0];
            lenght = 0;
        }
        public Arraylist(int a)
        {
            massiv = new int[1] { a };
            lenght = 1;
        }
            
        public Arraylist(int[] a)
        {
            massiv = a;
            lenght = a.Length;
        }
        private void UpMassivSize()
        {
            int newL = Convert.ToInt32(massiv.Length * 1.3d + 1);
            int[] newMassiv = new int[newL];
            for (int i = 0; i < massiv.Length; i++)
            {
                newMassiv[i] = massiv[i];
            }
            massiv = newMassiv;
        }
        public void AddattheEnd(int a) // добавление в конец  числа
        {
            if (lenght >=  massiv.Length)
            {   UpMassivSize();
                            }
            massiv[lenght] = a;
            lenght++;
            int[] c = new int[lenght];
            for (int i=0; i<lenght; i++)
            {
                c[i] = massiv[i];
            }
            
        }
        public void AddattheEnd(int [] a)   // добавление в конец массива
        {   while (lenght + a.Length > massiv.Length)
            { UpMassivSize(); }
            for (int i= 0; i < a.Length; i++)
            {
                massiv[lenght + i] = a[i];
            }
            lenght+=a.Length;
        }
        public int [] AddattheEnd(int[] a,int [] b)   // добавление в конец 2-x массивов
        {
            while (lenght + a.Length + b.Length > massiv.Length)
            { UpMassivSize();}
                int[] c = new int[a.Length + b.Length];
                for (int i = 0; i < a.Length; i++)
                {
                c[i] = a[i];
                }
                for (int i = 0; i < b.Length; i++)
                {
                c[a.Length+i] = b[i];
                }
                int[] newarray = new int[massiv.Length + c.Length];
                for (int i=0; i < c.Length; i++)
                {
                newarray [massiv.Length + i] = c[i];
                }
            return newarray;

        }


        public void Addatthebeginning(int a)  // добавление в начало 1 числа
        {   if (lenght > massiv.Length)
            {
                UpMassivSize();
            }
            int[] newarray = new int[massiv.Length + 1];
            if (massiv.Length == 0 )
            {
                massiv = new int[2];
                massiv[1] = 0;
                newarray = massiv;
            }
            else
            {
                for (int i = massiv.Length - 1; i >= 0; i--)
                { newarray[i + 1] = massiv[i];
                }
            }
            newarray[0] = a;
            massiv = newarray;
            lenght++;
        }

        public void Addatthebeginning(int [] a)  // добавление в начало массива
        {
            int[] newarray = new int[lenght + a.Length];
            if ( lenght == 0 || a.Length == 0)
            {
                for (int i = lenght-1; i >= 0; i--)
                {
                 newarray[i]= massiv [i];
                }
            }
            else
            {
                for (int i = lenght-1; i >= 0; i--)
                {
                    newarray[i + a.Length] = massiv[i] ;
                }
            }
            for (int j = 0; j < a.Length ; j++)

            {
                newarray[j] = a[j];

            }
            massiv = newarray;
            lenght = newarray.Length;
        }
        public void Readscreen()    // вывести массив
        { for (int i = 0; i < lenght; i++)
                Console.WriteLine(massiv[i]);
                    }
        public void Addbyindex(int index, int a)  // добавление числа по индексу cо сдвигом всего остального массива
        {
            if (lenght == 0)
            {
                Addatthebeginning(a);
            }
            else
            {
            int[] c = new int[lenght + 1];
            for (int i = lenght - 1; i >= index; i--)
            { c[i + 1]= massiv[i] ;
            }

            for (int i = 0; i <= index; i++)
            {
                if (i == index)
                {
                    c[index] = a;
                }
                else
                {
                     c[i]= massiv[i];
                }
            }
            massiv = c;
            lenght++;
            }
        }

        public void Addmassivbyindex( int a, int[]c )  // добавление массива по индексу со сдвигом
        {
            int[] newarray = new int[lenght + c.Length];
            for (int j = 0; j < a; j++)
            {
                newarray[j] = massiv[j];
            }
            for (int i = lenght - 1; i >= a; i--)
            {
                newarray [i + c.Length] = massiv[i];
            }
            for (int q = 0; q < c.Length; q++)
            {
                newarray[q+a] = c[q];
            }
            massiv = newarray;
            lenght = newarray.Length; 
        }
        public void Changebyindex(int index, int g)  // изменение массива по индексу 
        {
            for (int i = 0; i < lenght; i++)
            {
                if (i == index)
                {
                    massiv[index] = g;
                }
                else
                {
                    massiv[i] = massiv[i];
                }
            }
        }
        public void CancelItemfromEnd()    // удаление из конца (сокращение массива на 1 элемент)
        {
            if (lenght!=0)
            {

                massiv[lenght - 1] = 0;
              lenght--;
            }
        }
        public void CancelItemfromBegining() // удаление из начала
        {
            for (int i = 0; i < lenght-1; i++)
            {
                massiv[i] = massiv[i+1];
            }
                                     
            lenght--;
        }
        public void CancelItemByIndex(int index) //удаление числа по индексу
        {  if (lenght!=0)
            {
                for (int j = index; j < lenght; j++)
            { 
                massiv[index] = massiv[index + 1];
            }
            massiv[lenght-1] = 0;
                        lenght--;
            }
        }
        public int AccessByIndex(int index) // доступ по индексу
        {
            if (lenght != 0)
            {
                return massiv[index];
            }
            else
            {
                int k = 666666666;
                return k;
            }


        }
        public int this[int a]     // доступ по значению через свойства
        {
            get { return massiv[a]; }
            set { massiv[a] = value; }
        }
        public int AccessByValue(int a) // доступ по значению методом
        {
            bool f = false; 
            int index=0;
            for (int i = 0; i < lenght; i++)
            {   if ( massiv[i]==a)
                {
                    index= i;
                    f = true;
                }
            }
            if (f == false)
            {
                index = -1;
            }
            return index;
        }

        public int[] Returnmassiv()  // возвращение массива
        {
            int[] arraytoreturn = new int[lenght];
            for (int i = 0; i < lenght; i++)
            {
                arraytoreturn[i] = massiv[i];
            }
            return arraytoreturn;
        }

        public void Reversemassiv()  // реверс массива
        {
            int tmp = 0;
            if (lenght % 2 == 0)
            {
                for (int i = 0; i < lenght / 2; i++)
                {
                    tmp = massiv[i];
                    massiv[i] = massiv[lenght - 1 - i];
                    massiv[lenght - 1 - i] = tmp;
                }
            }
            else
            {
                for (int i = 0; i < (lenght - 1) / 2; i++)
                {
                    tmp = massiv[i];
                    massiv[i] = massiv[lenght - 1 - i];
                    massiv[lenght - 1 - i] = tmp;
                }
            }
        }
        public int searchminimum()  // поиск минимального значения
        {
            int minimum = massiv[0];
            if (lenght !=0)
            {
                
                for (int i = 0; i < lenght; i++)
                {
                    if (minimum > massiv[i])
                    {
                    minimum = massiv[i];
                    }
                    
                }
            }

            return minimum;
        }
        public int searchmaximum()   // поиск максимального значения
        {
            int maximum = massiv[0];

            for (int i = 0; i < lenght; i++)
            {
                if (maximum < massiv[i])
                {
                    maximum = massiv[i];

                }

            }
            return maximum;
        }
        public int searchindexofminimum()   // поиск по минимальному индексу
        {
            int minindex = 0;

            if (lenght != 0)
            {
                for (int i = 0; i < lenght; i++)
            {
                if (massiv[i] < massiv[minindex])
                {
                    minindex = i;
                }
            }

            }

            else
            {
                minindex = -1;
            }
            return minindex;
        }
        public int searchindexofmaximum()   // поиск по максимальному индексу
        {
            int maxindex = 0;

            if (lenght != 0)
            {

                for (int i = 0; i<lenght; i++)
                {
                if (massiv[i] > massiv[maxindex])
                {
                    maxindex = i;
                }
                }
            }
            else
            {
                maxindex = -1;
            }
            return maxindex;
        }
        public  void sortingUp()  // сортировка по возрастанию
        {
            int[] array = new int[lenght];
            for (int j = 0; j < lenght; j++)
            {
                array[j] = massiv[j];
            }
            int g = 0;
            for (int i = 0; i < lenght; i++)
            {
                for (int j = 0; j < lenght-i-1; j++)
                {
                    if (array[j] > array[j+1])
                    {
                        g = array[j];
                        array[j] = array[j+1];
                        array[j+1] = g;
                    }
                }
            }
            massiv = array;
             
        }

        public void sortingDown()  // сортировка по убыванию
        {
            int[] array = new int[lenght];
            for (int j = 0; j < lenght; j++)
            {
                array[j] = massiv[j];
            }
            int g = 0;
            for (int i = 0; i < lenght; i++)
            {
                for (int j = 0; j < lenght - i-1; j++)
                {
                    if (array[j] < array[j + 1])
                    {
                        g = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = g;
                    }
                }
            }

            massiv = array;

        }

        public void Cancelbyvalue(int a)    // удаление по значению
        {
            int s = 0;
            for (int i = 0; i < lenght; i++)
            {
                if (massiv[i]==a)
                {
                    s = s + 1;
                    for (int j= i; j< lenght-1;j++)
                    {

                        massiv[j] = massiv[j + 1];
                    }

                }
                
            }
            lenght = lenght - s;
        }

        public int returnlenght()  // вернуть длину
        {
            return lenght;
        }

        public void CancelItemsfromEnd(int n)    // удаление из конца N элементов
        {
            if (lenght>n)
            {
                for (int i = lenght-1; i >= lenght-n; i--)
                {
                massiv[i] = 0;
                }
              lenght=lenght-n;

            }
        
             else 
            {
                massiv = new int[0];
                lenght = 0;
             }
          
        }
        public void CancelItemsfrombeginning(int n)    // удаление из начала N элементов
        {
            if (lenght > n)

            {
                for (int i = 0; i < lenght - n; i++)
                {
                    {
                        massiv[i] = massiv[i + n];
                    }

                }

                lenght = lenght - n;
            }
            else if (lenght < n)

            {
                massiv = new int[] { };
                lenght = 0;
            }
            
            

        }

        public void CancelItemsbyindex(int index, int n)    // удаление по индексу N элементов
        {
            if (index+1>lenght )
            
            {
                for (int i = 0; i < lenght; i++)
                {
                    Returnmassiv();
                }
                
            }
            else
            {
                if (lenght != 0)
               
                {  
                for (int i = index; i < lenght-n; i++)
                {
                    { 
                        massiv[i] = massiv[i + n];
                    }
                      
                }
                
                
                lenght = lenght - n;
                }
            }
        }
    }

}

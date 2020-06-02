using System;
using System.Collections.Generic;
using System.Text;
using datastructure.IListok;

namespace datastructure.DoubleLinkedlists
{
   public class DoubleLinkedList:IList
    {

        private DoubleNode root;
        private DoubleNode end;
        public int lenght { get; private set; }

        public DoubleLinkedList()
        {
            root = null;
            end = null;
            lenght = 0;
            
        }

        public DoubleLinkedList(int a)
        {
            root = new DoubleNode(a);
            lenght = 1;
            end = root;
        }

        public DoubleLinkedList(int [] a)
        {
            root = null;
            lenght = 0;
            end = null;         
             AddattheEnd(a);
           
        }

        public void AddattheEnd(int a) //1. добавление элемента в конец
        {
            if (lenght == 0)
            {
                root = new DoubleNode(a);
                end = root;
                lenght = 1;
            }
            
            else 
            {
                end.Next = new DoubleNode(a);
                end.Next.Previous = end;
                end = end.Next;
                lenght++;
            }
        }

        public void AddattheEnd(int[] a)    // 21.добавление массива в конец
        {  
            if (a.Length!=0)
            {
                if (lenght == 0)
                {
                root = new DoubleNode(a[0]);
                    end = root;

                DoubleNode tmp = root;

                for (int i = 1; i < a.Length; i++)
                {
                    tmp.Next = new DoubleNode(a[i]);
                    tmp.Next.Previous = tmp;
                    tmp = tmp.Next;

                }
                lenght = a.Length;
                    end = tmp;
                }

            else
               {
                DoubleNode tmp = root;
                while (tmp.Next != null)
                {
                    tmp = tmp.Next;
                }
                for (int i = 0; i < a.Length; i++)
                {
                    tmp.Next = new DoubleNode(a[i]);
                    tmp.Next.Previous = tmp;
                    tmp = tmp.Next;
                }
                lenght += a.Length;
            }
        }
        }
                     
        public void Addatthebeginning(int a) //2. добавление элемента в начало
        {
            if (lenght == 0)
            {
                root = new DoubleNode(a);
                end = root;
                lenght = 1;
            }
            else 
            {
                root.Previous = new DoubleNode(a);
                root.Previous.Next = root;
                root = root.Previous;
                lenght++;
            }
        }
        public void Addatthebeginning(int[] a)   // 22.добавление в начало массива
        {
            if (a.Length != 0)
            {
                if (lenght == 0)
                {
                    root = new DoubleNode(a[0]);
                    DoubleNode tmp = root;
                    for (int j = 0; j < lenght; j++)
                    {
                        for (int i = 1; i < a.Length; i++)
                        {
                            tmp.Next = new DoubleNode(a[i]);
                            tmp = tmp.Next;
                            tmp.Next.Previous = tmp;
                        }
                    }
                    lenght = a.Length;
                }
                else
                {
                    DoubleNode tmp = root;
                    while (tmp.Next != null)
                    {
                        tmp = tmp.Next;
                    }
                    for (int i = a.Length - 1; i >= 0; i--)
                    { 
                        Addatthebeginning(a[i]);
                    }
                    
                }
            }
        }
        public int[] Returnmassiv()             // 10. возврат массива
        {
            int[] massiv = new int[lenght];
            if(lenght!=0)
            {
               int i = 0;
               DoubleNode tmp = root;
                do
                {
                    massiv[i] = tmp.Value;
                    i++;
                    tmp = tmp.Next;

                }
                while (tmp != null);
            }
            return massiv;
        
        }

        public void Addbyindex(int index,int a)   // 3.добавление по индексу
        {
            if (lenght == 0)
            {
                root = new DoubleNode(a);
                end = root;
                lenght = 1;
            }

            else if (lenght == 1)
            {
                if (index == 0)
                {
                    root.Previous = new DoubleNode(a);
                    root.Previous.Next = root;
                    root = root.Previous;
                    lenght++;
                }
                else
                {
                    AddattheEnd(a);
                }
            }
            else
            {
            DoubleNode tmp = root;
            DoubleNode nov = new DoubleNode(a);
            
            for (int i=0;i<index-1;i++)
                {
                    tmp=tmp.Next;
                }
                nov.Next = tmp.Next;
                tmp.Next = nov;
                tmp.Next.Previous = nov;
             
        
             
                lenght++;

         
            }
            
        }
        public void CancelItemfromEnd()   // 4. удаление с конца одного элемента
        {
            if (lenght == 0 || lenght == 1)
            {
                root = null;
                lenght = 0;
            }
           
            else
            {
                DoubleNode tmp = root;
                while (tmp.Next.Next != null)
                {
                    tmp = tmp.Next;
                }
                tmp.Next = null;

                lenght--;

            }
        
        }
        public void CancelItemsfromEnd(int n)  // 24. удаление с конца n элементов
        {
            if (n != 0)
            {
                if (n > lenght)
                {
                    root = null;
                    end = root;
                    lenght = 0;
                }
                else
                {
                    if (lenght == 0)
                    {
                        root = null;
                        end = root;
                        lenght = 0;
                    }
                    if (lenght == 1)
                    {
                        root = null;
                        end = root;
                        lenght = 0;
                    }
                    else
                    {
                        DoubleNode tmp = root;
                        while (tmp.Next != null)
                        {
                            tmp = tmp.Next;
                        }
                        for (int j = 0; j < n; j++)
                        {
                            CancelItemfromEnd();

                        }
                    }
            }   }
        }

        public void CancelItemfromBegining() // 5. удаление из начала одного элемента
        {
            if (lenght == 0)
            {
                root = null;
                end = root;
                lenght = 0;
            }
            if (lenght == 1)
            {
                root = null;
                end = root;
                lenght = 0;
            }
            else
            {
               root = root.Next;
               root.Previous = null;
                lenght--;
                               
            }
            
        }
        public void CancelItemsfrombeginning(int n) // 25. удаление из начала нескольких элементов
        {

            if (n != 0)
            {
                if (n > lenght)
                {
                    root = null;
                    end = root;
                    lenght = 0;
                }
                else
                { 
                    if (lenght == 0)
                    {
                    root = null;
                    end = root;
                    lenght = 0;
                    }
                if (lenght == 1)
                {
                    root = null;
                    end = root;
                    lenght = 0;
                }
                else
                {
                    for (int i = 0; i < n; i++)

                    {
                        CancelItemfromBegining();
                    }
                }
                }
            
            }
        }
        public void CancelItemByIndex(int index) // 6. удаление по индексу
        {
            if (lenght != 0)
            {
                if (index == 0)
                {
                    CancelItemfromBegining();
                }
                else if (index == lenght - 1)
                {
                    CancelItemsfromEnd(lenght - 1);
                }
                else
                {
                DoubleNode tmp = root;
                for (int i=1;i<index;i++)
                {
                tmp = tmp.Next;
                tmp.Next.Previous = tmp;
                        
                }
                tmp.Next = tmp.Next.Next;
                lenght--;
                }
            }
        }



        public void CancelItemsbyindex(int index, int n) // 26. удаление из начала N количества эелементов элемента
        {
            if (lenght == 0)
            {
                root = null;
                end = root;
                lenght = 0;
            }

            else if (lenght == 1)
            {
                root = null;
                end = root;
                lenght = 0;
            }
            else
            {

                if (index < lenght - 1)
                {
                    DoubleNode tmp = root;
                    for (int i = 0; i < index - 1; i++)
                    {
                        tmp = tmp.Next;
                        tmp.Next.Previous = tmp;

                    }
                    for (int j = 1; j <= n; j++)
                    {
                        tmp.Next = tmp.Next.Next;
                        lenght--;
                    }

                }
                else
                {
                    Returnmassiv();
                }

            }

        }
        public void Addmassivbyindex(int index, int[] a)   //23.добавление по индексу

        {
            if (lenght == 0)
            {
                AddattheEnd(a);
            }

            else if (lenght == 1)
            {
                if (index == 0)
                {
                    Addatthebeginning(a);
                }
                else
                {
                    AddattheEnd(a);
                }
            }
            else
            {

                for (int i = 0; i < a.Length; i++)
                {
                    Addbyindex(index, a[i]);
                }

            }
        }

        public int AccessByIndex(int index)  // 7.доступ по индексу
        {
             if (lenght != 0)
            {


                DoubleNode tmp = root;
                for (int i = 0; i < index; i++)
                {
                    tmp = tmp.Next;
                }
                return tmp.Value;
            }
            else
            {
                int k = 666666666;
                return k;
            }

        }
        public int AccessByValue(int findingvalue)  // 8.индекс по значению
        {
            int index = 0;
            DoubleNode tmp = root;

            while (tmp != null)
            {
                if (tmp.Value == findingvalue)
                {
                    return index;
                }
                else
                {
                    tmp = tmp.Next;
                    index++;
                }
            }

            return -1;
        }
        public void Changebyindex(int index, int g) //9. изменение по индексу

        {
            if (lenght != 0)

            {

                if (index == 0)
                {
                    Addatthebeginning(g);

                    DoubleNode current = root;
                    for (int j = 1; j <= 1; j++)
                    {
                        current.Next = current.Next.Next;
                    }
                    lenght--;
                }
                else
                {
                    DoubleNode tmp = root;
                    DoubleNode newnode = new DoubleNode(g);
                    for (int i = 0; i < index - 1; i++)
                    {
                        tmp = tmp.Next;
                    }

                    tmp.Next.Value = g;

                }
            }
        }
        public void Reversemassiv()
        { if (lenght != 0)
               {   
               if (lenght == 1)
               {   end = null;
                root.Next = end;
                lenght = 1;
               }
               else
               {
          
               DoubleNode tmp = root;
               DoubleNode current;
                do
                {
                    current = tmp.Next;
                    tmp.Next = tmp.Previous;
                    tmp.Previous = current;

                    tmp = tmp.Previous; 
                } while (tmp != null);
               
                current = root;
                root = end;
                end = current;

                }


            }


        }

        public int searchminimum() //12. поиск значения максимального элемента
        {
            DoubleNode tmp = root;
            DoubleNode minimum = root;
            if (lenght != 0)
            {

                for (int i = 1; i < lenght; i++)
                {
                    tmp = tmp.Next;
                    if (tmp.Value < minimum.Value)
                    {
                        minimum = tmp;
                    }
                }
            }
            return minimum.Value;

        }
        public int searchmaximum() //13. поиск значения максимального элемента
        {
            DoubleNode tmp = root;
            DoubleNode maximum = root;
            if (lenght != 0)
            {

                for (int i = 1; i < lenght; i++)
                {
                    tmp = tmp.Next;
                    if (tmp.Value > maximum.Value)
                    {
                        maximum = tmp;
                    }
                }
            }
            return maximum.Value;

        }
        public int searchindexofminimum() //14. поиск индекса максимального элемента
        {

            int index = 0;
            int minIndex = 0;
            if (root == null)
            {
                index = -1;
                minIndex = index;
            }
            else
            {
                DoubleNode tmp = root;
                int minimum = tmp.Value;

                while (tmp.Next != null)
                {

                    if (tmp.Value < minimum)

                    {
                        minimum = tmp.Value;
                        minIndex = index;
                    }
                    tmp = tmp.Next;
                    index++;
                }
            }
            return minIndex;
        }
        public int searchindexofmaximum()  // 15. поиск индекса максимального элемента
        {
            int index = 0;
            int maxIndex = 0;
            if (root == null)
            {
                index = -1;
                maxIndex = index;
            }

            else
            {
                DoubleNode tmp = root;
                int maximum = tmp.Value;

                while (tmp.Next != null)
                {
                    while (tmp.Next != null)
                    {
                        tmp = tmp.Next;
                        index++;

                        if (tmp.Value > maximum)

                        {
                            maximum = tmp.Value;
                            maxIndex = index;
                        }



                    }

                    
                    
                }
            }
            return maxIndex;

        }

        public int returnlenght()  //19. вернуть длину
        {
            return lenght;
        }
        public void sortingUp()   // 16. сортировка по возрастанию (пузырек)
        {
                       
           if (lenght != 0)
           {
                    DoubleNode tmp = root;
                    int k = 0;
                    while (tmp.Next != null)
                    {
                        if (tmp.Value > tmp.Next.Value)
                        {
                            int a = tmp.Next.Value;
                            tmp.Next.Value = tmp.Value;
                            tmp.Value = a;
                            k = 1;
                        }
                        tmp = tmp.Next;
                    }
                    if (k != 0)
                    {
                    sortingUp();
                    }
                }
           


        }
        public void sortingDown()   //17. сортировка по убыванию
        {
            if (lenght != 0)
            {

                for (int i = 1; i < lenght; i++)
                {
                    DoubleNode tmp = root;
                    if (root.Value < tmp.Next.Value)
                    {
                        tmp = tmp.Next;
                        root.Next = tmp.Next;
                        tmp.Next = root;
                        root = tmp;
                    }
                    while (tmp.Next.Next != null)
                    {
                        DoubleNode left = tmp.Next;
                        DoubleNode right = tmp.Next.Next;
                        if (left.Value < right.Value)
                        {
                            left.Next = right.Next;
                            right.Next = left;
                            tmp.Next = right;
                        }
                        tmp = tmp.Next;
                    }
                }

            }

        }

        public void Cancelbyvalue(int a) // 18.удаление по значению
        {
            DoubleNode tmp = root;
            if (lenght!=0)
                {
                while (tmp.Next != null)
                {
                    if (tmp.Next.Value == a)
                    {
                        tmp.Next = tmp.Next.Next;
                        lenght--;
                    }
                    else
                    {
                        tmp = tmp.Next;
                    }

                }
            }
        }
    }
}


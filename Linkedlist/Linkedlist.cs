using System;
using System.Collections.Generic;
using System.Text;
using datastructure.IListok;


namespace datastructure.Linkedlists
{
    public class Linkedlist : 
        IList
    {
        private Node head;
        private int lenght;

        


        public Linkedlist()
        {
            head = null;
            lenght = 0;

        }

        public Linkedlist(int a)
        {
            head = new Node(a);
            lenght = 1;
        }




        public Linkedlist(int[] a)
        {
            head = null;
            lenght = 0;
            for (int i = 0; i < a.Length; i++)
            {
                AddattheEnd(a[i]);
               
            }

        }

        public int this[int index]

        {
            get
            {
                
                    Node tmp = head;

                    for (int i = 0; i < index; i++)
                    {
                        tmp = tmp.Next;
                    }
                    return tmp.Value;

                

            }
            set
            {
                Node tmp = head;

                for (int i = 0; i < index; i++)
                {
                    tmp = tmp.Next;
                }
                tmp.Value = value;
            }
        }


        public void AddattheEnd(int[] a)    // 21.добавление элемента в конец
        {

            //for (int i = 0; i < a.Length; i++)
            //{
            //    AddattheEnd(a[i]);
            //}
            if (a.Length != 0)
            {
                if (lenght == 0)
                {
                    head = new Node(a[0]);
                    Node tmp = head;
                    for (int i = 1; i < a.Length; i++)
                    {
                        tmp.Next = new Node(a[i]);
                        tmp = tmp.Next;
                    }
                    lenght = a.Length;
                }
                else
                {
                    Node tmp = head;
                    while (tmp.Next != null)
                    {
                        tmp = tmp.Next;
                    }
                    for (int i = 0; i < a.Length; i++)
                    {
                        tmp.Next = new Node(a[i]);
                        tmp = tmp.Next;
                    }
                    lenght += a.Length;
                }
            }
        }
        

        public void AddattheEnd(int a)    // 1.добавление элемента в конец
        {
            if (lenght == 0)
            {
                head = new Node(a);
                lenght = 1;
            }
            else if (lenght == 1)

            {
                head.Next = new Node(a);
                lenght++;
            }
            else
            {
                Node tmp = head;
                while (tmp.Next != null)
                {
                    tmp = tmp.Next;
                }

                tmp.Next = new Node(a);
                lenght++;
            }
        }

        public int[] Returnmassiv()             // 10. возврат массива
        {
            int[] massiv = new int[lenght];
            if (lenght != 0)
            {
                int i = 0;
                Node tmp = head;
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

        public void Addatthebeginning(int a)   // 2.добавление в начало 
        {
            Node tmp = new Node(a);
            tmp.Next = head;
            head = tmp;
            lenght++;
        }

        public void Addatthebeginning(int[] a)   // 22.добавление в начало массива
        {
            if (a.Length != 0)
            {
                if (lenght == 0)
                {
                    head = new Node(a[0]);
                    Node tmp = head;
                    for (int j = 0; j < lenght; j++)
                    {
                        for (int i = 1; i < a.Length; i++)
                        {
                            tmp.Next = new Node(a[i]);
                            tmp = tmp.Next;
                        }
                    }
                    lenght = a.Length;
                }
                else
                {
                    Node tmp = head;
                    while (tmp.Next != null)
                    {
                        tmp = tmp.Next;
                    }

                    for (int i = a.Length-1; i >=0; i--)
                    {
                         Addatthebeginning(a[i]);
                    }


                }
                            
        
            }
        }
         public void Addbyindex(int index,int a)   // 3.добавление по индексу
        {
            if (lenght == 0)
            {
                AddattheEnd(a);
            }
            else if (lenght == 1)
            {
                if (index ==0)
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
                Node tmp = head;
                Node nov = new Node(a);

                for (int i = 0; i < index-1; i++)
                {
                    tmp = tmp.Next;
                }
                nov.Next = tmp.Next;
                tmp.Next = nov;
                lenght++;
                

            }

        }

        public void CancelItemfromEnd()  //4. удаление с конца одного элемента
        {
            if (lenght == 0)
            {
                head = null;
                lenght = 0;
            }
            else if (lenght == 1)
            {
                head = null;
                lenght = 0;
            }
            else
            {
                Node tmp = head;
                while (tmp.Next.Next != null)
                {
                    tmp = tmp.Next;
                }
                tmp.Next = null;

                lenght--;
            }

        }
        public void CancelItemfromBegining()  // 5. удаление из начала одного элемента
        {

            head = head.Next;
            lenght--;
        }

        public void CancelItemByIndex(int index)  // 6.удаление по индексу одного элемента
        { 
            if (lenght != 0)
            {
                if (index==0)
                {
                CancelItemfromBegining();
                }
            else if(index==lenght-1)
            {
                CancelItemsfromEnd(lenght - 1);
            }
            else
            {
                Node tmp = head;
                for (int i = 1; i <= index-1; i++)
                {
                tmp = tmp.Next;

                }

                 tmp.Next = tmp.Next.Next;
                 lenght--;

                }

            }
        }

        public int AccessByIndex(int index)  // 7.доступ по индексу
        {
            if (lenght!=0)
            {
                
            
               Node tmp = head;
                for (int i = 0; i < index; i++)
                {
                tmp = tmp.Next;
                }
            return tmp.Value;
            }
            else
            {
                
                return 666666666;
            }
        }

        public int AccessByValue(int findingvalue)  // 8.индекс по значению
        {
            int index = 0;
            Node tmp = head;

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

        public void Reversemassiv()  //11. реверс массива
        {
            if (lenght != 0)
            { 
            Node tmp = head;
            Node tmphead = head;
            while (tmphead.Next != null)
            {
                tmp = tmphead.Next;
                tmphead.Next = tmphead.Next.Next;
                tmp.Next = head;
                head = tmp;
            }
        }

        }

        public void Changebyindex(int index, int changingvalue)  // 9. изменение по индексу Changebyindex
        {
            if (lenght != 0)
            
            {

                if (index == 0)
                {
                    Addatthebeginning(changingvalue);
                    
                    Node current = head;
                    for (int j=1; j<=1; j++)
                    {
                        current.Next = current.Next.Next;
                    }
                    lenght--;
                }
                else
                {
                Node tmp = head;
                Node newnode = new Node(changingvalue);
                for (int i = 0; i < index-1; i++)
                {
                    tmp = tmp.Next;
                }

                    tmp.Next.Value = changingvalue;
               
                }
            }
        }

        public void Addmassivbyindex(int index, int[] a)  // 23. добавдение по индексу массива
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
                    Addbyindex(index,a[i]);
                }

            }
        }



        public void Cancelbyvalue(int a)  // 18. удаление по значению
        {
            Node tmp = head;

            if (lenght !=0)
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

        public int searchminimum() //12. поиск значения максимального элемента
        {
            Node tmp = head;
            Node minimum = head;
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
            Node tmp = head;
            Node maximum = head;
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
        public int searchindexofminimum() //15. поиск индекса минимального элемента 
        {
            int index = 0;
            int minIndex = 0;
            if (head == null)
            {
                index = -1;
                minIndex = index;
            }
            else
            {
                Node tmp = head;
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
        public int searchindexofmaximum()  // 14. поиск индекса минимального элемента  14. поиск индекса максимального элемента
        {
            int index = 0;
            int maxIndex = 0;
            if (head == null)
            {
                index = -1;
                maxIndex = index;
            }

            else
            {
            Node tmp = head;
            int maximum = tmp.Value;
           
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
            return maxIndex;

        }
    
        
        public int returnlenght()  //19. вернуть длину
        {
            return lenght;
        }
        //public int[] sortingUp()   // 16. сортировка по возрастанию
        //{
        //    int[] massiv = new int[lenght];
        //    Node tmp = head;
        //    if (lenght != 0)
        //    {
        //        int i = 0;

        //        do
        //        {
        //            massiv[i] = tmp.Value;
        //            i++;
        //            tmp = tmp.Next;

        //        }
        //        while (tmp != null);
        //    }
        //    int g = 0;
        //    for (int j = 0; j < lenght; j++)
        //    {
        //        for (int i = 0; j < lenght - i - 1; i++)
        //        {
        //            if (tmp.Value > tmp.Next.Value)
        //            {
        //                g = tmp.Value;
        //                tmp.Value = tmp.Next.Value;
        //                tmp.Next.Value = g;
        //            }
        //        }
        //    } return massiv;

        //}

        public void sortingUp()   // 16. сортировка по возрастанию
        {
            
                
                Node prev = null;
                Node minPrev = null;
                Node min = head;
                Node tmp = head;

                while (tmp != null)
                {
                    if (min.Value > tmp.Value)
                    {
                        min = tmp;
                        minPrev = prev;
                    }
                    prev = tmp;
                    tmp = tmp.Next;
                }
                if (minPrev != null)
                {
                    minPrev.Next = minPrev.Next.Next;
                    min.Next = head;
                    head = min;

                }
                Node place = head;
                for (int i = 1; i < lenght; i++)

                {
                    prev = place;
                    minPrev = place;
                    min = place.Next;
                    tmp = place.Next;

                    while (tmp != null)
                    {
                        if (min.Value > tmp.Value)
                        {
                            min = tmp;
                            minPrev = prev;

                        }
                        prev = tmp;
                        tmp = tmp.Next;

                    }
                    minPrev.Next = minPrev.Next.Next;
                    min.Next = place.Next;
                    place.Next = min;
                    place = place.Next;

                }
               

        }
        public void sortingDown()   //17. сортировка по убыванию
        {

                  
            if (lenght !=0)
            {
                
                for (int i = 1; i < lenght; i++)
                {
                    Node tmp = head;
                    if (head.Value < tmp.Next.Value)
                    {
                        tmp = tmp.Next;
                        head.Next = tmp.Next;
                        tmp.Next = head;
                        head = tmp;
                    }
                    while (tmp.Next.Next != null)
                    {
                        Node left = tmp.Next;
                        Node right = tmp.Next.Next;
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
        public void CancelItemsfromEnd(int n)  //24. удаление с конца одного элемента
        {
            if(n!=0)
            {
                if (lenght == 0)
            {
                head = null;
                lenght = 0;
            }
            else if (lenght == 1)
            {
                head = null;
                lenght = 0;
            }
            else
            {
                if (n  > lenght)

                {
                    
                        head = null;
                        lenght = 0;
                }
                else
                {
                    for (int i = 1; i <=n; i++)
                    { 
                        Node tmp = head;
                        while (tmp.Next.Next!= null)
                        {
                            tmp = tmp.Next;
                        }
                        tmp.Next = null;

                        lenght--;

                    }
                }
            }
}
        }
        public void CancelItemsfrombeginning(int n)  // 25. удаление из начала массива
        {

            if (n != 0)
            {
                if (lenght == 0)
                {
                    head = null;
                    lenght = 0;
                }
                else if (lenght == 1)
                {
                    head = null;
                    lenght = 0;
                }
                else
                {
                    if (n > lenght)

                    {

                        head = null;
                        lenght = 0;
                    }
                    else
                    {
                        for (int i = 0; i < n; i++)
                         {
                          head = head.Next;
                           lenght--;
                        }
                    }
                }
            }
        }

        public void CancelItemsbyindex(int index, int n)  // 26.удаление по индексу n элементов
        {


            if (lenght == 0)
            {
                head = null;
                lenght = 0;
            }
            else if (lenght == 1)
            {
                if (index == 0)
                {
                    CancelItemfromEnd();
                }
                else
                {
                    lenght = 1;
                }
            }

            else
            {
                if (index <= lenght - 1)
                {
                    for (int j = 1; j <= n; j++)

                    {
                        Node tmp = head;
                        for (int i = 1; i <= index - 1; i++)
                        {
                            tmp = tmp.Next;

                        }
                        tmp.Next = tmp.Next.Next;
                        lenght--;

                    }
                }
               
            }

        } 
    }
}



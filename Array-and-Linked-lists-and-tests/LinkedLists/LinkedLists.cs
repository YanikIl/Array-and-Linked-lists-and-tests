using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    public class LinkedList
    {
        private Node _root;

        private Node _tail;

        #region индексатор
        public int this[int index]
        {
            get
            {
                Node crnt = _root;
                for (int i = 1; i <= index; i++)
                {
                    crnt = crnt.Next;
                }

                return crnt.Value;
            }

            set
            {

            }
        }

        #endregion

        public int Length
        {
            get
            {
                int count = 0;
                Node crnt = _root;

                while (crnt != null)
                {
                    crnt = crnt.Next;
                    count++;
                }

                return count;
            }
            private set
            {
            }
        }

        #region конструкторы
        public LinkedList()
        {
            _root = null;

            _tail = null;
        }
        public LinkedList(int value)
        {
            _root = new Node(value);
            _tail = _root;
        }
        public LinkedList(int[] values)
        {
            if (values.Length == 0)
            {
                _root = null;
                _tail = null;
            }
            else
            {
                _root = new Node(values[0]);
                _tail = _root;

                for (int i = 1; i < values.Length; i++)
                {
                    Add(values[i]);
                }
            }
        }
        #endregion

        #region сдвиг влево
        private void LeftShift()
        {
            for (int i = 1; i <= Length - 1; ++i)
            {

            }
        }
        #endregion

        #region сдвиг вправо
        private void RightShift()
        {
            for (int i = Length - 1; i >= 0; --i)
            {
                _tail.Next = 
            }
        }
        #endregion

        #region 1. добавление значения в конец
        public void Add(int value)
        {
            if (_root == null)
            {
                _root = new Node(value);
                _tail = _root;
            }
            else
            {
                //Node crnt = _root;

                //while (crnt.Next != null)
                //{
                //    crnt = crnt.Next;
                //}

                //crnt.Next = new Node(value);

                _tail.Next = new Node(value);
                _tail = _tail.Next;
            }
        }
        #endregion

        #region 2. добавление значения в начало
        public void AddToStart(int value)
        {
            
        }
        #endregion

        #region 3. добавление значения по индексу
        #endregion

        #region 4. удаление из конца одного элемента
        #endregion

        #region 5. удаление из начала одного элемента
        #endregion

        #region 6. удаление по индексу одного элемента
        public void DeleteByIndex(int index)
        {
            if (index < 0 || index > Length - 1)
            {
                throw new IndexOutOfRangeException();
            }
            else if (index == 0)
            {
                _root = _root.Next;
            }
            else
            {
                Node crnt = _root;
                for (int i = 1; i < index; i++)
                {
                    crnt = crnt.Next;
                }
                crnt.Next = crnt.Next.Next;
            }
        }
        #endregion

        #region 7. удаление из конца N элементов
        #endregion

        #region 8. удаление из начала N элементов
        #endregion

        #region 9. удаление по индексу N элементов
        #endregion

        #region 10. вернуть длину (уже есть)
        public int GetLength()
        {
            return Length;
        }
        #endregion


        #region 11. доступ по индексу 
        private Node GetNodeByIndex(int index)
        {
            Node crnt = _root;
            for (int i = 1; i <= index; i++)
            {
                crnt = crnt.Next;
            }

            return crnt;
        }
        #endregion

        #region 19. сортировка по возрастанию
        public void Sort()
        {
            int l = Length;
            Node crnt;
            Node prev;

            for (int i = l - 2; i >= 0; i--)
            {
                if (i == 0)
                {
                    crnt = _root;
                    if (crnt.Next != null && crnt.Value > crnt.Next.Value)
                    {
                        _root = crnt.Next;
                        crnt.Next = _root.Next;
                        _root.Next = crnt;
                    }
                    prev = _root;
                }
                else
                {
                    prev = GetNodeByIndex(i - 1);
                    crnt = prev.Next;
                }

                while (crnt.Next != null && crnt.Value > crnt.Next.Value)
                {
                    prev.Next = crnt.Next;
                    crnt.Next = prev.Next.Next;
                    prev.Next.Next = crnt;

                    prev = prev.Next;
                }
            }

            _tail = GetNodeByIndex(l - 1);
        }
        #endregion




        #region переопределенные методы
        public override string ToString()
        {
            string s = "";
            Node crnt = _root;

            while (crnt != null)
            {
                s += $"{crnt.Value} ";
                crnt = crnt.Next;
            }

            return s;
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || !(obj is LinkedList))
            {
                return false;
            }

            LinkedList list = (LinkedList)obj;

            if (list.Length != this.Length)
            {
                return false;
            }

            Node thisCrnt = this._root;
            Node listCrnt = list._root;

            while (thisCrnt != null)
            {
                if (thisCrnt.Value != listCrnt.Value)
                {
                    return false;
                }

                thisCrnt = thisCrnt.Next;
                listCrnt = listCrnt.Next;
            }

            return true;
        }
        #endregion

    }
}
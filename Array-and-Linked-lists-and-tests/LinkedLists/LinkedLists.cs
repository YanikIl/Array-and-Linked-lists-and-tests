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
                if (index < 0 || index >= Length)
                {
                    throw new IndexOutOfRangeException("Index out of range");
                }

                Node crnt = _root;

                for (int i = 1; i <= index; i++)
                {
                    crnt = crnt.Next;
                }

                return crnt.Value;
            }

            set
            {
                if (index < 0 || index >= Length)
                {
                    throw new IndexOutOfRangeException();
                }

                Node crnt = _root;

                for (int i = 1; i <= index; i++)
                {
                    crnt = crnt.Next;
                }

                crnt.Value = value;
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
                Node crnt = _root;
                _tail = crnt;
                for (int i = 1; i < values.Length; i++)
                {
                    crnt.Next = new Node(values[i]);
                    crnt = crnt.Next;
                    _tail = crnt;
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
                _tail.Next = new Node(value);
                _tail = _tail.Next;
            }
        }
        #endregion

        #region 2. добавление значения в начало
        public void AddToStart(int value)
        {
            if (_root is null)
            {
                _root = new Node(value);
                _tail = _root;
            }
            else
            {
                Node crnt = _root;
                _root = new Node(value);
                _root.Next = crnt;
            }
        }
        #endregion

        #region 3. добавление значения по индексу
        public void AddByIndex(int index, int value)
        {
            if (index >= Length || index < 0)
            {
                throw new IndexOutOfRangeException();
            }

            if (index > 0)
            {

                Node tmp = _root;

                for (int i = 0; i < index - 1; i++)
                {

                    tmp = tmp.Next;

                }
                Node crnt = new Node(value);
                crnt.Next = tmp.Next;
                tmp.Next = crnt;
            }

            else
            {
                AddToStart(value);
            }
        }
        #endregion

        #region 4. удаление из конца одного элемента
        public void DeleteLast()
        {
            if (Length == 0)
            {
                throw new Exception("Nothing to delete");
            }

            if (Length == 1)
            {
                _root = null;
                _tail = null;
            }

            if (Length > 1)
            {

                Node crnt = _root;
                for (int i = 1; i < Length - 1; i++)
                {
                    crnt = crnt.Next;
                }

                crnt.Next = null;

            }
        }
        #endregion

        #region 5. удаление из начала одного элемента
        public void DeleteFirst()
        {
            if (Length == 0)
            {
                throw new Exception("Nothing to delete");
            }
            _root = _root.Next;
        }
        #endregion

        #region 6. удаление по индексу одного элемента
        public void DeleteByIndex(int index)
        {
            if (Length == 0)
            {
                throw new Exception("Nothing to delete");
            }
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
        public void DeleteLastNNumbers(int n)
        {
            if (n > Length)
            {
                throw new Exception("N more Length");
            }

            if (Length == n)
            {
                _root = null;
            }
            
            if(n < Length)
            {
                Node crnt = _root;
                for (int i = 1; i < Length - n; i++)
                {
                    crnt = crnt.Next;
                }
                crnt.Next = null;

            }
        }
        #endregion

        #region 8. удаление из начала N элементов
        public void DeleteFirstNNumbers(int n)
        {
            if (n > Length)
            {
                throw new Exception("N more Length");
            }

            if (Length == n)
            {
                _root = null;
            }

            if (n < Length)
            {

                Node crnt = _root;

                for (int i = Length - n; i < Length; i++)
                {

                    crnt = crnt.Next;
                }
                _root = crnt;

            }
        }
        #endregion

        #region 9. удаление по индексу N элементов
        public void DeleteByIndexNNumbers(int index, int n)
        {
            if (n > Length)
            {
                throw new Exception("N more Length");
            }

            else if (index < 0 || index > Length || Length - n < index)
            {
                throw new IndexOutOfRangeException();
            }

            if (index > 0)
            {
                Node crnt = _root;

                for (int i = 1; i < index; i++)
                {
                    crnt = crnt.Next;
                }
                for (int j = 0; j < n; j++)
                {
                    crnt.Next = crnt.Next.Next;
                }

            }
            else if (index == 0)
            {
                DeleteFirstNNumbers(n);
            }
        }
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
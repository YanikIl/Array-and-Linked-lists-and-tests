namespace ArrayLists
{
    public class ArrayList
    {
        private const int _minArrayLenght = 10;

        private int[] _array;
        public int Length { get; private set; }

        #region 23. конструкторы
        public ArrayList()
        {
            Length = 0;
            _array = new int[_minArrayLenght];
        }

        public ArrayList(int n)
        {
            Length = 1;
            _array = new int[] { n };
        }

        public ArrayList(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                _array = new int[10];
                Length = 0;
            }
            else
            {
                _array = array;
                Length = array.Length;
                UpArraySize();
            }
        }
        #endregion

        #region новые условия сравнения
        public override bool Equals(object? obj)
        {
            bool isEqual = true;

            if (obj == null || !(obj is ArrayList))
            {
                isEqual = false;
            }
            else
            {
                ArrayList list = (ArrayList)obj;

                if (list.Length != this.Length)
                {
                    isEqual = false;
                }
                else
                {
                    for (int i = 0; i < this.Length; i++)
                    {
                        if (list[i] != this[i])
                        {
                            isEqual = false;
                        }
                    }
                }
            }
            return isEqual;
        }

        public override string ToString()
        {
            string s = "";
            for (int i = 0; i < Length; i++)
            {
                s += $"{_array[i]} ";
            }
            return s;
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region вывод в консоль
        public void WriteToConsole()
        {
            Console.Write($"L={Length} RL={_array.Length}   ");
            for (int i = 0; i < Length; i++)
            {
                Console.Write($"{_array[i]} ");
            }
            Console.WriteLine();
        }
        #endregion

        #region индексатор
        public int this[int index]
        {
            get
            {
                if (index < 0 || index >= Length)
                {
                    throw new IndexOutOfRangeException();
                }
                return _array[index];
            }
            set
            {
                if (index < 0 || index >= Length)
                {
                    throw new IndexOutOfRangeException();
                }
                _array[index] = value;
            }
        }
        #endregion

        #region увеличение массива
        private void UpArraySize()
        {
            int[] tmpArray = new int[(int)(Length * 1.5 + 1)];
            for (int i = 0; i < Length; i++)
            {
                tmpArray[i] = _array[i];
            }
            _array = tmpArray;
        }
        #endregion

        #region уменьшение массива
        private void DownArraySize()
        {
            int[] tmpArray = new int[(int)(_array.Length * 0.7)];
            for (int i = 0; i < Length; i++)
            {
                tmpArray[i] = _array[i];
            }
            _array = tmpArray;
        }
        #endregion

        #region сдвиг влево
        private void LeftShift()
        {
            for (int i = 1; i <= Length - 1; ++i)
            {
                _array[i - 1] = _array[i];
            }
        }
        #endregion

        #region сдвиг вправо
        private void RightShift()
        {
            for (int i = Length - 1; i >= 0; --i)
            {
                _array[i + 1] = _array[i];
            }
        }
        #endregion


        #region 1. добавление значения в конец
        public void AddToEnd(int value)
        {

            if (Length == _array.Length)
            {
                UpArraySize();
            }

            _array[Length] = value;
            Length++;
        }
        #endregion

        #region 2. добавление значения в начало
        public void AddToStart(int value)
        {
            if (Length == _array.Length)
            {
                UpArraySize();
            }
            RightShift();

            _array[0] = value;
            Length++;
        }
        #endregion

        #region 3. добавление значения по индексу
        public void AddByIndex(int index, int value)
        {
            if (index < 0 || index >= Length)
            {
                throw new IndexOutOfRangeException("Выход за пределы");
            }
            if (Length == _array.Length)
            {
                UpArraySize();
            }

            for (int i = Length - 1; i >= index; --i)
            {
                _array[i + 1] = _array[i];
            }

            _array[index] = value;

            Length++;
        }
        #endregion

        #region 4. удаление из конца одного элемента
        public void DeleteLast()
        {
            if (Length == 0)
            {
                throw new Exception("List is empty");
            }
            if (Length == _array.Length)
            {
                UpArraySize();
            }
            if (Length > 0)
            {
                Length--;
            }
        }
        #endregion

        #region 5. удаление из начала одного элемента
        public void DeleteFirst()
        {
            if (Length == 0)
            {
                throw new Exception("List is empty");
            }
            if (Length == _array.Length)
            {
                UpArraySize();
            }
            if (Length > 0)
            {
                LeftShift();
                Length--;
            }
        }
        #endregion

        #region 6. удаление по индексу одного элемента
        public void DeleteByIndex(int index)
        {
            if (index < 0 || index >= Length)
            {
                throw new IndexOutOfRangeException();
            }
            if (Length == _array.Length)
            {
                UpArraySize();
            }
            for (int i = index + 1; i <= Length - 1; ++i)
            {
                _array[i - 1] = _array[i];
            }
            Length--;
        }
        #endregion

        #region 7. удаление из конца N элементов
        public void DeleteLastNNumbers(int n)
        {
            if (n < 0 || n > Length)
            {
                throw new ArgumentOutOfRangeException();
            }
            Length = Length - n;
            if (Length <= _array.Length / 2)
            {
                DownArraySize();
            }
        }
        #endregion

        #region 8. удаление из начала N элементов
        public void DeleteFirstNNumbers(int n)
        {
            if (n < 0 || n > Length)
            {
                throw new ArgumentOutOfRangeException();
            }
            int tmp = 0;
            for (int i = n; i <= Length; ++i)
            {
                _array[tmp] = _array[i];
                tmp++;
            }
            Length = Length - n;
            if (Length <= _array.Length / 2)
            {
                DownArraySize();
            }
        }
        #endregion

        #region 9. удаление по индексу N элементов
        public void DeleteByIndexNNumbers(int index, int n)
        {
            if ((n + index) > Length)
            {
                throw new ArgumentException();
            }
            else if (n < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            else if (index < 0)
            {
                throw new IndexOutOfRangeException();
            }

            int tmp = index;
            while (tmp + n < Length)
            {
                _array[tmp] = _array[tmp + n];
                ++tmp;
            }
            Length = Length - n;
            if (Length <= _array.Length / 2)
            {
                DownArraySize();
            }
        }
        #endregion

        #region 10. вернуть длину (уже есть)
        public int GetLength()
        {
            return Length;
        }
        #endregion

        // негативный валится, спросить
        #region 11. доступ по индексу 
        public int IndexValue(int index)
        {
            if (Length == 0)
            {
                throw new Exception("List is empty");
            }
            return _array[index];
        }
        #endregion

        #region 12. первый индекс по значению
        public int GetFirstIndexByValue(int value)
        {
            for (int i = 0; i < Length; ++i)
            {
                if (_array[i] == value)
                {
                    return i;
                }
            }
            return -1;
        }
        #endregion

        //негативные
        #region 13. изменение по индексу
        public void ChangeValueByIndex(int index, int value)
        {
            _array[index] = value;
        }
        #endregion

        #region 14. реверс (123 -> 321)
        public void Reverse()
        {
            int tmp;
            for (int i = 0; i < Length / 2; i++)
            {
                tmp = _array[i];
                _array[i] = _array[Length - i - 1];
                _array[Length - i - 1] = tmp;
            }
        }
        #endregion

        #region 15. поиск значения максимального элемента
        public int GetMax()
        {
            if (Length == 0)
            {
                throw new Exception("List is empty");
            }
            
            int max = _array[0];

            for (int i = 0; i < Length; ++i)
            {
                if (_array[i] > max)
                {
                    max = _array[i];
                }
            }

            return max;
        }
        #endregion

        #region 16. поиск значения минимального элемента
        public int GetMin()
        {
            if (Length == 0)
            {
                throw new Exception("List is empty");
            }

            int min = _array[0];

            for (int i = 0; i < Length; ++i)
            {
                if (_array[i] < min)
                {
                    min = _array[i];
                }
            }

            return min;
        }
        #endregion

        #region 17. поиск индекса максимального элемента
        public int GetIndexByMax()
        {
            if (Length == 0)
            {
                throw new Exception("List is empty");
            }

            int max = _array[0];
            int index = 0;

            for (int i = 0; i < Length; ++i)
            {
                if (_array[i] > max)
                {
                    max = _array[i];
                    index = i;
                }
            }

            return index;
        }

        #endregion

        #region 18. поиск индекса минимального элемента
        public int GetIndexByMin()
        {
            if (Length == 0)
            {
                throw new Exception("List is empty");
            }

            int min = _array[0];
            int index = 0;

            for (int i = 0; i < Length; ++i)
            {
                if (_array[i] < min)
                {
                    min = _array[i];
                    index = i;
                }
            }

            return index;
        }
        #endregion

        #region 19. сортировка по возрастанию
        public void BubbleSortAscending()
        {
            for (int i = 0; i < Length; i++)
            {
                for (int j = i + 1; j < Length; j++)
                {
                    if (_array[i] > _array[j])
                    {
                        int tmp = _array[i];
                        _array[i] = _array[j];
                        _array[j] = tmp;
                    }
                }
            }
        }
        #endregion

        #region 20. сортировка по убыванию descending
        public void BubbleSortDescending()
        {
            for (int i = 0; i < Length; i++)
            {
                for (int j = i + 1; j < Length; j++)
                {
                    if (_array[i] < _array[j])
                    {
                        int tmp = _array[j];
                        _array[j] = _array[i];
                        _array[i] = tmp;
                    }
                }
            }
        }
        #endregion

        // не работает
        #region 21. удаление по значению первого (вернуть индекс)  
        public int DeleteByFirstValue(int value)
        {
            if (Length == 0)
            {
                throw new Exception("List is empty");
            }
            int index = GetFirstIndexByValue(value);

            if (index != -1)
            {
                DeleteByIndex(index);
            }

            return index;
        }
        #endregion

        #region 22. удаление по значению всех
        public int DeleteAllByValue(int value)
        {
            if (Length == 0)
            {
                throw new Exception("Пустой массив");
            }
            if (Length <= _array.Length / 2)
            {
                DownArraySize();
            }
            int count = 0;
            for (int i = 0; i < Length; i++)
            {
                if (_array[i] == value)
                {
                    count++;
                }
                else
                {
                    _array[i - count] = _array[i];
                }
            }
            Length -= count;

            return count;
        }
        #endregion

        //проверить
        #region 23. 3 конструктора(пустой, на основе одного элемента, на основе массива), есть выше
        #endregion

        //проверить
        #region 24. добавление списка(вашего самодельного) в конец

        public void AddListToEnd(ArrayList list)
        {
            if (list is null)
            {
                throw new NullReferenceException();
            }

            for (int i = 0; i < list.Length; i++)
            {
                AddToEnd(list[i]);
            }
        }
        #endregion

        //проверить
        #region 25. добавление списка в начало
        public void AddListToStart(ArrayList list)
        {
            if (list is null)
            {
                throw new NullReferenceException();
            }

            for (int i = 0; i < list.Length; i++)
            {
                AddToStart(list[i]);
            }
        }
        #endregion

        //проверить
        #region 26. добавление списка по индексу
        public void AddListByIndex(int index, ArrayList list)
        {
            if (list is null)
            {
                throw new NullReferenceException();
            }

            for (int i = 0; i < list.Length; i++)
            {
                AddByIndex(index, list[i]);
            }
        }
        #endregion

    }
}
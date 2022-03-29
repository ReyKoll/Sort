using System;

namespace Sort.Model
{
    public class QuickSort
    {
        /// <summary>
        /// Алгоритм получения индекса пивота
        /// </summary>
        /// <param name="array"></param>
        /// <param name="minIndex"></param>
        /// <param name="maxIndex"></param>
        /// <param name="comparator"></param>
        /// <returns>Индекс пивота</returns>
        private int GetPivotIndex(char[] array, int minIndex, int maxIndex, Comparison<char> comparator)
        {
            // Начальный индекс пивота
            int pivot = minIndex - 1;

            // Перестановка пивота
            for (int i = minIndex; i <= maxIndex; ++i)
            {
                if (comparator(array[i], array[maxIndex]) != 0)
                {
                    ++pivot;
                    Swap(ref array[pivot], ref array[i]);
                }
            }

            // Установка пивота на свое место
            ++pivot;
            Swap(ref array[pivot], ref array[maxIndex]);

            return pivot;
        }

        private void Swap(ref char left, ref char right)
        {
            char temp = left;
            left = right;
            right = temp;
        }

        /// <summary>
        /// Алгоритм быстрой сортировки
        /// </summary>
        /// <param name="array"></param>
        /// <param name="minIndex"></param>
        /// <param name="maxIndex"></param>
        /// <param name="comparator"></param>
        /// <returns>Отсортированный массив символов</returns>
        public char[] SortArray(char[] array, int minIndex, int maxIndex, Comparison<char> comparator)
        {
            // Условие завершения сортировки
            if (minIndex >= maxIndex)
                return array;

            int pivotIndex = GetPivotIndex(array, minIndex, maxIndex, comparator);

            // Сортировка левого подмассива
            if (pivotIndex > 1)
                SortArray(array, minIndex, pivotIndex - 1, comparator);

            // Сортировка правого подмассива
            if (pivotIndex + 1 < maxIndex)
                SortArray(array, pivotIndex + 1, maxIndex, comparator);

            return array;
        }
    }
}
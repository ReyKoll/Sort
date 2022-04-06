using Sort.Model;
using Sort.View;

namespace Sort.Presenter
{
    public class SortPresenter
    {
        // Объект
        QuickSort quickSort = new QuickSort();

        // Экземпляр Интерфейса
        private readonly ISort _sort;

        public SortPresenter(ISort sort)
        {
            _sort = sort;
        }

        public SortPresenter() { }

        /// <summary>
        /// Сравнивает между собой 2 символа массива
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>Знаковое целое число, которое определяет относительные значения параметров x и y</returns>
        private int Compare(char x, char y)
        {
            if (x == 'С' && y == 'К')
                return -1;

            return x < y ? -1 : 0;
        }

        public char[] SetArray()
        {
            string inputString = "ССЗСКЗЗЗККСЗССКЗ";

            char[] inputArray = inputString.ToCharArray();

            return inputArray;
        }

        public char[] GetArray()
        {
            return quickSort.SortArray(SetArray(), 0, SetArray().Length - 1, Compare);
        }
    }
}
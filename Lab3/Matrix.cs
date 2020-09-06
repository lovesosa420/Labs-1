using System;
using System.Collections.Generic;
using System.Text;

namespace SparseMatrix
{
    public class Matrix<T>
    {
        /// <summary>
        /// Словарь для хранения значений
        /// </summary>
        private readonly Dictionary<string, T> _matrix = new Dictionary<string, T>();

        /// <summary>
        /// Количество элементов по горизонтали (максимальное количество столбцов)
        /// </summary>
        private readonly int _maxX;

        /// <summary>
        /// Количество элементов по вертикали (максимальное количество строк)
        /// </summary>
        private readonly int _maxY;
        private readonly int _maxZ;

        /// <summary>
        /// Пустой элемент, который возвращается если элемент с нужными координатами не был задан
        /// </summary>
        private readonly T nullElement;

        /// <summary>
        /// Конструктор
        /// </summary>
        public Matrix(int px, int py, int pz, T nullElementParam)
        {
            _maxX = px;
            _maxY = py;
            _maxZ = pz;
            nullElement = nullElementParam;
        }

        /// <summary>
        /// Индексатор для доступа к данных
        /// </summary>
        public T this[int x, int y, int z]
        {
            get
            {
                CheckBounds(x, y, z);
                var key = DictKey(x, y, z);
                if (_matrix.ContainsKey(key))
                {
                    return _matrix[key];
                }
                else
                {
                    return nullElement;
                }
            }
            set
            {
                CheckBounds(x, y, z);
                var key = DictKey(x, y, z);
                _matrix.Add(key, value);
            }
        }

        /// <summary>
        /// Проверка границ
        /// </summary>
        private void CheckBounds(int x, int y, int z)
        {
            if (x < 0 || x >= _maxX) throw new Exception("x=" + x + " выходит за границы");
            if (y < 0 || y >= _maxY) throw new Exception("y=" + y + " выходит за границы");
            if (z < 0 || z >= _maxZ) throw new Exception("z=" + z + " выходит за границы");
        }

        /// <summary>
        /// Формирование ключа
        /// </summary>
        private string DictKey(int x, int y, int z) => x.ToString() + "_" + y.ToString() + "_" + z.ToString();

        /// <summary>
        /// Приведение к строке
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            //Класс StringBuilder используется для построения длинных строк
            //Это увеличивает производительность по сравнению с созданием и склеиванием 
            //большого количества обычных строк

            var b = new StringBuilder();

            for (var z = 0; z < _maxZ; z++) 
            {
                for (var j = 0; j < _maxY; j++)
                {
                    b.Append("[");
                    for (var i = 0; i < _maxX; i++)
                    {
                        if (i > 0) b.Append("\t");
                        b.Append(this[i, j, z]?.ToString() ?? "null");
                    }
                    b.Append("]\n");
                }
                b.Append('\n');
            }

            return b.ToString();
        }

    }
}

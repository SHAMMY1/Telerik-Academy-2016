using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Matrix<T> where T : struct, 
                                     IComparable,
                                     IComparable<T>,
                                     IConvertible,
                                     IEquatable<T>,
                                     IFormattable
    {
        private T[,] matrix;

        public Matrix(int rows, int cols)
        {
            this.matrix = new T[rows, cols];
        }

        public T this[int row, int col]
        {
            get
            {
                return this.matrix[row, col];
            }

            set
            {
                this.matrix[row, col] = value;
            }
        }

        public static Matrix<T> operator +(Matrix<T> first, Matrix<T> second)
        {
            if (first.matrix.GetLength(0) != second.matrix.GetLength(0) || first.matrix.GetLength(1) != second.matrix.GetLength(1))
            {
                throw new ArgumentException("matrises must be same!");
            }

            var rezult = new Matrix<T>(first.matrix.GetLength(0), first.matrix.GetLength(1));

            for (int row = 0; row < first.matrix.GetLength(0); row++)
            {
                for (int col = 0; col < first.matrix.GetLength(1); col++)
                {
                    rezult[row, col] = (dynamic)first[row, col] + (dynamic)second[row, col];
                }
            }

            return rezult;
        }

        public static Matrix<T> operator -(Matrix<T> first, Matrix<T> second)
        {
            if (first.matrix.GetLength(0) != second.matrix.GetLength(0) || first.matrix.GetLength(1) != second.matrix.GetLength(1))
            {
                throw new ArgumentException("matrises must be same!");
            }

            var rezult = new Matrix<T>(first.matrix.GetLength(0), first.matrix.GetLength(1));

            for (int row = 0; row < first.matrix.GetLength(0); row++)
            {
                for (int col = 0; col < first.matrix.GetLength(1); col++)
                {
                    rezult[row, col] = (dynamic)first[row, col] - (dynamic)second[row, col];
                }
            }
            return rezult;

        }
    }
}

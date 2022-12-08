using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prakt6DeutchLand
{
    internal class Triangle
    {
        private int _a, _b, _c;

        public int A
        {
            get => _a;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Значение не может быть меньше 0");
                }
                _a = value;
            }
        }

        public int B
        {
            get => _b;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Значение не может быть меньше 0");
                }
                _b = value;
            }
        }

        public int C
        {
            get => _c;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Значение не может быть меньше 0");
                }
                _c = value;
            }
        }

        public int Perimetr()
        {
            int Perim = _a + _b + _c;
            return Perim;
        }

        public void Uvelich()
        {
            _a *= 2;
            _b *= 2;
            _c *= 2;
        }

        public void SetParams(int x)
        {
            _a = x;
        }

        public void SetParams(int x, int y)
        {
            _a = x;
            _b = y;
        }

        public void SetParams(int x, int y, int z)
        {
            _a = x;
            _b = y;
            _c = z;
        }
        public static bool operator true(Triangle triangle)
        {
            return
                triangle._a + triangle._b > triangle._c
                &&
                triangle._b + triangle._c > triangle._a
                &&
                triangle._c + triangle._a > triangle._b;
        }
        public static bool operator false(Triangle triangle)
        {
            return
                triangle._a + triangle._b <= triangle._c
                &&
                triangle._b + triangle._c <= triangle._a
                &&
                triangle._c + triangle._a <= triangle._b;
        }
        public static Triangle operator ++(Triangle triangle)
        {
            Triangle triangle1 = new Triangle();
            triangle1._a = triangle._a + 1;
            triangle1._b = triangle._b + 1;
            triangle1._c = triangle._c + 1;
            return triangle1;
        }
        public static Triangle operator --(Triangle triangle)
        {
            Triangle triangle1 = new Triangle();
            triangle1._a = triangle._a - 1;
            triangle1._b = triangle._b - 1;
            triangle1._c = triangle._c - 1;
            return triangle1;
        }
    }
}

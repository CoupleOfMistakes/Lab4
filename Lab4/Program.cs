using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Rectangle
    {
        private int side_a;
        private int side_b;
        private int color;

        public int this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0: return side_a;
                    case 1: return side_b;
                    case 2: return color;
                    default: Console.WriteLine("Index Error"); return 0;
                }
            }
        }

        public override string ToString()
        {
            return ("All the information about the rectangle:\nSide a = " + side_a + "\nSide b = " + side_b + "\nColor = " + GetColor() + "\nIs a Square = " + IsSquare() +
               "\nPerimeter = " + CalculatingPerimeter() + "\nSquare = " + CalculatingSquare());
        }

        public Rectangle ToRectangle(string String)
        {
            var input = String.Split(' ').Select(x => int.Parse(x)).ToArray();
            side_a = input[0]; side_b = input[1]; color = input[2];
            return this;
        }

        public static Rectangle operator ++(Rectangle r)
        {
            ++r.side_a;
            ++r.side_b;
            return r;
        }
        public static Rectangle operator --(Rectangle r)
        {
            --r.side_a;
            --r.side_b;
            return r;
        }

        public static bool operator true(Rectangle r)
        {
            return r.side_a == r.side_b;
        }
        public static bool operator false(Rectangle r)
        {
            return r.side_a != r.side_b;
        }
        public static Rectangle operator *(Rectangle r, int scalar)
        {
            r.side_a *= scalar;
            r.side_b *= scalar;
            return r;
        }


        public Rectangle(int side_a, int side_b, int color)
        {
            this.side_a = side_a;
            this.side_b = side_b;
            this.color = color;
            Console.WriteLine("A rectangle has been created");
        }

        public void GetSideLength()
        {
            Console.WriteLine("Side a = " + side_a + "\nSide b = " + side_b);
        }
        public void SetSideLength(int side_a, int side_b)
        {
            this.side_a = side_a;
            this.side_b = side_b;
            Console.WriteLine("Applying changes...");
        }
        public string GetColor()
        {
            switch (color)
            {
                case 1: return "White";
                case 2: return "Red";
                case 3: return "Black";
                case 4: return "Grey";
                case 5: return "Yellow";
                case 6: return "Blue";
                default: return "Undefined";
            }
        }
        public int CalculatingSquare()
        {
            return side_b * side_a;
        }
        public int CalculatingPerimeter()
        {
            return 2 * side_a + 2 * side_b;
        }
        public bool IsSquare()
        {
            if (side_a == side_b)
            { return true; }
            else
            { return false; }
        }
        public void GetAllInfo()
        {
            Console.WriteLine("Output the information about the rectangle:\nSide a = " + side_a + "\nSide b = " + side_b + "\nColor = " + GetColor() + "\nIs a Square = " + IsSquare() +
                "\nPerimeter = " + CalculatingPerimeter() + "\nSquare = " + CalculatingSquare());
        }
    }

    class VectorShort
    {
        short[] ShortArray;
        static uint n;
        uint codeError;
        static uint num_v;
        public int index;
        public uint N
        {
            get => n;
        }

        public uint Code
        {
            get => codeError;
            set => codeError = value;
        }

        public short[] ShortArray_get
        {
            get => ShortArray;
        }
        public uint Arr1(int k)
        {
            uint y = 0;
            for (int i = 0; i < ShortArray.Length; i++)
            {
                if (i == k)
                    y = (uint)ShortArray[i];
            }
            return y;
        }

        public VectorShort()
        {
            n = 1;
            ShortArray = new short[n];
            ShortArray[0] = 0;
        }

        public VectorShort(uint k)
        {
            n = k;
            ShortArray = new short[k];
            for (int i = 0; i < ShortArray.Length; i++)
            {
                ShortArray[i] = 0;
            }
        }
        public VectorShort(uint k, short y)
        {
            n = k;
            ShortArray = new short[n];
            for (int i = 0; i < ShortArray.Length; i++)
            {
                ShortArray[i] = y;
            }
        }
        ~VectorShort()
        {
            Console.WriteLine("Destructor");
        }

        public void Output()
        {
            for (int i = 0; i < this.ShortArray.Length; i++)
            {
                Console.Write("[{0}] = {1}\t", (i + 1), ShortArray[i]);
            }
        }

        public short[] Inn()
        {
            Console.Write("Enter the numbers of vector columns: ");
            n = uint.Parse(Console.ReadLine());
            ShortArray = new short[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("[{0}] = ", i + 1);
                ShortArray[i] = (short)(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine("\t");
            }
            return ShortArray;
        }
        public void Assign_value_par(short k)
        {
            for (int i = 0; i < this.ShortArray.Length; i++)
            {
                ShortArray[i] = k;
            }
        }
        public void Assign_value(VectorShort o)
        {

            for (int col = 0; col < n; col++)
            {

                ShortArray[col] = o.ShortArray[col];

            }
        }
        public short this[int index]
        {
            set
            {
                if (index > ShortArray.Length) codeError = 10;
                else codeError = 0;
                ShortArray[index] = value;
            }
            get
            {
                return ShortArray[index];
            }
        }
        public static VectorShort operator ++(VectorShort o)
        {
            for (int i = 0; i < o.ShortArray.Length; i++)
            {
                ++o.ShortArray[i];
                Console.Write("[{0}] = {1}\t", (i + 1), o.ShortArray[i]);
            }
            return o;
        }
        public static VectorShort operator --(VectorShort o)
        {
            for (int i = 0; i < o.ShortArray.Length; i++)
            {
                --o.ShortArray[i];
                Console.Write("[{0}] = {1}\t", (i + 1), o.ShortArray[i]);
            }
            return o;
        }
        public static bool operator true(VectorShort f1)
        {
            return f1.N != 0;
        }
        public static bool operator false(VectorShort f1)
        {
            return f1.N == 0;
        }
        public static bool operator !(VectorShort f1)
        {
            return f1.N != 0;
        }
        public static bool operator !=(VectorShort f1, int k)
        {
            k = 0;
            return f1.N != k;
        }
        public static bool operator ==(VectorShort f1, int k)
        {
            k = 0;
            return f1.N == k;
        }
        public static VectorShort operator +(VectorShort f1, VectorShort c2)
        {
            Console.WriteLine();
            for (int i = 0; i < f1.ShortArray.Length; i++)
            {
                f1.ShortArray[i] += c2.ShortArray[i];
                Console.Write("[{0}] = {1}\t", (i + 1), f1.ShortArray[i]);
            }
            return f1;
        }
        public static VectorShort operator -(VectorShort f1, VectorShort c2)
        {
            Console.WriteLine();
            for (int i = 0; i < f1.ShortArray.Length; i++)
            {
                f1.ShortArray[i] -= c2.ShortArray[i];
                Console.Write("[{0}] = {1}\t", (i + 1), f1.ShortArray[i]);
            }
            return f1;
        }
        public static VectorShort operator +(VectorShort f1, short c2)
        {
            Console.WriteLine();
            for (int i = 0; i < f1.ShortArray.Length; i++)
            {
                f1.ShortArray[i] += c2;
                Console.Write("[{0}] = {1}\t", (i + 1), f1.ShortArray[i]);
            }
            return f1;
        }
        public static VectorShort operator -(VectorShort f1, short c2)
        {
            Console.WriteLine();
            for (int i = 0; i < f1.ShortArray.Length; i++)
            {
                f1.ShortArray[i] -= c2;
                Console.Write("[{0}] = {1}\t", (i + 1), f1.ShortArray[i]);
            }

            return f1;
        }

        public static VectorShort operator *(VectorShort f1, VectorShort c2)
        {
            Console.WriteLine();
            for (int i = 0; i < f1.ShortArray.Length; i++)
            {
                f1.ShortArray[i] *= c2.ShortArray[i];
                Console.Write("[{0}] = {1}\t", (i + 1), f1.ShortArray[i]);
            }
            return f1;
        }
        public static VectorShort operator /(VectorShort f1, VectorShort c2)
        {
            Console.WriteLine();
            for (int i = 0; i < f1.ShortArray.Length; i++)
            {
                f1.ShortArray[i] /= c2.ShortArray[i];
                Console.Write("[{0}] = {1}\t", (i + 1), f1.ShortArray[i]);
            }
            return f1;
        }
        public static VectorShort operator *(VectorShort f1, short c2)
        {
            Console.WriteLine();
            for (int i = 0; i < f1.ShortArray.Length; i++)
            {
                f1.ShortArray[i] *= c2;
                Console.Write("[{0}] = {1}\t", (i + 1), f1.ShortArray[i]);
            }
            return f1;
        }
        public static VectorShort operator /(VectorShort f1, short c2)
        {
            Console.WriteLine();
            for (int i = 0; i < f1.ShortArray.Length; i++)
            {
                f1.ShortArray[i] /= c2;
                Console.Write("[{0}] = {1}\t", (i + 1), f1.ShortArray[i]);
            }

            return f1;
        }
        public static VectorShort operator <<(VectorShort f1, int c2)
        {
            Console.WriteLine();
            for (int i = 0; i < f1.ShortArray.Length; i++)
            {
                f1.ShortArray[i] = (byte)(c2 << 1); ;// *2
                Console.Write("[{0}] = {1}\t", (i + 1), f1.ShortArray[i]);
            }

            return f1;

        }
        public static VectorShort operator >>(VectorShort f1, int c2)
        {
            Console.WriteLine();
            for (int i = 0; i < f1.ShortArray.Length; i++)
            {
                f1.ShortArray[i] = (byte)(c2 >> 1); // /2
                Console.Write("[{0}] = {1}\t", (i + 1), f1.ShortArray[i]);
            }

            return f1;

        }
        public static bool operator >(VectorShort f1, VectorShort c2)
        {
            bool result = false;
            int index = f1.index;
            for (int i = 0; i < f1.ShortArray.Length; i++)
            {
                if (i == index)
                {
                    if (f1.ShortArray[i] > c2.ShortArray[i])
                        result = true;
                }
            }
            return result;
        }
        public static bool operator <(VectorShort f1, VectorShort c2)
        {
            bool result = false;
            int index = f1.index;
            for (int i = 0; i < f1.ShortArray.Length; i++)
            {

                if (i == index)
                {
                    if (f1.ShortArray[i] < c2.ShortArray[i])
                        result = true;
                }

            }
            return result;
        }
    }

    class MatrixShort
    {
        uint[,] ShortArray;
        int n, m;
        int codeError;
        static int num_m;
        public int index;

        public int Code
        {
            get => codeError;
            set => codeError = value;

        }
        public int Columns
        {
            get => n;
        }
        public int Rows
        {
            get => m;
        }
        public MatrixShort()
        {
            n = 1; m = 1;
            ShortArray = new uint[n, m];
            ShortArray[0, 0] = 0;
        }
        public MatrixShort(int N, int M)
        {
            n = N; m = M;
            ShortArray = new uint[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    ShortArray[i, j] = 0;
            }
        }
        public MatrixShort(int N, int M, uint k)
        {
            n = N; m = M;
            ShortArray = new uint[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    ShortArray[i, j] = k;
            }
        }
        public void Output()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                { Console.Write("[{0}][{1}] = {2}\t", (i + 1), (j + 1), ShortArray[i, j]); }
                Console.WriteLine();
            }
        }
        public void EnterMatrix()
        {
            Console.Write("Enter the numbers of matrix columns: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Enter the numbers of matrix rows: ");
            m = int.Parse(Console.ReadLine());
            ShortArray = new uint[n, m];
            ushort k;
            for (int col = 0; col < n; col++)
            {
                for (int row = 0; row < m; row++)
                {
                    Console.Write("Enter the element of matrix cell [" + (col + 1) + ":" + (row + 1) + "]: ");
                    k = (ushort)Convert.ToInt32(Console.ReadLine());
                    ShortArray[col, row] = k;
                }
            }
        }
        public void Assign_value_par(uint k)
        {
            for (int col = 0; col < n; col++)
            {
                for (int row = 0; row < m; row++)
                {
                    ShortArray[col, row] = k;
                }
            }
        }
        public void Assign_value(VectorShort o)
        {
            for (int col = 0; col < n; col++)
            {
                for (int row = 0; row < m; row++)
                {
                    ShortArray[col, row] = (uint)o.ShortArray_get[col];
                }
            }
        }



        public uint this[int i, int j]
        {
            get
            {
                if (i < 0 || i >= n || j < 0 || j >= m)
                {
                    codeError = -1;
                    return 0;
                }
                else
                {
                    return ShortArray[i, j];
                }
            }
            set
            {
                if (i < 0 || i >= n || j < 0 || j >= m)
                {
                    codeError = (int)value;
                }
                else
                {
                    ShortArray[i, j] = value;
                }
            }
        }
        public static MatrixShort operator ++(MatrixShort o)
        {
            for (int i = 0; i < o.Columns; i++)
            {
                for (int j = 0; j < o.Rows; j++)
                {
                    ++o.ShortArray[i, j];
                }
            }
            return o;
        }
        public static MatrixShort operator --(MatrixShort o)
        {
            for (int i = 0; i < o.Columns; i++)
            {
                for (int j = 0; j < o.Rows; j++)
                {
                    --o.ShortArray[i, j];
                }
            }
            return o;
        }
        public static MatrixShort operator +(MatrixShort o, MatrixShort o2)
        {
            for (int i = 0; i < o.Columns; i++)
            {
                for (int j = 0; j < o.Rows; j++)
                {
                    o.ShortArray[i, j] += o2.ShortArray[i, j];

                }
            }
            return o;
        }
        public static MatrixShort operator -(MatrixShort o, MatrixShort o2)
        {
            for (int i = 0; i < o.Columns; i++)
            {
                for (int j = 0; j < o.Rows; j++)
                {
                    o.ShortArray[i, j] -= o2.ShortArray[i, j];
                }
            }
            return o;
        }
        public static MatrixShort operator -(MatrixShort o, uint o2)
        {
            for (int i = 0; i < o.Columns; i++)
            {
                for (int j = 0; j < o.Rows; j++)
                {
                    o.ShortArray[i, j] -= o2;
                }
            }
            return o;
        }
        public static MatrixShort operator +(MatrixShort o, uint o2)
        {
            for (int i = 0; i < o.Columns; i++)
            {
                for (int j = 0; j < o.Rows; j++)
                {
                    o.ShortArray[i, j] += o2;
                }
            }
            return o;
        }
        public static bool operator !(MatrixShort f1)
        {
            return f1.Columns != 0 && f1.Rows != 0;
        }
        public static bool operator true(MatrixShort f1)
        {
            return f1.Columns != 0 && f1.Rows != 0;
        }
        public static bool operator false(MatrixShort f1)
        {
            return f1.Columns == 0 && f1.Rows == 0;
        }
        public static MatrixShort operator <<(MatrixShort f1, int c2)
        {
            Console.WriteLine();

            for (int i = 0; i < f1.Columns; i++)
            {
                for (int j = 0; j < f1.Rows; j++)
                {
                    f1.ShortArray[i, j] = (byte)(c2 << 1); ;
                    Console.Write("[{0}][{1}] = {2}\t", (i + 1), (j + 1), f1.ShortArray[i, j]);
                }
                Console.WriteLine();
            }

            return f1;

        }
        public static MatrixShort operator >>(MatrixShort f1, int c2)
        {
            Console.WriteLine();
            for (int i = 0; i < f1.Columns; i++)
            {
                for (int j = 0; j < f1.Rows; j++)
                {
                    f1.ShortArray[i, j] = (byte)(c2 >> 1); ;
                    Console.Write("[{0}][{1}] = {2}\t", (i + 1), (j + 1), f1.ShortArray[i, j]);

                }
                Console.WriteLine();
            }
            return f1;
        }
        public static bool operator <(MatrixShort f1, MatrixShort c2)
        {
            int index = f1.index;
            bool result = false;
            Console.WriteLine();
            for (int i = 0; i < f1.Columns; i++)
            {

                for (int j = 0; j < f1.Rows; j++)
                {
                    if (i == index)
                    {
                        if (f1.ShortArray[i, j] < c2.ShortArray[i, j])
                            result = true;
                    }
                }
            }
            return result;
        }
        public static bool operator >(MatrixShort f1, MatrixShort c2)
        {
            int index = f1.index;
            bool result = false;
            Console.WriteLine();
            for (int i = 0; i < f1.Columns; i++)
            {
                for (int j = 0; j < f1.Rows; j++)
                {
                    if (i == index)
                    {
                        if (f1.ShortArray[i, j] > c2.ShortArray[i, j])
                            result = true;
                    }
                }
            }
            return result;
        }
        public static bool operator !=(MatrixShort f1, int k)
        {
            bool result = false;
            for (int i = 0; i < f1.Columns; i++)
            {
                for (int j = 0; j < f1.Rows; j++)
                {
                    if (i == k)
                    {
                        if (f1.ShortArray[i, j] > 5)
                            result = true;
                    }
                }
            }
            return result;
        }
        public static bool operator ==(MatrixShort f1, int k)
        {
            bool result = false;
            for (int i = 0; i < f1.Columns; i++)
            {
                for (int j = 0; j < f1.Rows; j++)
                {
                    if (i == k)
                    {
                        if (f1.ShortArray[i, j] < 5)
                            result = true;
                    }
                }
            }
            return result;
        }
        ~MatrixShort()
        {
            Console.WriteLine("Destructor");
        }
    }


    class Program
    {
        static void Task2()
        {
            Console.WriteLine("Клавiша:\n\"1\" Конструктор без параметрiв\n\"2\" Конструктор iз одним  параметром\n\"3\" Конструктор iз двома параметрами" +
                "\n\"4\" Деструктор\n\"5\" Ввести елементи вектора з клавiатури\n\"6\" Вивести елементи вектора на екран\n\"7\" Присвоєння елементам масиву вектора деякого значення" +
                "\n\"8\" Присвоїти елементам масиву деяке значення (параметр) \n\"9\" Повертає розмiрнiсть вектора (читання)" +
                "\n\"10\" Індексатор, що дозволяє звертатися по iндексу до масиву \n\"11\" Перевантаження унарних операцiї ++ (--)\n\"12\" Перевантаження сталих true & false" +
                " \n\"13\" Перевантаження унарної логiчної операцiї!\n\"14\" Перевантаження арифметичних бiнарнi операцiї \n\"15\" Перевантаження операцiй == та !=" +
                "\n\"16\" Перевантаження порiвняння\n\"0\" Вернутись назад");
            while (true)
            {
                Console.WriteLine("\n\nChoose the one you want to start:");
                int input = Convert.ToInt32(Console.ReadLine());
                if (input == 0) break;
                switch (input)
                {
                    case 1:
                        {
                            Console.WriteLine("Конструктор без параметрiв;");
                            VectorShort v1 = new VectorShort();
                            v1.Output();
                        }
                        break;
                    case 2:
                        {
                            Console.WriteLine("Конструктор iз одним  параметром; ");
                            VectorShort v1 = new VectorShort(3);
                            v1.Output();
                        }
                        break;
                    case 3:
                        {
                            Console.WriteLine("Конструктор iз двома параметрами;");
                            VectorShort v1 = new VectorShort(3, 1);
                            v1.Output();
                        }
                        break;
                    case 4:
                        {
                            VectorShort v1 = new VectorShort(3, 1);
                            v1.Output();
                            Console.WriteLine("\nДеструктор");
                            v1 = null;
                            GC.Collect();
                        }
                        break;
                    case 5:
                        {
                            Console.WriteLine("Ввести елементи вектора з клавiатури;");
                            VectorShort v1 = new VectorShort(3);
                            v1 = new VectorShort();
                            v1.Inn();
                            v1.Output();
                        }
                        break;
                    case 6:
                        {
                            Console.WriteLine("Вивести елементи вектора на екран;");
                            VectorShort v1 = new VectorShort(3, 3);
                            v1.Output();
                        }
                        break;
                    case 7:
                        {
                            Console.WriteLine("Присвоєння елементам масиву вектора деякого значення");

                            VectorShort v1 = new VectorShort(2, 2);
                            v1.Output(); Console.WriteLine();
                            VectorShort v2 = new VectorShort(2, 3);
                            v2.Output(); v2.Assign_value(v1); Console.WriteLine();
                            v2.Output();
                        }
                        break;
                    case 8:
                        {
                            Console.WriteLine("Присвоїти елементам масиву деяке значення (параметр); ");

                            VectorShort v1 = new VectorShort(2, 3);
                            v1.Output(); v1.Assign_value_par(3); Console.WriteLine();
                            v1.Output();
                        }
                        break;
                    case 9:
                        {
                            Console.WriteLine("Повертає розмiрнiсть матрицi (читання); ");
                            VectorShort v1 = new VectorShort(2, 3);
                            Console.WriteLine(v1.N);
                        }
                        break;
                    case 10:
                        {
                            Console.WriteLine("Індексатор, що дозволяє звертатися по iндексу до масиву;");
                            VectorShort v1 = new VectorShort();
                            v1.Inn();
                            v1.Output(); Console.WriteLine();
                            Console.WriteLine(v1[1]);
                        }
                        break;
                    case 11:
                        {
                            Console.WriteLine("Перевантаження унарних операцiї ++ (--) ");
                            VectorShort v1 = new VectorShort();
                            v1.Inn();
                            v1.Output();
                            Console.WriteLine();
                            ++v1; Console.WriteLine();
                            --v1;
                        }
                        break;
                    case 12:
                        {
                            Console.WriteLine("True & false;");
                            VectorShort v1 = new VectorShort(2, 3);
                            v1.Output();
                            if (v1)
                                Console.WriteLine("Size != 0");
                            else Console.WriteLine("Size == 0");

                        }
                        break;
                    case 13:
                        {
                            Console.WriteLine("Перевантаження унарної логiчної операцiї!");

                            VectorShort v1 = new VectorShort(3, 3);
                            v1.Output(); Console.WriteLine();
                            if (!v1)
                                Console.WriteLine("Size != 0");
                            else Console.WriteLine("Size == 0");
                        }
                        break;
                    case 14:
                        {
                            Console.WriteLine("Перевантаження арифметичних бiнарнi операцiї");
                            VectorShort v1 = new VectorShort(2, 3);
                            VectorShort v2 = new VectorShort(2, 5);
                            v1.Output(); Console.WriteLine();
                            v2.Output(); Console.WriteLine(); v1 += v2;
                            Console.WriteLine();

                            Console.WriteLine(v1 << 2);
                            Console.WriteLine(v1 >> 2);
                        }
                        break;
                    case 15:
                        {
                            Console.WriteLine("Перевантаження операцiй == та !=");

                            VectorShort v1 = new VectorShort(3, 3);
                            Console.WriteLine(v1 == 1);
                        }
                        break;
                    case 16:
                        {
                            Console.WriteLine("Перевантаження порiвняння");
                            VectorShort v1 = new VectorShort(2, 3);
                            VectorShort v2 = new VectorShort(2, 5);
                            v1.index = 1;
                            Console.WriteLine(v1 > v2);

                        }
                        break;
                    default:
                        Console.WriteLine("You've chosen a wrong number. There is no such a task");
                        break;
                }
            }
        }

        static void Task3()
        {
            Console.WriteLine("Клавiша:\n\"1\" Конструктор без параметрiв\n\"2\" Конструктор iз двома параметрами\n\"3\" Конструктор iз трьома параметрами" +
               "\n\"4\" Деструктор\n\"5\" Ввести елементи вектора з клавiатури\n\"6\" Вивести елементи вектора на екран\n\"7\" Присвоєння елементам масиву вектора деякого значення" +
               "\n\"8\" Присвоїти елементам масиву деяке значення (параметр) \n\"9\" Повертає розмiрнiсть вектора (читання)" +
               "\n\"10\" Iндексатор з двома iндексами, якi вiдповiдають iндексам масиву \n\"11\" Перевантаження унарних операцiї ++ (--)\n\"12\" Перевантаження сталих true & false" +
               " \n\"13\" Перевантаження унарної логiчної операцiї!\n\"14\" Перевантаження арифметичних бiнарнi операцiї \n\"15\" Перевантаження операцiй == та !=" +
               "\n\"16\" Перевантаження порiвняння\n\"0\" Вернутись назад");
            while (true)
            {
                Console.WriteLine("\n\nChoose the one you want to start:");
                int input = Convert.ToInt32(Console.ReadLine());
                if (input == 0) break;
                switch (input)
                {
                    case 1:
                        {
                            Console.WriteLine("Конструктор без параметрiв");
                            MatrixShort m1 = new MatrixShort();
                            m1.Output();
                        }
                        break;
                    case 2:
                        {
                            Console.WriteLine("Конструктор iз двома параметрами");
                            MatrixShort m1 = new MatrixShort(3, 3);
                            m1.Output();
                        }
                        break;
                    case 3:
                        {
                            Console.WriteLine("3)Конструктор iз трьома параметрами");
                            MatrixShort m1 = new MatrixShort(3, 3, 3);
                            m1.Output();
                        }
                        break;
                    case 4:
                        {
                            MatrixShort m1 = new MatrixShort(3, 2, 4); m1.Output();
                            Console.WriteLine("Деструктор");
                            m1 = null;
                            GC.Collect();
                            Console.ReadKey();
                        }
                        break;
                    case 5:
                        {
                            Console.WriteLine("Ввести елементи вектора з клавiатури");
                            MatrixShort m1 = new MatrixShort();
                            m1.EnterMatrix();
                            m1.Output();
                        }
                        break;
                    case 6:
                        {
                            Console.WriteLine("Вивести елементи вектора на екран");
                            MatrixShort m1 = new MatrixShort(3, 3, 3);
                            m1.Output();
                        }
                        break;
                    case 7:
                        {
                            Console.WriteLine("Присвоєння елементам масиву вектора деякого значення");

                            VectorShort v1 = new VectorShort(2, 3);
                            v1.Output(); Console.WriteLine();
                            MatrixShort m1 = new MatrixShort(2, 3, 3);
                            m1.Output(); m1.Assign_value(v1);
                            m1.Output();
                        }
                        break;
                    case 8:
                        {
                            Console.WriteLine("Присвоїти елементам масиву деяке значення (параметр)");

                            MatrixShort m1 = new MatrixShort(2, 3, 3);
                            m1.Output(); m1.Assign_value_par(3); Console.WriteLine();
                            m1.Output();
                        }
                        break;
                    case 9:
                        {
                            Console.WriteLine("Повертає розмiрнiсть вектора (читання)");
                            MatrixShort m1 = new MatrixShort(2, 3, 3);
                            Console.WriteLine(m1.Columns);
                            Console.WriteLine(m1.Rows);
                        }
                        break;
                    case 10:
                        {
                            Console.WriteLine("Iндексатор з двома iндексами, якi вiдповiдають iндексам масиву ");
                            MatrixShort m1 = new MatrixShort();
                            m1.EnterMatrix();
                            m1.Output();
                            Console.WriteLine(m1[0, 0]);
                        }
                        break;
                    case 11:
                        {
                            Console.WriteLine("Перевантаження унарних операцiї ++ (--) ");
                            MatrixShort m1 = new MatrixShort();
                            m1.EnterMatrix();
                            m1.Output();
                            Console.WriteLine();
                            ++m1; m1.Output();
                        }
                        break;
                    case 12:
                        {
                            Console.WriteLine("Перевантаження сталих true & false");
                            MatrixShort m1 = new MatrixShort(2, 3, 3);
                            m1.Output(); Console.WriteLine();
                            if (m1)
                                Console.WriteLine("Size != 0");
                            else Console.WriteLine("Size == 0");
                        }
                        break;
                    case 13:
                        {
                            Console.WriteLine("Перевантаження унарної логiчної операцiї!");

                            MatrixShort m1 = new MatrixShort(2, 3, 3);
                            m1.Output(); Console.WriteLine();
                            if (!m1)
                                Console.WriteLine("Size != 0");
                            else Console.WriteLine("Size == 0");
                        }
                        break;
                    case 14:
                        {
                            Console.WriteLine("Перевантаження арифметичних бiнарнi операцiї");
                            MatrixShort m1 = new MatrixShort(2, 3, 3);
                            MatrixShort m2 = new MatrixShort(2, 3, 5);
                            m1.Output(); Console.WriteLine();
                            m2.Output(); Console.WriteLine(); m1 += m2; m1.Output();
                            Console.WriteLine(m1 << 2);
                            Console.WriteLine(m1 >> 2);
                        }

                        break;
                    case 15:
                        {
                            Console.WriteLine("Перевантаження операцiй == та != ");
                            MatrixShort m1 = new MatrixShort(2, 3, 3);
                            Console.WriteLine(m1 == 1);
                        }
                        break;
                    case 16:
                        {
                            Console.WriteLine("Перевантаження порiвняння");
                            MatrixShort m1 = new MatrixShort(2, 3, 3);
                            MatrixShort m2 = new MatrixShort(2, 3, 1);
                            m1.index = 1;
                            Console.WriteLine(m1 > m2);
                        }
                        break;
                    default:
                        Console.WriteLine("You've chosen a wrong number. There is no such a task");
                        break;
                }
            }
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\t\tLab 4\nThere are tasks with numbers 1.3, 2.3, 3.3 \nChoose the one you want to start:");
                String task_number = Console.ReadLine();
                switch (task_number)
                {
                    case "1.3":
                        Console.WriteLine("Creating a Rectangle. Input its color, side a and b (all int):");
                        int color = int.Parse(Console.ReadLine()), a = int.Parse(Console.ReadLine()), b = int.Parse(Console.ReadLine());
                        Rectangle r = new Rectangle(a, b, color);
                        Console.WriteLine(r.ToString());
                        Console.WriteLine("\n\tперевiрка iндексатора\nIndex 0 (side a) = " + r[0] + "\n"); //////////////
                        Rectangle r2 = new Rectangle(5, 6, 2);
                        Console.WriteLine("\n\tперевiрка перетворення зi string в obj.:  r2 = (5, 6, 2), r2.ToRectangle(\"3 5 4\") ");///////////
                        Console.WriteLine(r2.ToRectangle("3 5 4"));
                        Console.WriteLine("\n\tперевiрка перегруження операторiв r2++, r2--, r* scalar, false, true ");
                        r2++;
                        r2.GetSideLength();
                        r2--;
                        r2.GetSideLength();
                        Console.WriteLine(r2 * 4);
                        if (r2)
                        {
                            Console.WriteLine(true);
                        }
                        else Console.WriteLine(false);
                        string input;
                        do
                        {
                            Console.WriteLine("Do you want to change sides of your rectangle to see a different result? (Y/N)");
                            input = Console.ReadLine();
                            if (input == "Y" || input == "Yes" || input == "y" || input == "yes")
                            {
                                Console.WriteLine("Input side a and b (all int):");
                                a = int.Parse(Console.ReadLine()); b = int.Parse(Console.ReadLine());
                                r.SetSideLength(a, b);
                                r.GetSideLength(); r.GetAllInfo();
                                Console.WriteLine("Index 0 = " + r[0]);
                            }
                        } while (input == "Y" || input == "Yes" || input == "y" || input == "yes");
                        break;
                    case "2.3":
                        Task2();
                        break;
                    case "3.3":
                        Task3();
                        break;
                    default: Console.WriteLine("You've chosen a wrong number. There is no such a task"); Console.ReadLine(); break;
                }
                Console.ReadLine();
            }
        }
    }
}
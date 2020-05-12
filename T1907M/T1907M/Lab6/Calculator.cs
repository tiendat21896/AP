namespace T1907M.Lab6
{
    public delegate int CalNumber(int a, int b);
    public class Calculator
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Sub(int a, int b)
        {
            return a - b;
        }
        public static int Mul(int a, int b)
        {
            return a * b;
        }

        public static int Div(int a, int b)
        {
            return a / b;
        }

        public static CalNumber Result(string choose)
        {
            if (choose == "Cong")
            {
                return Add;
            }else if (choose == "Tru")
            {
                return Sub;
            }else if (choose == "Nhan")
            {
                return Mul;
            }
            else
            {
                return Div;
            }
        }
    }
}
using System;

namespace calculatrice
{
    public class calcul
    {
        public interface IOperation
        {
            string operation { get; }

            float Operate(float chiffre1, float chiffre2);
        }

        public class addition : IOperation
        {
            public string operation
            {
                get { return "+"; }
            }

            public float Operate(float chiffre1, float chiffre2)
            {
                return chiffre1 + chiffre2;
            }
        }

        public class multiplication : IOperation
        {
            public string operation
            {
                get { return "*"; }
            }

            public float Operate(float chiffre1, float chiffre2)
            {
                return chiffre1 * chiffre2;
            }
        }

        public class division : IOperation
        {
            public string operation
            {
                get { return "/"; }
            }

            public float Operate(float chiffre1, float chiffre2)
            {
                if (chiffre2 != 0)
                {
                    return chiffre1 / chiffre2;
                }
                else
                {
                    Console.WriteLine("division par 0 impossible");
                    return 0;
                }
            }
        }

        public class soustraction : IOperation
        {
            public string operation
            {
                get { return "-"; }
            }

            public float Operate(float chiffre1, float chiffre2)
            {
                return chiffre1 - chiffre2;
            }
        }

        public void Caculate<T>(float a, float b) where T : IOperation, new()
        {
            T operationObj = new T();
            Console.WriteLine(operationObj.Operate(a, b));
        }
    }
}
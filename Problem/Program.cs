using System;

namespace Problem {
    class Program {
        delegate T MathOperation<T>(in T fOperand, in T sOperand);
        static void Main(string[] args) {
            MathOperation<double> operation;
            Console.Write("Введите первое число: ");
            double op1 = double.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            double op2 = double.Parse(Console.ReadLine());
            Console.Write("Введите операцию(+, -, *, /): ");
            string opStr = Console.ReadLine();
    
            operation = opStr switch {
                "+" => Plus<double>,
                "-" => Minus<double>,
                "*" => Multiplication<double>,
                "/" => Division<double>,
                _ => throw new Exception("Неправильный оператор")
            };

            System.Console.WriteLine(operation(op1, op2));
        }

        static T Plus<T>(in T fOperand, in T sOperand) where T : struct {
            dynamic a = fOperand;
            dynamic b = sOperand;
            return a + b;
        }
        static T Minus<T>(in T fOperand, in T sOperand) where T : struct {
            dynamic a = fOperand;
            dynamic b = sOperand;
            return a - b;
        }
        static T Multiplication<T>(in T fOperand, in T sOperand) where T : struct {
            dynamic a = fOperand;
            dynamic b = sOperand;
            return a * b;
        }
        static T Division<T>(in T fOperand, in T sOperand) where T : struct {
            dynamic a = fOperand;
            dynamic b = sOperand;
            return a / b;
        }
    }
}

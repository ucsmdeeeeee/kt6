public enum Operation
{
    Add,
    Subtract,
    Multiply,
    Divide
}

class Programm3
{
    public static void OperationPrint(Operation op)
    {
        switch(op)
        {
            case Operation.Add:
                Console.WriteLine($"{1 + 1}");
                break;
            case Operation.Subtract:
                Console.WriteLine($"{1 - 1}");
                break;
            case Operation.Multiply:
                Console.WriteLine($"{1 * 1}");
                break;
            case Operation.Divide:
                Console.WriteLine($"{1 / 1}");
                break;
            default:
                Console.WriteLine("Операция вне диапазона");
                break;
        }
    }
    public static void Main(string[] args)
    {
        Operation op1 = Operation.Add;
        Operation op2 = Operation.Subtract;
        Operation op3 = Operation.Multiply;
        Operation op4 = Operation.Divide;
        OperationPrint(op1);
        OperationPrint(op2);
        OperationPrint(op3);
        OperationPrint(op4);
    }
}
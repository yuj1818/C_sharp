Calcul calcul = new Calcul();
while (true) {
    calcul.Inputex();
    calcul.Operator();
    Console.WriteLine();
}
class Calcul {
    public string expression, op, num1, num2;
    public double num12, num22;
    public void Inputex() {
        Console.Write("연산자: ");
        op = Console.ReadLine();
        Console.Write("num1: ");
        num1 = Console.ReadLine();
        if (op != "||") {
            Console.Write("num2: ");
            num2 = Console.ReadLine();
        }
        num12 = Convert.ToDouble(num1);
        num22 = Convert.ToDouble(num2);
    }

    public void Operator() {
        switch (op) {
            case "+":
                Console.WriteLine($"{num12} + {num22} = {num12 + num22}");
                break;
            case "-":
                Console.WriteLine($"{num12} - {num22} = {num12 - num22}");
                break;
            case "*":
                Console.WriteLine($"{num12} * {num22} = {num12 * num22}");
                break;
            case "/":
                if (num22 == 0) {
                    Console.WriteLine("0으로는 나눌 수 없습니다.");
                } 
                else {
                    Console.WriteLine($"{num12} / {num22} = 몫: {num12 / num22}, 나머지: {num12 % num22}");
                }
                break;
            case "^":
                Console.WriteLine($"{num12} ^ {num22} = {Math.Pow(num12,num22)}");
                break;
            case "||":
                Console.WriteLine($"|{num12}| = {Math.Abs(num12)}");
                break;
            default:
                Console.WriteLine("연산자가 잘못 입력되었습니다.");
                break;

        }
    }
}
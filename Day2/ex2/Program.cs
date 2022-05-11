// See https://aka.ms/new-console-template for more information

Console.Write("숫자 1 : ");
String num1 = Console.ReadLine();
Console.Write("숫자 2 : ");
String num2 = Console.ReadLine();

int a = Convert.ToInt32(num1);
int b = Convert.ToInt32(num2);

Console.WriteLine("두 수의 합: {0}", Add(a, b));
Console.WriteLine("큰 값: {0}", Max(a, b));
Console.WriteLine("작은 값: {0}", Min(a, b));
Console.WriteLine("절대값: {0} , {1}", absol(a), absol(b));

int Add(int a, int b) {
    return a+b;
}

int Max(int a, int b) {
    if (a < b) {
        return b;
    }
    else {
        return a;
    }
}

int Min(int a, int b) {
    if (a < b) {
        return a;
    } else {
        return b;
    }
}

int absol(int a) {
    if (a < 0) {
        return (a * -1);
    } else {
        return a;
    }
}
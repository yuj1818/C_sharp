// See https://aka.ms/new-console-template for more information

while (true) {
    Console.Write("수를 입력하시오: ");
    string number = Console.ReadLine();
    int num = Convert.ToInt32(number);

    if (num % 2 == 0) {
        Console.WriteLine("짝수입니다.");
    } else {
        Console.WriteLine("홀수입니다.");
    }
}

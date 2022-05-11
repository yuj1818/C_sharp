while (true) {
    Random random = new Random();
    string[] motion = new string[] { "가위", "바위", "보" };
    string computer = motion[random.Next(0, motion.GetLength(0))];

    Console.Write("가위, 바위, 보 중 하나를 골라주세요: ");
    string user = Console.ReadLine();

    Console.WriteLine($"User: {user}");
    Console.WriteLine($"Computer: {computer}");

    if (user == "가위") {
        if (computer == "바위") {
            Console.WriteLine("Lose");
        } else if (computer == "보") {
            Console.WriteLine("Win");
        } else {
            Console.WriteLine("Draw");
        }
    } else if (user == "바위") {
        if (computer == "보") {
            Console.WriteLine("Lose");
        } else if (computer == "가위") {
            Console.WriteLine("Win");
        } else {
            Console.WriteLine("Draw");
        }
    } else {
        if (computer == "가위") {
            Console.WriteLine("Lose");
        } else if (computer == "바위") {
            Console.WriteLine("Win");
        } else {
            Console.WriteLine("Draw");
        }
    }
}
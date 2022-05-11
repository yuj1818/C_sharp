int[] lotto = new int[6];

Random random = new Random();
for (int i = 0; i < 6; i++) {
    int num = random.Next(1,46);
    if (lotto.Contains(num)) {
        i -= 1;
    }
    else {
        lotto[i] = num;
    }
}

Console.WriteLine("로또 번호 생성기");
for (int j = 0; j < lotto.GetLength(0); j++) {
    Console.Write($"{lotto[j]} ");
}
Console.WriteLine();
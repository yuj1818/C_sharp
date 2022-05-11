// See https://aka.ms/new-console-template for more information
int i = 0;
float[] person = new float[5];
char[] grad = new char[5];
for(i = 0; i < person.GetLength(0); i++)
{
    Console.Write("국어 : ");
    String korean = Console.ReadLine();
    Console.Write("영어 : ");
    String english = Console.ReadLine();
    Console.Write("수학 : ");
    String math = Console.ReadLine();

    int a = Convert.ToInt32(korean);
    int b = Convert.ToInt32(english);
    int c = Convert.ToInt32(math);

    int total = a + b + c;
    float average = (float)total / 3;

    person[i] = average;

    char grade;
    switch (average)
    {
        case >= 90:
            grade = 'A';
            break;
        case >= 80:
            grade = 'B';
            break;
        case >= 70:
            grade = 'C';
            break;
        case >= 60:
            grade = 'D';
            break;
        default:
            grade = 'F';
            break;
    }
    grad[i] = grade;
    //Console.WriteLine("person[{0}]", i);
    //Console.WriteLine("평균: {0}, 학점 : {1}", Math.Round(average, 2), grade);
}

for(int j = 0; j < 5; j++)
{
    Console.WriteLine("person[{0}]", j);
    Console.WriteLine("평균: {0}, 학점 : {1}", person[j],grad[j]); 
}
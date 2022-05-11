// See https://aka.ms/new-console-template for more information
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
float average = total / 3;
Console.WriteLine("총점 : {0}", total);
Console.WriteLine("평균 : {0}", Math.Round(average,2));


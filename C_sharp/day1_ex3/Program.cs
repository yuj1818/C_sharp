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
float average = (float)total / 3;
char grade;
if (average >= 90)
{
    grade = 'A';
}
else if(average >= 80)
{
    grade = 'B';
}
else if(average >= 70)
{
    grade = 'C';
}
else if(average >= 60)
{
    grade = 'D';
}
else
{
    grade = 'F';
}
Console.WriteLine("총점 : {0}", total);
Console.WriteLine("평균 : {0}", Math.Round(average, 2));
Console.WriteLine("학점 : {0}", grade);


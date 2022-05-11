// See https://aka.ms/new-console-template for more information

Dog dog = new Dog();
dog.Bark();
//dog.Display();

Console.WriteLine("eyes_ = {0}", dog.GetEyes());

Dog dog2 = new Dog(2,1,1,2);
//dog2.Display();
dog2.SetEyes(4);
//Console.WriteLine("setEyes = {0}", dog2.GetEyes());

//Person person = new Person(25,"손유정", "여");
////person.Display();
//person.Setage(26);
//Console.WriteLine("age : {0}", person.Getage());

class Dog {
    private int eyes, nose, mouse, ears;
    public void Bark() {
        Console.WriteLine("멍멍");
    }

    public Dog() {  //생성자, 동일한 이름의 생성자가 여러 개 만들어 질 수 있음. 
                    //하지만 매개변수는 항상 달라야 함.
        eyes = 0;
        nose = 0;
        mouse = 0;
        ears = 0;
    }

    public Dog(int eyes, int nose, int mouse, int ears) {
        this.eyes = eyes;   //this.을 사용하면 해당 클래스 안의 변수를 가르킴
        this.nose = nose;
        this.mouse = mouse;
        this.ears = ears;
    }

    public void Display() {
        Console.WriteLine("eyes = {0}", eyes);
        Console.WriteLine("nose = {0}", nose);
        Console.WriteLine("mouse = {0}", mouse);
        Console.WriteLine("ears = {0}", ears);
    }

    public int GetEyes() {
        return this.eyes;
    }

    public int GetMouse() {
        return this.mouse;
    }

    public int GetNose() {
        return this.nose;
    }

    public int Getears() {
        return this.ears;
    }

    public void SetEyes(int eyes) {
        this.eyes = eyes;
    }

    public void SetMouse(int mouse) {
        this.mouse = mouse;
    }

    public void SetNose(int nose) {
        this.nose = nose;
    }

    public void SetEars(int ears) {
        this.ears = ears;
    }
}

//class Person {
//    private string name, gender;
//    private int age;
//    public Person() {
//        name = "";
//        age = 0;
//        gender = "";
//    }

//    public Person(int age, string name, string gender) {
//        this.age = age;
//        this.name = name;
//        this.gender = gender;
//    }

//    public void Display() {
//        Console.WriteLine("나이: {0}", age);
//        Console.WriteLine("이름: {0}", name);
//        Console.WriteLine("성별: {0}", gender);
//    }
//    public int Getage() {
//        return this.age;
//    }

//    public string Getname() {
//        return this.name;
//    }

//    public string Getgender() {
//        return this.gender;
//    }

//    public void Setage(int age) {
//        this.age = age;
//    }

//    public void Setname(string name) {
//        this.name = name;
//    }

//    public void Setgender(string gender) {
//        this.gender = gender;
//    }
//}
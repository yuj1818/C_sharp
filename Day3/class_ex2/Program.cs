// See https://aka.ms/new-console-template for more information

Dog dog = new Dog();
dog.Bark();
//dog.Display();

Console.WriteLine("eyes_ = {0}", dog.GetEyes());

Dog dog2 = new Dog(2, 1, 1, 2);
//dog2.Display();
dog2.SetEyes(4);
//Console.WriteLine("setEyes = {0}", dog2.GetEyes());

Buldok buldok = new Buldok();
buldok.BuldokInformation();

public class Dog {
    protected int eyes, nose, mouse, ears;
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

public class Buldok:Dog {
    private string kind;
    public Buldok() {
        base.eyes = 0;   //상속받은 변수는 앞에 base.를 붙여줘야 한다.
        base.nose = 0;   //상속받은 변수는 앞에 base.를 붙여줘야 한다.
        base.mouse = 0;  //상속받은 변수는 앞에 base.를 붙여줘야 한다.
        base.ears = 0;   //상속받은 변수는 앞에 base.를 붙여줘야 한다.
        this.kind = "불독";
    }

    public void BuldokInformation() {
        Console.WriteLine("Buldok eyes = {0}", base.eyes);
        Console.WriteLine("Buldok nose = {0}", base.nose);
        Console.WriteLine("Buldok mouse = {0}", base.mouse);
        Console.WriteLine("Buldok ears = {0}", base.ears);
        Console.WriteLine("Buldok kind = {0}", kind);
    }

    public void BuldokBark() {
        Console.WriteLine("으르렁");
    }

    public string GetKind() {
        return this.kind;
    }
}
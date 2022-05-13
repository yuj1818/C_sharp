Person person = new Person();
person.InputInfo();
while (true) {
    if (person.GetId() == "exit") {
        break;
    }
    person.FindInfo();
}
class Person {
    private string id;
    string[] name_array = new string[5];
    string[] id_array = new string[5];
    string[] book_name_array = new string[5];
    string[] bdate_array = new string[5];
    string[] rdate_array = new string[5];

    public void InputInfo() {
        Console.WriteLine("회원 정보를 입력해주세요");
        Console.WriteLine();
        for (int i = 0; i < 5; i++) {
            Console.WriteLine($"회원{i+1}");
            Console.WriteLine("=============================");
            Console.Write("이름: ");
            name_array[i] = Console.ReadLine();
            Console.Write("ID: ");
           id_array[i] = Console.ReadLine();
            Console.Write("책 이름: ");
            book_name_array[i] = Console.ReadLine();
            Console.Write("대여 일자: ");
            bdate_array[i] = Console.ReadLine();
            Console.Write("반납 기일: ");
            rdate_array[i] = Console.ReadLine();
            Console.WriteLine();
        }
    }

    public void FindInfo() {
        Console.Write("찾고자 하는 회원의 ID를 입력해주세요(exit 입력 시 종료): ");
        id = Console.ReadLine();
        if (Array.Exists(id_array, x => x == id) == true) {
            int index = Array.IndexOf(id_array, id);
            Console.WriteLine($"이름: {name_array[index]}");
            Console.WriteLine($"ID: {id_array[index]}");
            Console.WriteLine($"책 이름: {book_name_array[index]}");
            Console.WriteLine($"대여 일자: {bdate_array[index]}");
            Console.WriteLine($"반납 기일: {rdate_array[index]}");
            Console.WriteLine();
        } 
        else if(id == "exit") {
            return;
        }
        else {
            Console.WriteLine("해당 회원 없음");
            Console.WriteLine();
        }
    }

    public string GetId() {
        return this.id;
    }
}
Calcul calcul = new Calcul();
calcul.Operator();
class Calcul {
    private string expression;
    private int intsum, intab;
    private double doublesum, doubleab;

    public void Operator() {
        Console.Write("수식을 입력하세요: ");
        expression = Console.ReadLine();
        double[] doublenum = new double[2];
        int[] intnum = new int[2];

        if (expression.Contains('+')) {
            string[] nums = expression.Split('+');
            for (int i = 0; i < nums.GetLength(0); i++) {
                if (nums[i].Contains('.')) {
                    doublenum[i] = Convert.ToDouble(nums[i]);
                } else {
                    intnum[i] = Convert.ToInt32(nums[i]);
                }
            }
            if (doublenum[0] == 0 && doublenum[1] == 0) {
                for (int j = 0; j < 2; j++) {
                    intsum += intnum[j];
                }
                Console.WriteLine($"{intnum[0]} + {intnum[1]} = {intsum}");
            } else {
                for (int k = 0; k < 2; k++) {
                    doublesum += doublenum[k];
                }
                Console.WriteLine($"{doublenum[0]} + {doublenum[1]} = {doublesum}");
            }
        } 
        else if (expression.Contains('|')) {
             string nums = expression.Replace("|", string.Empty);
            if (nums.Contains("-")) {
                Console.WriteLine($"절댓값: {nums.Replace("-", string.Empty)}");
            } else {
                Console.WriteLine($"절댓값: {nums}");
            }
        } else if (expression.Contains('*')) {
            string[] nums = expression.Split('*');
            for (int i = 0; i < nums.GetLength(0); i++) {
                if (nums[i].Contains('.')) {
                    doublenum[i] = Convert.ToDouble(nums[i]);
                } else {
                    intnum[i] = Convert.ToInt32(nums[i]);
                }
            }
            if (doublenum[0] == 0 && doublenum[1] == 0) {
                Console.WriteLine($"{intnum[0]} * {intnum[1]} = {intnum[0] * intnum[1]}");
            } else {
                Console.WriteLine($"{doublenum[0]} * {doublenum[1]} = {doublenum[0] * doublenum[1]}");
            }
        } 
        else if (expression.Contains('/')) {
            string[] nums = expression.Split('/');
            if (nums[1] == "0") {
                Console.WriteLine("0으로는 나눌 수 없습니다.");
            }
            for (int i = 0; i < nums.GetLength(0); i++) {
                if (nums[i].Contains('.')) {
                    doublenum[i] = Convert.ToDouble(nums[i]);
                } else {
                    intnum[i] = Convert.ToInt32(nums[i]);
                }
            }
            if (doublenum[0] == 0 && doublenum[1] == 0) {
                Console.WriteLine($"{intnum[0]} / {intnum[1]} = 몫: {intnum[0] / intnum[1]}, 나머지: {intnum[0] % intnum[1]}");
            } else {
                Console.WriteLine($"{doublenum[0]} / {doublenum[1]} = 몫: {doublenum[0] / doublenum[1]}, 나머지: {doublenum[0] % doublenum[1]}");
            }
        } 
        else if (expression.Contains('^')) {
            string[] nums = expression.Split('^');
            for (int i = 0; i < nums.GetLength(0); i++) {
                if (nums[i].Contains('.')) {
                    doublenum[i] = Convert.ToDouble(nums[i]);
                } else {
                    intnum[i] = Convert.ToInt32(nums[i]);
                }
            }
            if (doublenum[0] == 0 && doublenum[1] == 0) {
                Console.WriteLine($"{intnum[0]} ^ {intnum[1]} = {Math.Pow(intnum[0], intnum[1])}");
            } else {
                Console.WriteLine($"{doublenum[0]} ^ {doublenum[1]} = {Math.Pow(doublenum[0], doublenum[1])}");
            }
        } 
        else if (expression.Contains('-')) {
            string[] nums = expression.Split('-');
            
            for (int i = 0; i < nums.GetLength(0); i++) {
                if (nums[i].Contains('.')) {
                    doublenum[i] = Convert.ToDouble(nums[i]);
                } else {
                    intnum[i] = Convert.ToInt32(nums[i]);
                }
            }
            if (doublenum[0] == 0 && doublenum[1] == 0) {
                Console.WriteLine($"{intnum[0]} - {intnum[1]} = {intnum[0]-intnum[1]}");
            } else {
                Console.WriteLine($"{doublenum[0]} - {doublenum[1]} = {doublenum[0]-doublenum[1]}");
            }
        } 
    }
}
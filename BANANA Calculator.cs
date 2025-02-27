using System;
class BananaCalculator
{
    static void Main()
    {
        Console.WriteLine("BANANA計算機(二進数)_BANANA Calculator(Binary)");
        while (true)
        {
            string bin1 = GetBinaryInput("1個目の二進数を入力_First Binary Number(BA=1, NA=0): ");
            string bin2 = GetBinaryInput("2個目の二進数を入力_Second Binary Number(BA=1, NA=0): ");
            int num1 = Convert.ToInt32(bin1, 2);
            int num2 = Convert.ToInt32(bin2, 2);
            Console.WriteLine($"入力された値_Input Number: {bin1} と {bin2}");
            Console.WriteLine("選択_Select:");
            Console.WriteLine("1: 加算_Addition");
            Console.WriteLine("2: 減算_Subtraction");
            Console.WriteLine("3: 乗算_Multiplication");
            Console.WriteLine("4: 除算_Division");
            Console.Write("計算方法を決定(Number)_Select calculate method(Number): ");
            int choice = int.Parse(Console.ReadLine());
            int result;
            string operation = "";
            switch (choice)
            {
                case 1:
                    result = num1 + num2;
                    operation = "＋";
                    break;
                case 2:
                    result = num1 - num2;
                    operation = "－";
                    break;
                case 3:
                    result = num1 * num2;
                    operation = "×";
                    break;
                case 4:
                    if (num2 == 0)
                    {
                        Console.WriteLine("NAで割ることはできません_Cannot divide by 0");
                        continue;
                    }
                    if (num1 == 0)
                    {
                        Console.WriteLine("NAで割ることはできません_Cannot divide by 0");
                        continue;
                    }
                    result = num1 / num2;
                    operation = "÷";
                    break;
                default:
                    Console.WriteLine("無効な選択_Invalid Select");
                    continue;
            }
            string binaryResult = Convert.ToString(result, 2);
            string formattedResult = "";
            foreach (char c in binaryResult)
            {
                formattedResult += (c == '0') ? "NA" : "BA";
            }
            Console.WriteLine($"計算過程_Calculation process: {num1} {operation} {num2} = {formattedResult}");
            Console.WriteLine($"結果_Result: {formattedResult}");
            Console.Write("もう一度計算しますか?_One more calculation? (Y/N): ");
            string again = Console.ReadLine().Trim().ToUpper();
            if (again != "Y")
            {
                Console.WriteLine("終了します_Exit");
                break;
            }
        }
    }
    static string GetBinaryInput(string message)
    {
        while (true)
        {
            Console.Write(message);
            string input = Console.ReadLine();
            if (input.Length > 0 && input.Replace("BA", "").Replace("NA", "").Length == 0)
            {
                return input.Replace("BA", "1").Replace("NA", "0");
            }
            Console.WriteLine("BAとNAのみを使用してください_Use BA and NA only");
        }
    }
}

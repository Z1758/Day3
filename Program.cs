namespace Day3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region 과제1

            string nameInput;
            Console.WriteLine("이름 입력");
            
            nameInput = Console.ReadLine();

            //자리 표시자
            Console.WriteLine("{0}님, 반갑습니다.", nameInput);

            #endregion

            #region 과제2

            float fNum1;
            float fNum2;
                                  
            Console.WriteLine("첫 번째 실수를 입력하여 주세요");
            float.TryParse(Console.ReadLine(), out fNum1);

            Console.WriteLine("두 번째 실수를 입력하여 주세요");
            float.TryParse(Console.ReadLine(), out fNum2);   

            Console.WriteLine("두 수의 합은 {0} 입니다", fNum1+fNum2);

            #endregion

            #region 과제3

            int iNum1;
            int iNum2;

            Console.Write("나눗셈을 진행할 첫 번째 수를 입력하여 주세요: ");
            int.TryParse(Console.ReadLine(), out iNum1);

            Console.Write("두번째 나눌 수를 입력해주세요: ");
            int.TryParse(Console.ReadLine(), out iNum2);

            //문자열 보간 $
            Console.WriteLine($"{iNum1}와 {iNum2}의 나눗셈 결과, 몫은 {iNum1 / iNum2} 나머지는 {iNum1 % iNum2}");

            #endregion

            #region 과제4

            int threeNum1;
            int threeNum2;
            int threeNum3;

            string testString;

            //Parse
            Console.WriteLine("첫째 정수 입력");
            testString = Console.ReadLine();
            threeNum1 = int.Parse(testString);

            //TryParse
            Console.WriteLine("둘째 정수 입력");
            int.TryParse(Console.ReadLine(), out threeNum2);

            //Convert
            Console.WriteLine("셋째 정수 입력");
            testString = Console.ReadLine();
            threeNum3 = Convert.ToInt32(testString);

            Console.WriteLine($"첫째수 더하기 둘째수에 셋째수를 곱한 값은 {(threeNum1+threeNum2)*threeNum3} 입니다.");

            #endregion
        }
    }
}

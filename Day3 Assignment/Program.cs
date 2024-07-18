using System;

namespace Day3_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 과제1
            int successCount;
            bool exceptionFlag;

            Console.WriteLine("성공한 갯수를 입력하여 주세요");

            exceptionFlag = int.TryParse(Console.ReadLine(), out successCount);
            if (exceptionFlag)
            {
                if (successCount > 100)
                {
                    Console.WriteLine("100 초과 예외처리");
                }
                else if (successCount == 100)
                {
                    Console.WriteLine("SS 등급입니다.");
                }
                else if (successCount >= 90)
                {
                    Console.WriteLine("S 등급입니다.");
                }
                else if (successCount >= 70)
                {
                    Console.WriteLine("A 등급입니다.");
                }
                else if (successCount >= 40)
                {
                    Console.WriteLine("B 등급입니다.");
                }
                else
                {
                    Console.WriteLine("F 등급입니다.");
                }


                /*
                
                else if (successCount >= 0)
                {
                    Console.WriteLine("F 등급입니다.");
                }
                else
                {
                    Console.WriteLine("0 미만 예외처리");
                }

                */
            }
            else
            {
                Console.WriteLine("바른 수 입력 예외처리");
            }

            #endregion

            #region 심화 과제2
            int num;
          
            Console.WriteLine("정수 입력");

            int.TryParse(Console.ReadLine(), out num);

            Console.WriteLine();

            //if문
            Console.WriteLine("if문");
            if (num == 1)
            {
                Console.WriteLine("Cocked Pistol 발령");
            }
            else if (num == 2)
            {
                Console.WriteLine("Fast Pace 발령");
            }
            else if (num == 3)
            {
                Console.WriteLine("Round House 발령");
            }
            else
            {
                Console.WriteLine("비상 태세");
            }

            Console.WriteLine();

            //switch문
            Console.WriteLine("switch문");
            switch (num)
            {
                case 1:
                    Console.WriteLine("Cocked Pistol 발령");
                    break;
                case 2:
                    Console.WriteLine("Fast Pace 발령");
                    break;
                case 3:
                    Console.WriteLine("Round House 발령");
                    break;

                default:
                    Console.WriteLine("비상 태세");
                    break;
            }
            #endregion
        }
    }
}

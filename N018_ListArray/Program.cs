using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//05-13
namespace N018_ListArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            
            for (int i = 0; i < 10; i++)
            {
                int a = r.Next();
                int b = r.Next(100);
                int c = r.Next(10, 20);
                double d = r.NextDouble();

                Console.WriteLine("{0,10},{1,10},{2,10},{3,10:F3}", a, b, c, d);
            }

            //두개의 주사위를 100번 던져서 합이 얼마인지 출력하라.
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(r.Next(1, 6) + r.Next(1, 6));
            }

             for(int i = 0; i < 100; i++)
            {
                int x = r.Next(1, 7);
                int y = r.Next(1, 7);

                int sum = x + y;
                Console.WriteLine("{0},{1},{2}",x,y,sum);
            }

            //두개의 주사위를 1000000번 던져서 각각의 합이 몇번씩 나왔는지를 출력하시오.
            int []array = new int[13];
            int []ar = new int[13];
            Console.WriteLine("a");
            for (int i = 0; i < 100; i++)
            {
                ar[r.Next(1, 7) + r.Next(1, 7)]++;
            }

            for (int i = 2; i < 13; i++)
            {
                Console.WriteLine("{0,2} : {1}", i, ar[i]);
            }

                for (int i = 0; i < 1000000; i++)
                {
                    array[r.Next(1, 7) + r.Next(1, 7)]++;
                }

                for (int i = 2; i < 13; i++)
                {
                    Console.WriteLine("{0,2} : {1}", i, array[i]);
                }
            Console.WriteLine("foreach array");
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("foreach:ar");
            foreach (var item in ar)
            {
                Console.WriteLine(item);
            }

            //리스트 : Generic <T> List<T>
            List<int> lst = new List<int>();
            List<int> lst1 = new List<int>();

            for (int i = 0; i < 100; i++)
            {
                lst1.Add(r.Next(100));
            }

            foreach (var item in lst1)
            {
                Console.WriteLine(item);
            }

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(lst1[i]);
            }

            for (int i = 0; i < 10; i++)
            {
                lst.Add(r.Next(100));
            }
            foreach (var item in lst)
                Console.WriteLine(item);

            Console.WriteLine("for array");

            for (int i = 0; i <10; i++)
            {
                Console.WriteLine(lst[i]);
            }

            //문자열 배열s1과 문자열 리스트 s2를 만드시오
            //문자열 10개를 콘솔에서 입력받아 배열과 리스트에 저장하시오

            Console.WriteLine("문자열 10개를 입력하세요");
            string[] s1 = new string[10];
            List<string> s2 = new List< string >();

            for (int i = 0; i < 10; i++)
            {
                string s=Console.ReadLine();
                s1[i] = s;
                s2.Add(s);

            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0,20}  {1,20}", s1[i], s2[i]);
            }

            //정렬하여 출력하기
            Array.Sort(s1);  //배열
            s2.Sort();       //리스트

  
            Console.WriteLine("배열과 리스트 정렬후 출력");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0,20}  {1,20}", s1[i], s2[i]);
            }
        }
    }
}


using ConsoleApp1;
using System.Collections;
using System.Numerics;

namespace CSharpTutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            /* List<String> list = solution.printNumber();
             Console.WriteLine(String.Join(",", list));*/

            /*Console.WriteLine(solution.getNode(">>>>>>>>>><^^vvv"));*/

            Fibonacci fibonacci = new Fibonacci();
            /*Console.WriteLine(fibonacci.Fib1(100));*/
            Console.WriteLine(fibonacci.FibWithDynamic(100));
        }
    }

    class Solution
    {
        public List<String> printNumber ()
        {
            List<String> result = new List<string>();

            for (int i = 1; i<=100; i++)
            {
                var str = "";
                if (i % 3 == 0 )
                {
                    str += "Leon";
                    
                } 
                if (i % 5 ==0 )
                {
                    str += "teq";
                }
                
                else
                {
                    str = i.ToString();
                }

                result.Add(str);
            }
            return result;
        }

        public int getNode(String input)
        {
            var startPoint = new Point(0, 0);

            HashSet<String> visited = new HashSet<String>();

            foreach (char c in input)
            {
                switch (c)
                {
                    case '>':
                        startPoint.x++;
                        break;
                    case '<':
                        startPoint.x--;
                        break;
                    case '^':
                        startPoint.y++;
                        break;
                    case 'v':
                        startPoint.y--;
                        break;
                    default:
                        break;
                }

                visited.Add(startPoint.x.ToString() + "," + startPoint.y.ToString());

            }

            return visited.Count;

        }

    }

    public class Point
    {
        public int x;
        public int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    

}
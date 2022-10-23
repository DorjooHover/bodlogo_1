using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bodlogo_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();

            List<int> num = PrimaryNumber(int.Parse(n));
            for (int i = 0; i < num.Count; i++)
            {
                Console.WriteLine(num[i] );
            }
        }

        static List<int> PrimaryNumber(int num)
        {
            List<int> nums = new List<int>();

            for(int j = 2; j <= num; j++)
            {
                if(j == 2)
                {
                    nums.Add(j);
                }
                else
                {
                    int i = 2, check = 0 ;
                    while (i < j)
                    {
                        if( j % i == 0)
                        {
                            check++;
                            break;
                        }
                        i++;
                    }
                    if (check == 0 && )
                    {
                        nums.Add(i);
                    }
                    
                }
            }
            return nums;
        }
    }
}

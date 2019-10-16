using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = 0;

            for(var deep = 0; ; deep++)
            {
                var levelSum = (int)Math.Pow(5.0, deep * 1.0f);
                //sum += levelSum;
                sum += levelSum - (int)(5 * 0.6 * 5); // 假设每层的发展率为60%，40%放弃就行发展下线。
                Console.WriteLine($"层={deep},\t\t本层总人数={string.Format("{0:0,0}", levelSum)}人, \t总计={string.Format("{0:0,0}", sum)}人");
                //Console.WriteLine($"{deep} {string.Format("{0:0,0}", levelSum)} {string.Format("{0:0,0}", sum)}");
                if (deep == 10)
                    break;
            }
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class TestClass
    {
        public static void GetNormalValue(int id)
        {
            id += 1;
        }

        public static void GetNormalValueOut(out int outPara)
        {
            outPara = 780000;

            var newItem = outPara + outPara + outPara + 500;
            return;
        }

        public static void GetNextName(ref int id)
        {            

            //insert
            //update

            //calculation
            id =id+ 1;            
        }

        public static T GetQueryString<T>(string key, T defaultValue) 
        { 
        
        }

        static void Main(string[] args)
        {
            //normal
            int k = 100;
            GetNormalValue(k);
            Console.WriteLine("Previous value of integer k:" + k.ToString());

            //ref
            int i = 1;
            Console.WriteLine("Previous value of integer i:" + i.ToString());
            GetNextName(ref i);
            Console.WriteLine("Current value of integer i:" + i.ToString());

            //out
            int outParam=1000;
            GetNormalValueOut(out outParam);

            Console.WriteLine("Current value of integer i:" + outParam.ToString());
        }
    }
  
}

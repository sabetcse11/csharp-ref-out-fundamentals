using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //namespace DoFactory.GangOfFour.Prototype.Structural
    //{
        #region Singleton
        public class Singleton
        {
            private static Singleton instance;
            public static Singleton GetInstance()
            {
                if (instance == null)
                {
                    instance = new Singleton();
                    return instance;
                }
                return instance;
            }
        }
        public class Program
        {
            static void Main()
            {
                Singleton singleton = Singleton.GetInstance();
                Singleton singleton2 = Singleton.GetInstance();
                var hashCode1 = singleton.GetHashCode();
                var hashCode2 = singleton.GetHashCode();
                Console.WriteLine("hashCode1:{0}", hashCode1);
                Console.WriteLine("hashCode1:{0}", hashCode2);
                Console.ReadKey();
            }
        }
        #endregion
    }
//}

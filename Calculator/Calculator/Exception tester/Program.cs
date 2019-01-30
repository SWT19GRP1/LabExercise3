using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_tester
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Course for new ship? ");
            var course = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("");

            try
            {
                var ship = new Ship(course);
                Console.WriteLine("Ship is heading course {0}", ship.GetCourse());
            }
            catch (Exception)
            {
                Console.WriteLine("Error in course!");
            }
        }
    }
    public class Ship
    {
         private readonly uint _course;
    public Ship(uint initialCourse)
    {
    if (initialCourse < 360)
    _course = initialCourse;
    else
    throw new Exception();
    }

    public uint GetCourse()
    {
        return _course;
    }
}

}

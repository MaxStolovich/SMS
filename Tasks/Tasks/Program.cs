using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    class Program
    {
        public static Line[] myLines = new Line[Int32.Parse(Console.ReadLine())];
        static Line[] Li = new Line[myLines.Length];

        public static void Main(string[] args)
        {
            StartProgram(ref myLines, out Li);

            Console.ReadKey();

        }
       



        static void StartProgram(ref Line[] L, out Line[] Li)
        {
            for (int i = 0; i<L.Length; i++)
            {
                string[] points = Console.ReadLine().Trim().Split();
                L[i].begin = Int32.Parse(points[0]);
                L[i].end = Int32.Parse(points[1]);
            }
            Li = L;
        }
    }


    public class Line : IComparable
    {
        public int begin;
        public int end;

        public Line(int a, int b)
        {
            this.begin = a;
            this.end = b;
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Line otherLine = obj as Line;
            if (otherLine != null)
                return this.end.CompareTo(otherLine.end);
            else
                throw new ArgumentException("Object is not a Line");
            
        }
    }
}

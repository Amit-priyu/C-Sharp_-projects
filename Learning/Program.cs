// See https://aka.ms/new-console-template for more inofrmation
namespace ArrayDemo
{
   class Employ
    {
        public void show(int empno,out string empname,out double basic)
        {
            if (empno == 1)
            {
                empname = "amit";
                basic = 1848;
            }
            else if(empno == 3) {
                empname = "shivem";
                basic = 38384;
            }
            else
            {
                empname = "Not found";
                basic = 0;
            }
        }
    }
   class Program
    {
        static void Main(string[] args)
        {
            int empno;
            string name;
            double basic;
            empno = Convert.ToInt32(Console.ReadLine());

            Employ emp = new Employ();
            emp.show(empno, out name, out basic);
        }
    }
}
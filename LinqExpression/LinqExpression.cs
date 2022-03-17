using System;
using System.Linq.Expressions;



namespace LinqExpression
{
    class LinqExpression
    {
        static void Main(string[] args)
        {
            Expression<Func<Student, bool>> isTeenAgerExpr = s => s.Age > 12 && s.Age < 20;

            
            Func<Student, bool> isTeenAger = isTeenAgerExpr.Compile();

            //Invoking
            bool result = isTeenAger(new Student() { StudentID = 1, StudentName = "Steve", Age = 20 });
            

            Console.WriteLine(result);

            

        }
    }

    public class Student
    {

        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
    }
}

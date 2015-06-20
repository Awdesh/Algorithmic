using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class LINQSample
    {
        public class Student
        {
            public string First { get; set; }
            public string Last { get; set; }
            public int ID { get; set; }
            public List<int> Scores;
        }

        // Create a data source by using a collection initializer. 
        public static List<Student> students = new List<Student>
        {
            new Student {First="Svetlana", Last="Omelchenko", ID=111, Scores= new List<int> {97, 92, 81, 60}},
            new Student {First="Claire", Last="O'Donnell", ID=112, Scores= new List<int> {75, 84, 91, 39}},
            new Student {First="Sven", Last="Mortensen", ID=113, Scores= new List<int> {88, 94, 65, 91}},
            new Student {First="Cesar", Last="Garcia", ID=114, Scores= new List<int> {97, 89, 85, 82}},
            new Student {First="Debra", Last="Garcia", ID=115, Scores= new List<int> {35, 72, 91, 70}},
            new Student {First="Fadi", Last="Fakhouri", ID=116, Scores= new List<int> {99, 86, 90, 94}},
            new Student {First="Hanying", Last="Feng", ID=117, Scores= new List<int> {93, 92, 80, 87}},
            new Student {First="Hugo", Last="Garcia", ID=118, Scores= new List<int> {92, 90, 83, 78}},
            new Student {First="Lance", Last="Tucker", ID=119, Scores= new List<int> {68, 79, 88, 92}},
            new Student {First="Terry", Last="Adams", ID=120, Scores= new List<int> {99, 82, 81, 79}},
            new Student {First="Eugene", Last="Zabokritski", ID=121, Scores= new List<int> {96, 85, 91, 60}},
            new Student {First="Michael", Last="Tucker", ID=122, Scores= new List<int> {94, 92, 91, 91} }
        };

        /// <summary>
        /// 
        /// </summary>
        public void QueryUsingEnumerable()
        {
            // Create the query
            IEnumerable<Student> studentQuery =
                from student in students
                where student.Scores[0] > 30
                select student;

            // Do something with the query.
            foreach (Student student in studentQuery)
            {
                Console.WriteLine("{0}", student.Last);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void QueryUsingVar()
        {
            // Create the query
            var studentQuery =
                from student in students
                where student.Scores[0] > 30
                select student;

            // Do something with the query.
            foreach (Student student in studentQuery)
            {
                Console.WriteLine("{0}", student.Last);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void QueryModification()
        {
            // Create the query
            var studentQuery =
                from student in students
                where student.Scores[0] > 30
                group student by student.Last into studentGroup
                orderby studentGroup.Key
                select studentGroup;

            // Do something with the query.
            foreach (var groupOfStudents in studentQuery)
            {
                Console.WriteLine("{0}", groupOfStudents.Key);
                foreach(var student in groupOfStudents)
                {
                    Console.WriteLine("{0}, {1}", student.Last, student.First);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void QueryUsingLetKeyword()
        {
            // Create the query
            var studentQuery =
                from student in students
                let totalScore = student.Scores[0] + student.Scores[1] + student.Scores[2]
                where totalScore / 4 > student.Scores[0]
                select student.Last + " " + student.First;

            // Do something with the query.
            foreach (var groupOfStudents in studentQuery)
            {
                Console.WriteLine("{0}", groupOfStudents);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void LambdaExpression()
        {
            int[] scores = { 90, 71, 82, 93, 75, 82 };

            // The call to Count forces iteration of the source 
            int highScoreCount = scores.Where(n => n > 80).Count();

            Console.WriteLine("{0} scores are greater than 80", highScoreCount);

            // Outputs: 4 scores are greater than 80    
        }
    }
}

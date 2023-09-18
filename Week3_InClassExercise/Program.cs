using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_InClassExercise
{
    /*public class program
    {
        static void main(string[] args)
        {
            //data sources
            int[] numbers = new int[] { 2, 1, 3, 5, 4, 6, 8, 9, 7, 10 };
            student[] students = new classroom().students;

            //todo #1 - console.writeline all numbers less than five
            //var query = 
            //    from num in numbers
            //    where num < 5
            //    select num;
            //foreach (int num in query)
            //{
            //    console.writeline(num);
            //}   
            //console.readline();

            //todo #2 - console.writeline the highest value in numbers

            //todo #3 - console.writeline all numbers, sorted largest to smallest (ie. 10, 9, 8, 7, etc.)

            ienumerable<int> query2 = 
            from num2 in numbers 
            where num2 > 0 
            orderby num2 ascending 
            select num2; 

            foreach (int num2 in query2)
            {
                console.writeline(num2);
            }
            console.readline();

            //todo #4 - console.writeline all students that have passed the exam (ie. exam grade greater than 50 is a pass)

            

        }
    }



    public class classroom
    {
        public student[] students { get; set; }

        public classroom()
        {
            students = new student[] {
                new student(1, "alice", "johnson", 85),
                new student(2, "bob", "smith", 92),
                new student(3, "charlie", "brown", 78),
                new student(4, "david", "wilson", 88),
                new student(5, "eve", "anderson", 95),
                new student(6, "frank", "davis", 45),
                new student(7, "grace", "lee", 76),
                new student(8, "henry", "martinez", 91),
                new student(9, "isabella", "taylor", 82),
                new student(10, "jack", "rodriguez", 87),
                new student(11, "kate", "white", 93),
                new student(12, "liam", "garcia", 84),
                new student(13, "mia", "hernandez", 35),
                new student(14, "noah", "lopez", 90),
                new student(15, "olivia", "adams", 77),
                new student(16, "owen", "clark", 94),
                new student(17, "sophia", "turner", 81),
                new student(18, "thomas", "scott", 86),
                new student(19, "victoria", "walker", 75),
                new student(20, "william", "baker", 97),
            };
        }
    }

    public class student
    {
        public student(int studentid, string firstname, string lastname, int grade)
        {
            studentid = studentid;
            firstname = firstname;
            lastname = lastname;
            examgrade = grade;
        }

        public int studentid { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public int examgrade { get; set; }

        public override string tostring()
        {
            return $"student->id:{studentid},fname:{firstname},lname:{lastname},examgrade:{examgrade}";
        }
}
*/

public class Program
    {
        static void Main(string[] args)
        {
            //Data Sources
            int[] numbers = new int[] { 2, 1, 3, 5, 4, 6, 8, 9, 7, 10 };
            Student[] students = new Classroom().Students;

            //TODO #1 - Console.WriteLine all numbers less than five
            //var Q1 = numbers.Where(x => x < 5);
            //foreach (var num in  Q1)
            //{
            //    Console.WriteLine(num);
            //} Console.ReadLine();

            //TODO #2 - Console.WriteLine the highest value in numbers


            //TODO #3 - Console.WriteLine all numbers, sorted largest to smallest (ie. 10, 9, 8, 7, etc.)
            //var Q3 = numbers.OrderByDescending(x => x);
            //foreach (var num in Q3)
            //{
            //    Console.WriteLine(num);
            //} Console.ReadLine();

            //TODO #4 - Console.WriteLine all students that have passed the exam (ie. Exam grade greater than 50 is a pass)
            var q4 =
                from student in students
                where student.ExamGrade > 50
                select student;
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
            //var Q4 = students.Where(x => x.ExamGrade > 90);
            //foreach (var num in Q4) {
            //    Console.WriteLine(num);
            //}
            Console.ReadLine();
        }
    }



    public class Classroom
    {
        public Student[] Students { get; set; }

        public Classroom()
        {
            Students = new Student[] {
                new Student(1, "Alice", "Johnson", 85),
                new Student(2, "Bob", "Smith", 92),
                new Student(3, "Charlie", "Brown", 78),
                new Student(4, "David", "Wilson", 88),
                new Student(5, "Eve", "Anderson", 95),
                new Student(6, "Frank", "Davis", 45),
                new Student(7, "Grace", "Lee", 76),
                new Student(8, "Henry", "Martinez", 91),
                new Student(9, "Isabella", "Taylor", 82),
                new Student(10, "Jack", "Rodriguez", 87),
                new Student(11, "Kate", "White", 93),
                new Student(12, "Liam", "Garcia", 84),
                new Student(13, "Mia", "Hernandez", 35),
                new Student(14, "Noah", "Lopez", 90),
                new Student(15, "Olivia", "Adams", 77),
                new Student(16, "Owen", "Clark", 94),
                new Student(17, "Sophia", "Turner", 81),
                new Student(18, "Thomas", "Scott", 86),
                new Student(19, "Victoria", "Walker", 75),
                new Student(20, "William", "Baker", 97),
            };
        }
    }

    public class Student
    {
        public Student(int studentId, string firstName, string lastName, int grade)
        {
            StudentId = studentId;
            FirstName = firstName;
            LastName = lastName;
            ExamGrade = grade;
        }

        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ExamGrade { get; set; }

        public override string ToString()
        {
            return $"Student->ID:{StudentId},FName:{FirstName},LName:{LastName},ExamGrade:{ExamGrade}";
        }
    }







}

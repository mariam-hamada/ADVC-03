using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment12
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Exercise 1: Student Grade Manager

            ////Create a Collection with these grades: 85, 92, 78, 95, 88, 70, 100, 65
            //List<int> StudentsGrades = new List<int>() { 85, 92, 78, 95, 88, 70, 100, 65 };

            ////Print the collection, Count, first and last grade
            //Console.WriteLine($"Our grades colletion is: [{string.Join(',', StudentsGrades)}]");
            //Console.WriteLine($"Count: {StudentsGrades.Count()}");
            //Console.WriteLine($"First grade is: {StudentsGrades.First()}");
            //Console.WriteLine($"Last grade is: {StudentsGrades.Last()}");
            //Console.WriteLine();

            ////Sort the grades ascending, then print
            //StudentsGrades.Sort();
            //Console.WriteLine($"our grades colletion sorted in ascending order is: [{string.Join(',', StudentsGrades)}]");
            //Console.WriteLine();

            ////Get the first grade above 90
            //Console.WriteLine($"First grade above 90 degree is: {StudentsGrades.Find((grade) => grade > 90 )}");
            //Console.WriteLine();

            ////Get all grades below 75(failing grades)
            //List<int> FailGrades = StudentsGrades.FindAll((grade) => grade < 75);
            //Console.WriteLine($"All grade below 75 degree is: {string.Join(',' , FailGrades)}");
            //Console.WriteLine();

            ////Remove all failing grades(below 75)
            //StudentsGrades.RemoveAll((grade) => grade < 75);
            //Console.WriteLine($"Grades after removing grades less than 75: {string.Join(',', StudentsGrades)}");
            //Console.WriteLine();

            ////Check if any grade equals 100
            //bool contain = StudentsGrades.Any((grade) => grade == 100);
            //Console.WriteLine($"Is my list contain a grade equals 100? =>{contain}");
            //Console.WriteLine();

            ////Create a List<string> where each grade becomes "Grade: X"
            //List<string> summary = new List<string>();
            //Console.WriteLine("--- Grades Summary ---");
            //foreach(int grade in StudentsGrades)
            //{
            //    summary.Add($"Grade: {grade}");
            //}
            //foreach (string grade in summary)
            //{
            //    Console.WriteLine(grade);
            //}


            #endregion

        }

    }
}

using Microsoft.VisualBasic;
using System.Drawing;
using System.Linq.Expressions;
using System.Xml.Linq;
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

            #region Exercise 2: Leaderboard

            ////Create a leaderboard that automatically sorts players by score.
            //SortedDictionary<int, string> Players = new SortedDictionary<int, string>();

            ////Add: 500 = "Ahmed", 200 = "Sara", 800 = "Ali", 350 = "Mona"
            //Players.Add(500, "Ahmed");
            //Players.Add(200, "Sara");
            //Players.Add(800, "Ali");
            //Players.Add(350, "Mona");

            ////Print all entries(they should be sorted by score automatically)
            //Console.WriteLine("--- Our Dictionary ---");
            //foreach (var player in Players)
            //{
            //    Console.WriteLine(player.Key + " -> " + player.Value); 
            //}
            //Console.WriteLine();

            ////Access the first key and first value
            //Console.WriteLine($"The First Key and Value is: {Players.First()}");
            //Console.WriteLine();

            ////Check if score 500 exists
            //bool flag = Players.Any((player) => player.Key == 500);
            //Console.WriteLine($"Is there is a player with score equals 500? {flag}");
            //Console.WriteLine();

            ////Safely get the player with score 999
            //string PlayerName;
            //if (Players.TryGetValue(999, out PlayerName))
            //    Console.WriteLine(PlayerName);
            //else
            //    Console.WriteLine("Player with score 999 is not found");
            //Console.WriteLine();


            ////Remove the player with score 200 and print the updated list
            //Players.Remove(200);
            //Console.WriteLine("-- Dictionary after removing --");
            //foreach (var player in Players)
            //{
            //    Console.WriteLine(player.Key + " -> " + player.Value);
            //}
            //Console.WriteLine();

            #endregion

            #region Exercise 3: Phone Book

            //Create a Collection with 4 contacts(name → phone number)
            //Dictionary<string, string> Contacts = new Dictionary<string, string>()
            //{
            //    { "Ahmed", "01012345678" }, { "Sara", "01123456789" }, { "Mona", "01234567890" }, { "Ali", "01512345678" }
            //};

            ////Add a new contact using [] syntax (add or update)
            //Contacts["Mariam"] = "01095678244";

            ////Try adding a duplicate using .Add() — catch the exception and print the error
            //try
            //{
            //    Contacts.Add("Mariam", "01095678244");
            //}
            //catch(ArgumentException ex)
            //{
            //    Console.WriteLine("error occured due to dublication");
            //}
            //Console.WriteLine();

            ////Try adding a duplicate using .TryAdd() — print whether it succeeded
            //bool flag = Contacts.TryAdd("Mariam", "01095678244");
            //Console.WriteLine($"Does adding a duplicate with these method succeded? {flag}");
            //Console.WriteLine();

            ////Search for a contact that doesn’t exist
            //bool exist = Contacts.ContainsKey("Khaled");
            //Console.WriteLine($"Does the Dictinary contains a member with a key = Khaled? {exist}");
            //Console.WriteLine();

            ////Get a contact with a fallback of "Not Found"
            //string number;
            //if (Contacts.TryGetValue("Khaled", out number))
            //    Console.WriteLine($"Number of Khaled is: {number}");
            //else
            //    Console.WriteLine("Member you are searching for doesn't exist in contacts");
            //Console.WriteLine();

            ////Print all Keys on one line, then all Values on another line
            //Console.WriteLine($"All Keys on one line: {string.Join(',', Contacts.Keys)}");
            //Console.WriteLine();
            //Console.WriteLine($"All Values on one line: {string.Join(',', Contacts.Values)}");
            //Console.WriteLine();

            #endregion

        }

    }
}

namespace DictionaryCollection
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Dictionary<int, string> StudentList = [];
            Dictionary<string, string> ClassList = [];
            Dictionary<(int, string), char> GradeList = new(5);

            //Adding Students
            StudentList.Add(1, "Judy Star");
            StudentList.Add(2, "Rick Johnson");
            StudentList.Add(3, "Faith Jones");
            StudentList.Add(4, "Maggie Oliver");
            StudentList.Add(5, "Becky Smith");

            Console.WriteLine("StudentList Keys");
            Dictionary<int, string>.KeyCollection keys = StudentList.Keys;
            foreach (int k in keys)
            {
                Console.WriteLine("Key: {0}", k);
            }
            Console.WriteLine();

            Console.WriteLine("StudentList Values");
            Dictionary<int, string>.ValueCollection values = StudentList.Values;
            foreach (string v in values)
            {
                Console.WriteLine("Value: {0}", v);
            }
            Console.WriteLine();

            Console.WriteLine("StudentList Key/Value Pairs");
            foreach (KeyValuePair<int, string> kvp in StudentList)
            {
                Console.WriteLine($"Key: {kvp.Key}  Value: {kvp.Value}");
            }
            Console.WriteLine();
            // Changing values
            StudentList[1] = "Judy Stark";
            StudentList[2] = "Rick Johnston";
            _ = StudentList.Remove(3);

            Console.WriteLine("Revised StudentList Key/Value Pairs");
            foreach (KeyValuePair<int, string> kvp in StudentList)
            {
                Console.WriteLine($"Key: {kvp.Key}  Value: {kvp.Value}");
            }
            Console.WriteLine();

            //Adding classes
            ClassList.Add("VCA147", "Web Design");
            ClassList.Add("CIT195", "Application Development");
            ClassList.Add("VCA100", "Materials & Techniques");
            ClassList.Add("ART174", "Digital Photography");
            bool addDept = true;
            while (addDept)
            {
                Console.WriteLine("Enter the code of the class you wish to add");
                string classCode = Console.ReadLine();
                if (ClassList.ContainsKey(classCode))
                {
                    _ = ClassList.Remove(classCode);
                }
                Console.WriteLine("Enter the class name you wish to add");
                string className = Console.ReadLine();
                ClassList.Add(classCode, className);
                Console.WriteLine("The class has been added");
                Console.WriteLine("Add another? (y for yes, any key for no)");
                string answer = Console.ReadLine();
                if (answer == "y")
                {
                    continue;
                }
                else
                {
                    addDept = false;
                }
            }
            Console.WriteLine($"There are {ClassList.Count} classes in your list");
            foreach (KeyValuePair<string, string> kvp in ClassList)
            {
                Console.WriteLine($"Class Code: {kvp.Key}   Class Name: {kvp.Value}");
            }
            Console.WriteLine();

            //Adding Grades
            GradeList.Add((1, "ART174"), 'A');
            GradeList.Add((2, "VCA100"), 'B');
            GradeList.Add((3, "CIT195"), 'C');
            GradeList.Add((4, "VCA147"), 'D');
            GradeList.Add((5, "VCA100"), 'A');

            // Grade list
            Console.WriteLine("Student Grades");
            foreach (KeyValuePair<(int, string), char> kvp in GradeList)
            {
                Console.WriteLine($"Student ID/Class: {kvp.Key}   Grade: {kvp.Value}");
            }
            Console.WriteLine();


        }

    }
}
/*


Add 5 items to a dictionary
Retrieve and display all the keys
Retreive and display all the values
Retrieve and display both the keys and the values
Remove an item from the dictionary
Display a count of the dictionary items.
 */
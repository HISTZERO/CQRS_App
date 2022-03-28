using System;



public class Program
{
    public static void Main()


    {
        String input = "01111";
        int i = input.IndexOf("1");
        int result = 0;

        for (int j = i; j< input.Length; j++)
        {
            if (input[j] == '1')
            {
                result += 2;
            } else
            {
                result += 1;
            }
        }

        Console.WriteLine(result-1);

    }






        // Student collection
        /*IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 13, StandardID =1 },
                new Student() { StudentID = 2, StudentName = "Moin",  Age = 21, StandardID =1 },
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 18, StandardID =2 },
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20, StandardID =2 },
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
            };

        var groupedResult = studentList.GroupBy(s => s.Age).Where(a => a.Key == 18).First().Select(a => a.StudentName).ToList();

        Console.WriteLine(String.Join(",", groupedResult));

        IList<Standard> standardList = new List<Standard>() {
                new Standard(){ StandardID = 1, StandardName="Standard 1"},
                new Standard(){ StandardID = 2, StandardName="Standard 2"},
                new Standard(){ StandardID = 3, StandardName="Standard 3"}
            };

        var innerJoinResult = from s in studentList
                              join st in standardList
                              on s.StandardID equals st.StandardID
                              select s;

        foreach (var obj in innerJoinResult)
        {

            Console.WriteLine("{0} - {1}", obj.StudentName, obj.StandardID);
        }*/

    //}

}

public class Student
{
    public int StudentID { get; set; }
    public string StudentName { get; set; }
    public int Age { get; set; }
    public int StandardID { get; set; }

}

public class Standard
{

    public int StandardID { get; set; }
    public string StandardName { get; set; }
}
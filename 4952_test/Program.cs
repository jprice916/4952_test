using dotnet_lib;

Student student = new()
{
    ID = 1,
    Fname = "adam",
    Lname = "apple",
    school = "alan uni"
}; 

Console.WriteLine(student.ID);
Console.WriteLine(student.Fname);
Console.WriteLine(student.Lname);
Console.WriteLine(student.school);


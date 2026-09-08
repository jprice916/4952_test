namespace dotnet_lib;

public class Student
{
    public int ID { get; set; }

    public string? Fname { get; set; }

    public string? Lname { get; set; }

    public string? school { get; set; }

    public override string ToString()
    {
        return Fname;
    }
}

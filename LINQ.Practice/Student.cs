public class Student
{
    public string Name { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string EducationalInstitute { get; set; }

    public override string ToString()
    {
        return $"Name:{Name}\nLast name:{LastName}\nAge:{Age}\nEducational Institute:{EducationalInstitute}\n\n";
    }
}
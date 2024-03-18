
public class Person
{
    protected Person(string? firstName = null, string? lastName = null)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public string? FirstName { get; set; }
    public string? LastName { get; set; }
}
namespace Library;

public class Person
{
    public string Name { get; set; } = string.Empty;

    public int Age { get; set; }

    public bool IsAllowedToBuyAlcohol()
    {
        return Age >= 18;
    }

    public bool IsValidName()
    {
        if (Name.Length > 10)
        {
            return false;
        }

        if (char.ToLowerInvariant(Name[0]) == 'b')
        {
            return false;
        }

        return true;
    }
}

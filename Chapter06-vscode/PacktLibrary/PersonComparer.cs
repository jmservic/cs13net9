namespace Packt.Shared;

public class PersonComparer : IComparer<Person?>
{
    public int CompareOld(Person? x, Person? y)
    {
        int position;

        if ((x is not null) && (y is not null))
        {
            if ((x.Name is not null) && (y.Name is not null))
            {
                // If both Name values are not null...
                // ...then compare the Name Lengths
                int result = x.Name.Length.CompareTo(y.Name.Length);

                // ...and if they are equal...
                if (result == 0)
                {
                    // ...then compare by the Names...
                    return x.Name.CompareTo(y.Name);
                }
                else
                {
                    // ...otherwise compare by the Lengths.
                    position = result;
                }
            }
            else if ((x.Name is not null) && (y.Name is null))
            {
                position = -1; // x Person precedes y Person.
            }
            else if ((x.Name is null) && (y.Name is not null))
            {
                position = 1; // x Person follows y Person.
            }
            else // x.Name and y.Name are both null.
            {
                position = 0; // x and y are at some position.
            }
        }
        else if ((x is not null) && (y is null))
        {
            position = -1; // x Person precedes y Person
        }
        else if ((x is null) && (y is not null))
        {
            position = 1; // x Person follows y Person
        }
        else // x and y are both null. 
        {
            position = 0; // x and y are at same poistion.
        }
        return position;
    }

    public int Compare(Person? x, Person? y) => (x, y) switch
    {
        (Person p1, Person p2) => (p1.Name, p2.Name) switch
        {
            (string s1, string s2) => s1.Length.CompareTo(s2.Length) switch
            {
                0 => s1.CompareTo(s2),
                int position => position
            },
            (string, null) => -1,
            (null, string) => 1,
            (_, _) => 0
        },
        (Person, null) => -1,
        (null, Person) => 1,
        (_, _) => 0,
    };
}
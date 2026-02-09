using Microsoft.EntityFrameworkCore; // for GenerateCreateScript()
using Packt.Shared; // Academy

using (Academy a = new())
{
    bool deleted = await a.Database.EnsureDeletedAsync();
    WriteLine($"Database deleted: {deleted}");

    bool created = await a.Database.EnsureCreatedAsync();
    WriteLine($"Database created: {created}");

    WriteLine("SQL script used to create database:");
    WriteLine(a.Database.GenerateCreateScript());

    if (a.Students is null)
        return;

    foreach (Student s in a.Students.Include(s => s.Courses))
    {
        WriteLine("{0} {1} attends the following {2} courses:", s.FirstName, s.LastName, s.Courses?.Count());

        if (s.Courses is null)
            continue;

        foreach (Course c in s.Courses)
        {
            WriteLine($"  {c.Title}");            
        }
    }
}
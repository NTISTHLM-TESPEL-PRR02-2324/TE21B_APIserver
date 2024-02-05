using TE21B_APIserver;

public class TeacherCollection
{
  List<Teacher> teachers = new() {
    new() {Name = "Micke", HitPoints = 100},
    new() {Name = "Martin", HitPoints = 3 },
    new() {Name = "Lena", HitPoints = 9000 }
  };

  public IResult GetTeacher(int number)
  {

    if (number < 0 || number >= teachers.Count)
    {
      return Results.NotFound();
    }

    return Results.Ok(teachers[number]);
  }

    
  public void AddTeacher(Teacher t)
  {
    Console.WriteLine(t.Name + " added");
    teachers.Add(t);
  }

  public IResult GetAllTeachers() => Results.Ok(teachers);
}

using Microsoft.AspNetCore.Mvc;
using TE21B_APIserver;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
WebApplication app = builder.Build();

// app.MapGet("/", () => "Hello World!");

app.MapGet("/", GetHello);
app.MapGet("/hello", () => "Goodbye");

app.MapGet("/teachers/{number}", GetTeacher);

app.Run();


static IResult GetTeacher(int number)
{
  List<Teacher> teachers = new() {
    new() {Name = "Micke", HitPoints = 100},
    new() {Name = "Martin", HitPoints = 3 },
    new() {Name = "Lena", HitPoints = 9000 }
  };

  if (number < 0 || number >= teachers.Count)
  {
    return Results.NotFound();
  }

  return Results.Ok(teachers[number]);
}



static string GetHello()
{
  return "Hello TE21B!";
}
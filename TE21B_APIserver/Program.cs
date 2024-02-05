using Microsoft.AspNetCore.Mvc;
using TE21B_APIserver;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
WebApplication app = builder.Build();

app.Urls.Add("http://*:5288");

TeacherCollection collection = new();

app.MapGet("/", GetHello);
app.MapGet("/hello", () => "Goodbye");

app.MapGet("/teachers/{number}", 
  collection.GetTeacher);

app.MapGet("/teachers/", collection.GetAllTeachers);

app.MapPost("/teachers/", collection.AddTeacher);

app.Run();






static string GetHello()
{
  return "Hello TE21B!";
}
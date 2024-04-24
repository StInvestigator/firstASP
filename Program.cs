using System.Runtime.InteropServices;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.UseStaticFiles();

app.MapGet("/", async context =>
{
    context.Response.ContentType = "text/html";

    await context.Response
    .WriteAsync("<!DOCTYPE html><html lang=\"en\"><head><meta charset=\"UTF-8\"><meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <title>Main</title>\r\n    <link rel=\"stylesheet\" href=\"style.css\">\r\n</head>\r\n<body>" +
    "<h2>Мене звати <span style=\"color:red\">Владислав</span></h2>" +
    "<h3>Я народився в Краматорську, зараз перебуваю в Одесі</h3>" +
    "<h3>На сьогодняшній день навчаюсь в 11-ому класі</h3>" +
    "<h3>У вільний час граю у шахи, відеоігри, відвідую спортивний зал</h3>" +
    "<a href=\"skills\" style=\"display:block\">To skills</a>" +
    "<img src=\"/Gigachad.jpg\" style=\"width:200px\"/>" +
    "</body></html>");
});

app.MapGet("/skills", async context =>
{
    context.Response.ContentType = "text/html";

    await context.Response
    .WriteAsync("<!DOCTYPE html><html lang=\"en\"><head><meta charset=\"UTF-8\"><meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <title>Skills</title>\r\n    <link rel=\"stylesheet\" href=\"style.css\">\r\n</head>\r\n<body>" +
    "<h2>My skills:</h2>"+
    "<ul>"+
    "<li>C++</li>"+
    "<li>C#</li>" +
    "<li>WinForms</li>" +
    "<li>WPF</li>" +
    "<li>Microsoft SQL Server</li>" +
    "<li>HTML + CSS</li>" +
    "<li>JS</li>" +
    "<li>React & Angular</li>" +
    "</ul>" +
    "<a href=\"\\\" style=\"display:block\">Back</a>" +
    "</body></html>");
});

app.Run();

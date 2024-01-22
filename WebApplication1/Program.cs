

using System.Runtime.InteropServices;


var builder = WebApplication.CreateBuilder();
var app = builder.Build();


/*
Console.Write("Введите имя загружаемого файла: ");
string name = Console.ReadLine();


app.Run( async ( context) =>
{
    if (name == "nebo") await context.Response.SendFileAsync(name+".jpg");
    else
    {
       
        var response = context.Response;
        response.ContentType = "text/html; charset=utf-8";
        response.StatusCode = 404;
        await response.WriteAsync($"<h2>Имя: {name} - не найдено");
    }
}
);
*/

/*
app.Run(async (context) =>
{
    context.Response.ContentType = "text/html; charset=utf-8";
    await context.Response.SendFileAsync("Properties/html/index.html");
});

*/

/*
app.Run(async (context) =>
{
    var path = context.Request.Path;
    var fullPath = $"Properties/html/{path}";
    var response = context.Response;
    response.ContentType = "text/html; charset=utf-8";

    if (File.Exists(fullPath))
    {
        await response.SendFileAsync(fullPath);  
    }
    else
    {
        response.StatusCode = 404;
        await response.WriteAsync("<h2>Not found</h2>");
    }


});
*/

app.Run(async (context) =>
{
    context.Response.Headers.ContentDisposition = "attachment; filename=my_nebo.jpg";
    await context.Response.SendFileAsync("nebo.jpg");
});






app.Run();
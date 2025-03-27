var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.Run(async (context) =>
{
    context.Response.ContentType = "text/html; charset=utf-8";

    var path = context.Request.Path;
    var now = DateTime.UtcNow;
    var response = context.Response;

    if (path == "/date")
        await response.WriteAsync($"Date: {now.ToString()}");
    else if (path == "/fuck")
        await response.WriteAsync("� ����� ��� ���� ����� �������?");
    else
        await response.WriteAsync("������ �� �����");
});

app.Run();

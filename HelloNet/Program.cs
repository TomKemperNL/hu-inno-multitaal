var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


app.MapGet("/net", () =>
    {
        return "Hello from .NET";
    })
    .WithName("GetNet")
    .WithOpenApi();

app.MapGet("/java", async () =>
    {
        HttpClient client = new HttpClient();
        HttpResponseMessage response = await client.GetAsync(new Uri("http://localhost:8080/java"));
        return await response.Content.ReadAsStringAsync();
    })
    .WithName("GetJava")
    .WithOpenApi();

app.Run();
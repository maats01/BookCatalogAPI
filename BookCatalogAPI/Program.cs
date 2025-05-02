using BookCatalogAPI.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddSingleton<BooksService>();

var app = builder.Build();

app.UseRouting();
app.MapControllers();

app.Run();

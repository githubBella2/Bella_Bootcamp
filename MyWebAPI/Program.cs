using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer(); //cari endpoin
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddDbContext<Database>(opt =>
{
    opt.UseSqlite("Data Source=./database.db"); //siapapun class yg butuh databse, kasih ini.
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())//jika dalam development
{
    app.UseSwagger();//swaggernya nyala
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();//redirect http ke https
app.MapControllers();


app.Run();


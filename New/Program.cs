using AutoMapper;
using Microsoft.EntityFrameworkCore;
using New;
using New.Mappers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer(); //cari endpoin
builder.Services.AddSwaggerGen();
builder.Services.AddControllers(); 
builder.Services.AddDbContext<Database>(opt =>
{
    opt.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"));
    // opt.useHost=localhost;Port=5432;Database=Yourdatabase;Username=postgres;Password=password
    // opt.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")); //siapapun class yg butuh databse, kasih ini.
});
builder.Services.AddAutoMapper(typeof(MyMapper));

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


using Visitas_residenciales;
using Visitas_residenciales.Services;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSqlServer<VisitasContext>("Data Source=localhost,1433; Initial Catalog=Visitas_residencialesDB;user id=sa;password=r00t.R00t;Encrypt=False");
builder.Services.AddScoped <ICasaService, CasaService> ();
builder.Services.AddScoped <IHabitantesService, HabitantesService> ();
builder.Services.AddScoped<IResidenteService, ResidenteService> ();
builder.Services.AddScoped<IVisitaService, VisitaService>();
builder.Services.AddScoped<IVisitanteService, VisitanteService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{

    //documentacion del Rest Api
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

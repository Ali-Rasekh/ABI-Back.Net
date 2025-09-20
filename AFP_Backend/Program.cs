using AFP_Backend.Contexts;
using AFP_Backend.Modules.BiFilters.Contracts.IRepository;
using AFP_Backend.Modules.BiFilters.Repository;
using AFP_Backend.Modules.Public.Contracts.IRepository;
using AFP_Backend.Modules.Public.Repository;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//builder.Services.AddAutoMapper(typeof(MappingProfile).Assembly); فقط پروفایل مورد نظر رو میاره
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies()); // این میره همه پروفایل ها رو میاره
builder.Services.AddDbContext<MaroonContext>();
builder.Services.AddScoped<IBiFilterRepository, BiFiltersRepository>();
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

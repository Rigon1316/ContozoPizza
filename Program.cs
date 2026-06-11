var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// ¡Aquí están las líneas mágicas para que Swagger funcione siempre!
app.UseSwagger();
app.UseSwaggerUI();

// Comentamos esta línea para que no choque con la seguridad de Render
// app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
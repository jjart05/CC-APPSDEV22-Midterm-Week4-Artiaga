var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

// Swagger services
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Enable Swagger UI
app.UseSwagger();
app.UseSwaggerUI();

// Optional: remove HTTPS redirect warning when using HTTP only
// app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

// Optional: redirect root URL to Swagger
app.MapGet("/", () => Results.Redirect("/swagger"));

app.Run();

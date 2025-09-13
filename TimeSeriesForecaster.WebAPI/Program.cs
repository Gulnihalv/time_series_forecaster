var builder = WebApplication.CreateBuilder(args);

// CORS politikasını ekle (React uygulamasının API'a erişebilmesi için)
var reactAppPolicy = "AllowReactApp";
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: reactAppPolicy,
                      policy =>
                      {
                          policy.WithOrigins("http://localhost:5174") // Vite'ın varsayılan portu
                                .AllowAnyHeader()
                                .AllowAnyMethod();
                      });
});

// Add services to the container.

builder.Services.AddControllers();
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

// HTTPS yönlendirmesini etkinleştir
app.UseHttpsRedirection();

// Tanımladığımız CORS politikasını kullan. Bu MapControllers'dan önce gelmeli.
app.UseCors(reactAppPolicy);

// Yetkilendirme (Authentication'dan sonra gelir)
app.UseAuthorization();

// Gelen istekleri Controller'lara yönlendir
app.MapControllers();

app.Run();

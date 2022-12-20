using LibraryExtension.Application.Implementations;
using LibraryExtension.Application.Interfaces;
using LibraryExtension.Infrastructure;
using LibraryExtension.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddCors(opt =>
{
    opt.AddPolicy("asd", policy => policy.WithOrigins("https://localhost:7108/", "http://localhost:7108/").AllowAnyHeader());
    opt.AddDefaultPolicy(builder => builder.SetIsOriginAllowed(origin => new Uri(origin).Host == "localhost").AllowAnyHeader().AllowAnyMethod());
});

builder.Services.AddControllers();
builder.Services.AddSwaggerGen();
builder.Services
    .AddDbContext<ApplicationDbContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<IReaderService, ReaderService>();
builder.Services.AddScoped<IBookService, BookService>();
builder.Services.AddScoped<ITransactionService, TransactionService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}


app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
app.UseCors();
app.MapControllers();
app.UseSwagger();
app.UseSwaggerUI();
app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
    options.RoutePrefix = string.Empty;
});
app.Run();

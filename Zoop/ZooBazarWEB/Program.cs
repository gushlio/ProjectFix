using DataAccessLayer;
using Domain.Manager;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

// Register UserManager with its dependencies
builder.Services.AddScoped<ImagesDB>(); // Assuming UserDAL requires no additional configuration
builder.Services.AddSingleton<ImageManager>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();

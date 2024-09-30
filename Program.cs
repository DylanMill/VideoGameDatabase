using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RazorPagesGame.Data;
using VideoGameDatabase.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<RazorPagesGameContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("RazorPagesGameContext") ?? throw new InvalidOperationException("Connection string 'RazorPagesGameContext' not found.")));

if (builder.Environment.IsDevelopment())
{
    builder.Services.AddDbContext<RazorPagesGameContext>(options =>
        options.UseSqlite(builder.Configuration.GetConnectionString("RazorPagesGameContext")));
}
else
{
    builder.Services.AddDbContext<RazorPagesGameContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("ProductionGameContext")));
}

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    SeedData.Initialize(services);
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();

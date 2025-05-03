var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMvc();
builder.Services.AddControllersWithViews();

var app = builder.Build();


app.UseStaticFiles();

app.UseRouting();

app.Run();

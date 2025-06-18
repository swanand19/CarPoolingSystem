using CarPoolingSystem.DbEntities;
using Microsoft.EntityFrameworkCore;



var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMvc();
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<ApplicationDbContext>( options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

var app = builder.Build();


app.UseStaticFiles();

app.UseRouting();  //maps the endpoints, does not execute it

app.UseEndpoints(endpoints =>            //UseEndpoints => executes the appropriate endpoint based on the endpoint selected by above UseRouting
{
    endpoints.MapControllers();
});


app.Run();

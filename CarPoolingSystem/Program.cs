using CarPoolingSystem.DbEntities;
using CarPoolingSystem.Tables;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMvc();
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<ApplicationDbContext>( options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

//enabling idenity
builder.Services.AddIdentity<User, Role>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddUserStore<UserStore<User, Role, ApplicationDbContext, long>>()
    .AddRoleStore<RoleStore<Role, ApplicationDbContext, long>>();

var app = builder.Build();

app.UseStaticFiles();
app.UseAuthentication(); //This middleware checks if the user is authenticated or not i.e. reading identity cookie

app.UseRouting();  //maps the endpoints, does not execute it (Identify action method based on route)

app.UseEndpoints(endpoints =>        //UseEndpoints => executes the appropriate endpoint based on the endpoint selected by above UseRouting
{
    endpoints.MapControllers(); //Execute the filter pipeline (action + filters)
});


app.Run();

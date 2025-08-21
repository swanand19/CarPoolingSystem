using CarPoolingSystem.DbEntities;
using CarPoolingSystem.Tables;
using Microsoft.AspNetCore.Authorization;
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
builder.Services.AddIdentity<User, Role>(options =>
    {
        options.Password.RequiredLength = 5;
        options.Password.RequireDigit = true;
        options.Password.RequireLowercase = true;
        options.Password.RequireUppercase = true;
        options.Password.RequireNonAlphanumeric = false;
    })
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddUserStore<UserStore<User, Role, ApplicationDbContext, long>>()
    .AddRoleStore<RoleStore<Role, ApplicationDbContext, long>>();

builder.Services.AddAuthorization(options =>
{
    options.FallbackPolicy = new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build();  //enforces authorization for all the action method. If not authorized, will be redirected to login page
});

builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/Users/Login";
});

var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();  //maps the endpoints, does not execute it (Identify action method based on route)
app.UseAuthentication(); //This middleware checks if the user is authenticated or not i.e. reading identity cookies
app.UseAuthorization(); //validates access permissions of the user.
app.UseEndpoints(endpoints =>        //UseEndpoints => executes the appropriate endpoint based on the endpoint selected by above UseRouting
{
    endpoints.MapControllers(); //Execute the filter pipeline (action + filters)
});


app.Run();

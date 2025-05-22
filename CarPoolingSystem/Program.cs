var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMvc();
builder.Services.AddControllersWithViews();

var app = builder.Build();


app.UseStaticFiles();

app.UseRouting();  //maps the endpoints, does not execute it

app.UseEndpoints(endpoints =>            //UseEndpoints => executes the appropriate endpoint based on the endpoint selected by above UseRouting
{
    endpoints.MapControllers();
});


app.Run();

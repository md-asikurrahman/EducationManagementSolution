

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();
builder.Services.AddRazorPages();
builder.Services.AddHttpClient();







var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    // Route for Admin area
    endpoints.MapControllerRoute(
        name: "admin",
        pattern: "Admin/{controller=DashBoard}/{action=Index}/{id?}",
        defaults: new { area = "Admin" }
    );

    // Default route for the Client area
    endpoints.MapControllerRoute(
        name: "client_default",
        pattern: "{controller=Home}/{action=Index}/{id?}",
        defaults: new { area = "Client" }  // Default area set to Client
    );

    // Map other attribute-routed controllers
    endpoints.MapControllers();
});

app.Run();

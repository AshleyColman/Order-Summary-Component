var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();
app.UseEndpoints(options =>
{
    options.MapRazorPages();
});
app.Run();

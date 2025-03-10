using ConfigurationAssignment.Options;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
// Register SocialMediaLinksOptions
builder.Services.Configure<SocialMediaLinksOptions>(builder.Configuration.GetSection(nameof(SocialMediaLinksOptions)));
var app = builder.Build();
app.UseStaticFiles();
app.UseRouting();
app.MapControllers();
app.Run();

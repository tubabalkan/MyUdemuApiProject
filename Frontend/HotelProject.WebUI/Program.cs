using FluentValidation;
using FluentValidation.AspNetCore;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.Dtos.GuestDto;
using HotelProject.WebUI.Mapping;
using HotelProject.WebUI.ValidationRules.GuestValidationRules;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddTransient<IValidator<CreateGuestDto>,CreateGuestValidator>();
builder.Services.AddTransient<IValidator<UpdateGuestDto>,UpdateGuestValidator>();
builder.Services.AddControllersWithViews().AddFluentValidation();
builder.Services.AddHttpClient();
builder.Services.AddAutoMapper(typeof(AutoMappingConfig));
//builder.Services.AddMvc(config =>
//{
//	var policy=new AuthorizationPolicyBuilder()
//	.RequireAuthenticatedUser()
//	.Build();
//	config.Filters.Add(new AuthorizeFilter(policy));
//});
//builder.Services.ConfigureApplicationCookie(options =>
//{
//	options.Cookie.HttpOnly = true;
//	options.ExpireTimeSpan = TimeSpan.FromMinutes(10);
//	options.LoginPath = "/Login/Index";
//});
builder.Services.AddDbContext<Context>();
builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<Context>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();
//app.UseAuthentication();
app.UseRouting();
app.UseAuthorization();
app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");
app.Run();

using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using OnlineConsultationManagementSystem.Data;
using OnlineConsultationManagementSystem.Models;
using OnlineConsultationManagementSystem.Models.Domain;
using OnlineConsultationManagementSystem.Util;
using OnlineConsultationManagementSystem.Util.Email;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("OCMS") ?? throw new InvalidOperationException("Connection string not found.")));

builder.Services.AddIdentity<User, IdentityRole>(opt =>
{
    //manage password policy
    opt.Password.RequiredLength = 7;
    opt.Password.RequireDigit = false;
    opt.Password.RequireUppercase = false;
    opt.User.RequireUniqueEmail = true;

    // require email confirmation before login and token provider    
    opt.SignIn.RequireConfirmedEmail = true;
    opt.Tokens.EmailConfirmationTokenProvider = "emailconfirmation";
    
    //user lockout settings
    opt.Lockout.AllowedForNewUsers = true;
    opt.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(2);
    opt.Lockout.MaxFailedAccessAttempts = 3;
})
.AddEntityFrameworkStores<ApplicationContext>()
.AddDefaultTokenProviders()
.AddTokenProvider<EmailConfirmationTokenProvider<User>>("emailconfirmation");

builder.Services.Configure<DataProtectionTokenProviderOptions>(opt =>
   opt.TokenLifespan = TimeSpan.FromHours(2));

builder.Services.Configure<EmailConfirmationTokenProviderOptions>(opt =>
 opt.TokenLifespan = TimeSpan.FromDays(3));

builder.Services.AddAutoMapper(typeof(Program));

builder.Services.AddScoped<IUserClaimsPrincipalFactory<User>, CustomClaimsFactory>();
builder.Services.AddScoped<IEmailService, EmailService>();

builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

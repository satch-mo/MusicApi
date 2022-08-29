using Microsoft.EntityFrameworkCore;
using MusicApi.Data;

var builder = WebApplication.CreateBuilder(args);

// ASP.NET Core 6 simplifies startup.cs and program.cs file into one (unlike ASP.NET 5 & earlier)
// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddControllers();
builder.Services.AddMvc().AddXmlSerializerFormatters();
//razorpages vs controllers?
builder.Services.AddDbContext<ApiDbContext>(option => option.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MusicDb;"));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}


app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();
app.MapControllers();
// controllers ^^ adding this line 27 and line 6 fixed 404 issue for get request - json showing now

app.Run();

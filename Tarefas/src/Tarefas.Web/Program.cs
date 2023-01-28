using Tarefas.DAO;
using AutoMapper;
using Tarefas.Web.Models;
using Tarefas.DTO;

var builder = WebApplication.CreateBuilder(args);
var config = new AutoMapper.MapperConfiguration(c => {
    c.CreateMap<TarefaViewModel, TarefaDTO>().ReverseMap();

});

IMapper mapper = config.CreateMapper();


// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<ITarefaDAO, TarefaDAO>();
builder.Services.AddSingleton(mapper);


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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

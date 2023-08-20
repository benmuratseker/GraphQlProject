using GraphiQl;
using GraphQL.Server;
using GraphQL.Types;
using GraphQlProject.Data;
using GraphQlProject.Interfaces;
using GraphQlProject.Mutation;
using GraphQlProject.Query;
using GraphQlProject.Schema;
using GraphQlProject.Services;
using GraphQlProject.Type;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddTransient<IMenuService, MenuService>();
builder.Services.AddTransient<ISubMenuService, SubMenuService>();
builder.Services.AddTransient<IReservationService, ReservationService>();

builder.Services.AddTransient<MenuType>();
builder.Services.AddTransient<MenuQuery>();
builder.Services.AddTransient<SubMenuType>();
builder.Services.AddTransient<SubMenuQuery>();
builder.Services.AddTransient<ReservationType>();
builder.Services.AddTransient<ReservationQuery>();
builder.Services.AddTransient<RootQuery>();

builder.Services.AddTransient<MenuMutation>();
builder.Services.AddTransient<SubMenuMutation>();
builder.Services.AddTransient<ReservationMutation>();
builder.Services.AddTransient<MenuInputType>();
builder.Services.AddTransient<SubMenuInputType>();
builder.Services.AddTransient<ReservationInputType>();
builder.Services.AddTransient<RootMutation>();

builder.Services.AddTransient<ISchema, RootSchema>();

builder.Services.AddGraphQL(options =>
{
    options.EnableMetrics = false;
}).AddSystemTextJson();

builder.Services.AddDbContext<GraphQlDbContext>(option => option.UseSqlServer(@"Data Source= (localdb)\MSSQLLocalDB; Initial Catalog = CoffeeShopDb; Integrated Security = true"));


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    //app.UseSwagger();
    //app.UseSwaggerUI();
}

app.UseGraphiQl("/graphql");
app.UseGraphQL<ISchema>();

using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<GraphQlDbContext>();
    dbContext.Database.EnsureCreated();
}


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

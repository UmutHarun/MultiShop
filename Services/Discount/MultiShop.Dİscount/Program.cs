using MultiShop.Discount.Context;
using MultiShop.Discount.Services;
using System.Text.Json.Serialization;
using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddTransient<DapperContext>();
builder.Services.AddTransient<IDiscountService, DiscountService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//builder.Services.AddControllers()
//            .AddJsonOptions(options =>
//            {
//                options.JsonSerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
//                options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
//            });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
//Environment.SetEnvironmentVariable("DOTNET_SYSTEM_GLOBALIZATION_INVARIANT", "false");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

using Microsoft.EntityFrameworkCore;
using Ecommerce.EFCoreApi.Data.Context;
using Ecommerce.EFCoreApi.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Ecommerce.EFCoreApi.Application.Interfaces.Services;
using Ecommerce.EFCoreApi.Identity.Services;
using EcommerceApi.Extensions;
using Ecommerce.EFCoreApi.Domain.Interfaces.Services;
using Ecommerce.EFCoreApi.Domain.Services;
using Ecommerce.EFCoreApi.Domain.Interfaces.Repositories;
using Ecommerce.EFCoreApi.Data.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DataContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
);

builder.Services.AddDbContext<IdentityDataContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
);

builder.Services.AddDefaultIdentity<IdentityUser>()
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<IdentityDataContext>()
    .AddDefaultTokenProviders();

builder.Services.AddScoped<IIdentityService, IdentityService>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();


// add authentication with jwt from another file
builder.Services.AddAuthentication(builder.Configuration);



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}



app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

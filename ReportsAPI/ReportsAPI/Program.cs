using AutoMapper;
using ReportsAPI.Contracts;
using ReportsAPI.MappingProfiles;
using ReportsAPI.Models;
using ReportsAPI.Services;

var builder = WebApplication.CreateBuilder(args);


string connectionString = Environment.GetEnvironmentVariable("AZURE_TABLE_STORAGE");
string tableNameVendors = Environment.GetEnvironmentVariable("TABLE_NAME_VENDORS");
string tablenameAssets = Environment.GetEnvironmentVariable("TABLE_NAME_ASSETS");
string tableNameWarranty = Environment.GetEnvironmentVariable("TABLE_NAME_WARRANTY");
string tableNameDevices = Environment.GetEnvironmentVariable("TABLE_NAME_DEVICES");


var mapperConfig = new MapperConfiguration(mc =>
{
    mc.AddProfile(new VendorProfile());
    mc.AddProfile(new AssetProfile());
    mc.AddProfile(new WarrantyProfile());
});

IMapper mapper = mapperConfig.CreateMapper();


builder.Services.AddScoped<IRepository<Vendor>>(x => new VendorsReportsRepository(connectionString, tableNameVendors, mapper));
builder.Services.AddScoped<IRepository<Asset>>(x => new AssetsReportsRepository(connectionString, tablenameAssets, mapper));
builder.Services.AddScoped<IRepository<Warranty>>(x => new WarrantyReportsRepository(connectionString, tableNameWarranty, mapper));
builder.Services.AddScoped<IRepository<IotDevice>>(x => new IotDevicesReportsRepository(connectionString, tableNameWarranty));




// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddCors(p => p.AddPolicy("corsapp", builder =>
{
    builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
}));

var app = builder.Build();

// Configure the HTTP request pipeline.

    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseCors("corsapp");



app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

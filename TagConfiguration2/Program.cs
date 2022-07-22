using Microsoft.OpenApi.Models;
using System.Reflection;
using TagConfiguration2.Models;
using TagConfiguration2.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.Configure<TagsConfigurationDatabaseSettings>(
builder.Configuration.GetSection("TagsConfigurationDatabase"));
builder.Services.AddSingleton<TagInputService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "Calculate tag autonomy API",
        Description = "An ASP.NET Core Web API for calculate tag autonomy",
        TermsOfService = new Uri("https://example.com/terms"),
        Contact = new OpenApiContact
        {
            Name = "Site web Ela innovation",
            Url = new Uri("https://elainnovation.com")
        },
        License = new OpenApiLicense
        {
            Name = "Example License",
            Url = new Uri("https://example.com/license")
        }
    });

    // using System.Reflection;
  //  var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
  //  options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
});

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

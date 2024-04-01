using GraphQL.API;
using GraphQL.API.GraphQL.QueryTypes;
using GraphQL.API.Services;
using MongoDB.Libmongocrypt;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddJsonOptions(
        options => options.JsonSerializerOptions.PropertyNamingPolicy = null);

// MongoDB connection
builder.Services.Configure<LibraryDatabaseSettings>(
    builder.Configuration.GetSection("LibraryDatabase"));

// GraphQL
builder.Services.AddGraphQLServer()
                .AddQueryType<QueryType>()
                .AddMutationType<MutationType>()
                .AddDefaultTransactionScopeHandler();

builder.Services.AddSingleton<BooksService>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();


app.MapGraphQL();

app.MapControllers();

app.Run();

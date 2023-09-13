using StripePaymentData;

var builder = WebApplication.CreateBuilder(args);

var dbConnectionString = builder.Configuration.GetConnectionString("DbConnectionString");
builder.Services.AddPaymentDbContext(dbConnectionString);

var app = builder.Build();
app.Run();

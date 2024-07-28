var builder = WebApplication.CreateBuilder(args);
// Add Services to DI

var app = builder.Build();

// Configure HTTP request pipeline

app.Run();

var builder = WebApplication.CreateBuilder(args);

const string LocalOrigins = "_localorigins";
builder.Services.AddCors(options =>
{
    options.AddPolicy(LocalOrigins,
        builder =>
        {
            builder
                .WithOrigins(
                    "https://localhost:3000",
                    "https://localhost:3001")
                .AllowAnyHeader()
                .AllowAnyMethod()
                .AllowCredentials();
        });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseCors(LocalOrigins);
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapFallbackToFile("/index.html");
});

app.Run();

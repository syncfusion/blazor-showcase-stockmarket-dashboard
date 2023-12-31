using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Cors.Infrastructure;
using StockMarket.Data;
using Syncfusion.Blazor;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSyncfusionBlazor();
builder.Services.AddSingleton<CardService>();
builder.Services.AddSingleton<WatchListService>();
builder.Services.AddSingleton<ChartService>();
builder.Services.AddSingleton<PerformanceService>();
builder.Services.AddSingleton<KeyStatisticsService>();
builder.Services.AddSingleton<TechnicalService>();
builder.Services.AddServerSideBlazor().AddHubOptions(o =>
{
    o.MaximumReceiveMessageSize = 102400000;
});
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Your License Key");
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseRequestLocalization("en-US");
app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();

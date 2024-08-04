using InMemoeryApp.Presentation.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

//swagger entegration _1 
builder.Services.AddEndpointsApiExplorer();//Apinin incelenmesi ve belgelerin olu�turulmas�
builder.Services.AddSwaggerGen();//Belgeler i�in gerekli ayarlar� yap�yor

//Inmemory and EFCore entegrations
builder.Services.AddDbContext<AppllicationDbContext>(Options => Options.UseInMemoryDatabase("ECommerceDb"));

builder.Services.AddMediatR(x => x.RegisterServicesFromAssemblies(typeof(Program).Assembly));


var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

app.MapControllers();

//swagger entegration _2
if (app.Environment.IsDevelopment())
{
    app.UseSwagger(); //apilerin yapt��� i�lemlerin ve bu i�lemlerin nas�l kullan�l�ca��n� a��klayan metodlard�r.
    app.UseSwaggerUI();//Apilerin g�rsel ayarlamalar�n� aktif hale getirir
}


app.Run();

//proje i�erisinde kullan�lan k�t�phanelerin tan�t�l�p y�netildi�i yer �zetle ayarlamalar�n�n yap�ld��� yer 
//Api endpoinlerinin metodlar� i�in test edilebilir d�k�man olu�turur
using InMemoeryApp.Presentation.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

//swagger entegration _1 
builder.Services.AddEndpointsApiExplorer();//Apinin incelenmesi ve belgelerin oluþturulmasý
builder.Services.AddSwaggerGen();//Belgeler için gerekli ayarlarý yapýyor

//Inmemory and EFCore entegrations
builder.Services.AddDbContext<AppllicationDbContext>(Options => Options.UseInMemoryDatabase("ECommerceDb"));

builder.Services.AddMediatR(x => x.RegisterServicesFromAssemblies(typeof(Program).Assembly));


var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

app.MapControllers();

//swagger entegration _2
if (app.Environment.IsDevelopment())
{
    app.UseSwagger(); //apilerin yaptýðý iþlemlerin ve bu iþlemlerin nasýl kullanýlýcaðýný açýklayan metodlardýr.
    app.UseSwaggerUI();//Apilerin görsel ayarlamalarýný aktif hale getirir
}


app.Run();

//proje içerisinde kullanýlan kütüphanelerin tanýtýlýp yönetildiði yer özetle ayarlamalarýnýn yapýldýðý yer 
//Api endpoinlerinin metodlarý için test edilebilir döküman oluþturur
using WebApplication1.DAOs.MSSDAOs;
using WebApplication1.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

#region configuración de restapi y swagger
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
#endregion

//creando el contexto
builder.Services.AddSingleton<AlumnoMSSDAO>();
builder.Services.AddSingleton<UsuarioDAO>();
builder.Services.AddSingleton<UsuariosRolesMSSDAL>();
builder.Services.AddSingleton<AlumnoService>();
builder.Services.AddSingleton<UsuarioService>();
builder.Services.AddSingleton<RolesService>();

#region identidad

builder.Services.AddAuthentication("Cookies")
    .AddCookie(options =>
    {
        options.LoginPath = "/Cuentas/Login";
        options.LogoutPath = "/Cuentas/Logout";
        options.Cookie.Name = "Cookie_authenticacion";
        options.Cookie.MaxAge = TimeSpan.FromMinutes(1);
    });

builder.Services.AddAuthorization();

builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(1);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
    options.Cookie.Name = "Cookie_session";
});

builder.Services.AddDataProtection();

#endregion


var app = builder.Build();

//if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

#region habilitando middleware adicionales
app.UseAuthentication(); //middleware para la autenticación
app.UseAuthorization();  //middleware para la autorización
app.UseSession();        //middleware para la sesión

// *** Agregar middleware de Swagger ***
app.UseSwagger();
app.UseSwaggerUI();
#endregion

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.Run();
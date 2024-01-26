namespace Projeto_Web_Lh_Pets_Alunos;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var app = builder.Build();

        app.MapGet("/", () => "PROJETO WEB - LH PETS VERSÃO 1");

            app.UseStaticFiles();
            app.MapGet("/index", (HttpContext contexto)=> {
                contexto.Response.Redirect("index.html", false );
            });
            
        Banco dba=new Banco();
        app.MapGet("/listaClientes", (HttpContext contexto) =>{
            contexto.Response.WriteAsync (dba.GetListaString());
        });

        app.Run();
    }
}

using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TCC_Final.Models;

namespace TCC_Final.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult UserCadastro(CadastroModel cadastroModel)
    {
        var Request = cadastroModel;
        return View();
    }

    public IActionResult UserLogin(LoginModel loginModel)
    {
        var Request = loginModel;
        return View();
    }

     public IActionResult Logar(LoginModel loginModel)
     {
        try{
           //if()    //verificar usuario no banco
           // { 
                // throw new Exception("usuario Incorreta");
           // }
           // else if () //vericar a senha
           //{
                // throw new Exception("Senha Incorreta");
           //}
           // else
           //{
                //logar
           //}

           throw new Exception("Usuário ou senha incorretos");
           return RedirectToAction("Index");
          }
        catch(Exception ex)
        {
             TempData["Erro"] = ex.Message + " "+ ex.InnerException;
            
        }
        return RedirectToAction("UserLogin");
     }

    public IActionResult UserRedSenha(UserRedSenhaModel userRedSenhaModel)
    {
        var Request = userRedSenhaModel;
        return View();
    }

     public IActionResult Redefinir(UserRedSenhaModel userRedSenhaModel)
     {
        try{
           //if()    //verificar usuario no banco
           // { 
                // throw new Exception("usuario Incorreta");
           // }
           // else if () //vericar a senha
           //{
                // throw new Exception("Senha Incorreta");
           //}
           // else
           //{
                //logar
           //}

           throw new Exception("Seu Email está incorreto");
           return RedirectToAction("Index");
          }
        catch(Exception teste)
        {
             TempData["EmailErro"] = teste.Message + " "+ teste.InnerException;
            
        }
        return RedirectToAction("UserRedSenha");
     }

    //Controle das Views Referentes ao Profissionais

    public IActionResult LoginMedico()
    {
        return View();
    }

    public IActionResult CadastroMedico()
    {
        return View();
    }

    public IActionResult ACMedico()
    {
        return View();
    }

    public IActionResult MedRedSenha()
    {
        return View();
    }



    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

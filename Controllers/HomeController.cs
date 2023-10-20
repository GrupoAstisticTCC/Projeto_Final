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

    public IActionResult Cadastrar(CadastroModel cadastroModel)
     {
        try{
           //if()    //verificar se os campos de senha são iguais
           // { 
                // throw new Exception("As senhas devem ser iguais");
           // }
           

           throw new Exception("As senhas devem ser iguais");
           return RedirectToAction("UserLogin");
          }
        catch(Exception ex)
        {
             TempData["Erro"] = ex.Message + " "+ ex.InnerException;
            
        }
        return RedirectToAction("UserCadastro");
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

    public IActionResult MedLogin(MedLoginModel medLoginModel)
    {
        var Inicializar = medLoginModel;
        return View();
    }

    public IActionResult Acessar(MedLoginModel medLoginModel)
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

           throw new Exception("Email ou senha incorretos");
           return RedirectToAction("Index");
          }
        catch(Exception ex)
        {
             TempData["Erro"] = ex.Message + " "+ ex.InnerException;
            
        }
        return RedirectToAction("MedLogin");
     }    

    public IActionResult MedCadastro(MedCadastroModel medCadastroModel)
    { 
        var Inicializar = medCadastroModel;
        return View();
    }


    public IActionResult Cadastro(MedLoginModel medLoginModel)
    { 
        // Cadastro no banco de dados
        var Inicializar = medLoginModel;
        return RedirectToAction("MedLogin");
    }

    public IActionResult MedRedSenha(MedRedSenhaModel medRedSenhaModel)
    {
        var Inicializar = medRedSenhaModel;
        return View();
    }

    public IActionResult Recadastrar(MedRedSenhaModel MedRedSenhaModel)
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

           throw new Exception("Email ou senha inválidos");
           return RedirectToAction("Index");
          }
        catch(Exception teste)
        {
             TempData["EmailErro"] = teste.Message + " "+ teste.InnerException;
            
        }
        return RedirectToAction("MedRedSenha");
     }

          public IActionResult AreaMed()
          {
               return View();
          }

          //Contole das Views referentes aos contatos

    public IActionResult ContatoFono()
    {
        return View();
    }

    public IActionResult ContatoTera()
    {
     return View();
    }

    public IActionResult ContatoPis()
    {
     return View();
    }

     // Area de controle das páginas com conteudo descritivo

     public IActionResult Brincadeiras()
     {
          return View();
     }

     public IActionResult Sobre()
     {
          return View();
     }

     // Area de controle das views dos jogos

     public IActionResult Games()
     {
          return View();
     }



    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

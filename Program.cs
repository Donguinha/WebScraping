// using HtmlAgilityPack;
// using System;
// using System.Net.Http;
// using System.Threading.Tasks;

// class Program
// {
//     static async Task Main(string[] args)
//     {
//         var url = "https://donguinha.github.io/portfolio/";

//         var httpClient = new HttpClient();
//         var html = await httpClient.GetStringAsync(url);

//         var htmlDocument = new HtmlDocument();
//         htmlDocument.LoadHtml(html);

//         // Exemplo: pegar todos os títulos h1 da página
//         var h1Nodes = htmlDocument.DocumentNode.SelectNodes("//h1");

//         if (h1Nodes != null)
//         {
//             foreach (var node in h1Nodes)
//             {
//                 Console.WriteLine("Título: " + node.InnerText);
//             }
//         }
//         else
//         {
//             Console.WriteLine("Nenhum título h1 encontrado.");
//         }
//     }
// }

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

class Program
{
    static void Main(string[] args)
    {
        // Configura o ChromeDriver
        var driver = new ChromeDriver();

        // Abre a página com o formulário
        driver.Navigate().GoToUrl("https://www.w3schools.com/html/html_forms.asp");

        // Aguarda até o campo de first name estar disponível
        var firstNameField = driver.FindElement(By.Id("fname"));
        firstNameField.Clear(); // Limpa o campo antes de inserir um novo valor
        firstNameField.SendKeys("teste"); // Insere "teste" no campo "First name"

        // Encontra o campo "Last name" e insere "web scraping"
        var lastNameField = driver.FindElement(By.Id("lname"));
        lastNameField.Clear();
        lastNameField.SendKeys("web scraping");

        // Encontra o botão de submit e clica nele
        var submitButton = driver.FindElement(By.CssSelector("input[type='submit']"));
        submitButton.Click();

        // Aguarda para ver o resultado (opcional)
        System.Threading.Thread.Sleep(5000);

        // Fecha o navegador
        driver.Quit();
    }
}

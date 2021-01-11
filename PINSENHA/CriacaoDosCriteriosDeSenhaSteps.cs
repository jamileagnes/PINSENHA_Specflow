using BoDi;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace PINSENHA
{
    [Binding]
    public class CriacaoDosCriteriosDeSenhaSteps
    {
        IWebDriver browser;
        private readonly IObjectContainer _objectContainer;

        public CriacaoDosCriteriosDeSenhaSteps(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;
        }

        [AfterScenario]
        public void Close()
        {
            this.browser.Close();
            this.browser.Dispose();
        }

        [When(@"acesso a tela para cadastro de senha")]
        public void QuandoAcessoATelaParaCadastroDeSenha()
        {
            browser = new ChromeDriver();

            _objectContainer.RegisterInstanceAs<IWebDriver>(browser);

            browser.Manage().Window.Maximize();

            browser.Navigate().GoToUrl("https://tsistemasweb.sefaz.ba.gov.br/sistemas/pinse/Internet/");

            browser.FindElement(By.XPath("/html/body/pinse-root/aslib/aslib-menu/nav/aslib-menu-item/ul[2]/li/a")).Click();
            Thread.Sleep(2000);

            browser.FindElement(By.XPath("/html/body/pinse-root/aslib/aslib-menu/nav/aslib-menu-item/ul[2]/li/aslib-menu-item/ul[2]/li/a")).Click();
            Thread.Sleep(2000);

            browser.FindElement(By.Name("cpf")).SendKeys("579.679.381-00");
            Thread.Sleep(2000);

        }

        [When(@"preencho o campo Senha com dados validos")]
        public void QuandoPreenchoOCampoSenhaComDadosValidos()
        {
            
        }
        
        [When(@"acesso a tela para alteração da senha")]
        public void QuandoAcessoATelaParaAlteracaoDaSenha()
        {
           
        }
        
        [When(@"preencho o campo Senha Atual com dados validos")]
        public void QuandoPreenchoOCampoSenhaAtualComDadosValidos()
        {
            
        }
        
        [When(@"preencho o campo Confirme a Senha com dados validos")]
        public void QuandoPreenchoOCampoConfirmeASenhaComDadosValidos()
        {
            browser.FindElement(By.XPath("/html/body/pinse-root/aslib/aslib-content/div/div[3]/pinse-homeservicoscomponent/pinse-sem-certificado/form/div[6]/button[1]")).Click();
            Thread.Sleep(2000);

            browser.FindElement(By.XPath("//input[@formcontrolname='senhaConfirmacao']")).SendKeys("123456a");
            Thread.Sleep(3000);


        }
        
        [When(@"preencho o campo Nova Senha com dados validos")]
        public void QuandoPreenchoOCampoNovaSenhaComDadosValidos()
        {
            
        }
        
        [When(@"preencho o campo Senha com caracteres especiais")]
        public void QuandoPreenchoOCampoSenhaComCaracteresEspeciais()
        {
            
        }
        
        [When(@"preencho o campo Senha Atual com caracteres especiais")]
        public void QuandoPreenchoOCampoSenhaAtualComCaracteresEspeciais()
        {
            
        }
        
        [When(@"preencho o campo Nova Senha com caracteres especiais")]
        public void QuandoPreenchoOCampoNovaSenhaComCaracteresEspeciais()
        {
            
        }
        
        [When(@"preencho o campo Senha com menos de (.*) caracteres")]
        public void QuandoPreenchoOCampoSenhaComMenosDeCaracteres(int p0)
        {
            
        }
        
        [When(@"preencho o campo Senha Atual com menos de (.*) caracteres")]
        public void QuandoPreenchoOCampoSenhaAtualComMenosDeCaracteres(int p0)
        {
            
        }
        
        [When(@"preencho o campo Confirme a Senha com menos de (.*) caracteres")]
        public void QuandoPreenchoOCampoConfirmeASenhaComMenosDeCaracteres(int p0)
        {
            browser.FindElement(By.XPath("/html/body/pinse-root/aslib/aslib-content/div/div[3]/pinse-homeservicoscomponent/pinse-sem-certificado/form/div[6]/button[1]")).Click();
            Thread.Sleep(2000);

            browser.FindElement(By.XPath("//input[@formcontrolname='senhaConfirmacao']")).SendKeys("1234");

            browser.FindElement(By.XPath("/html/body/aslib-modal-window/div/div/div[2]/pinse-gerenciador-senha/form/div[5]")).Click();

        }
        
        [When(@"preencho o campo Nova Senha com menos de (.*) caracteres")]
        public void QuandoPreenchoOCampoNovaSenhaComMenosDeCaracteres(int p0)
        {
            
        }
        
        [When(@"preencho o campo Confirme a Senha com valor divergente do campo Senha")]
        public void QuandoPreenchoOCampoConfirmeASenhaComValorDivergenteDoCampoSenha()
        {
            
        }
        
        [When(@"altero o campo Senha")]
        public void QuandoAlteroOCampoSenha()
        {
            
        }
        
        [When(@"altero o campo Confirme a Senha")]
        public void QuandoAlteroOCampoConfirmeASenha()
        {
            
        }
        
        [When(@"altero o campo Nova Senha")]
        public void QuandoAlteroOCampoNovaSenha()
        {
            
        }
        
        [When(@"preencho o campo Nova Senha com dados validos iguais aos do campo Senha Atual")]
        public void QuandoPreenchoOCampoNovaSenhaComDadosValidosIguaisAosDoCampoSenhaAtual()
        {
            
        }
        
        [When(@"apago os valores digitados deixando o campo vazio")]
        public void QuandoApagoOsValoresDigitadosDeixandoOCampoVazio()
        {
            browser.FindElement(By.XPath("//input[@formcontrolname='senhaConfirmacao']")).Clear();
        }
        
        [When(@"clico fora do campo")]
        public void QuandoClicoForaDoCampo()
        {
            browser.FindElement(By.XPath("/html/body/aslib-modal-window/div/div/div[2]/pinse-gerenciador-senha/form/div[5]")).Click();
        }
        
        [When(@"preencho o campo Confirme a Senha com dados validos e mesma informação preenchida no campo Senha")]
        public void QuandoPreenchoOCampoConfirmeASenhaComDadosValidosEMesmaInformacaoPreenchidaNoCampoSenha()
        {
            
        }
        
        [When(@"clico no botão Confirmar")]
        public void QuandoClicoNoBotaoConfirmar()
        {
            
        }
        
        [When(@"preencho o campo Nova Senha com dados validos e informações diferentes da preenshida no campo Senha Atual")]
        public void QuandoPreenchoOCampoNovaSenhaComDadosValidosEInformacoesDiferentesDaPreenshidaNoCampoSenhaAtual()
        {
            
        }
        
        [When(@"preencho o campo Confirme a Senha com dados validos e mesma informação preenchida no campo Nova Senha")]
        public void QuandoPreenchoOCampoConfirmeASenhaComDadosValidosEMesmaInformacaoPreenchidaNoCampoNovaSenha()
        {
            
        }
        
        [Then(@"o sistema permite a digitação da senha")]
        public void EntaoOSistemaPermiteADigitacaoDaSenha()
        {
            
        }
        
        [Then(@"mantem o botão Confirmar desabilitado")]
        public void EntaoMantemOBotaoConfirmarDesabilitado()
        {
            browser.FindElement(By.XPath("/html/body/aslib-modal-window/div/div/div[2]/pinse-gerenciador-senha/form/div[5]/button[1]"));
            Thread.Sleep(3000);
        }
        
        [Then(@"o sistema somente permite a digitação no campo senha de números ou letras")]
        public void EntaoOSistemaSomentePermiteADigitacaoNoCampoSenhaDeNumerosOuLetras()
        {
            
        }
        
        [Then(@"o sistema exibe ao lado do campo mensagem informando que ""(.*)""")]
        public void EntaoOSistemaExibeAoLadoDoCampoMensagemInformandoQue(string p0)
        {
            string confirmeSenha = browser.FindElement(By.XPath("/html/body/aslib-modal-window/div/div/div[2]/pinse-gerenciador-senha/form/div[4]/div[2]/div[2]/h6")).Text;
            Assert.AreEqual("As senhas não conferem !", confirmeSenha);
            Thread.Sleep(2000);
        }
        
        [Then(@"o sistema exibe mensagem de sucesso ""(.*)""")]
        public void EntaoOSistemaExibeMensagemDeSucesso(string p0)
        {
            
        }
        
        [Then(@"botão OK")]
        public void EntaoBotaoOK()
        {
            
        }
    }
}

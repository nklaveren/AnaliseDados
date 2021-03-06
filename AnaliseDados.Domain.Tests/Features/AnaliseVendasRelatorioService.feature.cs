﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.4.0.0
//      SpecFlow Generator Version:3.4.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace AnaliseDados.Domain.Tests.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class AnaliseVendasFeature : object, Xunit.IClassFixture<AnaliseVendasFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "AnaliseVendasRelatorioService.feature"
#line hidden
        
        public AnaliseVendasFeature(AnaliseVendasFeature.FixtureData fixtureData, AnaliseDados_Domain_Tests_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("pt-br"), "Features", "Análise Vendas", "o serviço deve ser capaz de traduzir as três entradas possíveis de dados e conver" +
                    "ter\r\nem entidades do dominio.\r\nExistem 3 tipos de dados dentro desses arquivos.\r" +
                    "\nPara cada tipo de dados há um layout diferente.", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        void System.IDisposable.Dispose()
        {
            this.TestTearDown();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Dados do vendedor")]
        [Xunit.TraitAttribute("FeatureTitle", "Análise Vendas")]
        [Xunit.TraitAttribute("Description", "Dados do vendedor")]
        [Xunit.TraitAttribute("Category", "(AnaliseVendasRelatorioService)")]
        public virtual void DadosDoVendedor()
        {
            string[] tagsOfScenario = new string[] {
                    "(AnaliseVendasRelatorioService)"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Dados do vendedor", null, tagsOfScenario, argumentsOfScenario);
#line 9
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                            "Linha"});
                table1.AddRow(new string[] {
                            "001ç1234567891234çPedroç50000"});
#line 10
 testRunner.Given("que tenho dados do vendedor", ((string)(null)), table1, "Dado ");
#line hidden
                TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                            "Tipo",
                            "CPF",
                            "Nome",
                            "Salario"});
                table2.AddRow(new string[] {
                            "001",
                            "1234567891234",
                            "Pedro",
                            "50000"});
#line 13
 testRunner.Then("O resultado esperado é uma instancia de um vendedor:", ((string)(null)), table2, "Então ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Dados do Cliente")]
        [Xunit.TraitAttribute("FeatureTitle", "Análise Vendas")]
        [Xunit.TraitAttribute("Description", "Dados do Cliente")]
        [Xunit.TraitAttribute("Category", "(AnaliseVendasRelatorioService)")]
        public virtual void DadosDoCliente()
        {
            string[] tagsOfScenario = new string[] {
                    "(AnaliseVendasRelatorioService)"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Dados do Cliente", null, tagsOfScenario, argumentsOfScenario);
#line 18
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                            "Linha"});
                table3.AddRow(new string[] {
                            "002ç2345675434544345çJose da SilvaçRural"});
#line 19
 testRunner.Given("que tenho dados do Cliente", ((string)(null)), table3, "Dado ");
#line hidden
                TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                            "Tipo",
                            "CNPJ",
                            "Nome",
                            "Area Negocio"});
                table4.AddRow(new string[] {
                            "002",
                            "2345675434544345",
                            "Jose da Silva",
                            "Rural"});
#line 22
 testRunner.Then("O resultado esperado é uma instancia de um Cliente:", ((string)(null)), table4, "Então ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Dados da venda")]
        [Xunit.TraitAttribute("FeatureTitle", "Análise Vendas")]
        [Xunit.TraitAttribute("Description", "Dados da venda")]
        [Xunit.TraitAttribute("Category", "(AnaliseVendasRelatorioService)")]
        public virtual void DadosDaVenda()
        {
            string[] tagsOfScenario = new string[] {
                    "(AnaliseVendasRelatorioService)"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Dados da venda", null, tagsOfScenario, argumentsOfScenario);
#line 27
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                            "linha"});
                table5.AddRow(new string[] {
                            "003ç10ç[1-10-100,2-30-2.50,3-40-3.10]çPedro"});
#line 28
 testRunner.Given("que tenho dados da venda", ((string)(null)), table5, "Dado ");
#line hidden
                TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                            "Tipo",
                            "Venda Id",
                            "Item",
                            "Vendedor Nome"});
                table6.AddRow(new string[] {
                            "003",
                            "10",
                            "[1-10-100,2-30-2.50,3-40-3.10]",
                            "Pedro"});
#line 31
 testRunner.Then("O resultado esperado é uma instancia de uma Venda:", ((string)(null)), table6, "Então ");
#line hidden
                TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                            "Item ID",
                            "Item Quantidade",
                            "Item Preço"});
                table7.AddRow(new string[] {
                            "1",
                            "10",
                            "100"});
                table7.AddRow(new string[] {
                            "2",
                            "30",
                            "2.50"});
                table7.AddRow(new string[] {
                            "3",
                            "40",
                            "3.10"});
#line 34
 testRunner.And("os itens da da venda são:", ((string)(null)), table7, "E ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Relatório completo")]
        [Xunit.TraitAttribute("FeatureTitle", "Análise Vendas")]
        [Xunit.TraitAttribute("Description", "Relatório completo")]
        [Xunit.TraitAttribute("Category", "(AnaliseVendasRelatorioService)")]
        public virtual void RelatorioCompleto()
        {
            string[] tagsOfScenario = new string[] {
                    "(AnaliseVendasRelatorioService)"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Relatório completo", null, tagsOfScenario, argumentsOfScenario);
#line 41
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                            "Linhas"});
                table8.AddRow(new string[] {
                            "001ç1234567891234çPedroç50000"});
                table8.AddRow(new string[] {
                            "001ç3245678865434çPauloç40000.99"});
                table8.AddRow(new string[] {
                            "002ç2345675434544345çJose da SilvaçRural"});
                table8.AddRow(new string[] {
                            "002ç2345675433444345çEduardo PereiraçRural"});
                table8.AddRow(new string[] {
                            "003ç10ç[1-10-100,2-30-2.50,3-40-3.10]çPedro"});
                table8.AddRow(new string[] {
                            "003ç08ç[1-34-10,2-33-1.50,3-40-0.10]çPaulo"});
#line 42
 testRunner.Given("que tenho as informações:", ((string)(null)), table8, "Dado ");
#line hidden
                TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                            "Quantidade Clientes",
                            "Quantidade Vendededor",
                            "Venda mais cara",
                            "Pior Vendedor"});
                table9.AddRow(new string[] {
                            "2",
                            "2",
                            "10",
                            "Paulo"});
#line 50
 testRunner.Then("O resultado esperado da analise é:", ((string)(null)), table9, "Então ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.4.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                AnaliseVendasFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                AnaliseVendasFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion

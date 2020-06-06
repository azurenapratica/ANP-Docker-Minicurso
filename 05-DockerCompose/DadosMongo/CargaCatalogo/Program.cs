using System;
using System.IO;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace CargaCatalogo
{
    class Program
    {
        static void Main()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile($"appsettings.json");
            var configuration = builder.Build();

            MongoClient client = new MongoClient(
                configuration.GetConnectionString("ConexaoCatalogo"));
            IMongoDatabase db = client.GetDatabase("DBCatalogo");

            Console.WriteLine("Incluindo produtos...");

            var catalogoProdutos = db.GetCollection<Produto>("Catalogo");

            Produto prod00001 = new Produto();
            prod00001.Codigo = "PROD00001";
            prod00001.Nome = "Detergente";
            prod00001.Tipo = "Limpeza";
            prod00001.Preco = 5.75;
            prod00001.DadosFornecedor = new Fornecedor();
            prod00001.DadosFornecedor.Codigo = "FORN00001";
            prod00001.DadosFornecedor.Nome = "EMPRESA XYZ";
            catalogoProdutos.InsertOne(prod00001);

            Produto prod00002 = new Produto();
            prod00002.Codigo = "PROD00002";
            prod00002.Nome = "Martelo";
            prod00002.Tipo = "Ferramentas";
            prod00002.Preco = 50.70;
            prod00002.DadosFornecedor = new Fornecedor();
            prod00002.DadosFornecedor.Codigo = "FORN00002";
            prod00002.DadosFornecedor.Nome = "ABCD FERRAMENTAS";
            catalogoProdutos.InsertOne(prod00002);

            Console.WriteLine("Incluindo serviços...");

            var catalogoServicos = db.GetCollection<Servico>("Catalogo");

            Servico serv00001 = new Servico();
            serv00001.Codigo = "SERV00001";
            serv00001.Nome = "LIMPEZA PREDIAL";
            serv00001.ValorHora = 150.00;
            catalogoServicos.InsertOne(serv00001);

            Servico serv00002 = new Servico();
            serv00002.Codigo = "SERV00002";
            serv00002.Nome = "GUARDA PATRIMONIAL";
            serv00002.ValorHora = 250.00;
            catalogoServicos.InsertOne(serv00002);

            Console.WriteLine("Finalizado!");
        }
    }
}
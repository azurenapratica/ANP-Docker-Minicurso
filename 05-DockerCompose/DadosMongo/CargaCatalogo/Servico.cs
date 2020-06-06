using MongoDB.Bson;

namespace CargaCatalogo
{
    public class Servico
    {
        public ObjectId _id { get; set; }
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public double ValorHora { get; set; }
    }
}
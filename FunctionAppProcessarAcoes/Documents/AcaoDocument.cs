using MongoDB.Bson;

namespace FunctionAppProcessarAcoes.Documents
{
    public class AcaoDocument
    {
        public ObjectId _id { get; set; }
        public string Codigo { get; set; }
        public double Valor { get; set; }
        public string DataReferencia { get; set; }        
    }
}
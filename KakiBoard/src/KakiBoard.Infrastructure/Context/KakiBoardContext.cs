using System.Collections.ObjectModel;
using MongoDB.Driver;
using System.Configuration;

namespace KakiBoard.Infrastructure.Context
{
    public class KakiBoardContext
    {
        public const string CONNECTION_STRING_NAME = "KakiBoardConnnection";
        public const string DATABASE_NAME = "kakiboard";

        private static readonly IMongoClient _client;
        private static readonly IMongoDatabase _database;

        static KakiBoardContext()
        {
            var connectionString = ConfigurationManager.ConnectionStrings[CONNECTION_STRING_NAME].ConnectionString;
            _client = new MongoClient(connectionString);
            _database = _client.GetDatabase(DATABASE_NAME);
        }      
        
        public IMongoClient Client
        {
            get { return _client; }
        }  

        public IMongoDatabase DataBase
        {
            get { return _database; }
        }
       
        //public IMongoCollection<Usuario> Usuarios { get; set; }
        //public IMongoCollection<Tarefa> Tarefas { get; set; }
        //public IMongoCollection<Tipo> Tipos { get; set; }
        //public IMongoCollection<Projeto> Projetos { get; set; }
        //public IMongoCollection<Status> Status { get; set; }

        //public MongoCollection<Usuario> Usuarios { get; set; }
        //public MongoCollection<Tarefa> Tarefas { get; set; }
        //public MongoCollection<Tipo> Tipos { get; set; }
        //public MongoCollection<Projeto> Projetos { get; set; }
        //public MongoCollection<Status> Status { get; set; }

    }
}

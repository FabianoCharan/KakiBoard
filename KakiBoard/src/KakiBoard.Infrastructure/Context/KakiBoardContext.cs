using KakiBoard.Domain.Tarefa.Models;
using KakiBoard.Domain.Usuario.Models;
using MongoDB.Driver;
using System.Configuration;

namespace KakiBoard.Infrastructure.Context
{
    public class KakiBoardContext
    {
        public const string CONNECTION_STRING_NAME = "KakiBoardConnnection";
        public const string DATABASE_NAME = "Kakiboard";
        public const string TAREFAS_COLLECTION_NAME = "tarefas";
        public const string USUARIOS_COLLECTION_NAME = "usuarios";

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

        public IMongoCollection<Usuario> Usuarios
        {
            get { return _database.GetCollection<Usuario>(USUARIOS_COLLECTION_NAME); }
        }

        public IMongoCollection<Tarefa> Tarefas
        {
            get { return _database.GetCollection<Tarefa>(TAREFAS_COLLECTION_NAME); }
        }
    }
}

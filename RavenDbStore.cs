using Raven.Client.Documents;
using Raven.Client.ServerWide;
using Raven.Client.ServerWide.Operations;
using Raven.Client;


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuervoBD;

public static class RavenDbStore
{
    private static Lazy<IDocumentStore> _store = new Lazy<IDocumentStore>(() =>
    {
        var store = new DocumentStore
        {
            Urls = new[] { "http://localhost:8080" },
            Database = "PersonasDB"
        };

        store.Initialize();
        EnsureDatabaseExists(store, store.Database);
        return store;
    });

    public static IDocumentStore Store => _store.Value;

    private static void EnsureDatabaseExists(IDocumentStore store, string database)
    {
        try
        {
            var record = store.Maintenance.Server.Send(new GetDatabaseRecordOperation(database));
            if (record == null)
            {
                store.Maintenance.Server.Send(new CreateDatabaseOperation(new DatabaseRecord(database)));
                Console.WriteLine($"Base de datos '{database}' creada.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al verificar/crear la base de datos: {ex.Message}");
            throw;
        }
    }
}
using Raven.Client.Documents;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuervoBD;

public class PersonaRepository
{
    private readonly IDocumentStore _store;

    public PersonaRepository(IDocumentStore store)
    {
        _store = store;
    }

    public List<Persona> GetAll()
    {
        using var session = _store.OpenSession();
        return session.Query<Persona>().ToList();
    }

    public Persona? GetById(string id)
    {
        using var session = _store.OpenSession();
        return session.Load<Persona>(id);
    }

    public void Add(Persona persona)
    {
        using var session = _store.OpenSession();
        session.Store(persona);
        session.SaveChanges();
    }

    public void Update(Persona persona)
    {
        using var session = _store.OpenSession();
        session.Store(persona); // Si tiene ID existente, lo actualiza
        session.SaveChanges();
    }

    public void Delete(string id)
    {
        using var session = _store.OpenSession();
        session.Delete(id);
        session.SaveChanges();
    }
}


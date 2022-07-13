using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstClassCollections;

public class ClientService
{
    private readonly ILogger _logger;
    private readonly Dictionary<Guid,Client> _clients = new (); 

    public ClientService(ILogger logger)
    {
        _logger = logger;
    }
    public Client Create(string name) {

        var client = new Client() { Name=name};
        _clients.Add(Guid.NewGuid(), client);
        return client;
    }
    public Client GetById(Guid id) {
        return _clients.GetValueOrDefault(id);
    }
}

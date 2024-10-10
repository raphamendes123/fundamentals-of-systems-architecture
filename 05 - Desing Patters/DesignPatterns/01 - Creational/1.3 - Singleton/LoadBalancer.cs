using System;
using System.Collections.Generic;

namespace DesignPatterns
{
    //TESTES DE CHAMADA DE REQUISIÇOES
    //UMA INSTANCIA DE GRAVAR ARQUIVO, SEM TER QUE ALOCAR MAIS MEMORIA
    //GRAVACAO DE LOG
    //SE ESTIVER USANDO D.I, SO INJETAR 

    //somente instanciada
    internal sealed class LoadBalancer
    {
        //propria classe em si - MESMA INSTANCIA (STATIC)
        private static readonly LoadBalancer Instance = new LoadBalancer();

        private readonly List<Server> _servers;
        private readonly Random _random = new Random();


        //carrega servers
        private LoadBalancer()
        {
            _servers = new List<Server>
            {
                 new Server{ Id=Guid.NewGuid(),  Name = "ServerI", IP = "120.14.220.18" },
                 new Server{ Id=Guid.NewGuid(), Name = "ServerII", IP = "120.14.220.19" },
                 new Server{ Id=Guid.NewGuid(), Name = "ServerIII", IP = "120.14.220.20" },
                 new Server{ Id=Guid.NewGuid(), Name = "ServerIV", IP = "120.14.220.21" },
                 new Server{ Id=Guid.NewGuid(), Name = "ServerV", IP = "120.14.220.22" },
            };
        }

        public static LoadBalancer GetLoadBalancer()
        {
            return Instance;
        }

        public Server NextServer
        {
            get
            {
                var r = _random.Next(_servers.Count);
                
                //retorna um servidor randomicamente.
                return _servers[r];
            }
        }
    }
}
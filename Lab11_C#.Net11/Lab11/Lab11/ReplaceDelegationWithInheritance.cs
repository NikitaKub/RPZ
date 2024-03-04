using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    internal class ReplaceDelegationWithInheritance
    {
        public void Example()
        {
            Server server = new Server();
            server.Name = "test";
            server.Welcome();
        }

        public void RefactoredExample()
        {
            RefactoredServer refactoredServer = new RefactoredServer();
            refactoredServer.Name = "test";
            refactoredServer.Welcome();
        }
    }

    //<----------- Ex 1 ----------->

    // Replace Delegation with Inheritance

    class User
    {
        public int Age { get; set; }
        public string Name { get; set; }
    }

    class Server
    {
        private User user = new User();

        public string Name { get { return user.Name; } set { user.Name = value; } }

        public void Welcome()
        {
            Console.WriteLine("Welcome " + Name);
        }
    }

    //<----------- Refactored ----------->

    class RefactoredUser
    {
        public int Age { get; set; }
        public string Name { get; set; }
    }

    class RefactoredServer : RefactoredUser
    {
        public void Welcome()
        {
            Console.WriteLine("Welcome " + Name);
        }
    }
}

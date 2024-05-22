using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_05_22_2_EagerSingleton {
    public class ServerCollectionManager {
        private List<string> servers;
        public List<string> Collection { get { return servers; } }
        private ServerCollectionManager instance = new ServerCollectionManager();
        public ServerCollectionManager Instance { get { return instance; } }
        private static readonly object padlock = new object();
        private ServerCollectionManager() {
            servers = new List<string>();
        }

        public bool addServer(string serverName) {
            if (serverName.Contains("http://www.") || serverName.Contains("https://www.")) {
                if (!servers.Contains(serverName)) {
                    servers.Add(serverName);
                    return true;
                }
            }
            return false;
        }

        public bool removeServer(string serverName) {
            return servers.Remove(serverName);
        }

        public bool removeServerAt(int index) {
            try {
                servers.RemoveAt(index);
                return true;
            } catch {
                return false;
            }
        }

        public bool addServerAt(string serverName, int index) {
            if (serverName.Contains("http://www.") || serverName.Contains("https://www.")) {
                if (!servers.Contains(serverName)) {
                    servers.Insert(index, serverName);
                    return true;
                }
            }
            return false;
        }
    }
}

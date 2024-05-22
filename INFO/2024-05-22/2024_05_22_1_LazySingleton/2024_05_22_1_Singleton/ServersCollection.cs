using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace _2024_05_22_1_Singleton {
    public class ServersCollection { //lazy singleton
        private static List<string> servers;
        private static ServersCollection instance;
        public static ServersCollection Instance {
            get {
                if (instance == null) {
                    instance = new ServersCollection();
                }
                return instance; 
            }
        }

        public static List<string> Collection {
            get {
                return servers; 
            }
        }

        private ServersCollection() {
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

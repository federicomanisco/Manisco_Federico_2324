using System.Collections.Concurrent;

namespace _2024_05_22_2_EagerSingleton {
    public class ServerCollectionManager {
        private ConcurrentQueue<string> coda;
        private List<string> servers;
        private static ServerCollectionManager instance = new ServerCollectionManager();
        public ConcurrentQueue<string> Queue { get { return coda; } }
        public List<string> Collection { get { return servers; } }
        public static ServerCollectionManager Instance { get { return instance; } }
        private ServerCollectionManager() {
            coda = new ConcurrentQueue<string>();
            servers = new List<string>();
        }
    }
}

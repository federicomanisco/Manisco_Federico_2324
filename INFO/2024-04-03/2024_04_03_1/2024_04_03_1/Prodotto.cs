using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_04_03_1
{
    public class Prodotto : IDisposable
    {
        private static List<string> ids;

        private string id;
        private string nome;
        public string Id
        {
            get { return id; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Il codice non può essere vuoto.");
                }

                if (ids.Contains(value))
                {
                    throw new ArgumentException("Codice già in uso.");
                }
                ids.Add(value);
                id = value;
            }
        }

        public string Nome
        {
            get { return nome; }
            set
            {
                if (value.Length < 8)
                {
                    throw new ArgumentException("Nome troppo corto.");
                }
                nome = value;
            }
        }

        public Prodotto(string id, string nome)
        {
            ids = new List<string>();
            this.nome = nome;
            Id = id;
        }

        public override string ToString()
        {
            return $"{Nome} - {Id}";
        }

        public void Dispose()
        {
            ids.Remove(id);
        }
    }
}

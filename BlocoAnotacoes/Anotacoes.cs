using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlocoAnotacoes
{
    class Anotacoes
    {
        private string titulo;
        private string texto;
        private DateTime data;

        public Anotacoes(string titulo, string texto, DateTime data)
        {
            this.titulo = titulo;
            this.texto = texto;
            this.data = data;
        }

        public Anotacoes()
        {
            titulo = "";
            texto = "";
            data = Convert.ToDateTime("");
        }

        public void setTitulo(string valor)
        {
            this.titulo = valor;
        }
        public string getTitulo()
        {
            return this.titulo;
        }
        public void setTexto(string valor)
        {
            this.texto = valor;
        }
        public string getTexto()
        {
            return this.texto;
        }
        public void setData(DateTime valor)
        {
            this.data = valor;
        }
        public DateTime getData()
        {
            return this.data;
        }
    }
}

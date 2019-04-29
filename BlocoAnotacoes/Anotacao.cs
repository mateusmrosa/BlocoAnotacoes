using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlocoAnotacoes
{
    class Anotacao
    {
        private string titulo;
        private string texto;
        private DateTime data;

        public string Titulo { get => titulo; set => titulo = value; }
        public string Texto { get => texto; set => texto = value; }
        public DateTime Data { get => data; set => data = value; }

        public Anotacao(string titulo, string texto, DateTime data)
        {
            this.Titulo = titulo;
            this.Texto = texto;
            this.Data = data;
        }

        public Anotacao()
        {
            Titulo = "";
            Texto = "";
            Data = Convert.ToDateTime("");
        }

        //public void setTitulo(string valor)
        //{
        //    this.titulo = valor;
        //}
        //public string getTitulo()
        //{
        //    return this.titulo;
        //}
        //public void setTexto(string valor)
        //{
        //    this.texto = valor;
        //}
        //public string getTexto()
        //{
        //    return this.texto;
        //}
        //public void setData(DateTime valor)
        //{
        //    this.data = valor;
        //}
        //public DateTime getData()
        //{
        //    return this.data;
        //}
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlocoAnotacoes
{
    class BlocoAnotacoes
    {
        class BlocoAnotacao
        {
            private string _nome;
            private int _numPaginas;
            private List<Anotacao> _Anotacoes;

            public BlocoAnotacao(string nome)
            {
                _nome = nome;
                _numPaginas = 0;
                _Anotacoes = new List<Anotacao>();
            }
            public BlocoAnotacao()
            {
                _nome = "";
                _numPaginas = 0;
                _Anotacoes = new List<Anotacao>();
            }

            public BlocoAnotacao(string nome, int numPaginas, List<Anotacao> blocoAnotacoes)
            {
                _nome = nome;
                _numPaginas = numPaginas;
                _Anotacoes = blocoAnotacoes;
            }

            public void Inserir(string titulo, string texto, DateTime data)
            {
                Anotacao anotacao = new Anotacao(titulo, texto, data);
                Anotacoes.Add(anotacao);
                _numPaginas += 1;
            }

            public void Inserir(Anotacao anotacao)
            {
                Anotacoes.Add(anotacao);
                _numPaginas += 1;
            }

            public Anotacao Buscar(string titulo)
            {
                Anotacao retorno = null;
                for (int i = 0; i <= Anotacoes.Count(); i++)
                {
                    if (Anotacoes[i].Titulo == titulo)
                    {
                        retorno = new Anotacao();
                        retorno.Data = Anotacoes[i].Data;
                        retorno.Titulo = Anotacoes[i].Titulo;
                        retorno.Texto = Anotacoes[i].Texto;
                    }
                }
                return retorno;
            }

            public List<Anotacao> BuscarTodas(string filtro)
            {
                List<Anotacao> ListaAux = null;
                foreach (Anotacao nota in _Anotacoes)
                {
                    if (nota.Texto.IndexOf(filtro) > 0 || nota.Titulo.IndexOf(filtro) > 0)
                    {
                        if (ListaAux == null)
                            ListaAux = new List<Anotacao>();
                        ListaAux.Add(nota);
                    }
                }
                return ListaAux;
            }

            public List<Anotacao> BuscarTodasData(DateTime Data)
            {
                List<Anotacao> ListaAux = null;
                foreach (Anotacao nota in _Anotacoes)
                {
                    if (nota.Data == Data)
                    {
                        if (ListaAux == null)
                            ListaAux = new List<Anotacao>();
                        ListaAux.Add(nota);
                    }
                }
                return ListaAux;
            }

            public void Apagar(Anotacao anotacao)
            {
                foreach (Anotacao nota in _Anotacoes)
                {
                    if (nota == anotacao)
                    {
                        _Anotacoes.Remove(nota);
                    }
                }

            }

            public void Salvar(Anotacao anotacao)
            {
                StreamWriter salvar = new StreamWriter(@"c:\bloco.txt");
                string linha = "";
                foreach (Anotacao nota in _Anotacoes)
                {
                    linha += nota.Data + "|" + nota.Titulo + "|" + nota.Texto;
                    salvar.WriteLine(linha);
                }
                salvar.Close();
            }

            public string Nome { get => _nome; set => _nome = value; }
            public int NumPaginas { get => _numPaginas; set => _numPaginas = value; }
            public List<Anotacao> Anotacoes { get => _Anotacoes; set => _Anotacoes = value; }




        }
    }
}

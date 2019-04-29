using System;
using System.Collections.Generic;
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
                Anotacao anotacao = new Anotacao( titulo, texto, data);
                Anotacoes.Add(anotacao);
                _numPaginas += 1;
            }

            public void Inserir(Anotacao anotacao)
            {
                Anotacoes.Add(anotacao);
                _numPaginas += 1;
            }

            public Anotacao BuscaAnotacao(string titulo)
            {
                return _Anotacoes.Find(x => x.Titulo.Contains(titulo));
            }

            public Boolean BuscaAnotacoes(Anotacao anotacao)
            {
                return _Anotacoes.Contains(anotacao);
            }

            public List<Anotacao> BuscaAnotacoes(string filtro)
            {
                List<Anotacao> ListaAux= null;
                foreach (Anotacao nota in _Anotacoes)
                {
                    if (nota.Texto == filtro || nota.Titulo == filtro)
                    {
                        if (ListaAux.Count == 0)
                            ListaAux = new List<Anotacao>();

                    }
                }
                return ListaAux;
            }

            //public Anotacao GetAnotacao(int index)
            //{
            //    Anotacao anot = new Anotacao();
            //    for (int i = 0; i <= _Anotacoes.Count - 1; i++)
            //    {
            //        if (_Anotacoes[i].Index == index)
            //        {
            //            anot = _Anotacoes[i];
            //            break;
            //        }
            //    }
            //    return anot;
            //}

            public string Nome { get => _nome; set => _nome = value; }
            public int NumPaginas { get => _numPaginas; set => _numPaginas = value; }
            public List<Anotacao> Anotacoes { get => _Anotacoes; set => _Anotacoes = value; }




        }
    }
}

using Aviacao;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AviacaoWPF.ViewModel
{
    public class PessoasViewModel
    {
        public ObservableCollection<Pessoa> Pessoas { get; set; }

        public Pessoa PessoaSelecionada { get; set; }

        public Boolean PodeRemover
        {
            get
            {
                return this.PessoaSelecionada != null;
            }
        }
        private ModelAviacao context = new ModelAviacao();

        public PessoasViewModel()
        {
            this.Pessoas = new ObservableCollection<Pessoa>(context.Pessoas.ToList());

            this.PessoaSelecionada = context.Pessoas.FirstOrDefault();
        }

        public void Salvar()
        {
            this.context.SaveChanges();
        }

        public void Remover()
        {
            if (PessoaSelecionada.Id != 0)
            {
                this.context.Pessoas.Remove(this.PessoaSelecionada);
            }
            this.Pessoas.Remove(this.PessoaSelecionada);
            
        }

        public void Adicionar()
        {
            Pessoa p = new Pessoa();
            this.Pessoas.Add(p);
            this.context.Pessoas.Add(p);
            this.PessoaSelecionada = p;
        }
    }
}

using Aviacao;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AviacaoWPF.ViewModel
{
    public class CidadesViewModel
    {
        public ObservableCollection<Cidade> Cidades { get; set; }

        public Cidade CidadeSelecionada { get; set; }

        private ModelAviacao Context = new ModelAviacao();

        public CidadesViewModel()
        {
            this.Cidades = new ObservableCollection<Cidade>(Context.Cidades.ToList());

            this.CidadeSelecionada = Context.Cidades.FirstOrDefault();
        }

        public void Adicionar()
        {
            Cidade c = new Cidade();
            this.Cidades.Add(c);
            this.Context.Cidades.Add(c);
            this.CidadeSelecionada = c;
        }

        public void Salvar()
        {
            this.Context.SaveChanges();    
        }
    }
}

using Aplicacao;
using Modelo;
using System.Collections.Generic;

namespace LojaOnline.Models
{
    public class BicicletaViewModel
    {
        public int Id { get; set; }

        public string Modelo { get; set; }

        public decimal Preco { get; set; }

        public decimal PrecoProposto { get; set; }

        public static List<BicicletaViewModel> Listar()
        {
            List<BicicletaViewModel> retorno = new List<BicicletaViewModel>();
            BicicletaService bs = new BicicletaService();

            var bicicletas = bs.Listar();

            foreach (var b in bicicletas)
            {
                BicicletaViewModel bicicleta = new BicicletaViewModel();
                bicicleta.Id = b.Id;
                bicicleta.Modelo = b.Modelo;
                bicicleta.Preco = b.Preco;
                bicicleta.PrecoProposto = b.PrecoProposto;

                retorno.Add(bicicleta);
            }

            return retorno;
        }

        public static int Atualizar(BicicletaViewModel bicicletaViewModel)
        {
            BicicletaService bs = new BicicletaService();
            Bicicleta bicicleta = new Bicicleta();

            bicicleta.Id = bicicletaViewModel.Id;
            bicicleta.Modelo = bicicletaViewModel.Modelo;
            bicicleta.Preco = bicicletaViewModel.Preco;

            bs.Alterar(bicicleta);

            return 1;
        }

    }
}

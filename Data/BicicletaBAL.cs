using Modelo;
using System.Collections.Generic;
using System.Linq;

namespace Data
{
    public class BicicletaBAL
    {
        public List<Bicicleta> Listar()
        {
            List<Bicicleta> bicicletas = new List<Bicicleta>();
            BicicletaDataContext db = new BicicletaDataContext();
            BicicletaEstoqueDataContext dbEstoque = new BicicletaEstoqueDataContext();

            var resultado = from b in db.ListBicicletas() select b;

            foreach (var b in resultado)
            {
                Bicicleta bicicleta = new Bicicleta();
                bicicleta.Id = b.Id;
                bicicleta.Modelo = b.Modelo;
                bicicleta.Preco = b.Preco;

                var precoProposto = (from be in dbEstoque.SearchBicicletas(b.Modelo) select be.PrecoProposto).FirstOrDefault();

                bicicleta.PrecoProposto = precoProposto;
                
                bicicletas.Add(bicicleta);
            }

            return bicicletas;
        }

        public void Adicionar(Bicicleta bicicleta)
        {
            BicicletaDataContext db = new BicicletaDataContext();
            db.AddBicicleta(bicicleta.Modelo, bicicleta.Preco);
        }

        public void Alterar(Bicicleta bicicleta)
        {
            BicicletaDataContext db = new BicicletaDataContext();
            db.UpdateBicicleta(bicicleta.Id, bicicleta.Modelo, bicicleta.Preco);
        }

        public void Excluir(Bicicleta bicicleta)
        {
            BicicletaDataContext db = new BicicletaDataContext();
            db.DeleteBicicleta(bicicleta.Id);
        }
    }
}

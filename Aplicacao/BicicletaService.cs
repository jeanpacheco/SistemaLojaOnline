using Data;
using Modelo;
using System.Collections.Generic;


namespace Aplicacao
{
    public class BicicletaService
    {
        BicicletaBAL bicicletaBAL = new BicicletaBAL();

        public void Adicionar(Bicicleta bicicleta)
        {
            bicicletaBAL.Adicionar(bicicleta);
        }

        public void Excluir(Bicicleta bicicleta)
        {
            bicicletaBAL.Excluir(bicicleta);
        }

        public void Alterar(Bicicleta bicicleta)
        {
            bicicletaBAL.Alterar(bicicleta);
        }

        public List<Bicicleta> Listar()
        {
            return bicicletaBAL.Listar();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Cafetera : Electrodomestico
    {
        public Cafetera(string nome) : base(nome)   //Construtor que recibe nome, y automaticamente pasamos para base, que es la clase pai (Electrodomestico)
        {
        }

        private static void AquecerAgua() { }       //Metodo, que colocamos static porque va pertenecer a la propia clase

        private static void ColocarCapsula() { }    //Metodo, que colocamos static porque va pertenecer a la propia clase

        public void PrepararCafe()                  //Metodo
        {
            AquecerAgua();
            ColocarCapsula();

            //aqui vienen los demas pasos
        }
        
        //Aplicando Polimorfismo
        public override void Desligar()          //Implementamos de Electrodomesticos, pues son obligatorios al ser "abstract" na clase pai
        {
            throw new NotImplementedException();
        }

        public override void Ligar()            //Implementamos de Electrodomesticos, pues son obligatorios al ser "abstract" na clase pai
        {
            throw new NotImplementedException();
        }

        // Demonos de cuenta, que en la clase Electrodomestico tenemos otro metodo "Pausar", pero este no nos obliga implementarlo
        // pues es "virtual", y ya tiene implementacion dentro de él. 
        // Tambien podriamos llamarle, y cambiarle su comportamiento con "override", esto tambien es polimorfirmo.
    }
}

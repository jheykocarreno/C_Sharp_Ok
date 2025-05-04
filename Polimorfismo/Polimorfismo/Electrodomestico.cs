using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public abstract class Electrodomestico
    {
        private readonly string _nome;

        //Construtor que exige nombre
        public Electrodomestico (string nome)
        {
            _nome = nome;
        }

        //Método
        public abstract void Ligar();       //Definimos como abstract porque no tiene implementacion, no pueden ser instanciados. Obligamos a que la 
                                            //clase que herede a esta, llame a este metodo y lo implemente. 
                                            //Esto es Polimorfismo.
        public abstract void Desligar();    //Definimos como abstract porque no tiene implementacion, no pueden ser instanciados.
                                            //clase que herede a esta, llame a este metodo y lo implemente.
                                            //Esto es Polimorfismo

        public virtual void Pausar()        //Definimos como virtual. Este metodo si tiene que tener implementacion, y puede ser modificado
        {                                   //Esto tambien es Polimorfismo
            Console.WriteLine("Pausamos el eletrocdomestico");
        }

        public void Testar()                //Método comun. Este metodo debe tener implementacion. No puede ser modificado. No podemos utilizar override
        {                                   //Este metodo no es Polimorfico
            Console.WriteLine("Testamos el electrodomestico");
        }
    }
}

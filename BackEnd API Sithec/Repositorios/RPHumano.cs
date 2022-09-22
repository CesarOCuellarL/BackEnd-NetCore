using System.Collections.Generic;
using System.Linq;
using webapi_csharp.Modelos;

namespace webapi_csharp.Repositorios
{
    public class RPHumano
    {
        public static List<Humano> _listaHumanos = new List<Humano>()
        {
            new Humano() { Id = 1, Nombre = "Cesar Cuellar", Sexo = "Masculino", Edad = 23, Altura= 1.73 , Peso = 88 },
            new Humano() { Id = 2, Nombre = "Osiel Luevano", Sexo = "Masculino", Edad = 23, Altura= 1.73 , Peso = 88 },
            new Humano() { Id = 3, Nombre = "Cesar Luevano", Sexo = "Masculino", Edad = 23, Altura= 1.73 , Peso = 88 }
        };

        public IEnumerable<Humano> ObtenerHumanos()
        {
            return _listaHumanos;
        }

        public Humano ObtenerHumano(int id)
        {
            var Humano = _listaHumanos.Where(cli => cli.Id == id);

            return Humano.FirstOrDefault();
        }

        public void Agregar(Humano nuevoHumano)
        {
            _listaHumanos.Add(nuevoHumano);
        }

        public void Editar(Humano editarHumano)
        {
            int id = editarHumano.Id;
            var Humano = _listaHumanos.Where(cli => cli.Id == id);
        }
    }
}

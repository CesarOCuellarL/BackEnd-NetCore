using System.Collections.Generic;
using System.Linq;
using webapi_csharp.Modelos;

namespace webapi_csharp.Repositorios
{
    public class RPValue
    {
        public static List<Value> _listaValues = new List<Value>()
        {
            new Value() { Argumento1 = 1 , Argumento2 = 2 , Argumento3 = 3 },
        };

        public IEnumerable<Value> ObtenerValues()
        {
            return _listaValues;
        }

        public string Operaciones()
        {
            string resultado = "";
            int ar1 = 0;
            int ar2 = 0;
            int ar3 = 0;

            for (var i = 0; i < _listaValues.Count; i++)
            {
                ar1 = _listaValues.ElementAt<Value>(i).Argumento1;
                ar2 = _listaValues.ElementAt<Value>(i).Argumento2;
                ar3 = _listaValues.ElementAt<Value>(i).Argumento3;

                int suma = ar1 + ar2 + ar3;
                int resta = ar1 - ar2 - ar3;
                int multiplicacion = ar1 * ar2 * ar3;
                int division = ar1 / ar2 / ar3;

                resultado += "Suma:" + suma.ToString() + " " + "Resta:" + resta.ToString() + " " + "Multiplicacion:" + multiplicacion.ToString() + " " + "division:" + division.ToString() + "   ";

            }

            return resultado;

        }

        public void Agregar(Value nuevoValue)
        {
            _listaValues.Add(nuevoValue);
        }

    }
}

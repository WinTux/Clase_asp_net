using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;
using System.Runtime.CompilerServices;

namespace Clase_asp_net.Extra
{
    public static class ConversorParaSesion
    {
        public static void ConvertirAjson(this ISession sesion, string llave, object valor) {
            sesion.SetString(llave, JsonConvert.SerializeObject(valor));
        }
        public static T ConvertirACsharp<T>(this ISession sesion, string llave) {
            var valor = sesion.GetString(llave);
            return valor == null ? default(T) : JsonConvert.DeserializeObject<T>(valor);
        }
    }
}

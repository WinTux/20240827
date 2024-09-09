using Newtonsoft.Json;
namespace ProyectoAppWeb.Herramientas
{
    public static class ConversorParaSesion
    {
        public static void SetObjetoAJson(this ISession sesion, string llave, object valor) {
            sesion.SetString(llave, JsonConvert.SerializeObject(valor));
        }
        public static T GetObjetoDeJson<T>(this ISession sesion, string llave) {
            string valorString = sesion.GetString(llave);
            return valorString == null ? default(T) : JsonConvert.DeserializeObject<T>(valorString);
        }
    }
}

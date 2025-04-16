namespace Dominio.Comun
{
    public static class Utilidades
    {
        public static bool StringValido(string valor)
        {
            bool exito = false;
            if (string.IsNullOrEmpty(valor))
            {
                exito = false;
            }
            else
            {
                exito = true;
            }
            return exito;
        }

        public static bool ContraseniaValido(string valor)
        {
            bool exito = false;
            if (string.IsNullOrEmpty(valor) && valor.Length < 8)
            {
                exito = false;
            }
            else
            {
                exito = true;
            }
            return exito;
        }
    }
}

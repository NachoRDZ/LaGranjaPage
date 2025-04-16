using Dominio;
using Dominio.Entidades;

namespace Inicio
{
    internal class Program
    {
        private static Sistema _sistema = new();
        static void Main(string[] args)
        {

            int opcion = 0;
            do
            {
                Console.WriteLine(
                    "Ingrese la opción:\n" +
                    "1 - Precargar\n" +
                    "2 - Listado Animales\n" +
                    "3 - Dado cant. hec. y num. de animales, mostrar potreros\n" +
                    "4 - Establecer Precio por KG de Lana de Ovinos\n" +
                    "5 - Alta Bovino\n" +
                    "0 - Salir"
                    );
                opcion = PedirNumero();
                switch (opcion)
                {
                    case 1:
                        _sistema.Precargar();
                        break;
                    case 2:
                        ListarAnimales();
                        break;
                    case 3:
                        DeterminarPotrero();
                        break;
                    case 4:
                        EstablecerPrecioKgLanaOvino();
                        break;
                    case 5:
                        AltaBovino();
                        break;
                    default:
                        break;
                }

            } while (opcion != 0);
        }

        private static int PedirNumero()
        {
            int numero = 0;
            bool seguir;
            do
            {
                try
                {
                    numero = int.Parse(Console.ReadLine());
                    seguir = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("Solo debe ingresar numeros.");
                    seguir = true;
                }

            } while (seguir);

            return numero;
        }

        private static void Precargar()
        {
            try
            {
                _sistema.Precargar();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error en precargar: {e.Message}");
            }
        }

        private static void ListarAnimales()
        {
            foreach (Animal item in _sistema.Animales)
            {
                Console.WriteLine($"Id Caravana: {item.Caravana} - Raza: {item.Raza} - Peso: {item.Peso} - Sexo: {item.Sexo}");
            }
        }

        private static void DeterminarPotrero()
        {
            Console.WriteLine("Ingrese cantidad de hectareas.");
            int hectareas = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese capacidad del potrero.");
            int capacidad = int.Parse(Console.ReadLine());
            try
            {
                _sistema.BuscarPotrero(hectareas, capacidad);
            } catch (Exception e)
            {
                Console.WriteLine($"Error al buscar potrero: {e.Message}");
            }
        }

        private static void EstablecerPrecioKgLanaOvino()
        {
            decimal nuevoPrecioKg;

            try
            {
                Console.WriteLine($"Por favor ingrese el nuevo precio.");
                nuevoPrecioKg = decimal.Parse(Console.ReadLine());

                foreach (Ovino item in _sistema.Animales.OfType<Ovino>()) 
                {
                    item.PrecioKg = nuevoPrecioKg;
                }
                Console.WriteLine($"Se actualizo el precio, siendo ahora {nuevoPrecioKg}");

            } catch (Exception)
            {
                Console.WriteLine("Por favor verifique los datos.");
            }
        }

        /// Este es el metodo utilizado para solicitar datos a los efectos de dar de alta un nuevo bovino

        private static void AltaBovino()
        {
            string? caravana;
            string? sexo;
            string? raza;
            DateTime fechaNacimiento;
            decimal costoAdquisicion;
            decimal costoAlimentacion;
            int peso;
            bool esHibrido;
            string? tipoAlimentacion;

            try
            {
                Console.WriteLine("Por favor ingrese el codigo identificador");
                caravana = Console.ReadLine();
                if (caravana.Length < 8)
                {
                    throw new ArgumentException("La caravana debe tener al menos 8 caracteres.");
                }
                Console.WriteLine("Ingrese su sexo: Macho o Hembra");
                sexo = Console.ReadLine();
                if (!(sexo.Equals("Macho", StringComparison.OrdinalIgnoreCase) || sexo.Equals("Hembra", StringComparison.OrdinalIgnoreCase)))
                {
                    throw new ArgumentException("El sexo debe ser 'Macho' o 'Hembra'.");
                }
                Console.WriteLine("Ingrese su raza");
                raza = Console.ReadLine();
                Console.WriteLine("Ingrese su fecha de nacimiento (Formato DD/MM/YYYY)");
                fechaNacimiento = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese su costo de adquisicion");
                costoAdquisicion = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Ingrese su costo de alimentacion");
                costoAlimentacion = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Ingrese su peso actual");
                peso = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Es un hibrido? (True/False)");
                esHibrido = Convert.ToBoolean(Console.ReadLine());
                Console.WriteLine("Ingrese su tipo de alimentacion: Grano o Pastura");
                tipoAlimentacion = Console.ReadLine();
                if (!(tipoAlimentacion.Equals("Grano", StringComparison.OrdinalIgnoreCase) || tipoAlimentacion.Equals("Pastura", StringComparison.OrdinalIgnoreCase)))
                {
                    throw new ArgumentException("El tipo de alimentación debe ser 'Grano' o 'Pastura'.");
                }

                Bovino bovino = new(tipoAlimentacion, 2, caravana, sexo, raza, fechaNacimiento, costoAdquisicion, costoAlimentacion, peso, esHibrido, "Libre");
                _sistema.AgregarBovino(bovino);

                Console.WriteLine($"Se dio de alta el siguiente Bovino: {caravana}, {sexo}, {raza}, {fechaNacimiento}, {costoAdquisicion}, {costoAlimentacion}, {peso}, {esHibrido}, {tipoAlimentacion}");
            }
            catch (FormatException)
            {
                Console.WriteLine("El formato de entrada es incorrecto.");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine($"Error en los datos ingresados: {e.Message}");
            } 
            catch (Exception)
            {
                Console.WriteLine("Por favor verifique los datos");
            }
        }
    }
}

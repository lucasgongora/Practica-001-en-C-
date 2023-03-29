using System;
using System.Collections.Generic;
using System.Text;

namespace LucasGóngora_M2_P1.Motorhome
{
    /* en clase controlMH se monitorean y calculan los sistemas del propio vehiculo (bus).
     * ante cualquier desperfecto o posible problema detectado a tiempo el sistema muestra alarmas identificadas.
     el control es avanzado porque utiliza datos como horario en el que se esta marchando,  la temperatura del motor y 
    de acuerdo a las alarmas pendientes recomiendo la velocidad mas favorable para viajar sin correr riezgos.*/
    public class ControlMH
    {
        public int alarmas;
        public float presupuesto;
        public bool listo;
        public string horario;
        public char temperatura;
        private int[] velocidades = new int[4] { 0, 30, 60, 100 };
        private float[] tempInterior = new float[3] { 18.5F, 21.5F, 24.5F };
        private string[] partes = new string[5] { "motor", "ruedas", "energia", "aguas", "calefacion" };

        public void Encender()
        {
            Console.WriteLine("El sistema de control del MotorHome se ha ACTIVADO");

        }

        public void Econsumo()
        {
            Console.WriteLine("El sistema de control del MotorHome está en modo AHORRO DE ENERGIA");
        }

        /* se supone que este metodo se llama pasando como parametro la variable -alarmas- para que retorne un valor
         que se use para permitir o no utilizar normalmente todos los servicios.*/
        public bool HabilitarViaje(int fallas)
        {
            if (fallas > 0)
            {
                return true;
            }
            else { return false; }
        }

        /* se supone que este metodo se llama pasando como parametro la variable -presupuesto- para que retorne un string que 
         se use en la decisión de realizar el gasto de reparaciones o no.*/
        public string Reparaciones(float pesos)
        {
            if (pesos > 10000)
            {
                return "RECHAZADO";
            }
            else { return "ACEPTADO"; }
        }

        /* RECORRIDO DE ARRAYS */
        public void RecorrerArrays()
        {
            Console.WriteLine("Recorrido del array de enteros: ");
            for (int i = 0; i < velocidades.Length; i++)
            {
                Console.WriteLine(velocidades[i]);
            }

            Console.WriteLine("\nRecorrido del array de float: ");
            for (int i = 0; i < tempInterior.Length; i++)
            {
                Console.WriteLine(tempInterior[i]);
            }

            Console.WriteLine("\nRecorrido del array de string: ");
            for (int i = 0; i < partes.Length; i++)
            {
                Console.WriteLine(partes[i]);
            }
        }

        public void Propiedades()
        {
            Console.WriteLine("************************ PROPIEDADES *********************\n");
            Console.WriteLine("Las propiedades de la clase CONTROLMH son:\nalarmas = {0}\npresupuesto = {1}\nlisto = {2}\nhorario = {3}\ntemperatura = {4}\n" +
                "velocidades = ({5}, {6}, {7}, {8})\ntempInterior = ({9}, {10}, {11})\npartes = ({12}, {13}, {14}, {15}, {16})\n", alarmas, presupuesto, listo,
                horario, temperatura, velocidades[0], velocidades[1], velocidades[2], velocidades[3], tempInterior[0], tempInterior[1], tempInterior[2], partes[0], partes[1], partes[2], partes[3], partes[4]);
        }

        public static void Funcionalidad()
        {
            Console.WriteLine("***************************************************** CLASE CONTROLMH ***************************************\n");
            Console.WriteLine("En clase controlMH se monitorean y calculan los sistemas del propio vehiculo (bus). Ante cualquier desperfecto o posible problema detectado a tiempo el sistema muestra alarmas identificadas. el control es avanzado porque utiliza datos como horario en el que se esta marchando, la temperatura del motor y de acuerdo a las alarmas pendientes recomiendo la velocidad mas favorable para viajar sin correr riezgos.\n");
        }
    }

    /* la clase controlViaje simplemente controla y calcula todos los datos tipicos de un viaje para 
     * llegar al destino deseado aprovechando al 100% las funcionalidades de los sistemas del MotorHome*/
    public class ControlViaje
    {
        public int horasViaje;
        public float recorrido;
        public bool marcha;
        public string ingresos;
        public char moneda;
        private int[] distancias = new int[4] { 30, 60, 100, 200 };
        private float[] diasViaje = new float[3] { 0.5F, 2F, 5F };
        private string[] paradas = new string[8] { "gasolinera", "comedor", "ferreteria", "gomeria", "taller", "mercado", "camping", "estadia" };

        public void Comenzar()
        {
            Console.WriteLine("Ya se puede comenzar el viaje al destino deseado");
        }

        public void Llegar()
        {
            Console.WriteLine("Ha llegado a su punto de destino");
        }

        /* Metodo para saber cuantos pesos corresponden por cierta cantidad de dólares adquiridos   */
        public float CambiarMoneda(float dolar)
        {
            return (dolar * 200);
        }

        /* Metodo para controlar las horas de conduccion. si se supera las 5 horas conduciendo el sistema aconseja detener el viaje y descansar */
        public string Recomendacion(int horas)
        {
            if (horas > 5)
            {
                return "DESCANSAR";
            }
            else { return "CONTINUAR"; }
        }

        /* RECORRIDO DE ARRAYS */
        public void RecorrerArrays()
        {
            Console.WriteLine("Recorrido del array de enteros: ");
            for (int i = 0; i < distancias.Length; i++)
            {
                Console.WriteLine(distancias[i]);
            }

            Console.WriteLine("\nRecorrido del array de float: ");
            for (int i = 0; i < diasViaje.Length; i++)
            {
                Console.WriteLine(diasViaje[i]);
            }

            Console.WriteLine("\nRecorrido del array de string: ");
            for (int i = 0; i < paradas.Length; i++)
            {
                Console.WriteLine(paradas[i]);
            }
        }

        public void Propiedades()
        {
            Console.WriteLine("************************ PROPIEDADES *********************\n");
            Console.WriteLine("Las propiedades de la clase CONTROLVIAJE son:\nhorasViaje = {0}\nrecorrido = {1}\nmarcha = {2}\ningresos = {3}\nmoneda = {4}\n" +
                "distancias = ({5}, {6}, {7}, {8})\ndiasViaje = ({9}, {10}, {11})\nparadas = ({12}, {13}, {14}, {15}, {16}, {17}, {18}, {19})\n", horasViaje, recorrido, marcha,
                ingresos, moneda, distancias[0], distancias[1], distancias[2], distancias[3], diasViaje[0], diasViaje[1], diasViaje[2], paradas[0], paradas[1], paradas[2], paradas[3], paradas[4], paradas[5], paradas[6], paradas[7]);
        }

        public static void Funcionalidad()
        {
            Console.WriteLine("***************************************************** CLASE CONTROLVIAJE ***************************************\n");
            Console.WriteLine("La clase controlViaje simplemente controla y calcula todos los datos tipicos de un viaje para llegar al destino deseado aprovechando al 100 % las funcionalidades de los sistemas del MotorHome.\n");
        }
    }
}

using System;

namespace LucasGóngora_M2_P1
{
    /* en Clase Gasolina se controla todo lo relacionado al combustible necesario en el MotorHome
     cantidad en el tanque, cantidad a cargar segun precio y tipo de combustible disponible. 
    tambien se controla la forma en que se pagaria cada adquisicion de combustible y si se repone 
    en el tanque del motor, en el tanque de la calefacción o en el tanque de reserva de emergencia */
    public class Gasolina
    {
        public int litros;
        public float costo;
        public bool nivelCritico;
        public string calidad;
        public char tanque;
        private int[] capacidades = new int[3] { 20, 50, 150 };
        private float[] precios = new float[3] { 90.55F, 100.99F, 130.75F };
        private string[] pago = new string[4] { "trueque", "efectivo", "virtual", "tarjeta" };

        public void CargarCombustible()
        {
            Console.WriteLine("Cargar combustible");
        }

        /* suponiendo que esta carga se realiza  en una estación de gasolina */
        public void PagarCombustible()
        {
            Console.WriteLine("Pagar el combustible con tarjeta de credito");
        }

        /* Si el nivel de combustible del tanque principal esta por debajo de los 50 litros, el metodo retorna TRUE para activar el -nivelCritico- */
        public bool NivelCombustible(int litros)
        {
            if (litros < 50)
            {
                return true;
            }
            else { return false; }

        }

        /* si el combustible es especial el metodo retorna -P- refiriendose como destino al tanque PRINCIPAL, pero si es combustible común
         * entonces retorna -R- restinando la carga a los tanques de RESERVA.*/
        public char TipoCombustible(string calidad)
        {
            if (calidad == "especial")
            {
                return 'P';
            }
            else { return 'R'; }
        }

        /* RECORRIDO DE ARRAYS */
        public void RecorrerArrays()
        {
            Console.WriteLine("Recorrido del array de enteros: ");
            for (int i = 0; i < capacidades.Length; i++)
            {
                Console.WriteLine(capacidades[i]);
            }

            Console.WriteLine("\nRecorrido del array de float: ");
            for (int i = 0; i < precios.Length; i++)
            {
                Console.WriteLine(precios[i]);
            }

            Console.WriteLine("\nRecorrido del array de string: ");
            for (int i = 0; i < pago.Length; i++)
            {
                Console.WriteLine(pago[i]);
            }
        }

        public void Propiedades()
        {
            Console.WriteLine("************************ PROPIEDADES *********************\n");
            Console.WriteLine("Las propiedades de la clase GASOLINA son:\nlitros = {0}\ncosto = {1}\nnivelCritico = {2}\ncalidad = {3}\ntanque = {4}\n" +
                "capacidades = ({5}, {6}, {7})\nprecios = ({8}, {9}, {10})\npago = ({11}, {12}, {13}, {14})\n", litros, costo, nivelCritico,
                calidad, tanque, capacidades[0], capacidades[1], capacidades[2], precios[0], precios[1], precios[2], pago[0], pago[1], pago[2], pago[3]);
        }

        public static void Funcionalidad()
        {
            Console.WriteLine("****************************************************CLASE GASOLINA**************************************\n");
            Console.WriteLine("En Clase Gasolina se controla todo lo relacionado al combustible necesario en el MotorHome cantidad en el tanque, cantidad a cargar segun precio y tipo de combustible disponible. tambien se controla la forma en que se pagaria cada adquisicion de combustible y si se repone en el tanque del motor, en el tanque de la calefacción o en el tanque de reserva de emergencia.\n");
        }
    }

    /* en Clase Gasolina se controla todo lo relacionado a las aguas utilizadas en el MotorHome.
     * ya sea el deposito de agua potable para consumir, para limpieza, para el motor y limpiadoresdel vehiculo como tambien 
    las aguas residuales ya utilizadas y contaminadas.
    el control abarca los costos de reposicion, los niveles, segun el tipo de agua a manejar, la temperatura segun el uso 
    del momento y las cantidades necesarias siempre dependiendo del tipo de uso, las capacidades de los alojamientos y los niveles limites*/
    public class Agua
    {
        public int cantidad;
        public float costo;
        public bool nivelCritico;
        public string tipo;
        public char temperatura;
        private int[] capacidad = new int[4] { 10, 15, 100, 300 };
        private float[] nivelx = new float[3] { 0.5F, 15.5F, 85.5F };
        private string[] uso = new string[5] { "inodoro", "cocina", "ducha", "beber", "viaje" };

        public void AguasNegras()
        {
            Console.WriteLine("Vaciar URGENTE el deposito de aguas residuales");
        }

        public void Ducharse()
        {
            Console.WriteLine("Accionar el sistema de calentado de agua para ducharse");
        }

        /* si se llama al metodo con el caracter C entonces retorna TRUE que será utilizado en la activacion del calentamiento del agua para su uso,
         * sino retorna FALSE para no calentar el agua*/
        public bool CalentarAgua(char temperatura)
        {
            if (temperatura == 'C')
            {
                return true;
            }
            else { return false; }
        }

        /* simplemente pasando los litros que se cargaran de agua potable, el metodo calcula el precio a pagar en base a un valor de $70 por litro*/
        public float PrecioAgua(int litros)
        {
            return (litros * 70.35F);
        }

        /* RECORRIDO DE ARRAYS */
        public void RecorrerArrays()
        {
            Console.WriteLine("Recorrido del array de enteros: ");
            for (int i = 0; i < capacidad.Length; i++)
            {
                Console.WriteLine(capacidad[i]);
            }

            Console.WriteLine("\nRecorrido del array de float: ");
            for (int i = 0; i < nivelx.Length; i++)
            {
                Console.WriteLine(nivelx[i]);
            }

            Console.WriteLine("\nRecorrido del array de string: ");
            for (int i = 0; i < uso.Length; i++)
            {
                Console.WriteLine(uso[i]);
            }
        }

        public void Propiedades()
        {
            Console.WriteLine("************************ PROPIEDADES *********************\n");
            Console.WriteLine("Las propiedades de la clase AGUA son:\ncantidad = {0}\ncosto = {1}\nnivelCritico = {2}\ntipo = {3}\ntemperatura = {4}\n" +
                "capacidad = ({5}, {6}, {7}, {8})\nnivelx = ({9}, {10}, {11})\nuso = ({12}, {13}, {14}, {15}, {16})\n", cantidad, costo, nivelCritico,
                tipo, temperatura, capacidad[0], capacidad[1], capacidad[2], capacidad[3], nivelx[0], nivelx[1], nivelx[2], uso[0], uso[1], uso[2], uso[3], uso[4]);
        }

        public static void Funcionalidad()
        {
            Console.WriteLine("****************************************************** CLASE AGUA ****************************************\n");
            Console.WriteLine("En Clase Gasolina se controla todo lo relacionado a las aguas utilizadas en el MotorHome. Ya sea el deposito de agua potable para consumir, para limpieza, para el motor y limpiadoresdel vehiculo como tambien las aguas residuales ya utilizadas y contaminadas. el control abarca los costos de reposicion, los niveles, segun el tipo de agua a manejar, la temperatura segun el uso del momento y las cantidades necesarias siempre dependiendo del tipo de uso, las capacidades de los alojamientos y los niveles limites.\n");
        }
    }

    /* en Clase Energia se controla todo lo relacionado a las cargas electricas necesarias en el MotorHome.
     teniendo en cuenta que el consumo interior del motorhome funciona con corriente alterna, el sistema del 
    vehiculo con conrriente continua de sus correspondientes baterias, el sistema de baterias del conversor 
    son cargadas por paneles solares y tambien puede conectarse una linea de corriente alterna externa.
    se controlan tanto los niveles de voltajes de entrada, de salida y los consumos en tiempo real para calcular a futuro la duracion de las baterias*/
    public class Energia
    {
        public int voltajeAC;
        public float voltajeDC;
        public bool nivelCritico;
        public string consumo;
        public char fuente;
        private int[] capacidad = new int[3] { 24, 30, 220 };
        private float[] nivelx = new float[3] { 22.5F, 24.5F, 28.5F };
        private string[] generador = new string[3] { "solar", "cable", "motor" };

        public void UsarPaneles()
        {
            Console.WriteLine("Ubicarse urgente una zona con sol para recargar las baterias del invensor");
        }

        public void ConsumoAlto()
        {
            Console.WriteLine("Peligro de sobreconsumo energetico! - conectar una linea estable o priorizar el uso de algunos artefactos");
        }

        /* pasando la cantidad de horas de sol que obtuvieron los paneles, el metodo devuelve la cantidad en HORAS de energia electrica de CA disponible .*/
        public float EnergiaDisponible(int hora)
        {
            return (hora * 1.5F);
        }

        /* si el nivel de las baterias del INVERSOR es bajo, el metodo retorna el mensaje BATERIAS BAJAS, sino BATERIAS OK */
        public string NivelDC(float DC)
        {
            if (DC < 22) { return "BATERIAS BAJAS"; }
            else { return "BATERIAS OK"; }
        }

        /* RECORRIDO DE ARRAYS */
        public void RecorrerArrays()
        {
            Console.WriteLine("Recorrido del array de enteros: ");
            for (int i = 0; i < capacidad.Length; i++)
            {
                Console.WriteLine(capacidad[i]);
            }

            Console.WriteLine("\nRecorrido del array de float: ");
            for (int i = 0; i < nivelx.Length; i++)
            {
                Console.WriteLine(nivelx[i]);
            }

            Console.WriteLine("\nRecorrido del array de string: ");
            for (int i = 0; i < generador.Length; i++)
            {
                Console.WriteLine(generador[i]);
            }
        }

        public void Propiedades()
        {
            Console.WriteLine("************************ PROPIEDADES *********************\n");
            Console.WriteLine("Las propiedades de la clase ENERGIA son:\nvoltajeAC = {0}\nvoltajeDC = {1}\nnivelCritico = {2}\nconsumo = {3}\nfuente = {4}\n" +
                "capacidad = ({5}, {6}, {7})\nnivelx = ({8}, {9}, {10})\ngenerador = ({11}, {12}, {13})\n", voltajeAC, voltajeDC, nivelCritico,
                consumo, fuente, capacidad[0], capacidad[1], capacidad[2], nivelx[0], nivelx[1], nivelx[2], generador[0], generador[1], generador[2]);
        }

        public static void Funcionalidad()
        {
            Console.WriteLine("***************************************************** CLASE ENERGIA ***************************************\n");
            Console.WriteLine("En Clase Energia se controla todo lo relacionado a las cargas electricas necesarias en el MotorHome. Teniendo en cuenta que el consumo interior del motorhome funciona con corriente alterna, el sistema del vehiculo con conrriente continua de sus correspondientes baterias, el sistema de baterias del conversor son cargadas por paneles solares y tambien puede conectarse una linea de corriente alterna externa. se controlan tanto los niveles de voltajes de entrada, de salida y los consumos en tiempo real para calcular a futuro la duracion de las baterias.\n");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Funciones de ENUMs
            static void Enumerado1()
            {
                Ruedas rueda1 = Ruedas.RuedaDelanteraIzq;
                Ruedas rueda2 = Ruedas.RuedaDelanteraDer;
                Ruedas rueda3 = Ruedas.RuedaTraseraIzq;
                Ruedas rueda4 = Ruedas.RuedaTraseraDer;
                Console.WriteLine("Elementos del Enum Ruedas y sus valores: ");
                Console.WriteLine("{0} = {1} \n{2} = {3}\n{4} = {5}\n{6} = {7}\n", rueda1, (int)rueda1, rueda2, (int)rueda2,
                    rueda3, (int)rueda3, rueda4, (int)rueda4);
            }
            static void Enumerado2()
            {
                Viajes viaje1 = Viajes.zonal;
                Viajes viaje2 = Viajes.provincial;
                Viajes viaje3 = Viajes.nacional;
                Viajes viaje4 = Viajes.internacional;
                Console.WriteLine("Elementos del Enum Viajes y sus valores: ");
                Console.WriteLine("{0} = {1} \n{2} = {3}\n{4} = {5}\n{6} = {7}\n", viaje1, (int)viaje1, viaje2, (int)viaje2,
                    viaje3, (int)viaje3, viaje4, (int)viaje4);
            }

            //Funciones de STRUCTs
            static void Iluminacion()
            {
                Console.WriteLine("Intensidad de las luces principales:");
                Luces intensidad;
                intensidad.alta = 90;
                intensidad.baja = 80;
                intensidad.reflector = 60;
                Console.WriteLine("Luz Alta = {0}%\nLuz Baja = {1}%\nReflectores = {2}%\n", intensidad.alta, intensidad.baja, intensidad.reflector);
            }
            static void Internet()
            {
                Console.WriteLine("Señales de internet disponibles:");
                SeñalWifi ok;
                ok.modem = "NULA";
                ok.celular = "DEBIL";
                ok.satelital = "FUERTE";
                Console.WriteLine("Modem = {0}\nCelular = {1}\nSatelital = {2}\n", ok.modem, ok.celular, ok.satelital);
            }

            //BEINVENIDA AL SISTEMA
            Console.WriteLine("************************Bienvenidos al MotorHome Inteligente*********************\n");

            // Inicializacion y llamado de funciones de la clase Gasolina
            Gasolina recorrido1 = new Gasolina();
            recorrido1.litros = 85;
            recorrido1.costo = 155.85F;
            recorrido1.nivelCritico = true;
            recorrido1.calidad = "especial";
            recorrido1.tanque = 'R';
            Gasolina.Funcionalidad();
            recorrido1.CargarCombustible();
            recorrido1.PagarCombustible();
            Console.WriteLine("Nivel critico de gasolina = "+ recorrido1.NivelCombustible(45));
            Console.WriteLine("[R reserva - P tanque principal] Cargar en = "+ recorrido1.TipoCombustible("especial"));
            recorrido1.RecorrerArrays();
            recorrido1.Propiedades();

            // Inicializacion y llamado de funciones de la clase Agua
            Console.WriteLine("\n");
            Agua recorrido2 = new Agua();
            recorrido2.cantidad = 250;
            recorrido2.costo = 2435.45F;
            recorrido2.nivelCritico = false;
            recorrido2.tipo = "potable";
            recorrido2.temperatura = 'f';
            Agua.Funcionalidad();
            recorrido2.AguasNegras();
            recorrido2.Ducharse();
            Console.WriteLine("Calentar TRUE - No calentar FALSE= "+recorrido2.CalentarAgua('c'));
            Console.WriteLine("Precio del agua cargada= $"+recorrido2.PrecioAgua(238));
            recorrido2.RecorrerArrays();
            recorrido2.Propiedades();

            // Inicializacion y llamado de funciones de la clase Energia
            Console.WriteLine("\n");
            Energia recorrido3 = new Energia();
            recorrido3.voltajeAC = 220;
            recorrido3.voltajeDC = 23.8F;
            recorrido3.nivelCritico = false;
            recorrido3.consumo = "alto";
            recorrido3.fuente = 'S';
            Energia.Funcionalidad();
            recorrido3.UsarPaneles();
            recorrido3.ConsumoAlto();
            Console.WriteLine("Horas de energia alterna disponible= {0} horas", recorrido3.EnergiaDisponible(6));
            Console.WriteLine("Nivel de carga de Baterias del Inversor= " + recorrido3.NivelDC(21.3F));
            recorrido3.RecorrerArrays();
            recorrido3.Propiedades();

            // Inicializacion y llamado de funciones de la clase ControlMH
            Console.WriteLine("\n");
            Motorhome.ControlMH recorrido4 = new Motorhome.ControlMH();
            recorrido4.alarmas = 5;
            recorrido4.presupuesto = 3520.75F;
            recorrido4.listo = true;
            recorrido4.horario = "noche";
            recorrido4.temperatura = 'c';
            Motorhome.ControlMH.Funcionalidad();
            recorrido4.Encender();
            recorrido4.Econsumo();
            Console.WriteLine("Servicios habilitados= "+ recorrido4.HabilitarViaje(0));
            Console.WriteLine("Aprobacion de Reparaciones= " + recorrido4.Reparaciones(5642.10F));
            recorrido4.RecorrerArrays();
            recorrido4.Propiedades();

            // Inicializacion y llamado de funciones de la clase ControlViaje
            Console.WriteLine("\n");
            Motorhome.ControlViaje recorrido5 = new Motorhome.ControlViaje();
            recorrido5.horasViaje = 3;
            recorrido5.recorrido = 286.6F;
            recorrido5.marcha = false;
            recorrido5.ingresos = "positivos";
            recorrido5.moneda = 'd';
            Motorhome.ControlViaje.Funcionalidad();
            recorrido5.Comenzar();
            recorrido5.Llegar();
            Console.WriteLine("Pesos equivalentes= $" + recorrido5.CambiarMoneda(520.5F));
            Console.WriteLine("Recomendacion actual para conductor= " + recorrido5.Recomendacion(6));
            recorrido5.RecorrerArrays();
            recorrido5.Propiedades();
            
            Console.WriteLine("\n");

            //Llamado de las funciones de ENUMs
            Enumerado1();
            Enumerado2();

            //Llamado de las funciones de STRUCTs
            Iluminacion();
            Internet();
            
            




        }
    }
}

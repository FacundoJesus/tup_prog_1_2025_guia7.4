namespace Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int encuestadores, encuestadosTotal, autoTotal, biciTotal, tPubTotal, opcion, encuestados, auto, moto ,bici, tpublico;
            double distBici, distMoto, distPromBici, distPromMoto, prcBici, prcAuto, prcTPub, kmBici, kmMoto;

            do
            {
                Console.WriteLine("Ingrese la cantidad de Encuestadores (2,3 o 4):");
                encuestadores = Convert.ToInt32(Console.ReadLine());
            } while (encuestadores < 2 || encuestadores > 4);

            encuestadosTotal = 0;
            autoTotal = 0;
            biciTotal = 0;
            tPubTotal = 0;
            for (int i = 1; i <= encuestadores; i++) {
                Console.WriteLine("Ingrese el tipo de transporte: \n\t1-Bicicleta\n\t2-Motocicleta\n\t3-Auto\n\t4-Transporte Público\n\t-1 P/Salir");
                opcion = Convert.ToInt32(Console.ReadLine());
                encuestados = 0;
                auto = 0;
                bici = 0;
                moto = 0;
                tpublico = 0;
                distBici = 0;
                distMoto = 0;
                while (opcion != -1) {
                    switch (opcion) { 
                        case 1:
                            bici++;
                            Console.WriteLine("Ingrese la distancia recorrida en Bicicleta:");
                            kmBici = Convert.ToDouble(Console.ReadLine());
                            distBici += kmBici;
                            break;
                        case 2:
                            moto++;
                            Console.WriteLine("Ingrese la distancia recorrida en Moto:");
                            kmMoto = Convert.ToDouble(Console.ReadLine());
                            distMoto += kmMoto;
                            break;
                        case 3:
                            auto++;
                            break;
                        case 4:
                            tpublico++;
                            break;
                        default:
                            Console.WriteLine("Tipo de transporte no válido");
                            break;
                    }

                    Console.WriteLine("Ingrese el tipo de transporte: \n\t1-Bicicleta\n\t2-Motocicleta\n\t3-Auto\n\t4-Transporte Público\n\t-1 P/Salir");
                    opcion = Convert.ToInt32(Console.ReadLine());
                }
                encuestados = bici + moto + auto + tpublico;
                distPromBici = distBici / bici;
                distPromMoto = distMoto / moto;
                Console.WriteLine($"Cantidad de encuestados: {encuestados}");
                Console.WriteLine($"Cantidad de personas que usan Bici: {bici}\nCantidad de personas que usan Automovil:{auto}\nCantidad de personas que usan T.Público:{tpublico}");
                Console.WriteLine($"Distancia promedio recorrida para usuarios en Bici: {distPromBici:f2}km\nDistancia promedio recorrida para usuarios en Moto: {distPromMoto:f2}km");

                encuestadosTotal += encuestados;
                biciTotal += bici;
                tPubTotal += tpublico;
                autoTotal += auto;
            }

            if (encuestadosTotal > 0)
            {
                prcAuto = (autoTotal * 1.0 / encuestadosTotal) * 100;
                prcBici = (biciTotal * 1.0 / encuestadosTotal) * 100;
                prcTPub = (tPubTotal * 1.0 / encuestadosTotal) * 100;
                Console.WriteLine($"Cantidad de encuestados totales: {encuestadosTotal}");
                Console.WriteLine($"Porcentaje en cantidad de personas que usan Bicicleta: {Math.Ceiling(prcBici)}%\nPorcentaje en cantidad de personas que usan Auto: {Math.Ceiling(prcAuto)}%\nPorcentaje en cantidad de personas que usan T.Público: {Math.Ceiling(prcTPub)}%");
            }
            else
            {
                Console.WriteLine("No hubo encuestados");
            }
        }
    }
}

namespace Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double recTotal, recMoto, recAuto, recUtil, recCamion, rec, hs, monto, prcRecMoto, prcRecAuto, prcRecUtil, prcRecCamion, prcMotos, prcAutos, prcUtil, prcCamiones;
            int motos, autos, utilitarios, camiones, vehiculos, opc, x;
            bool seguir;


            const double phMoto = 100.00;
            const double phAuto = 200;
            const double phUtil = 250;
            const double phCamion = 700;
            recTotal = 0;
            motos = 0;
            autos = 0;
            utilitarios = 0;
            camiones = 0;
            vehiculos = 0;

            seguir = true;
            while (seguir) {
                Console.WriteLine("Ingrese el tipo de vehículo: \n\t1-Moto\n\t2-Auto\n\t3-Utilitario\n\t4-Camión\n\t-1 P/Salir");
                opc = Convert.ToInt32(Console.ReadLine());
                recMoto = 0;
                recAuto = 0;
                recUtil = 0;
                recCamion = 0;
                rec = 0;
                while (opc != -1)
                {
                    Console.WriteLine("Ingrese la cantidad de horas ocupadas:");
                    hs = Convert.ToDouble(Console.ReadLine());
                    switch (opc) {
                        case 1:
                            motos++;
                            monto = hs * phMoto;
                            recMoto += monto;
                            Console.WriteLine($"Costo por hora: {phMoto:c2} Costo Horas ocupadas: {monto:c2}");
                            break;
                        case 2:
                            autos++;
                            monto = hs * phAuto;
                            recAuto += monto;
                            Console.WriteLine($"Costo por hora: {phAuto:c2} Costo Horas ocupadas: {monto:c2}");
                            break;
                        case 3:
                            utilitarios++;
                            monto = hs * phUtil;
                            recUtil += monto;
                            Console.WriteLine($"Costo por hora: {phUtil:c2} Costo Horas ocupadas: {monto:c2}");
                            break;
                        case 4:
                            camiones++;
                            monto = hs * phCamion;
                            recCamion += monto;
                            Console.WriteLine($"Costo por hora: {phCamion:c2} Costo Horas ocupadas: {monto:c2}");
                            break;
                        default:
                            Console.WriteLine("Tipo de vehículo no válido.");
                            break;
                    }
                    rec = recMoto + recAuto + recUtil + recCamion;
                    Console.WriteLine("Ingrese el tipo de vehículo: \n\t1-Moto\n\t2-Auto\n\t3-Utilitario\n\t4-Camión\n\t-1 P/Salir");
                    opc = Convert.ToInt32(Console.ReadLine());
                }
                vehiculos = motos + autos + utilitarios + camiones;
                recTotal += rec;
                if (rec > 0)
                {
                    prcRecMoto = (recMoto / rec) * 100;
                    prcRecAuto = (recAuto / rec) * 100;
                    prcRecUtil = (recUtil / rec) * 100;
                    prcRecCamion = (recCamion / rec) * 100;
                    Console.WriteLine($"Porcentaje de Recaudación de Motos: {prcRecMoto:f2}%\nPorcentaje de Recaudación de Autos: {prcRecAuto:f2}%\nPorcentaje de Recaudación de Utilitarios: {prcRecUtil:f2}%\nPorcentaje de Recaudación de Camiones: {prcRecCamion:f2}%");
                    Console.WriteLine($"Recaudación total: {rec:c2}");
                }
                else
                {
                    Console.WriteLine("No hubo recaudación.");
                }

                Console.WriteLine("Si desea finalizar la Zona Presione `1´ o `Enter´ para continuar: ");
                x = Convert.ToInt32 (Console.ReadLine());
                if (x == 1) {
                    seguir = !seguir;
                }
            }

            if (vehiculos > 0)
            {
                prcMotos = (motos * 1.00 / vehiculos) * 100;
                prcAutos = (autos * 1.00 / vehiculos) * 100;
                prcUtil = (utilitarios * 1.00 / vehiculos) * 100;
                prcCamiones = (camiones * 1.00 / vehiculos) * 100;
                Console.WriteLine($"Porcentaje en cantidad de Motos: {Math.Ceiling(prcMotos)}%\nPorcentaje en cantidad de Autos: {Math.Ceiling(prcAutos)}%\nPorcentaje en cantidad de Utilitarios: {Math.Ceiling(prcUtil)}%\nPorcentaje en cantidad de Camiones: {Math.Ceiling(prcCamiones)}%");
                Console.WriteLine($"Recaudación total: {recTotal:c2}");
            }
            else
            {
                Console.WriteLine("No hubo vehículos estacionados.");
            }

        }
    }
}

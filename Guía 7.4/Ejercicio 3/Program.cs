namespace Ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vendedores, totoTotal, teleTotal, quiniTotal, total, tipo, telebingo, totobingo, quini, unidades;
            double recTeleTotal, recTotoTotal, recQuiniTotal, recTotal, monto, recVendedor, recTele, recToto, recQuini;
            string tipocarton;
            const double pTele = 400;
            const double pToto = 750;
            const double pQuini = 800;

            do
            {
                Console.WriteLine("Ingrese la cantidad de vendedores: (2 o 4)");
                vendedores = Convert.ToInt32(Console.ReadLine());
            } while (vendedores != 2 && vendedores != 4);

            recTotal = 0;
            recTeleTotal = 0;
            recTotoTotal = 0;
            recQuiniTotal = 0;
            totoTotal = 0;
            teleTotal = 0;
            quiniTotal = 0;
            monto = 0;
            tipocarton = "";
            for (int i = 1; i <= vendedores ; i++) {
                Console.WriteLine("Ingrese el tipo de cartón:\n1-Tele Bingo\n2-Quini Seis\n3-Toto Bingo\n-1 P/Salir");
                tipo = Convert.ToInt32(Console.ReadLine());
                telebingo = 0;
                totobingo = 0;
                quini = 0;
                while (tipo != -1)
                {
                    Console.WriteLine("Ingrese la cantidad de cartones:");
                    unidades = Convert.ToInt32(Console.ReadLine());
                    switch (tipo) {
                        case 1:
                            telebingo += unidades;
                            monto = unidades * pTele;
                            tipocarton = "Tele Bingo";
                            break;
                        case 2:
                            quini += unidades;
                            monto = unidades * pQuini;
                            tipocarton = "Quini Seis";
                            break;
                        case 3:
                            totobingo += unidades;
                            monto = unidades * pToto;
                            tipocarton = "Toto Bingo";
                            break;
                        default:
                            Console.WriteLine("Tipo de cartón no válido");
                            break;
                    }
                    Console.WriteLine("---TICKET---");
                    Console.WriteLine($"Cantidad de cartones: {unidades}\nMonto a pagar: {monto:c2}\nTipo de cartón: {tipocarton}");
                    Console.WriteLine("------------");
                    Console.WriteLine("Ingrese el tipo de cartón:\n1-Tele Bingo\n2-Quini Seis\n3-Toto Bingo\n-1\nP/Salir");
                    tipo = Convert.ToInt32(Console.ReadLine());
                }
                recVendedor = ((telebingo * pTele) + (quini * pQuini) + (totobingo * pToto))*1.0;
                recTele = (telebingo * pTele) * 1.0;
                recToto = (totobingo * pToto * 1.0);
                recQuini = (quini * pQuini) * 1.0;
                Console.WriteLine("------------");
                Console.WriteLine($"Recaudación del vendedor {i}: {recVendedor:c2}\nRecaudación en cartones Tele Bingo:{recTele:c2}\nRecaudación en cartones Quini Seis:{recQuini:c2}\nRecaudación en cartones Quini Seis:{recToto:c2}");
                Console.WriteLine($"Cantidad de cartones de Tele Bingo: {telebingo}\nCantidad de cartones de Quini Seis: {quini}\nCantidad de cartones de Toto Bingo: {totobingo}");
                Console.WriteLine("------------");
                recTotal += recVendedor;
                recTeleTotal += recTele;
                recTotoTotal += recToto;
                recQuiniTotal += recQuini;

                teleTotal += telebingo;
                quiniTotal += quini;
                totoTotal += totobingo;

            }

            total = teleTotal + quiniTotal + totoTotal;
            if (total > 0)
            {
                Console.WriteLine($"Recaudación total: {recTotal:c2}");
                Console.WriteLine($"Recaudación total en cartones Tele Bingo: {recTeleTotal:c2} Cantidad: {teleTotal}");
                Console.WriteLine($"Recaudación total en cartones Quini Seis: {recQuiniTotal:c2} Cantidad: {quiniTotal}");
                Console.WriteLine($"Recaudación total en cartones Tele Bingo: {recTotoTotal:c2} Cantidad: {totoTotal}"); 
            } else
            {
                Console.WriteLine("No hubo ventas de cartones.");
            }

        }
    }
}

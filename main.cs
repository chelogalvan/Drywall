using System;

using System;
using System.IO;

class Program
{

    static void Main(string[] args)
    {

        Select();


    }


    //-------------------------  calculo para paredes  ---------------------------------
    static void Pared()
    {
        Console.WriteLine($"\t\t\t\tLISTA DE MATERIALES PARED");
        Console.WriteLine($"\t!!!MEDIDAS!!!\n");
        Console.WriteLine($"\t <<<<<<<  !!  Ingrese nombre de cliente o tipo de ambiente.  !!  >>>>>>\n");
        var nombreAmbiente = Console.ReadLine();
        Console.WriteLine($"\t*Ingrese largo");
        var largo = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine($" *Ingrese alto");
        var alto = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine($"Ingrese precio x mt");
        var precioMt2 = Convert.ToDouble(Console.ReadLine());


        var mt2 = largo * alto;
        var precio = Convert.ToDecimal(precioMt2) * mt2;
        var solera = largo / 2.5m * 2;
        var montante = largo / 0.4m + 1;
        var placa = mt2 / 2.88m * 2;
        var lanaVidrio = decimal.ToDouble((decimal)mt2);
        var tornilloT1Aguja = Convert.ToInt32(montante * 4 * 1.3m);
        int tornilloT2Aguja = Convert.ToInt32(placa * 45);
        var fijaciones = Convert.ToInt32((largo / .4m) * 2 + (alto / .6m) * 2);
        var cintaPapel = Convert.ToInt32((placa * 3.60m));
        var masilla = Convert.ToDouble(mt2 * 1.6m) * 2;

        placa = Math.Ceiling(placa);
        solera = Math.Ceiling(solera);
        montante = Math.Ceiling(montante);
        lanaVidrio = Math.Ceiling(lanaVidrio);
        //masilla = Math.Ceiling(masilla);
        //mt2 =Math.Round(mt2);
        var montante260 = montante;
        var montante3 = montante;
        var montante4 = montante;


        Console.WriteLine($"\n * {mt2:N2}:\t\t Metros cuadrados\n * ${precio:N2}:\t\t precio de mano de obra\n * {solera}:\t\t\t Soleras.");

        if (alto <= 2.60m)
        {
            Console.WriteLine($" * {montante260}:\t\t\t montantes x 2,6 mts");
        }
        else if (alto <= 3)
        {
            Console.WriteLine($" * {montante3}:\t\t\t montantes x 3 mts");

        }
        else if (alto <= 4)
        {
            Console.WriteLine($" * {montante4}:\t\t\t montantes x 4 mts");

        }





        Console.WriteLine($" * {placa}:\t\t\t Placas std x 2.4\n * {lanaVidrio}:\t\t\t metros de lana de vidrio");
        Console.WriteLine($" * {tornilloT1Aguja}:\t\t\t Tornillos T1 aguja.\n * {tornilloT2Aguja}:\t\t\t Tornillo T2 aguja.\n * {fijaciones}:\t\t\t fijaciones 06 mm.");
        Console.WriteLine($" * {cintaPapel}:\t\t\t metros de cinta de papel.\n * {masilla:N2}:\t\t kl de masilla.\n");


        string fechaHoraActual = DateTime.Now.ToString("yyyyMMdd_HHmmss");
        string presupuestos = $"{nombreAmbiente}_{fechaHoraActual}.txt";

        using (StreamWriter sw = new(presupuestos))
        {
            sw.WriteLine($"\t\t!!!materiles para pared!!!!!\n");
            sw.WriteLine($"{mt2}:\t\tMetros cuadrados  ");
            sw.WriteLine($"{solera}:\t\tSolereas  ");
            if (alto <= 2.60m)
            {
                sw.WriteLine($"{montante}:\t\tmontantes x 2.60 mts ");
            }
            else if (alto <= 3)
            {
                sw.WriteLine($"{montante}:\t\tmontantes x 3 mts");
            }
            else if (alto <= 4)
            {
                sw.WriteLine($"{montante}:\t\tmontantes x 4 mts");
            }
            sw.WriteLine($"{placa}:\t\tPlacas std x 2.40 ");
            sw.WriteLine($"{lanaVidrio}:\t\tmetros de lana de vidrio");
            sw.WriteLine($"{tornilloT1Aguja}:\t\ttornillos t1 aguja");
            sw.WriteLine($"{tornilloT2Aguja}:\t\tTornillo T2 aguja.");
            sw.WriteLine($"{fijaciones}:\t\t fijaciones 06 mm.");
            sw.WriteLine($"{cintaPapel}:\t\t\t metros cinta de papel.");
            sw.WriteLine($"{masilla:N1}:\t\t kl de masilla.");

        }
        Agregar();
    }

    //--------------------  calculo para cielorraso omega -------------------------

    static void Cielo()
    {

        Console.WriteLine($"\t\t\t\tLISTA DE MATERIALES CIELORRASO\n");

        Console.WriteLine($"\t <<<<<<<  !!  Ingrese nombre de cliente o tipo de ambiente.  !!  >>>>>>\n");
        var nombreAmbiente = Console.ReadLine();
        Console.WriteLine($"\t!!!MEDIDAS!!!\n");
        Console.WriteLine($"\t*Ingrese largo");
        decimal largo = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine($"\t*Ingrese ancho");
        decimal ancho = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine($"\t*Ingrese distancia de modulacion.\n");
        Console.WriteLine($"\t> 1 para modulacion cada 40 cm.");
        Console.WriteLine($"\t> 2 para modulacion cada 50 cm.");
        Console.WriteLine($"\t> 3 para modulacion cada 60 cm.");





        decimal mt2 = largo * ancho;
        decimal perimetral = ((largo + ancho) * 2) / 2.4m;
        decimal modulacionOmega = largo / 0.40m;
        decimal modulacionF47 = (ancho / 0.80m - 0.80m);
        decimal velas = modulacionOmega * modulacionF47;
        decimal omegas = 0; //ver en modulaciones	
        decimal f47 = Convert.ToInt32(ancho / 0.80m - 0.80m) * (largo / 3.60m);
        decimal placa = 0;//mt2 / 2.88m;
        decimal lanaVidrio = Convert.ToDecimal(mt2);
        decimal tornilloT1Aguja = Convert.ToInt32((modulacionF47 + 2) * (modulacionOmega + 2) * 2 + velas);
        decimal tornilloT2Aguja = Convert.ToInt32((placa * 45));
        int fijaciones = Convert.ToInt32((largo + ancho) * 2 / 0.40m);
        decimal cintaPapel = Convert.ToInt32((placa * 3.60m));
        decimal masilla = mt2 * 1.6m;


        perimetral = Math.Ceiling(perimetral);
        f47 = Math.Ceiling(f47);

        var placa3 = largo * ancho / 3.6m;
        var placa240 = largo * ancho / 2.88m;

        placa3 = Math.Ceiling(placa3);
        placa240 = Math.Ceiling(placa240);

        //------------modulaciones de estructura------------

        var mod40 = (largo / 0.40m) * (ancho / 2.30m);
        var mod50 = (largo / 0.50m) * (ancho / 2.30m);
        var mod60 = (largo / 0.60m) * (ancho / 2.30m);

        mod40 = Math.Ceiling(mod40);
        mod50 = Math.Ceiling(mod50);
        mod60 = Math.Ceiling(mod60);


        decimal valor = Convert.ToInt32(Console.ReadLine());

        if (valor == 1)
        {
            Console.WriteLine($"\tseleccioneste modulacion  a 40 cm.\n\n ");
            omegas = mod40;
        }
        else if (valor == 2)
        {
            Console.WriteLine($"\tseleccioneste modulacion  a 50 cm.\n\n ");
            omegas = mod50;
        }
        else if (valor == 3)
        {
            Console.WriteLine($"\tseleccioneste modulacion  a 60 cm.\n\n ");
            omegas = mod60;
        }
        else
        {
            Console.WriteLine("no seleccionaste ninguna opcion");
        }



        Console.WriteLine($"\t\t** Ingrese precio por mt2.");
        decimal precio = mt2 * Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine($"\n\n * {mt2:N2}:\t\t Metros cuadrados.\n * ${precio}:\t\t precio de mano de obra.\n\n * {perimetral}:\t\t\t Cantoneras.");
        Console.WriteLine($" * {omegas}:\t\t\t omegas. ");
        Console.WriteLine($" * {f47}:\t\t\t perfil f47 x 4 mts.");

        // -----------seleccion de medida de placas----------

        if (valor == 1)
        {
            placa = placa240;
            tornilloT2Aguja = placa240 * 45;
            cintaPapel = placa240 * 3.6m;
            Console.WriteLine($" * {placa240}:\t\t\t placa std x 2.4mts.");
        }
        else if (valor == 2)
        {
            placa = placa3;
            tornilloT2Aguja = placa3 * 45;
            cintaPapel = placa3 * 4.2m;
            Console.WriteLine($" * {placa3}:\t\t\t placa std x 3mts.");
        }
        else if (valor == 3)
        {
            placa = placa240;
            tornilloT2Aguja = placa240 * 45;
            cintaPapel = placa240 * 3.6m;
            Console.WriteLine($" * {placa240}:\t\t\t placa std x 2.4mts");
        }

        Console.WriteLine($" * {lanaVidrio}:\t\t\t metros de lana de vidrio");
        Console.WriteLine($" * {tornilloT1Aguja}:\t\t\t Tornillos T1 aguja.\n * {tornilloT2Aguja}:\t\t\t Tornillo T2 aguja.\n * {fijaciones}:\t\t\t fijaciones 06 mm.");
        Console.WriteLine($" * {cintaPapel}:\t\t\t metros cinta de papel.\n * {masilla}:\t\t kilos de masilla.\n\n\n");

        //---------impresionde archivo txt-----------

        string fechaHoraActual = DateTime.Now.ToString("yyyyMMdd_HHmmss");
        string presupuestos = $"{nombreAmbiente}_{fechaHoraActual}.txt";

        using (StreamWriter sw = new(presupuestos))
        {
            sw.WriteLine($"!!!materiles para cielo!!!!!\n");
            sw.WriteLine($"{precio} precio mano de obra");
            sw.WriteLine($"{mt2:N2}:\t Metros cuadrados.\n");
            sw.WriteLine($"{perimetral}:\t\t\t Cantoneras.");
            sw.WriteLine($"{omegas}:\t\t\t omegas .");
            sw.WriteLine($"{f47}:\t\t\t perfil f47 x 4 mts.");
            sw.WriteLine($"{placa}:\t\t\t Placas std x 2.4.");
            sw.WriteLine($"{lanaVidrio}:\t\t\t metros de lana de vidrio");
            sw.WriteLine($"{tornilloT1Aguja}:\t\t\t Tornillos T1 aguja.");
            sw.WriteLine($"{tornilloT2Aguja}:\t\t\t Tornillo T2 aguja.");
            sw.WriteLine($"{fijaciones}:\t\t\t fijaciones 06 mm.");
            sw.WriteLine($"{cintaPapel}:\t\t\t metros cinta de papel.");
            sw.WriteLine($"{masilla}:\t\t\t latas de masilla.");

        }
        Agregar();

    }
    //---------------------- calculo para revestimiento -----------------------

    static void Revestimiento()
    {
        Console.WriteLine($"\t\t\tLISTA DE MATERIALES REVESTIMIENTO\n");
        Console.WriteLine($"\t <<<<<<<  !!  Ingrese nombre de cliente o tipo de ambiente.  !!  >>>>>>\n");
        var nombreAmbiente = Console.ReadLine();
        Console.WriteLine($"\t!!MEDIDAS!!\n");
        Console.WriteLine($"\t* Ingrese el largo.");
        decimal largo = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine($"\t* Ingrese el alto. ");
        decimal alto = Convert.ToDecimal(Console.ReadLine());

        //elegir si omega o montante 

        decimal mt2 = largo * alto;
        decimal omegas = largo / 0.4m + 2;
        //decimal montante = largo / 0.4m + 2;
        //decimal largoOmegas = alto / 2.2m;
        int totalOmegas = Convert.ToInt32(omegas * alto / 2.2m);
        int fijaciones = Convert.ToInt32(alto / .50m * 2 * totalOmegas);
        decimal placa = mt2 / 2.88m;
        int tornillost2 = decimal.ToInt32((placa * 45) * 1.3m);
        int cintaPapel = decimal.ToInt32(placa * 3.60m);
        decimal masilla = mt2 * 1.6m;

        placa = Math.Ceiling(placa);
        _ = Math.Ceiling(omegas);

        Console.WriteLine($"\n * {mt2:N2}:\tMetros cuadrados.\n * {totalOmegas}:\t\tOmegas.\n * {fijaciones}:\t\tfijaciones spiga /3cortes de 6mm.");
        Console.WriteLine($" * {placa}:\t\tplacas  2.4 x 12.5mm.\n * {tornillost2}:\t\ttornillos t2 aguja.\n * {cintaPapel}:\t\tmetros cinta de papel.");
        Console.WriteLine($" * {masilla:N2}:\tkl de masilla anclaflex /maropor.\n\n\n");

        string fechaHoraActual = DateTime.Now.ToString("yyyyMMdd_HHmmss");
        string presupuestos = $"{nombreAmbiente}_{fechaHoraActual}.txt";

        using (StreamWriter sw = new(presupuestos))
        {
            sw.WriteLine($"{mt2:N2}:\tMetros cuadrados.");
            sw.WriteLine($"{totalOmegas}:\t\tOmegas.");
            sw.WriteLine($"{fijaciones}:\t\tfijaciones spiga /3cortes de 6mm.");
            sw.WriteLine($"{placa}:\t\tplacas  2.4 x 12.5mm.");
            sw.WriteLine($"{tornillost2}:\t\ttornillos t2 aguja.");
            sw.WriteLine($"{cintaPapel}:\t\tmetros cinta de papel.");
            sw.WriteLine($"{masilla:N2}:\tkl de masilla anclaflex /maropor.");
        }

        Agregar();

    }

    //-------------------- seleccionar tipo de trabajo  -------------------
    static void Select()
    {
        Console.WriteLine($"\n\n\t     <<<<<  CALCULO A REALIZAR  >>>>> \n");
        Console.WriteLine($"\t\t* OPRIMA 1 PARA CIELORRASO");
        Console.WriteLine($"\t\t* OPRIMA 2 PARA PARED");
        Console.WriteLine($"\t\t* OPRIMA 3 PARA REVESTIMIENTO.");


        int medida = Convert.ToInt32(Console.ReadLine());

        if (medida == 1)
        {
            Cielo();
        }
        else if (medida == 2)
        {
            Pared();
        }
        else if (medida == 3)
        {
            Revestimiento();
        }
        else
        {
            Console.WriteLine($"Entrada invalida!!!");
        }
    }


    //--------------------- agregar medidas ------------------------
    static void Agregar()
    {
        Console.WriteLine($"\t\t\t\t!!Añadir medida");
        Console.WriteLine($"\t * OPRIMA 1 PARA CIELORRASO");
        Console.WriteLine($"\t * OPRIMA 2 PARA PARED");
        Console.WriteLine($"\t * OPRIMA 3 PARA REVESTIMIENTO.");

        int agregar = Convert.ToInt32(Console.ReadLine());
        if (agregar == 1)
        {
            Cielo();
        }
        else if (agregar == 2)
        {
            Pared();
        }
        else if (agregar == 3)
        {
            Revestimiento();
        }
        else
        {
            Console.WriteLine("gracias");
        }

    }

}





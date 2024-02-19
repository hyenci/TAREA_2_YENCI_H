using System;

public class TAREA2
{
    public static void Main(string[] args)
    {

        Console.WriteLine("--------------------------------------------");
        Console.WriteLine("1.\tConvertir un Número de Letra a Número:");
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine("");
        Console.WriteLine("INGRESE UN NUMERO DEL 1 AL 5 EN LETTRAS (UNO, DOS, TRES, CUATRO, CINCO");
        string numletra;
        int num = 0;
        numletra = Console.ReadLine().ToLower();

        switch (numletra)
        {

            case "uno":
                num = 1;
                break; 

            case "dos":
                num = 2;
                break;
            case "tres":
                num = 3;
                break;
            case "cuatro":
                num = 4;
                break;
            case "cinco":
                num = 5;
                break;

            default:
                Console.WriteLine("EL NUMERO QUE INGRESO NO SE ENCUENTRA EN EL RANGO DE  NUMEROS");
                break;

        }
        Console.WriteLine("**************************************");
        Console.WriteLine($"EL NUMERO QUE USTED INGRESO ES:{num}");
        Console.WriteLine("**************************************");


        Console.WriteLine("------------------------------------------------------");
        Console.WriteLine("2.\tMostrar el Día de la Semana a partir de un Número:");
        Console.WriteLine("------------------------------------------------------");
        Console.WriteLine("");

        Console.WriteLine("INGRESE EL NUMERO DEL DIA DE LA SEMANA QUE NECESITA IMPRIMIR");

        int dia = Convert.ToInt32(Console.ReadLine());
        switch (dia)
        {
            case 1:
                Console.WriteLine("EL DIA DE LA SEMANA QUE USTED SELECCIONO ES LUNES");
                break;
            case 2:
                Console.WriteLine("EL DIA DE LA SEMANA QUE USTED SELECCIONO ES MARTES");
                break;
            case 3:
                Console.WriteLine("EL DIA DE LA SEMANA QUE USTED SELECCIONO ES MIERCOLES");
                break;
            case 4:
                Console.WriteLine("EL DIA DE LA SEMANA QUE USTED SELECCIONO ES JUEVES");
                break;
            case 5:
             Console.WriteLine("EL DIA DE LA SEMANA QUE USTED SELECCIONO ES VIERNES");
                break;
            case 6:
           Console.WriteLine("EL DIA DE LA SEMANA QUE USTED SELECCIONO ES SABADO");
                break;
            case 7:
            Console.WriteLine("EL DIA DE LA SEMANA QUE USTED SELECCIONO ES DOMINGO");
                break;
            default: Console.WriteLine("EL NUMERO DEL DIA QUE INGRESO ES INCORRECTO, VUELA A INTENTAR");
                break;


        }

        Console.WriteLine("------------------------------------------------------");
        Console.WriteLine("3.\tCalcular el Importe a Pagar por un Servicio:");
        Console.WriteLine("------------------------------------------------------");
        Console.WriteLine("");














    } //NO BORRAR
} // nO BORRAR
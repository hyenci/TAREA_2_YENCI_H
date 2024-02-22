using System;


public class TAREA2
{
    public static void Main(string[] args)
    {

        try
        {
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("1.\tConvertir un Número de Letra a Número:");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("INGRESE UN NUMERO DEL 1 AL 5 EN LETRAS (UNO, DOS, TRES, CUATRO, CINCO");
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

            Console.WriteLine("");
            Console.WriteLine("");




            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("2.\tMostrar el Día de la Semana a partir de un Número:");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("");

            Console.WriteLine("INGRESE EL NUMERO DEL DIA DE LA SEMANA QUE NECESITA IMPRIMIR");

            int dia = Convert.ToInt32(Console.ReadLine());
            switch (dia)
            {
                case 1:
                    Console.WriteLine("EL DIA DE LA SEMANA QUE USTED SELECCIONO ES: >LUNES");
                    break;
                case 2:
                    Console.WriteLine("EL DIA DE LA SEMANA QUE USTED SELECCIONO ES:  >MARTES");
                    break;
                case 3:
                    Console.WriteLine("EL DIA DE LA SEMANA QUE USTED SELECCIONO ES: >MIERCOLES");
                    break;
                case 4:
                    Console.WriteLine("EL DIA DE LA SEMANA QUE USTED SELECCIONO ES: >JUEVES");
                    break;
                case 5:
                    Console.WriteLine("EL DIA DE LA SEMANA QUE USTED SELECCIONO ES: >VIERNES");
                    break;
                case 6:
                    Console.WriteLine("EL DIA DE LA SEMANA QUE USTED SELECCIONO ES: >SABADO");
                    break;
                case 7:
                    Console.WriteLine("EL DIA DE LA SEMANA QUE USTED SELECCIONO ES: <DOMINGO");
                    break;
                default:
                    Console.WriteLine("EL NUMERO DEL DIA QUE INGRESO ES INCORRECTO, VUELA A INTENTAR");
                    break;


            }

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("3.\tCalcular el Importe a Pagar por un Servicio:");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("INGRESE EL NUMERO DEL SERVICIO QUE DESEA HACERLE A SU AUTO");
            Console.WriteLine("");
            Console.WriteLine("1.Lavado de auto");
            Console.WriteLine("2.Cambio de aceite");
            Console.WriteLine("3.Revisión mecánica");

            int num2 = Convert.ToInt32(Console.ReadLine());
            switch (num2)
            {
                case 1:
                    Console.WriteLine("*****************************");
                    Console.WriteLine("SU TOTAL A PAGAR ES DE Q35");
                    Console.WriteLine("*****************************");
                    break;
                case 2:
                    Console.WriteLine("*****************************");
                    Console.WriteLine("SU TOTAL A PAGAR ES DE Q75");
                    Console.WriteLine("*****************************");
                    break;
                case 3:
                    Console.WriteLine("*****************************");
                    Console.WriteLine("SU TOTAL A PAGAR ES DE Q80");
                    Console.WriteLine("*****************************");
                    break;
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("4.\tMostrar un Mensaje de Bienvenida en Diferentes Idiomas:");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("");

            Console.WriteLine("SELECIONE EL IDIOMA QUE PREFIERA");
            Console.WriteLine("1.ESPAÑOL");
            Console.WriteLine("2.INGLES");
            Console.WriteLine("3.FRANCES");
            int numi = Convert.ToInt32(Console.ReadLine());

            switch (numi)
            {
                case 1:
                    Console.WriteLine("*********************");
                    Console.WriteLine("TEN UN LINDO DIA :)");
                    Console.WriteLine("*********************");
                    break;
                case 2:
                    Console.WriteLine("*********************");
                    Console.WriteLine("HAVE A NICE DAY :)");
                    Console.WriteLine("*********************");
                    break;
                case 3:
                    Console.WriteLine("*********************");
                    Console.WriteLine("TU ES INCROYABLE :)");

                    break;
                default:
                    Console.WriteLine("LA OPCION QUE SELECCIONO ES INCORRECTA");
                    break;

            }

            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("5.\tEvaluar la Calificación de un Examen:");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("");

            Console.WriteLine("INGRESE LA NOTA DE EL PRIMER PARCIAL");
            double parcial = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("INGRESE LA NOTA DE EL SEGUNDO PARCIAL");
            double parcial2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("INGRESE LA NOTA DE ACTIVIDADES");
            double acti1 = Convert.ToDouble(Console.ReadLine());
            double zonami;
            zonami = parcial + parcial2 + acti1;


            if (zonami >= 26)
            {

                Console.WriteLine("INGRESE LA NOTA DEl EXAMEN FINAL");
                double exfinal = Convert.ToDouble(Console.ReadLine());
                double nota;
                nota = parcial + parcial2 + acti1 + exfinal;

                switch (nota)
                {
                    case > 101:
                        Console.Write("ERROR EN LOS VALORES INGRESADOS");
                        break;
                    case >= 90:
                        Console.WriteLine("SU NOTA ES EXCELENTE, APROBADO");
                        break;
                    case >= 80:
                        Console.WriteLine("SU NOTA ES BUENA, APROBADO");
                        break;
                    case >= 70:
                        Console.WriteLine("SU NOTA ES SATISFACTORIA, APROBADO");
                        break;
                    case <= 60:
                        Console.WriteLine("SU NOTA ES INSATISFACTORIA, REPROBADO");
                        Console.WriteLine("");
                        Console.WriteLine("¿EL ESTUDIANTE SE SOMETIO A UN EXAMEN DE RECUPERACION?");

                        Console.WriteLine("SELECIONE EL NUMERO DE SU RESPUESTA 1.SI     2.NO");
                        int respuesta = Convert.ToInt32(Console.ReadLine());
                        if (respuesta == 1)
                        {
                            Console.WriteLine("INGRESE LA NOTA FINAL DEL EXAMEN DE RECUPERACION DEL ALUMNO");
                            double recup = Convert.ToDouble(Console.ReadLine());
                            if (recup >= 61)
                            {
                                Console.WriteLine("FELICIDADES APROBO EL CURSO EN SEGUNDA CONVOCATORIA");
                                Console.WriteLine($"CON UNA NOTA DE : " + recup);
                            }
                            else
                            {
                                Console.WriteLine($"EXAMEN DE RECUPERACIÓN REPROBADO CON UNA NOTA DE: " + recup);
                            }

                        }


                        break;

                    default:
                        Console.Write("VALORES FUERA DE RANGO DE SU NOTA");
                        break;

                }



            }
            else
            {
                Console.Write("NO LLEGO A ZONA MININA, HA SIDO REPROBADO, POR FAVOR REPETIR EL CURSO");
            }


            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");






        }



        catch (FormatException error)
        {


            Console.WriteLine("Error en algun valor o dato ingresado por favor volver a intentar");
            Console.WriteLine(error.Message);
        }
        finally
        {

            Console.WriteLine("Presione cualquier tecla para salir salir del programa...");
            Console.ReadKey();
        }






    } //NO BORRAR
} // nO BORRAR
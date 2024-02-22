using System;


public class Tarea
{
    public static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("CALCULAR EL MAYOR DE 3 NUMEROS");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("");

            Console.WriteLine("INGRESE EL PRIMER NUMERO A COMPARAR");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("INGRESE EL SEGUNDO NUMERO A COMPARAR");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("INGRESE EL TERCER NUMERO A COMPARAR");
            double num3 = Convert.ToDouble(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine($"EL NUMERO MAYOR ES:   " + num1);
            }
            else if (num1 < num2)
            {


                Console.WriteLine($"EL NUMERO MAYOR ES:   " + num2);
            }
            else if (num1 == num2 && num2 == num3 && num1 == num3)
            {


                Console.WriteLine("Los numeros que usted ingreso son iguales, por favor ingrese otros valores");

            }
            else { Console.WriteLine($"EL NUMERO MAYOR ES:   " + num3); }

            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("PROGRAMA 2");
            Console.WriteLine("");
            Console.WriteLine("INGRESE SU NOMBRE");
            string nombre1 = Console.ReadLine();

            Console.WriteLine("INGRESE SU EDAD");
            int edad = Convert.ToInt32(Console.ReadLine());
            if (edad >= 18)
            {
                Console.WriteLine("BIENVENIDO AL CLUB MADS");

            }
            else
            {
                Console.WriteLine("USTED ES MENOR DE EDAD, NO PUEDE UNIRSE AL CLUB");
            }


            Console.WriteLine("-------------------------------");
            Console.WriteLine("Calcular el Precio Final de un Producto:");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("");
            double descuento, des1;

            Console.WriteLine("INGRESE EL PRECIO DEL PRODUCTO A COBRAR");
            double precio = Convert.ToDouble(Console.ReadLine());
            if (precio >= 100)
            {
                descuento = (precio * 10 / 100);
                des1 = precio - descuento;
                Console.WriteLine($"SU DESCUENTO FUE DE {descuento} y su TOTAL A PAGAR ES {des1}");
            }
            else
            {
                Console.WriteLine($"SU TOTAL A PAGAR ES: " + precio);
            }

            Console.WriteLine("-------------------------------");
            Console.WriteLine("Validar Usuario y Contraseña:");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("");
            Console.WriteLine("INGRESE POR FAVOR SU NOMBRE DE USUARIO");
            string usuario = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("INGRESE SU CONTRASEÑA");
            string contra = Console.ReadLine();
            if (usuario == "ANA_21" && contra == "pandita12" || usuario == "Fer12h" && contra == "carliR")
            {

                Console.WriteLine("-------------------------------");
                Console.WriteLine("!BIENVENIDO!");
                Console.WriteLine("-------------------------------");
                Console.WriteLine("USUARIO Y CONTRASEÑA CORRECTOS");
            }

            else
            {



                Console.WriteLine("USUARIO O CONTRASEÑA INCORRECTOS");
                Console.WriteLine("********************************");
                Console.WriteLine("INTENTALO DE NUEVO");
            }



            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Determinar si un Número es Par o Impar:");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("");

            Console.WriteLine("INGRESE UN NUMERO");
            int numpI = Convert.ToInt32(Console.ReadLine());

            if (numpI % 2 == 0)
            {
                Console.WriteLine("EL NUMERO INGRESADO ES PAR");
                Console.WriteLine("");
                Console.WriteLine(":)");



            }
            else
            {
                Console.WriteLine("EL NUMERO INGRESADO ES IMPAR");
            }

            Console.WriteLine("-------------------------------");
            Console.WriteLine("Mostrar un Mensaje de Aprobación o Rechazo de Préstamo:");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("");

            Console.WriteLine("INGRESE SU EDAD");
            int edad1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine("INGRESE EL MONTO DE SU PRESTAMO");
            double prestamo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("");
            if (prestamo <= 5000 && edad1 >= 60)
            {
                Console.WriteLine("**********************************");
                Console.WriteLine("SU PRESTAMO FUE APROBADO CON EXITO");
                Console.WriteLine("**********************************");
            }
            else
            {

                Console.WriteLine("***************************************");
                Console.WriteLine("LO SENTIMOS, SU PRESTAMO FUE RECHAZADO");
                Console.WriteLine("***************************************");
            }

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Calcular el Área de una Figura Geométrica:");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("POR FAVOR, INGRESE EL TIPO DE FIGURA GEOMÉTRICA (TRIÁNGULO, CUADRADO O CÍRCULO");
            string figura = Console.ReadLine();

            if (figura.ToLower() == "triángulo")
            {
                Console.WriteLine("INGRESE LA BASE DEL TRIANGULO");
                double baseTriangulo = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("INGRESE LA ALTURA DEL TRIANGULO");
                double alturaTriangulo = Convert.ToDouble(Console.ReadLine());

                double areaTriangulo = (baseTriangulo * alturaTriangulo) / 2;
                Console.WriteLine($"EL AREA DEL TRIANGULO ES : {areaTriangulo}");
            }
            else if (figura.ToLower() == "cuadrado")
            {
                Console.WriteLine("INGRESE EL LADO DEL CUADRADO:");
                double ladoCuadrado = Convert.ToDouble(Console.ReadLine());

                double areaCuadrado = ladoCuadrado * ladoCuadrado;
                Console.WriteLine($"EL AREA DEL CUADRADO: {areaCuadrado}");
            }
            else if (figura.ToLower() == "círculo")
            {
                Console.WriteLine("INGRESE EL RADIO DEL CIRCULO:");
                double radioCirculo = Convert.ToDouble(Console.ReadLine());

                double areaCirculo = Math.PI * Math.Pow(radioCirculo, 2);
                Console.WriteLine($"EL AREA DEL CIRCULO: {areaCirculo}");
            }
            else
            {
                Console.WriteLine("FIGURA NO ENCONTRADA POR FAVOR VOLVER A INGRESAR LOS DATOS CORRECTAMENTE");
            }
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






    }//NO BORRAR
}//NO BORRAR
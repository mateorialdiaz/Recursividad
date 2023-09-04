using Microsoft.VisualBasic;

namespace Recursion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int SumaPrimerosN(int N)
        {
            if (N <= 0) return 0; // caso base
            return N + SumaPrimerosN(N - 1); // llamada recursiva
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int N = int.Parse(Interaction.InputBox("Ingrese el valor de N: "));
            int resultado = SumaPrimerosN(N);
            MessageBox.Show($"La suma de los primeros {N} enteros es: {resultado}");




        }
        //-----------------------------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------------------------


        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int input = int.Parse(Interaction.InputBox("Ingrese la cantidad de numeros pares que desee obtener"));

            ObtenerNPares(input);

        }


        // añade los N primeros números pares al ListBox
        public void ObtenerNPares(int N, int actual = 2)
        {
            if (N == 0)
            {
                return;
            }

            listBox1.Items.Add(actual);
            ObtenerNPares(N - 1, actual + 2);
        }

        //-----------------------------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------------------------

        private void button3_Click(object sender, EventArgs e)
        {

            int base_, potencia_;
            base_ = int.Parse(Interaction.InputBox("Base: "));
            potencia_ = int.Parse(Interaction.InputBox("Potencia: "));

            int resu = Potencia(base_, potencia_);
            MessageBox.Show($"El resultado de {base_} elevado a la {potencia_} es: {resu}", resu.ToString());


        }

        public int Potencia(int base_, int potencia_)
        {
            int resultado = 0;
            if (potencia_ == 1) { resultado = base_; }
            else resultado = base_ * Potencia(base_, potencia_ - 1);

            return resultado;
        }


        //-----------------------------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------------------------

        private void button4_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear(); // Limpia el ListBox antes de añadir nuevos elementos
            int n = int.Parse(Interaction.InputBox("Ingrese la cantidad de números de la serie de Fibonacci que desea: "));

            GenerarFibonacci(n, 0, 1, 0);
        }

        public void GenerarFibonacci(int N, int a, int b, int count)
        {
            //n ES EL NUMERO TOTAL DE ELEMENTOS PARA GENERAR
            //a ES EL ULTIMO NUMERO GENERADO EN LA SERIE DE FIBONACCI
            //b EL SIGUIENTE NUMERO DE LA SERIE
            if (count >= N)
            {  //COUNT ES UN CONTADOR DE LA CANTIDAD ACTUAL DE ELEMENTOS GENERADOS
                return;
            }

            if (count == 0)
            {
                listBox2.Items.Add(a);
            }
            else
            {
                listBox2.Items.Add(b);

                // Calculamos el siguiente número en la serie
                int temp = a + b;
                a = b;
                b = temp;
            }

            GenerarFibonacci(N, a, b, count + 1);
        }


        //-----------------------------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------------------
        private void button5_Click(object sender, EventArgs e)
        {
            int n = int.Parse(Interaction.InputBox("Ingrese los N consecutivos: "));  //este N es la cantidad de terminos que voy a sumar
            int desde = int.Parse(Interaction.InputBox("Desde donde vamos a comenzar a realizar la suma?: ")); //voy a empezar a sudmar desde este numero
            int resultado = SumaHasta(n, desde);
            MessageBox.Show($"El resultado de la suma de los {n} terminos consecutivos desde {desde} es: " + resultado);
        }

        public int SumaHasta(int n, int desde)
        {  //retorna la suma de los números desde "desde" hasta N números consecutivos a él.
            if (n == 0)
            {
                return 0;
            }

            return desde + SumaHasta(n - 1, desde + 1);
        }

        //-----------------------------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------------------------

        private void button6_Click(object sender, EventArgs e)
        {
            int N = int.Parse(Interaction.InputBox("Ingrese un número N:", "Suma de pares", "10"));

            if (N % 2 == 1)
            {
                MessageBox.Show("Error: El número ingresado es impar.");
                return;
            }

            int resultado = SumaDePares(N);
            MessageBox.Show($"La suma de los enteros positivos pares desde {N} hasta 2 es: " + resultado);


        }

        public int SumaDePares(int N)
        {
            if (N <= 0)
            {
                return 0;
            }

            if (N % 2 == 0)
            {
                return N + SumaDePares(N - 2);
            }
            else
            {
                return SumaDePares(N - 1);
            }
        }






        //-----------------------------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------------------------

        private void button7_Click(object sender, EventArgs e)
        {
            List<int> unaLista = new List<int> { 1, 2, 3 };
            List<string> otra = new List<string> { "a", "b", "c" };
            List<List<object>> resultado = Aparear(unaLista, otra);

            string resultadoStr = "Lista apareada: ";
            foreach (var par in resultado)
            {
                resultadoStr += $"({par[0]}, {par[1]}), ";
            }
            // Remueve la última coma y espacio.
            resultadoStr = resultadoStr.Substring(0, resultadoStr.Length - 2);

            MessageBox.Show(resultadoStr);
        }



        //el metodo aparear inicializa la lista de listas de objetos en resultado y llama a la recursiva
        //cada lista interior contiene un par de elementos, un entero y una cadena
        private List<List<object>> Aparear(List<int> unaLista, List<string> otra)
        {
            List<List<object>> resultado = new List<List<object>>();
            return AparearRecursivo(unaLista, otra, 0, resultado);
        }



        //el metodo aparearRecursivo toma 4 argumentos: 
        // * las dos listas a aparear
        // * index, que es el indice actual, y la lista resultado donde almaceno los pares
        private List<List<object>> AparearRecursivo(List<int> unaLista, List<string> otra, int index, List<List<object>> resultado)
        {
            //CASO BASE
            if (index >= unaLista.Count || index >= otra.Count)
            {
                return resultado;  //retorna la lista resultado en caso que llegue al final de las listas
            }


            //CASO RECURSIVO

            //creo un nuevo par (lista de objetos) y añado a resultado ese par
            List<object> par = new List<object> { unaLista[index], otra[index] };
            resultado.Add(par);
            //llamada recursiva con el indice incrementado por 1
            return AparearRecursivo(unaLista, otra, index + 1, resultado);
        }




        //////ALTERNATIVA PERO CONVIRTIENDO A STRING
        ///List<string> unaLista = new List<string> { "1", "2", "3" };
        //        List<string> otra = new List<string> { "a", "b", "c" };
        //        List<List<string>> resultado = Aparear(unaLista, otra);

        //        string resultadoStr = "Lista apareada: ";
        //    foreach (var par in resultado)
        //    {
        //        resultadoStr += $"({par[0]}, {par[1]}), ";
        //    }
        //    resultadoStr = resultadoStr.Substring(0, resultadoStr.Length - 2);  // Eliminando la última coma y espacio

        //    MessageBox.Show(resultadoStr);
        //}

        //private List<List<string>> Aparear(List<string> unaLista, List<string> otra)
        //{
        //    List<List<string>> resultado = new List<List<string>>();
        //    return AparearRecursivo(unaLista, otra, 0, resultado);
        //}

        //private List<List<string>> AparearRecursivo(List<string> unaLista, List<string> otra, int index, List<List<string>> resultado)
        //{
        //    if (index >= unaLista.Count || index >= otra.Count)
        //    {
        //        return resultado;
        //    }

        //    List<string> par = new List<string> { unaLista[index], otra[index] };
        //    resultado.Add(par);

        //    return AparearRecursivo(unaLista, otra, index + 1, resultado);
        //}

        //ALTERNATIVA PERO QUE EL USUARIO INGRESE LAS LISTAS


        //    List<string> unaLista = new List<string>();
        //    List<string> otra = new List<string>();

        //        // Obtener los elementos de la primera lista del usuario
        //        for (int i = 1; i <= 3; i++)
        //        {
        //            string input = Interaction.InputBox($"Ingrese el elemento {i} de la primera lista:");
        //    unaLista.Add(input);
        //        }

        //        // Obtener los elementos de la segunda lista del usuario
        //        for (int i = 1; i <= 3; i++)
        //        {
        //            string input = Interaction.InputBox($"Ingrese el elemento {i} de la segunda lista:");
        //otra.Add(input);
        //        }

        // No necesitamos validar el tamaño de las listas porque estamos recogiendo exactamente 3 elementos para cada una

        //List<List<string>> resultado = Aparear(unaLista, otra);

        //string resultadoStr = "Lista apareada: ";
        //foreach (var par in resultado)
        //{
        //    resultadoStr += $"({par[0]}, {par[1]}), ";
        //}
        //resultadoStr = resultadoStr.Substring(0, resultadoStr.Length - 2);  // Eliminando la última coma y espacio

        //MessageBox.Show(resultadoStr);
        //        }

        //        private List<List<string>> Aparear(List<string> unaLista, List<string> otra)
        //{
        //    List<List<string>> resultado = new List<List<string>>();
        //    return AparearRecursivo(unaLista, otra, 0, resultado);
        //}

        //private List<List<string>> AparearRecursivo(List<string> unaLista, List<string> otra, int index, List<List<string>> resultado)
        //{
        //    if (index >= unaLista.Count || index >= otra.Count)
        //    {
        //        return resultado;
        //    }

        //    List<string> par = new List<string> { unaLista[index], otra[index] };
        //    resultado.Add(par);

        //    return AparearRecursivo(unaLista, otra, index + 1, resultado);
        //}








        //-----------------------------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------------------------



        private void button8_Click(object sender, EventArgs e)
        {
            //string input = Interaction.InputBox("Ingrese el texto para convertir a mayúsculas: ");
            //string resultado = Mayusculas(input);
            //MessageBox.Show("Resultado: " + resultado);
            string input = Interaction.InputBox("Ingrese el texto: ");
            string resultado = Mayusculas(input);
            MessageBox.Show("Resultado: " + resultado);

        }

        public string Mayusculas(string unString)
        {
            return MayusculasRecursivo(unString.ToCharArray(), 0, true);
        }

        private string MayusculasRecursivo(char[] caracteres, int index, bool primeraLetra)
        {

            //caso base
            if (index >= caracteres.Length)
            {
                return new string(caracteres);
            }

            //llamado a la recursiva
            if (primeraLetra)
            {
                caracteres[index] = char.ToUpper(caracteres[index]);
                return MayusculasRecursivo(caracteres, index + 1, false);
            }
            else
            {
                return MayusculasRecursivo(caracteres, index + 1, false);
            }
        }



        //public string Mayusculas(string unString)
        //{
        //    return MayusculasRecursivo(unString.ToCharArray(), 0);
        //}

        //private string MayusculasRecursivo(char[] caracteres, int index)
        //{
        //    if (index >= caracteres.Length)
        //    {
        //        return new string(caracteres);
        //    }

        //    caracteres[index] = char.ToUpper(caracteres[index]);
        //    return MayusculasRecursivo(caracteres, index + 1);
        //}




        //-----------------------------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------------------------

        private void button9_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(Interaction.InputBox("Ingrese el número entero positivo para convertir a binario:"));
            if (numero < 0)
            {
                MessageBox.Show("Por favor, ingrese un número entero positivo.");
                return;
            }

            string resultado = ConvertirABinario(numero);
            MessageBox.Show("El número en notación binaria es: " + resultado);
        }

        public string ConvertirABinario(int numero)
        {
            if (numero == 0)
            {
                return "0";
            }
            else if (numero == 1)
            {
                return "1";
            }  //de no ser ni 0 ni 1, divido el numero entre 2 y se aplica la funcion recursivamente
            //y se concatena el resultado con el resto de la division que será 0 o 1
            else
            {
                return ConvertirABinario(numero / 2) + (numero % 2).ToString();
            }
        }







        //-----------------------------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------------------------


        private void button10_Click(object sender, EventArgs e)
        {
            //la cadena binario representa el numero en notacion binaria
            string binario = Interaction.InputBox("Ingrese el número en notación binaria para convertir a decimal:");
            foreach (char c in binario)
            {
                if (c != '0' && c != '1')
                {
                    MessageBox.Show("Por favor, ingrese un número válido en notación binaria.");
                    return;
                }


            }

            int resultado = ConvertirADecimal(binario);
            MessageBox.Show("El número en decimal es: " + resultado);





        }


        public int ConvertirADecimal(string binario)
        {
            return ConvertirADecimalRecursivo(binario, binario.Length - 1, 0);
        }

        private int ConvertirADecimalRecursivo(string binario, int posicion, int exponente)
        {

            //el entero posicion es para identificar que digito estoy examinando en cada paso de la recursion
            //finaliza la recursion cuando posicion es menor a cero

            //caso base
            if (posicion < 0)
            {
                return 0;
            }
            //

            //caso recursivo
            else
            {   //convierto el bit actual (ubicado en binario[posicion] ) de char a entero
              
                
                int digito = int.Parse(binario[posicion].ToString());

                //calcula el valor del bit actual en decimal
                //si el bit es 0 el valor sera 0
                //si el bit es 1 el valor será 2 elevado a exponente

                //llamo a la recursiva para el siguiente bit hacia la izquierda (bit mas significativo)
                //cada vez q se mueve un bit hacia la izquierda el exponente de la potencia de 2 correspondiente aumenta en 1
                return (digito * (int)Math.Pow(2, exponente)) + ConvertirADecimalRecursivo(binario, posicion - 1, exponente + 1);
            }
        }


        //----------------------------------------------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------------------------------------------

        private void button11_Click(object sender, EventArgs e)
        {
            string palabra = Interaction.InputBox("Ingrese la palabra para verificar si es un palíndromo:");
            bool esPalindromo = EsPalindromo(palabra);

            if (esPalindromo)
            {
                MessageBox.Show("La palabra es un palíndromo.");
            }
            else
            {
                MessageBox.Show("La palabra no es un palíndromo.");
            }
        }

        public bool EsPalindromo(string palabra)
        {
            return EsPalindromoRecursivo(palabra, 0, palabra.Length - 1);
        }
        private bool EsPalindromoRecursivo(string palabra, int inicio, int fin)
        {
            if (inicio >= fin)
            {
                return true;
            }

            if (palabra[inicio] != palabra[fin])
            {
                return false;
            }

            return EsPalindromoRecursivo(palabra, inicio + 1, fin - 1);
        }




    }
}






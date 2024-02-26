
   /* static bool esPrimo(int numero)
    {
        bool primo = true;

        for (int i = 2; i < numero; i++)
        {
            if (numero % i == 0)
            {
                primo = false;
            }
        }

        return primo;
    }

    static int sumaCifras(int anyo)
    { // siempre que necesite sumar los dígitos de uun número, usaré esta función
        int suma = 0;

        while (anyo != 0)
        {
            suma = suma + (anyo % 10); // acumulamos la suma del resto de la división
            anyo /= 10; // moviendo la coma del número a la izquierda
        }

        return suma;
    }

    static void Main()
    {

        /* int num1, num2;

         Console.WriteLine("Escribe el primer número: ");
         num1 = int.Parse(Console.ReadLine());

         Console.WriteLine("Escribe el segundo número: ");
         num2 = int.Parse(Console.ReadLine());

         if (esPrimo(num1) == true && esPrimo(num2) == true)
         {
             int suma = num1 + num2;
             Console.WriteLine("La suma es: " + suma);

             if (esPrimo(suma) == true)
             {
                 Console.WriteLine("La suma es: " + suma + " es un también un número primo");
             }
             else
             {
                 Console.WriteLine("La suma NO es: " + suma + " es un también un número primo");
             }
         }
         else
         {
             Console.WriteLine("Uno de los números no es primo");
         }*/

        /*int dia;
        int mes;
        int anyo;
        
        Console.WriteLine("Escribe el día de nacimiento: ");
        dia = int.Parse(Console.ReadLine());

        Console.WriteLine("Escribe el mes de nacimiento: ");
        mes = int.Parse(Console.ReadLine());

        Console.WriteLine("Escribe el anyo de nacimiento: ");
        anyo = int.Parse(Console.ReadLine());

        int semissuma_numero_magico = dia + mes + sumaCifras(anyo);
        int numero_magico = sumaCifras(semissuma_numero_magico);

        Console.WriteLine("El número mágico es: " + numero_magico);   


        string cadena = "Hola, bienvenidos a la clase de programación en c#";

        // longitud de cadena
        Console.WriteLine(cadena.Length);

        //int contador = 0;

        // recorrer una cadena letra a letra
        /*for(int i = 0; i < cadena.Length; i++){
             Console.WriteLine(cadena[i]);
        }*/

        /*char aBuscar = 'a';

        for (int i = 0; i < cadena.Length; i++)
        {
            if (cadena[i].Equals(aBuscar))
            {
                contador++;
            }
        }

        Console.WriteLine("Espacios en blanco = " + contador);

        // elimina un ccaraccter de una cadena
        cadena = cadena.Replace(",", "");

        // devuelve una cadena según el patrón a buscar
        string[] palabras = cadena.Split(' ');

        for (int i = 0; i < palabras.Length; i++)
        {
            Console.WriteLine(palabras[i]);
        }
        Console.WriteLine(palabras.Length);

        

    }*/

/*      EJERCICIO 1 DE CADENAS

        
    static void Menu(){

        Console.WriteLine("***** OPCIONES ******");
        Console.WriteLine("1. Leer cadea y mostrar longitud");
        Console.WriteLine("2. Introducir dos cadenas y operaciones");
        Console.WriteLine("3. Introducir cadena y mostrar en mayúscula");
        Console.WriteLine("4. Introducir cadena y concatenar una nueva");
        Console.WriteLine("5. Introducir cadena y eliminar N caracteres");
        Console.WriteLine("6. Introducir cadena y eliminar espacios, saltos de líenas y puntos");
        Console.WriteLine("7. Introducir cadena y un número");
        Console.WriteLine("8. Introducir texto y dos cadenas");
        Console.WriteLine("9. Salir");
    }

    static void Main()
    {
       
       int opcion = 0;

       while(opcion != 9){
            Menu();
            Console.WriteLine("Selecciona una opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion){

                case 1: 
                    Console.WriteLine( "Leer cadena y mostrar longitud");
                    string cadena = Console.ReadLine();
                    Console.WriteLine("La cadena tiene de longitud: " + cadena.Length);
                    break;

                case 2: 
                    Console.WriteLine("Introduce dos cadenas");

                    Console.WriteLine("Introduce la primera cadena: ");
                    string cadena1= Console.ReadLine();

                    Console.WriteLine("Introduce la segunda cadena: ");
                    string cadena2= Console.ReadLine();

                    // devuelve la posicion en la que una cadena contiene a la otra
                    int pos = cadena1.LastIndexOf(cadena2);

                    if(pos == -1){
                        Console.WriteLine("La cadena2 no está en la cadena1");
                    }else{  
                        Console.WriteLine("La cadena2 está en la posición " + pos + " de la cadena1");
                    }

                    break;

                case 3: 
                        Console.WriteLine("Introduce una cadena");
                        string cadena3= Console.ReadLine();
                        cadena3= cadena3.ToUpper();
                        Console.WriteLine(cadena3);
                    break;

                case 4:
                        Console.WriteLine("Introduce una cadena: "); 
                        string cadena4 = Console.ReadLine();

                        string cadena5 = " LA CADENA FIN HA SIDO AÑADIDA A NUESTRA CADENA ";

                        // unir dos cadenas sin el operador  +
                        string cadenaFinal = string.Concat(cadena4,cadena5);

                        Console.WriteLine(cadenaFinal);
                    break;

                case 5: 
                        Console.WriteLine("Introduce una cadena");
                        string cadena6= Console.ReadLine();

                        Console.WriteLine("introduce la posición: ");
                        int pos1 = int.Parse(Console.ReadLine());

                        Console.WriteLine("introduce la catidad de caracteres a eliminar: ");
                        int nCaracter = int.Parse(Console.ReadLine());

                        // elimina caracteres de una cadena a partir de uan posición dada
                        cadena6 = cadena6.Remove(pos1,nCaracter);

                        Console.WriteLine(cadena6);
                        
                    break;

                case 6: 
                        Console.WriteLine("Introduce una cadena");
                        string cadena7= Console.ReadLine();

                        cadena7 = cadena7.TrimEnd(' ','\n','.');

                         Console.WriteLine(cadena7);
                    break;

                case 7: 
                    Console.WriteLine("Introduce una cadena");
                    string cadena8= Console.ReadLine();
                    Console.WriteLine("Introduce un numero");
                    int numero= int.Parse(Console.ReadLine());

                    cadena8 = cadena8.PadRight(cadena8.Length + numero,'!');

                      Console.WriteLine(cadena8);
                    break;

                case 8: 
                    Console.WriteLine("Introduce un texto");
                    string texto= Console.ReadLine();
                    Console.WriteLine("Dame la primera cadena");
                    string cadena9= Console.ReadLine();
                    Console.WriteLine("Dame la segunda cadena");
                    string cadena10= Console.ReadLine();

                    texto = texto.Replace(cadena9,cadena10);

                    Console.WriteLine(texto);
                    break;

                case 9: 
                    opcion = 9;
                    Console.WriteLine("Has finalizado el programa !!!");
                    break;

                default:
                    Console.WriteLine("Seleccione una opción válida");
                    break;
            }

       }
        
        // EJERCICIO 3 (AHORCADO)

        static void Main(){

        Console.WriteLine("Entre la palabra a adivinar: ");
        string palabra = Console.ReadLine().ToUpper();

        Console.WriteLine("Entre el número máximo de fallos: ");
        int fallos = int.Parse(Console.ReadLine());

        int contador_fallos = 0;

        char []letrasAcertadas = new char[palabra.Length];
        char []letraFalladas = new char[fallos];

        // Inicializar el array con guinoes bajos
        for(int i = 0; i < letrasAcertadas.Length; i++){
            letrasAcertadas[i] = '_';
        }

        while(contador_fallos < fallos){

            Console.WriteLine("Palabra: " + string.Join(" ", letrasAcertadas));
            Console.WriteLine("Fallos: " + string.Join(" ", letraFalladas));

            Console.WriteLine("Entre una letra: ");
            char letra = char.ToUpper(Console.ReadLine()[0]);

            if(Array.IndexOf(letrasAcertadas,letra) != -1){
                Console.WriteLine("Ya has introducido esa letra");
                continue;
            }

            if(palabra.Contains(letra)){

                for(int i = 0; i < palabra.Length; i++){
                    if(palabra[i] == letra){
                        letrasAcertadas[i] = letra;
                    }
                }


            }else{
                letraFalladas[contador_fallos] = letra;
                contador_fallos++;
            }

            if(string.Join("", letrasAcertadas) == palabra){
                Console.WriteLine("Has adivinado la palabra: " + palabra);
                break;
            }

        }

        if(contador_fallos == fallos){
            Console.WriteLine("Has superado el número máximo de fallos");
            Console.WriteLine("La palabra a adivinar era: " + palabra);
        }

    }
        
       

    }

    // EJEJERCICIO 2 STRING BUILDER

         static string funcionEspecular(string frase){

        StringBuilder resultado = new StringBuilder();
        string []palabras = frase.Split(' ');

       foreach (string palabra in palabras)
        {
            StringBuilder palabraInvertida = new StringBuilder();
            for (int i = palabra.Length - 1; i >= 0; i--)
            {
                palabraInvertida.Append(palabra[i]);
            }
            resultado.Append(palabraInvertida + " ");
        }

        return resultado.ToString();
    }

    static string cambiarCaracter(string cadena){

        Random random = new Random();

        StringBuilder resultado = new StringBuilder();

        string caracteresEspeciales = ",:.;?¿!¡";

        foreach(char caracter in cadena){
            if(caracteresEspeciales.Contains(caracter)){
                char caraterAleatorio = (char) random.Next(224,238);
                resultado.Append(caraterAleatorio);
            }else{
                resultado.Append(caracter);    
            }
        }

        return resultado.ToString();
    }

    static string quitarEspaciosBlanco(string cadena){
       
        StringBuilder resultado = new StringBuilder();

        foreach(char caracter in cadena){
            if(caracter != ' '){
                resultado.Append(caracter);    
            }
        }

        return resultado.ToString();
    }

    static void Main(){
        Console.WriteLine("Introduce la frase a ofuscar");        
        string cadena = Console.ReadLine();
        
        if(cadena[cadena.Length-1] == '.'){
            Console.WriteLine(cadena);

            cadena = cadena.Replace(".",",");

            cadena = funcionEspecular(cadena);
            Console.WriteLine(cadena);

            cadena = cambiarCaracter(cadena);
            Console.WriteLine(cadena);
            
            cadena = quitarEspaciosBlanco(cadena);
            Console.WriteLine(cadena);
        }

    }
    //EJERCICIO CORTO ARRAYS 1

    static void Main(){

    Console.WriteLine("Tamaño del array: ");
    int n = int.Parse(Console.ReadLine());

    int[] array = new int[n];

    Random random = new Random();

    for(int i = 0; i < n; i++){
        array[i] = random.Next(1,100);
    }

    Console.WriteLine("Contenido del array: ");

    foreach(int numero in array){
        Console.Write(numero+" ");
    }

   }

   //EJERCICIO CORTO 2 ARRAYS 

    static void Main(){
        int n = 10;
        double[] array = new double[n];
        Random random= new Random();
    
        for(int i=0; i<n; i++)
        {
            array[i]= random.NextDouble() * 100d;
        }


        Console.WriteLine("Posiciones Múltiplos de 4: ");
        for(int i = 1; i < array.Length; i++){
            if(i % 4 == 0){
                Console.WriteLine(array[i]);
            }
        }


   }

   // EJERCICIO CORTO 3  ARRAYS 

     static void Main(){
        int n = 10;
        double[] array = new double[n];
        Random random= new Random();
        
        double suma = 0;

        for(int i=0; i<n; i++)
        {
            double numero = random.NextDouble() * 100d;            
            array[i] = numero;
            suma += numero; // acumular  la semisuma de cada numero
        }

        Console.WriteLine("La suma es: " + suma);
   }

        EJERCICIO CORTO 5 ARRAYS

          static void Main()
   {
    int n= 10;
    int [] array= new int [n];
    Random random= new Random();
    for(int i=0; i<n; i++)
    {
        array[i]= random.Next(1, 100);
    }
    foreach(int numero in array)
    {
        Console.Write(numero+ " ");
    }

    Console.WriteLine("");
    Console.WriteLine("Números pares - posición");
    
    for(int i=0; i<array.Length; i++){
        if(array[i] % 2 == 0){
            Console.WriteLine(array[i]+" - " + i);
        }
    }

   }

   // ejercicio 6

   static void Main(){
    int n= 10;
    Random random= new Random();
    int [] array= new int[n];

    for(int i=0; i<n; i++){
        array[i]= random.Next(1,200);
        Console.Write(array[i]+" ");
    }

    Console.WriteLine("");
    int m = array[0]; // inicializar la mayor con el primer valor
    int posM = 0; // inicializo la posición del mayor

    for(int i=0; i < array.Length; i++){

        if(array[i] > m){
            m = array[i];
            posM = i;
        }

    }

    Console.WriteLine("EL número mayor es: " + m + " y está en la posición: " + posM);

  }

  // ARRAYS EJERCICIO 7

   static void Main()
    {
        int n = 10;
        int[] V = new int[n];
        int[] P = new int[n];
        int[] I = new int[n];

        int num = 0;

        Random random = new Random();

        for (int j = 0; j < n; j++)
        {
            num = random.Next(1, 100);
            V[j] = num;

            if (num % 2 == 0)
            {
                P[j] = num;
            }
            else
            {
                I[j] = num;
            }
        }

        Array.Sort(P); // ordenar creciente
        Console.WriteLine("***** NÚMERO PARES *****");
        for (int m = 0; m < P.Length; m++)
        {
            if (P[m] > 0)
            {
                Console.WriteLine(P[m]);
            }
        }

        Array.Sort(I);
        Array.Reverse(I);
        Console.WriteLine("***** NÚMERO IMPARES *****");
        for (int r = 0; r < I.Length; r++)
        {
            if (I[r] > 0)
            {
                Console.WriteLine(I[r]);
            }
        }
        }

        //ARRAYS EJERCICIO 8 

          static bool esCapicua(char[] numero){

        bool capicua = true;

        int inicio = 0;
        int fin = numero.Length - 1;

        while(inicio < fin){
            if(numero[inicio] != numero[fin]){
                capicua = false;
            }
            inicio++;
            fin--;
        }

        return capicua;
    }

   static void Main()
   {
    Console.WriteLine("Introduce un número entero");
    char[] numero = Console.ReadLine().ToCharArray();

    bool capicua = esCapicua(numero);

    if(capicua == true){
        Console.WriteLine(numero);
        Console.WriteLine("El número es capicúa");
    }else{
         Console.WriteLine(numero);
        Console.WriteLine("El número NO es capicúa");
    }
   }

   //EJERCICIO 9 ARRAYS

     static void Main()
    {

        int opcion = 0;
        int n = 20;

        char[] contrasenya_actual = new char[n];

        while (opcion != 3)
        {

            Console.WriteLine("***** OPCIONES ******");
            Console.WriteLine("1. Registrarse en el sistema");
            Console.WriteLine("2. Entrar en el sistema");
            Console.WriteLine("3. Salir");

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("________________________");
                    Console.WriteLine("Registrarse: ");

                    char[] contraseya = new char[n];
                    char[] comp_contraseya = new char[n];

                    Console.Write("Contraseña: ");
                    contraseya = Console.ReadLine().ToCharArray();

                    Console.Write("Comprobar Contraseña: ");
                    comp_contraseya = Console.ReadLine().ToCharArray();

                    bool iguales = true;

                    for (int i = 0; i < contraseya.Length; i++)
                    {
                        if (contraseya[i] != comp_contraseya[i])
                        {
                            iguales = false;
                        }
                    }

                    if (iguales == true)
                    {
                        contrasenya_actual = contraseya;
                        Console.WriteLine("REGISTRO EXISTOSO !!");
                    }
                    else
                    {
                        Console.WriteLine("LAS CONTRASEÑAS NO COINCIDEN !!");
                    }
                    Console.WriteLine("________________________");

                    break;

                case 2:
                    Console.WriteLine("________________________");
                    Console.WriteLine("Entrar: ");

                    char[] contrasenya1 = new char[n];
                    Console.Write("Introduce contraseña: ");
                    contrasenya1 = Console.ReadLine().ToCharArray();

                    bool iguales1 = true;

                    if (contrasenya_actual.Length == contrasenya1.Length)
                    {
                        for (int i = 0; i < contrasenya_actual.Length; i++)
                        {
                            if (contrasenya1[i] != contrasenya_actual[i])
                            {
                                iguales1 = false;
                            }
                        }

                        if (iguales1 == true)
                        {
                            Console.WriteLine("La contraseña es correcta !!");
                        }
                        else
                        {
                            Console.WriteLine("La contraseña es incorrecta !!");
                        }

                    }
                    else
                    {
                        Console.WriteLine("La contraseña es incorrecta !!");
                    }


                    Console.WriteLine("________________________");

                    break;

                case 3:
                    Console.WriteLine("Ha finalizado el PROGRAMA !!");
                    break;

                default:
                    Console.WriteLine("Selecciona una opción válida");
                    break;
            }

        }

    }

    //EJERCICIO ARRAYS 10 

     static void Main()
    {

        int alumnos = 25;

        int[] calificaciones = new int[alumnos];
        int[] frecuencias = new int[alumnos];
        int pos = 0;

        int nota = 5;

        while (nota > 0 && nota <= 10)
        {
            Console.WriteLine("Introduce una nota: ");
            nota = int.Parse(Console.ReadLine());
            if (nota > 0 && nota <= 10)
            {
                calificaciones[pos] = nota;
                pos++;
            }
        }

        Console.WriteLine("****** NOTAS ******");
        for (int i = 0; i < calificaciones.Length; i++)
        {
            if (calificaciones[i] > 0)
            {
                Console.WriteLine(calificaciones[i]);
            }
        }

        Console.WriteLine("****** FRECUENCIAS NOTAS ******");
        for (int i = 0; i < calificaciones.Length; i++)
        {
            int num = calificaciones[i];
            int contador = 0;

            for (int j = 0; j < calificaciones.Length; j++)
            {
                if (num == calificaciones[j])
                {
                    contador++;
                }
                frecuencias[i] = contador;
            }
        }

        for (int i = 0; i < frecuencias.Length; i++)
        {
            if (frecuencias[i] > 0 && calificaciones[i] > 0)
            {
                Console.WriteLine(calificaciones[i] + " **** " + frecuencias[i]);
            }
        }


    }

	// EJERCICIO 11 ARRAYS

static void Main()
    {


        int n = 10;
        //int[] numeros = { 3, 2, 1, 4, 5, 6, 7, 8, 9, 4 };

        int[] numeros = new int[n];
        int[] numerosInvertidos = new int[n];
        Random random = new Random();

        Console.WriteLine("Array Inicial: ");
        for (int i = 0; i < numeros.Length; i++)
        {
            numeros[i] = random.Next(1, 11);
            Console.Write(numeros[i] + " ");
        }

        int ultimoNumero = numeros[numeros.Length - 1];
        numerosInvertidos[0] = ultimoNumero;

        for (int i = 1; i < numeros.Length; i++)
        {
            numerosInvertidos[i] = numeros[i - 1];
        }

        Console.WriteLine("\nArray Desplazado: ");
        for (int i = 0; i < numerosInvertidos.Length; i++)
        {
            Console.Write(numerosInvertidos[i] + " ");
        }


    }

    //EJERCICIO 4 ARRAYS

    static char GenerarCaracterAleatorio(){
                Random random = new Random();
                int numeroAleatorio= random.Next(65,122);
                char caracterAleatorio= (char)numeroAleatorio;
                return(caracterAleatorio);
               }

               static void Main(){
                int n=10;
                char[] array = new char[n];
                for(int i=0; i<n; i++){
                    char caracterAleatorio= GenerarCaracterAleatorio();
                    array[i]=caracterAleatorio;
                    if(char.IsUpper(caracterAleatorio)){
                        array[i]=char.ToLower(caracterAleatorio);
                    }else{
                        array[i] = char.ToUpper(caracterAleatorio);
                    }
                }
                
                Console.WriteLine("Array modificado: ");
                foreach(char caracter in array){
                    Console.Write(caracter+ " ");
                }
                
            }
    EJERCICIO 2 CLASES BASICAS
    // Crea un programa que permita guardar información sobre las características gráficas de un equipo informático. La información relevante es:

// Número de pulgadas (short)
// Controlador gráfico (string)
// Número de colores (short)
// Pixeles eje x (int)
// Pixeles eje y (int)
// Debe ser posible cambiar el número de colores, la resolución de la pantalla y el controlador en cualquier momento, así como consultar toda la información concerniente a las características gráficas. Crea alguna instancia de pantalla y prueba el funcionamiento.

// 📌 Nota: todos los campos serán privados, y deberemos crear solo los métodos y accesores o modificadores necesarios para poder hacer funcional la aplicación.

 class program{
    static void Main(){
        CaracteristicasGraficas pantalla= new CaracteristicasGraficas(22, "NVIDIA", 18909, 1920, 1080);

        Console.WriteLine("Información original:");
        pantalla.MostrarInformacion();

        pantalla.SetnumeroColores(333);
        pantalla.SetcontroladorGrafico("GTX GeForce");
        pantalla.SetresulucionPantalla(2080, 1950);

        Console.WriteLine();
        Console.WriteLine("Información después de modificaciones: ");
        pantalla.MostrarInformacion();
    }


 }
  class CaracteristicasGraficas{
        private short numeroPulgadas;
        private string controladorGrafico;
        private short numeroColores;
        private int pixelesEjeX;
        private int pixelesEjeY;

        public CaracteristicasGraficas(short Pulgadas, string controlador, short Colores, int EjeX, int EjeY){
            numeroPulgadas= Pulgadas;
            controladorGrafico= controlador;
            numeroColores= Colores;
            pixelesEjeX= EjeX;
            pixelesEjeY= EjeY;
        }

        public short GetnumeroPulgadas(){
            return numeroPulgadas;
        }

        public string GetcontroladorGrafico(){
            return controladorGrafico;
        }

        public short GetnumeroColores(){
            return numeroColores;
        }

        public int GetpixelesEjeX(){
            return pixelesEjeX;
        }

        public int GetpixelesEjeY(){
            return pixelesEjeY;
        }

        public void SetnumeroColores(short nuevoColor){
            numeroColores= nuevoColor;

        }

        public void SetresulucionPantalla(int nuevoEjeX, int nuevoEjeY){
            pixelesEjeX= nuevoEjeX;
            pixelesEjeY= nuevoEjeY;
        }

        public void SetcontroladorGrafico(string nuevoContorlador){
            controladorGrafico= nuevoContorlador;
        }

        public void MostrarInformacion(){
            Console.WriteLine("El numero de pulgadas es: "+numeroPulgadas);
            Console.WriteLine("El controlador gráfico es: "+controladorGrafico);
            Console.WriteLine("El número de colores es: "+numeroColores);
            Console.WriteLine("El número de pixeles en el eje y es: "+pixelesEjeY);
            Console.WriteLine("El número de pixeles en el eje x es: "+pixelesEjeX);
        }

        
}
//EJERCICIO 3 CLASES BÁSICAS
// Crea una clase Humano con los campos, como mínimo: nombre, edad, peso, sexo, inteligencia, fuerza, destreza y energía.
// Los métodos MostrarInformación, SetNombre, SetEdad,...y los constructores que creas necesarios.

class Humano{
    private string nombre;
    private int edad;
    private int peso;
    private string sexo;
    private string IQ;
    private string fuerza;
    private string destreza;
    private string energia;

        public Humano(string Nombre, int Edad, int Peso, string Sexo, string Iq, string Fuerza, string Destreza, string Energia){
            this.nombre= Nombre;
            this.edad= Edad;
            this.peso= Peso;
            this.sexo= Sexo;
            this.IQ= Iq;
            this.fuerza= Fuerza;
            this.destreza= Destreza;
            this.energia= Energia;
        }
        public string Getnombre(){
            return nombre;
        }

        public int Getedad(){
            return edad;
        }

        public string Getsexo(){
            return sexo;
        }

        public string GetIQ() {
            return IQ;
        }

        public string Getfuerza(){
            return fuerza;
        }

        public string Getdestreza(){
            return destreza;
        }

        public string Getenergia(){
            return energia;
        }

        public void Setedad(int nuevaEdad){
            edad= nuevaEdad;
        }

        public void Setfuerza(string nuevaFuerza){
            fuerza= nuevaFuerza;
        }

        public void Setenergia( string nuevaEnergia){
            energia= nuevaEnergia;
        }

        public void Setpeso(int nuevoPeso){
            peso= nuevoPeso;
        }
         public void MostrarInformacion(){
            Console.WriteLine("El nombre del humano: "+nombre);
            Console.WriteLine("La edad del humano es: "+edad);
            Console.WriteLine("El peso del humano es: "+peso);
            Console.WriteLine("El sexo del humano es: "+sexo);
            Console.WriteLine("El IQ del humano es: "+IQ);
            Console.WriteLine("La fuerza del humano es: "+fuerza);
            Console.WriteLine("La destreza del humano es: "+destreza);Console.WriteLine("La energia del humano es: "+energia);
        }
}

class program{
    static void Main(){
        Humano persona= new Humano("Néstor", 18, 85, "Hombre", "150 IQ", "88 N", "mucha", "444 Kcal");

        Console.WriteLine("Información original:");
        persona.MostrarInformacion();

        persona.Setedad(19);
        persona.Setfuerza("100 N");
        persona.Setenergia("600 Kcal");
        persona.Setpeso(88);

        Console.WriteLine();
        Console.WriteLine("Información después de modificaciones: ");
        persona.MostrarInformacion();
    }


 }
 EJERCICIO 4 CLASES BÁSICAS

 class program{
    static void Main(){
        Compas compas = new Compas();
Circulo circulo = compas.DibujaCirculo(3.5f);
Rotulador rotulador = Estuche.GetRotulador()
                      [
                          new Random().Next(0, Estuche.numeroRotuladores)
                      ];
rotulador.Rotula(circulo.Perimetro());
Pincel pincel = new Pincel();
pincel.Setcolor(Color.Verde);
pincel.PintaCirculo(circulo.Area());  
    }
}
public enum Color{
    Azul,
    Rojo,
    Negro,
    Amarillo,
    Morado,
    Verde,
    Marrón,
    Rosa,
    Gris,
    Naranja,
    Beige

}
class Circulo{
        private float radio;

        public Circulo(float radio)
{
    this.radio= radio;
}        public float Getradio(){
            return radio;
        }
        public float Area(){
            return (float)(Math.PI* Math.Pow(radio,2));
        }
        public float Perimetro()
    {
        return (float)(2 * Math.PI * radio);
    }
    }

class Rotulador{
    private Color color;

        public Rotulador(Color color){
            this.color= color;
        }

        public Color Getcolor(){
            return color;
        }

        public void Rotula(float Perimetro){
            Console.WriteLine("El perímetro rotulado es de "+Perimetro+ " cm de color "+color);
        }

}

class Compas{
    
    public Circulo DibujaCirculo(float radio){

        Console.WriteLine("Se ha dibujado un círculo de radio "+radio+ " cm");
        return new Circulo(radio);
    }
}
class Pincel{

    private Color color;

    public void Setcolor(Color color){
        this.color= color;
    }
    public Circulo PintaCirculo(float radio){
        Console.WriteLine("Se ha pintado el área de radio "+radio+ " cm y de color "+color);
        return new Circulo(radio);
    }
}

class Estuche{
     
    public const int numeroRotuladores= 10;
     public static Rotulador[] GetRotulador(){

        Random random = new Random();
        Rotulador[] rotuladores = new Rotulador[numeroRotuladores];
        for (int i = 0; i < numeroRotuladores; i++)
        {
            rotuladores[i] = new Rotulador((Color)random.Next(Enum.GetNames(typeof(Color)).Length));
        }
        return rotuladores;

     }
}
 // EJERCICIO 5 CLASES BÁSICAS

 
public enum Muebles{
    Sofás,
    Sillas,
    Mesas
}

public enum Color{
    Marrón, 
    Negro,
    Celeste,
    Blanco,
    Marron,
    Gris,
    Beige,
    Rojo

}

public enum Tela{
    Nylon,
    Seda,
    Políester,
    Acrílico,
    Acetato,
    Yute,
    Algodón
}
public enum Madera{
    Roble,
    Pino,
    Arce,
    Abeto,
    Cedro,
    Haya
}
class Mueble{
    private Muebles mueble;
    private Color color;
    private double peso;
    private string dimensiones;
    private string fabricante;
    private double precio;
    private bool abatible;
    private Tela tela;
    private double longitudRespaldo;
    private  Madera tipoMadera;



    public Mueble(Muebles mueble, Color color, double peso, string dimensiones, string fabricante, double precio){
        this.mueble= mueble;
        this.color= color;
        this.dimensiones= dimensiones;
        this.fabricante= fabricante;
        this.precio= precio;
        this.peso= peso;
    }
     public Mueble(Color color, float peso, string dimensiones, string fabricante, double precio, Tela tela, bool abatible){
        this.tela= tela;
        this.abatible= abatible;
     }
     public Mueble(Color color, double peso, string dimensiones, string fabricante, double precio, double longitudRespaldo){
        this.longitudRespaldo= longitudRespaldo;
     }
      public Mueble(Color color, double peso, string dimensiones, string fabricante, double precio, Madera tipoMadera){
        this.tipoMadera= tipoMadera;
      }

    public Muebles Getmueble(){
        return mueble;
    }

    public Color Getcolor(){
        return color;
    }

    public double Getpeso(){
        return peso;
    }

    public string Getdimensiones(){
        return dimensiones;
    }

    public string Getfabricante(){
        return fabricante;
    }

    public double Getprecio(){
        return precio;
    }

    
    public void SetPeso(double pesoActualizado){
        peso= pesoActualizado;
    }

    public void SetPrecio(double precioActualizado){
        precio= precioActualizado;
    }

    public void SetMueble(Muebles OtroMueble){
        mueble= OtroMueble;
    }

    public void SetColor(Color Otrocolor){
        color = Otrocolor;
    }

       public string ACadena()
    {
        string infoComun = $"Color: {color}, Peso: {peso} kg, Dimensiones: {dimensiones} cm, Fabricante: {fabricante}, Precio: {precio} euros";
        if (mueble == Muebles.Sofás)
            return $"{infoComun}, Tela: {tela}, Abatible: {(abatible ? "Sí" : "No")}";
        else if (mueble == Muebles.Sillas) 
            return $"{infoComun}, Longitud del respaldo: {longitudRespaldo} cm";
        else if (mueble == Muebles.Mesas) 
            return $"{infoComun}, Tipo de madera: {tipoMadera}";
        else
            return infoComun;
    }


}          

//EJERCICIO 6 CLASES BASICAS

public enum Categoria{
    Subalterno = 10,
    Administrativo = 20,
    JefeDepartamento = 40,
    Gerente= 60,
}
class Empleado{
    private readonly string dni;
    private readonly string nombre;
    private readonly int añoNacimiento;
    private Categoria categoria;
    private double salario;

        public Empleado(in string dni, in string nombre, in int nacimiento, in Categoria e, in double salario){
            this.dni= dni;
            this.nombre= nombre;
            this.añoNacimiento= nacimiento;
            this.categoria= e;
            this.salario= salario;
        }

        public string GetNombre(){
            return nombre;
        }

        public int GetAñoNacimiento(){
            return añoNacimiento;
        }

        public string GetDni(){
            return dni;
        }

        public void SetCategoria(in Categoria categoria){
             this.categoria= categoria;
        }

        public double GetSalario(){
            double salarioBase= 1200;
            double salario=0;
            if (categoria == Categoria.Subalterno){
                salario= salarioBase * 1.1;
            }
            if (categoria == Categoria.Administrativo){
                salario = salarioBase * 1.2;
            }
            if (categoria == Categoria.JefeDepartamento){
                salario = salarioBase * 1.4;
            }
            if (categoria == Categoria.Gerente){
                salario = salarioBase * 1.6;
            }
            
            return salario; 
        }
        public string Acadena(){
            
            return $"El empleado: {nombre} con dni: {dni} tiene un salario de: {salario} y su categoria es: {categoria}";
        }
}

class Empresa{
    private readonly string CIF;
    private readonly string razonSocial;
    private string direccion;
    private Empleado gerente;


        public Empresa(in string CIF, in string razonSocial, in string direccion, in string dni, in string nombre, in int añoNacimiento){
            this.CIF= CIF;
            this.razonSocial= razonSocial;
            this.direccion= direccion;
            this.gerente = new Empleado(dni, nombre, añoNacimiento, Categoria.Gerente );
        }

         public Empresa(Empresa e)
    {
        this.CIF = e.GetCif();
        this.razonSocial = e.GetRazonSocial();
        this.direccion = e.GetDireccion();
        this.gerente = new Empleado(e.gerente);
    }

        public string NombreGerente(){
            return gerente.GetNombre();
        }
        public string GetRazonSocial(){
            return razonSocial;
        }

        public string GetDirecion(){
            return direccion;
        }

        public string GetCif(){
            return CIF;
        }

        public Empleado[] GetEmpleados(){
            return new Empleado[]{gerente};
        }
        public void GetGerente(string dni, string nombre, int añoNacimiento){
            gerente = new Empleado(dni, nombre, añoNacimiento, Categoria.Gerente);
        }
        
        public void SetDireccion(in string direccion){
            this.direccion= direccion;
        }

        public void Contrata(in string dni, in int añoNacimiento, in string nombre, in string categoria ){
            Empleado nuevoEmpleado= new Empleado(dni, nombre, añoNacimiento, Categoria.Gerente, Categoria.Subalterno, Categoria.JefeDepartamento, Categoria.Administrativo);
        }

        public string DatosEmpresa(){
            return $"{CIF},{razonSocial},{direccion}";
        }


}

EJERCICIO 7
public enum Palo{
    Oros,
    Copas,
    Bastos,
    Espada

}
class Naipes{
    private int valor;
    private Palo palo;

        public Naipes(int valor, Palo palo){
            this.valor= valor;
            this.palo= palo;
        }

        public Palo GetPalo(){
            return palo;
        }

        public int GetValor(){
            return valor;
        }

        public Naipes [,] DevolverBaraja(){
            Naipes[,] baraja= new Naipes[4,12];
            for (int i= 0; i<4; i++) {
                for(int j=1; j<=12; j++ ){
                    baraja[i,j]= new Naipes(j, (Palo)i);
                }
            }
            return baraja;
        }

        public void MezclarBaraja(Naipes[,] baraja){
            Random random = new Random();
            for(int i= 0; i<4; i++){
                for(int j= 0; j<12; j++){
                    Palo randomPalo = (Palo)random.Next(0, 4);
                    int randomValor = random.Next(1, 13); 
                    Naipes cartaActual= baraja[i,j];
                    baraja[i,j] = baraja[randomPalo, randomValor];
                    baraja[randomPalo, randomValor]= cartaActual;
                }
            }

        }

        public void MostrarBaraja(Naipes[,] baraja){
            for( int i= 0; i<4; i++){
                for (int j=0; j<12; j++){
                    Console.WriteLine($"Naipe: {baraja[i, j].GetValor()} de {baraja[i, j].GetPalo()}");
                }
            }
        }

        class program{
            static void Main(){
            Naipes naipe= new Naipes(0, Palo.Oros);
            Naipes[,] baraja = naipe.DevolverBaraja();
            naipe.MezclarBaraja(baraja);
            naipe.MostrarBaraja(baraja);
            }
        }




}
 EJERCICIO 2 HERENCIA 

 class Local{
     public struct Dimensiones
        {
            public readonly float Alto;
            public readonly float Ancho;
            public readonly float Profundidad;

            public Dimensiones(float alto, float ancho, float profundidad)
            {
                Alto = alto;
                Ancho = ancho;
                Profundidad = profundidad;
            }
        }

    private string ciudad;
    private string calle;
    private int numeroPlantas;
    private Dimensiones dimensiones;

    public Local(string ciudad, string calle, int numeroPlantas, Dimensiones dimensiones){
        this.ciudad= ciudad;
        this.calle= calle;
        this.numeroPlantas= numeroPlantas;
        this.dimensiones= dimensiones;
    }
        public string GetCiudad(){
            return ciudad;
        }

        public string GetCalle(){
            return calle;
        }

        public int GetNumeroPlantas(){
            return numeroPlantas;
        }

        public void SetCiudad(string ciudad){
            this.ciudad= ciudad;
        }

        public void SetCalle(string calle){
            this.calle= calle;
        }

        public void SetNumeroPlantas(int numeroPlantas){
            this.numeroPlantas= numeroPlantas;
        }

        public float GetAlto(){
            return dimensiones.Alto;
        }

        public float GetAncho(){
            return dimensiones.Ancho;
        }

        public float GetProfundidad(){
            return dimensiones.Profundidad;
        }

        public void SetDimensiones(Dimensiones dimensiones){
            this.dimensiones= dimensiones;
        }

        public string ACadena(){
            string cadena= $"El local pertenece a la ciudad de {ciudad}, está ubicado en la calle {calle}, tiene {numeroPlantas} plantas y sus dimensiones son de: {this.dimensiones.Alto} x {this.dimensiones.Ancho} x {this.dimensiones.Profundidad} ";
            return cadena;
        }
}
// Con los campos razón social y número licencia.
// Con la operación ACadena que devolverá un string con los datos de un local comercial.
class LocalComercial : Local{
    private string razonSocial;
    private int numeroLicencia;
        
        public LocalComercial(string razonSocial, int numeroLicencia){
            this.razonSocial= razonSocial;
            this.numeroLicencia= numeroLicencia;
        }

        public string GetRazonSocial(){
            return razonSocial;
        }

        public int GetNumeroLicencia(){
            return numeroLicencia;
        }

        public void SetRazonSocial(string razonSocial){
            this.razonSocial= razonSocial;
        }

        public void SetNumeroLicencia(int numeroLicencia){
            this.numeroLicencia= numeroLicencia;
        }
        
        public string ACadena(){
            string cadena= $"La razón social del local comercial es: {razonSocial} y el numero de licencia es: {numeroLicencia}";
            return cadena;
        }

}

class Cine : LocalComercial{
    
}

//EJERCICIO 5 HERENCIA

class Persona
    {
        private string nombre;
        private int edad;
        private string nif;
        private string apellidos;

        public Persona(string nombre, int edad, string nif, string apellidos)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.nif = nif;
            this.apellidos= apellidos;
        }

        public virtual string GetNombre()
        {
            return nombre;
        }

          public virtual string GetApellidos()
        {
            return apellidos;
        }
        public virtual int GetEdad(){
            return edad;
        }

        public virtual string GetNIF(){
            return nif;
        }

        public void SetEdad(int edad){
            this.edad= edad;
        }

        public virtual string ACadena(){
            string cadena= $"El nombre de la persona es de {nombre} {apellidos}, cuya edad es de {edad} años, su NIF es: {nif} ";
            return cadena;
        }
    }

abstract class Legislador: Persona{
    private string provinciaQueRepresenta;
    private string ciudadProcedencia;
    private string partidoPolítico;

    public Legislador(string nombre, int edad, string nif, string apellidos, string provinciaQueRepresenta, string ciudadProcedencia, string partidoPolítico):base(nombre, edad, apellidos, nif){
        this.provinciaQueRepresenta= provinciaQueRepresenta;
        this.ciudadProcedencia= ciudadProcedencia;
        this.partidoPolítico= partidoPolítico;
    }

    public virtual string GetProvincia(){
        return provinciaQueRepresenta;
    }

    public string GetCiudad(){
        return ciudadProcedencia;
    }

    public string GetPartido(){
        return partidoPolítico;
    }

    public void SetProvincia(string provinciaQueRepresenta){
        this.provinciaQueRepresenta = provinciaQueRepresenta;
    }

    public override string ACadena()
    {
        string cadena= base.ACadena();
        cadena+= $"\nEste legislador procede de {ciudadProcedencia} y representa a la provincia de {provinciaQueRepresenta}, pertenciendo al siguiente partido político: {partidoPolítico}.";
        return cadena;
    }
}
public struct CamaraEnQueTrabaja{
            public readonly string senado;
            public readonly string congreso;
    
        public CamaraEnQueTrabaja(string Senado, string Congreso){
            senado= Senado;
            congreso= Congreso;
        }
         
}
class Senador : Legislador{
        

        private CamaraEnQueTrabaja camara;
    public Senador(string nombre, int edad, string nif, string apellidos, string provinciaQueRepresenta, string ciudadProcedencia, string partidoPolítico, CamaraEnQueTrabaja camara) : base(nombre, edad, nif, apellidos, provinciaQueRepresenta, ciudadProcedencia, partidoPolítico){
        this.camara = camara;
    }

        public string GetCamaraEnQueTrabaja(){
            return camara.senado;
        }

    public override string ACadena()
    {
       string cadena = base.ACadena();
       cadena += $"\nSu rol es de senador y se encuentra en el {camara.senado}.";
       return cadena;
    }
}

class Diputado : Legislador{
        private CamaraEnQueTrabaja camara;

    public Diputado(string nombre, int edad, string nif, string apellidos, string provinciaQueRepresenta, string ciudadProcedencia, string partidoPolítico, CamaraEnQueTrabaja camara) : base(nombre, edad, nif, apellidos, provinciaQueRepresenta, ciudadProcedencia, partidoPolítico){
        this.camara = camara;
    }


    public string GetCamaraEnQueTrabaja(){
            return camara.senado;
        }

    public override string ACadena()
    {
        string cadena= base.ACadena();
        cadena += $"\nSu rol es de diputado y se encuentra en el {camara.congreso}.";
        return cadena;
    }

}

class program{
    static void Main(){
        Legislador[] legisladores = new Legislador[3];
        legisladores[0]= new Diputado("Carles", 43, "Puigdemont", "5050672E","Barcelona", "Gerona", "JuntsXCat", new CamaraEnQueTrabaja("Senado", "Congreso de los diputados"));
        legisladores [1]= new Senador("Jose", 58, "Lopez Riera", "43887743P", "Valladolid", "Móstoles", "VOX", new CamaraEnQueTrabaja("Senado", "Congreso de los diputados"));
        legisladores[2]= new Diputado("Pedro", 48, "Sánchez", "35892117K","Madrid", "Madrid", "PSOE", new CamaraEnQueTrabaja("Senado", "Congreso de los Diputados") );

        foreach(Legislador legislador in legisladores){
            Console.WriteLine(legislador.ACadena());
        }
    }
}
EJERCICIO 1 FICHEROS

class program{
    static void MuestraSalidaMetodosPathPath(){
        char a = Path.VolumeSeparatorChar;
        char b = Path.DirectorySeparatorChar;
        string archivo = $"C{a}{b}Nueva Carpeta{b}archivo.txt";
        Console.WriteLine(Path.GetExtension(archivo)); //extension.txt
        Console.WriteLine(Path.GetFileName(archivo)); //Devuelve el nombre de archivo y la extensión
        Console.WriteLine(Path.GetFileNameWithoutExtension(archivo)); //devuelve el nombre del archivo sin la extension
        Console.WriteLine(Path.GetDirectoryName(archivo));// devuelve el directorio el que esta el archivo
        Console.WriteLine(Path.GetPathRoot(archivo));
        //devuelve el directorio raiz de la ruta de acceso
        Console.WriteLine(Path.ChangeExtension(archivo, "cs")); //cambia la extension del archivo
        Console.WriteLine(Path.GetFullPath(archivo));
        //muestra la ruta al completo
        Console.WriteLine(Path.Combine($"C{a}{b}Nueva Carpeta{b}", "holaMundo.java")); //combina dos rutas de acceso;
    }

    static void Main(){
        MuestraSalidaMetodosPathPath();
    }
}


//// ejercicio 2 FICHEROS
///class program{
    static void CreaArbolDeDirectorios(){
        char a = Path.PathSeparator;
        char b = Path.DirectorySeparatorChar;
        string ruta1= $"C{a}{b}nombres";
        if(File.Exists($"C{a}{b}nombres{b}pepe{b}datos{b}documento.txt")){
            Console.WriteLine("Ya se ha creado el arbol de ruta");
        }
        else{
        Directory.CreateDirectory(ruta1);
        Directory.CreateDirectory(Path.Combine($"{ruta1}", $"juan"));
        ruta1= Path.Combine(ruta1, "pepe");
        Directory.CreateDirectory(ruta1);
        ruta1= Path.Combine(ruta1, "datos");
        Directory.CreateDirectory(ruta1);
        ruta1= Path.Combine(ruta1, "documento.txt");
        File.Create(ruta1).Close();
        }
    }

    static void EliminarFichero(string ruta1){
        Console.WriteLine("Introduce la ruta de uno de los directorios a elimimar");
        ruta1 = Console.ReadLine();
        if(File.Exists(ruta1) == true){
            File.Delete(ruta1);
            Console.WriteLine($"Se el archivo del directorio {Path.GetFileName(ruta1)} de forma satisfactoria");
        }else{
            Console.Write("El archivo no existe");
        }
    }

    static void EliminarDirectorio(string ruta1){
        Console.WriteLine("Introduce la ruta de uno de los archivos a elimimar");
        ruta1 = Console.ReadLine();
        if(Directory.Exists(ruta1) == true){
            Directory.Delete(ruta1);
            Console.WriteLine($"Se elimina el directorio {ruta1} de forma satisfactoria");
        }else{
            Console.WriteLine("El directorio no existe");
        }

    }
    static void ImprimirInformacionDirectorio(DirectoryInfo infoDirectorio)
    {

        Console.WriteLine($"Nombre: {infoDirectorio.Name}");
        Console.WriteLine($"Ruta completa: {infoDirectorio.FullName}");
        Console.WriteLine($"Fecha de creación: {infoDirectorio.CreationTime}");
        Console.WriteLine($"Último acceso: {infoDirectorio.LastAccessTime}");
        Console.WriteLine($"Última modificación: {infoDirectorio.LastWriteTime}");

        // Calcula el tamaño total en bytes de todos los archivos dentro del directorio
        long tamañoTotal = infoDirectorio.EnumerateFiles().Sum(file => file.Length);
        Console.WriteLine($"Tamaño: {tamañoTotal} bytes");
    }



    static void MusestraInformacion(string ruta1){
         Console.WriteLine("Introduce la ruta de uno de los directorios a mostrar informacion");
        ruta1 = Console.ReadLine();
        if(Directory.Exists(ruta1) == true){
            DirectoryInfo infoDirectorio = new DirectoryInfo(ruta1);
            Console.WriteLine("Información del directorio: ");
            ImprimirInformacionDirectorio(infoDirectorio);
        }else{
            Console.WriteLine("El directorio no existe");
        }
    }

    static void MuestraAtributosFichero(string ruta1){
        Console.WriteLine("Introduce la ruta de uno de los directorios a mostrar informacion de los atributos");
        ruta1 = Console.ReadLine();
        if(File.Exists(ruta1) == true){
            FileInfo infoFichero = new FileInfo(ruta1);
            if(infoFichero.IsReadOnly){
                Console.WriteLine("El atributo del archivo es de solo lectura");
            }else{
                Console.WriteLine("Los atributos del fichero no son de solo lectura ");
            }
        }else{
            Console.WriteLine("El fichero no existe");
        }
    }

    static void Menu(){
        Console.WriteLine("////////////////MENÚ/////////////////////");
        Console.WriteLine("1. Crea el árbol de directorios");
        Console.WriteLine("2. Elimina el directorio");
        Console.WriteLine("3. Elimina un fichero");
        Console.WriteLine("4. Muestra informacion de todos los miembros del directorio");
        Console.WriteLine("5. Muestra atributos del fichero");
        Console.WriteLine("6. Salir");

        Console.WriteLine("Elige una opción:");

        bool salir= false;
        string ruta1= "";

        do{

         ConsoleKeyInfo tecla = Console.ReadKey(true);

         switch(tecla.Key){
            case ConsoleKey.D1:
            case ConsoleKey.NumPad1:
                Console.WriteLine("Elegiste la opción 1 ");
                CreaArbolDeDirectorios();
                break;
            case ConsoleKey.D2:
            case ConsoleKey.NumPad2:
                Console.WriteLine("Elegiste la opción 2 ");
                EliminarDirectorio(ruta1);
                break;
            case ConsoleKey.D3:
            case ConsoleKey.NumPad3:
                Console.WriteLine("Elegiste la opción 3 ");
                EliminarFichero(ruta1);
                break;
            case ConsoleKey.D4:
            case ConsoleKey.NumPad4:
                Console.WriteLine("Elegiste la opción 4 ");
                MusestraInformacion(ruta1);
                break;
            case ConsoleKey.D5:
            case ConsoleKey.NumPad5:
                Console.WriteLine("Elegiste la opción 5 ");
                MuestraAtributosFichero(ruta1);
                break;
            case ConsoleKey.Escape:
                Console.WriteLine("Elegiste salir del programa");
                break;
            default:
                Console.WriteLine("Introduce una opción válida");
            break;
            }

         }while(!salir);
    }

    static void Main(){
        Menu();
    }
}




*/




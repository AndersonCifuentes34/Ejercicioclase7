void buscaMayor()
{
    int mayor = 0;
    int menor = 100;
    int numero = 0;
    Random numerito = new Random();

    for (int i = 0; i < 5; i++)
    {
        numero = numerito.Next(100);
        Console.WriteLine(numero);
        if (numero > mayor)
        {
            mayor = numero;
        }
        if (numero < menor)
        {
            menor = numero;
        }
    }

    Console.WriteLine("El número mayor es: " + mayor);
    Console.WriteLine("El número menor es: " + menor);
}

void arreglos()
{
    int[] notas = new int[15];
    Random rnd = new Random();
    Console.WriteLine("Cargando Información");
    for (int i = 0; i < notas.Length; i++)
    {
        notas[i] = rnd.Next(100);
    }

    Console.WriteLine("Desplegando Información: ");
    int mayor = 0;
    int promedio = 0;
    for (int i = 0; i < notas.Length; i++)
    {
        Console.WriteLine(notas[i]);
        if (notas[i] > mayor)
        {
            mayor = notas[i];
        }
        promedio += notas[i];
    }
    promedio /= notas.Length;
    Console.WriteLine("Nota mayor=" + mayor);
    Console.WriteLine("Promedio=" + promedio);
}
void nombres()
{
    string[] nombre = new string[11];
    nombre[0] = "Jairo";
    nombre[1] = "Brandom";
    nombre[2] = "Hector";
    nombre[3] = "Yeimi";
    nombre[4] = "Fatima";
    nombre[5] = "Carlos";
    nombre[6] = "Joaquim";
    nombre[7] = "Jose";
    nombre[8] = "Renato";
    nombre[9] = "Victor";
    nombre[10] = "Alex";

    Random rnd = new Random();

    int primerLugarIndex = rnd.Next(0, nombre.Length);

    int segundoLugarIndex;
    do
    {
        segundoLugarIndex = rnd.Next(0, nombre.Length);
    } while (segundoLugarIndex == primerLugarIndex);

    string primerLugar = nombre[primerLugarIndex];
    string segundoLugar = nombre[segundoLugarIndex];

    Console.WriteLine("El ganador del primer lugar es: " + primerLugar + " y se ha ganado una pijama de cerdo.");
    Console.WriteLine("El ganador del segundo lugar es: " + segundoLugar + " y se ha ganado una pierna de cerdo.");
}

nombres();
//buscaMayor();
//arreglos();
//Adivina();

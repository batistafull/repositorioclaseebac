using UnityEngine;

public class EjerciciosCiclosArreglos : MonoBehaviour
{
    // Ejercicio 1
    public int[] arreglo1;
    public int[] arreglo2;
    public int[] arregloSuma;

    // Ejercicio 2
    public string[] palabras = { "Me", "Gusta", "Aprender", "a", "programar", "en", "Unity" };

    // Ejercicio 3
    int[,] matriz =
    {
        { 1, 2, 3 },
        { 4, 5, 6 } 
    };
    public int[] vector = { 7, 8, 9 };
    public int[] resultadoMatrizVector;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // ejercicio 1
        arreglo1 = new int[10];
        arreglo2 = new int[10];
        arregloSuma = new int[10];

        for (int i = 0; i < 10; i++)
        {
            arreglo1[i] = Random.Range(0, 101);
            arreglo2[i] = Random.Range(0, 101);
        }

        for (int i = 0; i < 10; i++)
        {
            arregloSuma[i] = arreglo1[i] + arreglo2[i];
            Debug.Log("arregloSuma[" + i + "] = " + arreglo1[i] + " + " + arreglo2[i] + " = " + arregloSuma[i]);
        }

        // ejercicio 2
        string oracionCompleta = "";
        foreach (string palabra in palabras)
        {
             if (oracionCompleta != "")
            {
                oracionCompleta += " ";
            }
            oracionCompleta += palabra;
        }
        Debug.Log("Oración completa: " + oracionCompleta);

        // ejercicio 3
        int renglones = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);

        if (vector.Length != columnas)
        {
            Debug.LogError("El vector debe tener " + columnas + " elementos y tiene " + vector.Length);
            return;
        }

         resultadoMatrizVector = new int[renglones];
        for (int i = 0; i < renglones; i++)
        {
            int suma = 0;
            string operacion = "";
            for (int j = 0; j < columnas; j++)
            {
                suma += matriz[i, j] * vector[j];

                if (operacion != "")
                {
                    operacion += " + ";
                }
                operacion += matriz[i, j] + "*" + vector[j];
            }
            resultadoMatrizVector[i] = suma;
            Debug.Log("resultado[" + i + "] = " + operacion + " = " + suma);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}

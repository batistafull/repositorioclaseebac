using System.Collections.Generic;
using UnityEngine;

public class EjerciciosEstructuras : MonoBehaviour
{
    // Ejercicio 1
    public List<int> listaAleatoria;

    // Ejercicio 2
    public int[] arregloOriginal = { 15, 3, 42, 8, 27, 1, 33 };
    public int[] arregloOrdenado;

    // Ejercicio 3
    public List<string> frutasRepetidas = new List<string> { "manzana", "pera", "manzana", "uva", "pera", "mango", "uva", "manzana" };

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Ejercicio 1
        listaAleatoria = MisNumeros(10, 1, 50);
        Debug.Log("Lista de " + listaAleatoria.Count + " números aleatorios: " + string.Join(", ", listaAleatoria));

        // Ejercicio 2
        arregloOrdenado = OrdenarDescendente(arregloOriginal);
        Debug.Log("Original: " + string.Join(", ", arregloOriginal) + " -> Descendente: " + string.Join(", ", arregloOrdenado));

        // Ejercicio 3
        HashSet<string> frutasSinRepetir = QuitarRepetidos(frutasRepetidas);
        Debug.Log("Con repetidos (" + frutasRepetidas.Count + "): " + string.Join(", ", frutasRepetidas));
        Debug.Log("Sin repetidos (" + frutasSinRepetir.Count + "): " + string.Join(", ", frutasSinRepetir));

        // Ejercicio 4
        Stack<string> pilaDeLibros = new Stack<string>();
        pilaDeLibros.Push("Harry Potter");
        pilaDeLibros.Push("El Señor de los Anillos");
        pilaDeLibros.Push("Cien Años de Soledad");
        pilaDeLibros.Push("El Principito");
        ImprimirPilaYCola(pilaDeLibros);
    }

    // Ejercicio 1
    public List<int> MisNumeros(int tamano, int rangoInferior, int RangoSuperior)
    {
        List<int> numeros = new List<int>();

        for (int i = 0; i < tamano; i++)
        {
            numeros.Add(Random.Range(rangoInferior, RangoSuperior));
        }

        return numeros;
    }

    // Ejercicio 2
    public int[] OrdenarDescendente(int[] numeros)
    {
        int[] ordenados = (int[])numeros.Clone();

        for (int i = 0; i < ordenados.Length - 1; i++)
        {
            for (int j = 0; j < ordenados.Length - 1 - i; j++)
            {
                if (ordenados[j] < ordenados[j + 1])
                {
                    int temporal = ordenados[j];
                    ordenados[j] = ordenados[j + 1];
                    ordenados[j + 1] = temporal;
                }
            }
        }

        return ordenados;
    }

    // Ejercicio 3
    public HashSet<string> QuitarRepetidos(List<string> lista)
    {
        HashSet<string> sinRepetidos = new HashSet<string>();

        foreach (string elemento in lista)
        {
            if (!sinRepetidos.Contains(elemento))
            {
                sinRepetidos.Add(elemento);
            }
        }

        return sinRepetidos;
    }

    // Ejercicio 4
    public void ImprimirPilaYCola(Stack<string> pila)
    {
        Queue<string> cola = new Queue<string>();

        // Se va guardando el texto DENTRO del ciclo, porque al terminar la pila ya está vacía
        string contenidoPila = "";
        while (pila.Count > 0)
        {
            if (contenidoPila != "")
            {
                contenidoPila += ", ";
            }
            contenidoPila += pila.Peek();
            cola.Enqueue(pila.Peek());
            pila.Pop();
        }
        Debug.Log("--- Contenido de la pila --- \n" + contenidoPila);

        string contenidoCola = "";
        while (cola.Count > 0)
        {
            if (contenidoCola != "")
            {
                contenidoCola += ", ";
            }
            contenidoCola += cola.Peek();
            cola.Dequeue();
        }
        Debug.Log("--- Contenido de la cola --- \n" + contenidoCola);
    }
}

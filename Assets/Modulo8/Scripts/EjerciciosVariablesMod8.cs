using System.Collections.Generic;
using UnityEngine;

public class EjerciciosVariablesMod8 : MonoBehaviour
{
    // Parte 1, Ejercicio 1
    public int numeroIncrementoUpdate = 0;
    public float decimalIncrementoFixedUpdate = 1.01f;

    // Parte 1, Ejercicio 2
    public float primerDecimal = 7.8f;
    public float segundoDecimal = 2.5f;
    public int resultadoEntero;

    // Parte 1, Ejercicio 3
    public int numeroParImpar = 0;
    public int resultadoParImpar;

    // Parte 1, Ejercicio 4
    public string inicialColor = "white";

    // Parte 1, Ejercicio 5
    public float numeroDecimal = 3.14159265f;
    public string numeroComoTexto;

    // Parte 1, Ejercicio 6
    public string nombreCompleto = "Alberto Batista Alberto";
    public List<string> nombreEnLista = new List<string>();

    // Parte 2, Ejercicio 1
    public string primerNumeroMilesTexto = "2500";
    public string segundoNumeroMilesTexto = "1750";

    // Parte 2, Ejercicio 2
    public string oracion = "Hola Mundo";

    // Parte 2, Ejercicio 3
    public string oracionEnString = "Me gusta programar en Unity";

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // parte 1, ejercicio 2
        resultadoEntero = (int)(primerDecimal * segundoDecimal);
        Debug.Log(primerDecimal + " * " + segundoDecimal + " = " + (primerDecimal * segundoDecimal) + " casteado a int: " + resultadoEntero);

        // parte 1, ejercicio 5
        numeroComoTexto = numeroDecimal.ToString("F4");
        Debug.Log("El número " + numeroDecimal + " con 4 decimales es: " + numeroComoTexto);

        // parte 1, ejercicio 6
        Debug.Log("El primer nombre es: " + nombreCompleto.Substring(0, nombreCompleto.IndexOf(" ")));
        Debug.Log("El primer apellido es: " + nombreCompleto.Substring(nombreCompleto.IndexOf(" ") + 1, nombreCompleto.LastIndexOf(" ") - nombreCompleto.IndexOf(" ") - 1));
        Debug.Log("El segundo apellido es: " + nombreCompleto.Substring(nombreCompleto.LastIndexOf(" ") + 1));
        nombreEnLista = new List<string>(nombreCompleto.Split(' '));
        Debug.Log("Nombre en lista: " + nombreEnLista[0] + ", Primer apellido en lista: " + nombreEnLista[1] + ", Segundo apellido en lista: " + nombreEnLista[2]);

        // parte 2, ejercicio 1
        if (int.TryParse(primerNumeroMilesTexto, out int primerNumero) && int.TryParse(segundoNumeroMilesTexto, out int segundoNumero))
        {
            int suma = primerNumero + segundoNumero;
            Debug.Log(primerNumero + " + " + segundoNumero + " = " + suma);
        }
        else
        {
            Debug.LogError("Error al convertir los números de texto a enteros.");
        }

        // parte 2, ejercicio 2
        string caracteresPares = "";
        for (int i = 0; i < oracion.Length; i++)
        {
            if (i % 2 == 0)
            {
                if (caracteresPares != "")
                {
                    caracteresPares += ",";
                }
                caracteresPares += oracion[i];
            }
        }
        Debug.Log("Caracteres en índice par de \"" + oracion + "\": " + caracteresPares);

        // parte 2, ejercicio 3
        string oracionRecortada = oracionEnString.Substring(5);
        Debug.Log("Original: \"" + oracionEnString + "\", Sin los primeros 5 caracteres: \"" + oracionRecortada + "\"");

    }

    // Update is called once per frame
    void Update()
    {
        // parte 1, ejercicio 1
        numeroIncrementoUpdate++;
        Debug.Log("El valor de numeroIncrementoUpdate es: " + numeroIncrementoUpdate);

        // parte 1, ejercicio 4
        CambiarColorPorPalabra();
    }

    void FixedUpdate()
    {
        // parte 1, ejercicio 1
        decimalIncrementoFixedUpdate *= 1.01f;
        Debug.Log("El valor de decimalIncrementoFixedUpdate es: " + decimalIncrementoFixedUpdate);

        // parte 1, ejercicio 3
        numeroParImpar++;
        resultadoParImpar = numeroParImpar % 2;

        if (resultadoParImpar == 0)
        {
           GetComponent<MeshRenderer>().material.color = Color.green;
        }
        else
        {
            GetComponent<MeshRenderer>().material.color = Color.red;
        }
    }

    // parte 1, ejercicio 4
    void CambiarColorPorPalabra()
    {
        Color nuevoColor;

        switch (inicialColor)
        {
            case "red":
                nuevoColor = Color.red;
                break;
            case "green":
                nuevoColor = Color.green;
                break;
            case "blue":
                nuevoColor = Color.blue;
                break;
            case "yellow":
                nuevoColor = Color.yellow;
                break;
            case "black":
                nuevoColor = Color.black;
                break;
            case "white":
                nuevoColor = Color.white;
                break;
            default:
                nuevoColor = Color.magenta;
                break;
        }

        GetComponent<MeshRenderer>().material.color = nuevoColor;
    }
}

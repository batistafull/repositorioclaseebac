using UnityEngine;

public class ComponenteModulo7 : MonoBehaviour
{
    public bool valor = false;
    public float intervalo = 0.5f;
    private float tiempo = 0f;

    void Awake()
    {
        GetComponent<MeshRenderer>().material.color = valor ? Color.white : Color.black;
    }

    void FixedUpdate()
    {
        tiempo += Time.fixedDeltaTime;

        if (tiempo < intervalo)
        {
            return;
        }

        tiempo = 0f;

        if (valor == false)
        {
            valor = true;
            GetComponent<MeshRenderer>().material.color = Color.white;
        }
        else
        {
            valor = false;
            GetComponent<MeshRenderer>().material.color = Color.black;
        }
    }
}

using UnityEngine;

// Evalua despues de que los cubos AND y OR cambien sus valores.
[DefaultExecutionOrder(200)]
public class ComponenteFinalModulo7 : MonoBehaviour
{
    public ComponenteANDModulo7 cubo3;
    public ComponenteORModulo7 cubo4;
    public bool valor = false;

    void FixedUpdate()
    {
        if (cubo3 == null || cubo4 == null)
        {
            return;
        }

        valor = cubo3.valor && cubo4.valor;

        if (valor == true)
        {
            GetComponent<MeshRenderer>().material.color = Color.white;
        }
        else
        {
            GetComponent<MeshRenderer>().material.color = Color.black;
        }
    }
}

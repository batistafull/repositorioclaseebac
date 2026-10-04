using UnityEngine;

// Evalua despues de que los dos primeros cubos cambien sus valores.
[DefaultExecutionOrder(100)]
public class ComponenteANDModulo7 : MonoBehaviour
{
    public ComponenteModulo7 cubo1;
    public ComponenteModulo7 cubo2;
    public bool valor = false;

    void FixedUpdate()
    {
        if (cubo1 == null || cubo2 == null)
        {
            return;
        }

        valor = cubo1.valor && cubo2.valor;

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

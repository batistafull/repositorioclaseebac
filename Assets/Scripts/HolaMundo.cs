using UnityEngine;

public class HolaMundo : MonoBehaviour
{
    public int x;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        x = 0;
        print("Algo Paso");

        Debug.LogWarning("Algo Salio medianamente mal");
        Debug.LogError("Algo Salio muy mal");
    }

    // Update is called once per frame
    void Update()
    {
       // x = x + 1;
       // Debug.Log(x);

        Debug.Log("Hola desde Update");
    }

    private void FixedUpdate()
    {
        Debug.LogWarning("Hola desde Fixed Update cada 50 frames");
    }

    private void LateUpdate()
    {
        Debug.LogWarning("Hola desde Late Update");
    }

    private void OnEnable()
    {
        Debug.LogWarning("El objeto está habilitado");
    }

    private void OnDisable()
    {
        Debug.LogWarning("El objeto está deshabilitado");
    }


}

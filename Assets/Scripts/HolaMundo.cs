using UnityEngine;

public class HolaMundo : MonoBehaviour
{
    public int x;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        x = 0;

        Debug.Log("Hola desde Start aqui comienza mi juego");
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
        Debug.LogError("Error al actualizar");
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

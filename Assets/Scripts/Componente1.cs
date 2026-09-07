using UnityEngine;

public class Componente1 : MonoBehaviour
{
    public static GameObject miObjeto;

    private void Awake()
    {
       
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    { 
        miObjeto = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

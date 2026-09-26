using UnityEngine;

public class CoboDesdeAwake : MonoBehaviour
{

    void Awake()
    {
        GameObject cubo = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cubo.transform.position = new Vector3(0, 0, 0);
        cubo.transform.localScale = new Vector3(1, 1, 1);
        cubo.GetComponent<Renderer>().material.color = Color.red;
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

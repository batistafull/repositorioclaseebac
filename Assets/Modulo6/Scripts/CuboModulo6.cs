using UnityEngine;

public class CuboModulo6 : MonoBehaviour
{
    
    void Awake()
    {
        GetComponent<MeshRenderer>().material.color = new Color(Random.value, Random.value, Random.value);

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

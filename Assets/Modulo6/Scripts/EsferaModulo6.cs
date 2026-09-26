using UnityEngine;

public class EsferaModulo6 : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        GetComponent<MeshRenderer>().material.color = new Color(Random.value, Random.value, Random.value);
    }
}

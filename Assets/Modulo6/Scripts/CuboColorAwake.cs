using UnityEngine;

public class CuboColorAwake : MonoBehaviour
{

    void Awake()
    {
        GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value);
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

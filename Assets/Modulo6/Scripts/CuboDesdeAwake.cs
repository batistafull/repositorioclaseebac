using UnityEngine;

public class CuboDesdeAwake : MonoBehaviour
{
    public GameObject cuboPrefab;

    void Awake()
    {
        GameObject cubo = Instantiate<GameObject>(cuboPrefab, new Vector3(-6.2f, 2.2f, -8.21f), Quaternion.identity);
        cubo.name = "CuboDesdeAwake";
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

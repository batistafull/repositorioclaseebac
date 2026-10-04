using UnityEngine;

public class CuboDesdeOnEnableOnDisable : MonoBehaviour
{
    public GameObject PrefabCubo;

    GameObject cubo;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnEnable()
    {
        cubo = Instantiate(PrefabCubo, new Vector3(10.2f, 2.2f, -8.21f), Quaternion.identity);
        cubo.name = "CuboDesdeOnEnable";
        cubo.GetComponent<MeshRenderer>().material.color = Color.blue;
    }

    void OnDisable()
    {
        if (cubo != null)
        {
            Destroy(cubo);
        }
    }
}

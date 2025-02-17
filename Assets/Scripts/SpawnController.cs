using UnityEngine;

public class SpawnController : MonoBehaviour
{
    public GameObject Pipes_Prefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Instantiate(Pipes_Prefab, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

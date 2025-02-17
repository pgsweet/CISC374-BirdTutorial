using UnityEngine;

public class SpawnController : MonoBehaviour
{
    public GameObject Pipes_Prefab;
    private float timer = 0.0f;
    public float spawnTime = 2.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Instantiate(Pipes_Prefab, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnTime) {
            timer += Time.deltaTime;
        } else {
            Instantiate(Pipes_Prefab, transform.position, transform.rotation);
            timer = 0.0f;
        }
    }
}

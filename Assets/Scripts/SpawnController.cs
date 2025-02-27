using UnityEngine;

public class SpawnController : MonoBehaviour
{
    public GameObject Pipes_Prefab;
    private float timer = 0.0f;
    public float spawnTime = 4.0f;
    public float heightOffset = 10.0f;
    private GameObject player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (player.GetComponent<CharacterController>().birdIsAlive)
        {
            if (timer < spawnTime) {
                timer += Time.deltaTime;
            } else {
                spawnPipe();
                timer = 0.0f;
            }
        }
    }

    void spawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        Instantiate(Pipes_Prefab, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}

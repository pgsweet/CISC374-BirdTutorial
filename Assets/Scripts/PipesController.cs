using UnityEngine;

public class PipesController : MonoBehaviour
{
    public float Move_Speed = 5;
    public int deadSpace = 40;
    public GameObject player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (player.GetComponent<CharacterController>().birdIsAlive)
        {
            gameObject.transform.position += Vector3.left * Time.deltaTime * Move_Speed;
        }
        
        if (gameObject.transform.position.x < -deadSpace) 
        {
            Destroy(gameObject);
        }
    }
}

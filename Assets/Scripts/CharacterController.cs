using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public GameObject player;
    public float JumpForce = 10;
    public LogicScript logic;
    public bool birdIsAlive = true;
    public int yBounds = 23;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            Jump();
        }
        
        if (gameObject.transform.position.y < -yBounds || gameObject.transform.position.y > yBounds)
        {
            logic.gameOver();
        }
    }

    void Jump() 
    {
        player.GetComponent<Rigidbody2D>().linearVelocity = Vector2.up * JumpForce;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }
}

using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public GameObject player;
    public float JumpForce = 10;
    public LogicScript logic;
    public bool birdIsAlive = true;
    public int yBounds = 23;
    private PlayerAnimation animation;
    public GameObject popSound;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        animation = GetComponent<PlayerAnimation>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            popSound.SetActive(true);
            popSound.GetComponent<PopScript>().Pop();
            animation.Flap();
            player.GetComponent<Rigidbody2D>().linearVelocity = Vector2.up * JumpForce;
        }
        else if (Input.GetKeyUp(KeyCode.Space) && birdIsAlive)
        {
            animation.StopFlap();
        }
        
        if (gameObject.transform.position.y < -yBounds || gameObject.transform.position.y > yBounds)
        {
            if (birdIsAlive) {
                logic.gameOver();
            }
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
    }
}

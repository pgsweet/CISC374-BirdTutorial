using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public GameObject player;
    public float JumpForce = 10;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            Jump();
        }
    }

    void Jump() 
    {
        player.GetComponent<Rigidbody2D>().linearVelocity = Vector2.up * 10;
    }
}

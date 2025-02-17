using UnityEngine;

public class PipesController : MonoBehaviour
{
    public float Move_Speed = 5;
    public int deadSpace = 40;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position += Vector3.left * Time.deltaTime * Move_Speed;
        if (gameObject.transform.position.x < -deadSpace) 
        {
            Destroy(gameObject);
        }
    }
}

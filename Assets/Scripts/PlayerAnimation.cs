using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    public Animator animation;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animation = GameObject.FindGameObjectWithTag("Animation").GetComponent<Animator>();
    }

    public void Flap()
    {
        animation.SetBool("Flap", true);
    }

    public void StopFlap()
    {
        animation.SetBool("Flap", false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

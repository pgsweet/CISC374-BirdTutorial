using UnityEngine;

public class AudioScript : MonoBehaviour
{
    public AudioClip ding;
    public AudioClip scratch;
    public AudioClip pop;

    public void Ding()
    {
        this.GetComponent<AudioSource>().PlayOneShot(ding);
    }

    public void Scratch()
    {
        this.GetComponent<AudioSource>().PlayOneShot(scratch);
    }
    
    public void Pop()
    {
        this.GetComponent<AudioSource>().PlayOneShot(pop);
    }
}

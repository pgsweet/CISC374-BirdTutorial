using UnityEngine;

public class DingScript : MonoBehaviour
{
    public void Ding()
    {
        if (GetComponent<AudioSource>().isPlaying) return;
        GetComponent<AudioSource>().Play();
    }
}

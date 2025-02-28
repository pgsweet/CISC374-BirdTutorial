using UnityEngine;

public class RecordScratchScript : MonoBehaviour
{
    public void RecordScratch()
    {
        if (GetComponent<AudioSource>().isPlaying) return;
        GetComponent<AudioSource>().Play();
    } 
}

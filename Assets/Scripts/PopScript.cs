using UnityEngine;

public class PopScript : MonoBehaviour
{
    public void Pop()
    {
        GetComponent<AudioSource>().Play();
    }
}

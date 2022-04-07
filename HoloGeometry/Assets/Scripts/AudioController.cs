using UnityEngine;

public class AudioController : MonoBehaviour
{
    public AudioSource audioDescription;
    void Start()
    {
        audioDescription.clip = GeometricBodyDescription.audioDescription;
    }
}

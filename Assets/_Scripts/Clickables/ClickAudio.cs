using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class ClickAudio : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private AudioClip clip;
    private AudioSource source;

    void Awake()
    {
        source = GetComponent<AudioSource>();
    }
    public void SetSound()
    {
        source.PlayOneShot(clip);
    }
}

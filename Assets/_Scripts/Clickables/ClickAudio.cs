using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class ClickAudio : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private AudioClip clip;
    private AudioSource source;
    private void Awake()
    {
        source = GetComponent<AudioSource>();
    }
    public void SetSound()
    {
        // If clip has not been assigned in the inspector this error came out
        if (clip == null)
        {
            Debug.LogError("The clip has not been assigned via the Inspector. Please assign the clip in the Inspector.");
        }
        // The clip is only play at once
        source.PlayOneShot(clip);
    }
}

using UnityEngine;

//This code fixes the error by adding an AudioSource component to the GameObject at runtime if it doesn't already have one.
[RequireComponent(typeof(AudioSource))]
public class ClickAudio : MonoBehaviour
{
    //Creates a "References" header in the Inspector.
    [Header("References")]
    [SerializeField] private AudioClip clip;
    private AudioSource source;
    private void Awake()
    {
        //Even if we check for the AudioSource component when the game starts, it could still be removed at runtime
        //which would cause errors again. That's why we use this code to continuously check whether it is null or not.

        if (!TryGetComponent<AudioSource>(out source))
        {
            Debug.LogError("AudioSource component not found");
        }
    }
    public void SetSound()
    {
        // If clip has not been assigned in the inspector, this error came out.
        if (clip == null)
        {
            Debug.LogError("The clip has not been assigned via the Inspector. Please assign the clip in the Inspector.");
            return;
        }
        // The clip is only play at once.
        source.PlayOneShot(clip);
    }
}

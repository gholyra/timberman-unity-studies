using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class AudioABS : MonoBehaviour
{
    private AudioSource audioSource;
    [SerializeField] protected AudioClip[] audioClips;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    protected void PlaySound(AudioClip audio)
    {
        audioSource.clip = audio;
        audioSource.Play();
    }

}

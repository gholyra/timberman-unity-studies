using UnityEngine;

public enum SFXAudioType
{
    OnClick,
    Hit,
    Hurts
}

[RequireComponent(typeof(AudioSource))]
public class SFXAudioManager : MonoBehaviour
{
    private AudioSource audioSource;
    [SerializeField] private AudioClip[] sfxAudios;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void ChooseSoundType(SFXAudioType audioType)
    {
        switch (audioType)
        {
            case SFXAudioType.OnClick:
                PlaySound(sfxAudios[0]);
                break;
            case SFXAudioType.Hit:
                PlaySound(sfxAudios[1]);
                break;
            case SFXAudioType.Hurts:
                PlaySound(sfxAudios[2]);
                break;
            default:
                break;
        }
    }

    private void PlaySound(AudioClip audio)
    {
        audioSource.clip = audio;
        audioSource.Play();
    }
}

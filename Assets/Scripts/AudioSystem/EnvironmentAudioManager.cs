using UnityEngine;

public enum EnvironmentAudioType
{
    Menu,
    Gameplay,
    GameOver
}

[RequireComponent(typeof(AudioSource))]
public class EnvironmentAudioManager : MonoBehaviour
{
    private AudioSource audioSource;
    [SerializeField] private AudioClip[] environmentAudios;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void ChooseSoundType(EnvironmentAudioType audioType)
    {
        switch (audioType)
        {
            case EnvironmentAudioType.Menu:
                PlaySound(environmentAudios[0]);
                break;
            case EnvironmentAudioType.Gameplay:
                PlaySound(environmentAudios[1]);
                break;
            case EnvironmentAudioType.GameOver:
                PlaySound(environmentAudios[2]);
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

using UnityEngine;

public class AudioSystem : MonoBehaviour
{
    [SerializeField] private EnvironmentAudioManager environmentAudio;
    [SerializeField] private SFXAudioManager sfxAudio;

    public void PlayEnvironmentAudioByType(EnvironmentAudioType audioType)
    {
        environmentAudio.PlaySoundByType(audioType);
    }
    
    public void PlaySFXAudioByType(SFXAudioType audioType)
    {
        sfxAudio.PlaySoundByType(audioType);
    }
}

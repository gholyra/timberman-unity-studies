using UnityEngine;

public enum SFXAudioType
{
    OnClick,
    TimberHit,
    PlayerHurts
}

[RequireComponent(typeof(AudioSource))]
public class SFXAudioManager : AudioABS
{
    public void PlaySoundByType(SFXAudioType audioType)
    {
        switch (audioType)
        {
            case SFXAudioType.OnClick:
                PlaySound(audioClips[0]);
                break;
            case SFXAudioType.TimberHit:
                PlaySound(audioClips[1]);
                break;
            case SFXAudioType.PlayerHurts:
                PlaySound(audioClips[2]);
                break;
            default:
                break;
        }
    }
}

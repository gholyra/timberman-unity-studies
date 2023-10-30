using UnityEngine;

public enum EnvironmentAudioType
{
    Menu,
    Gameplay,
    GameOver
}

[RequireComponent(typeof(AudioSource))]
public class EnvironmentAudioManager : AudioABS
{

    public void PlaySoundByType(EnvironmentAudioType audioType)
    {
        switch (audioType)
        {
            case EnvironmentAudioType.Menu:
                PlaySound(audioClips[0]);
                break;
            case EnvironmentAudioType.Gameplay:
                PlaySound(audioClips[1]);
                break;
            case EnvironmentAudioType.GameOver:
                PlaySound(audioClips[2]);
                break;
            default:
                break;
        }
    }

}

using UnityEngine;

public enum AudioType
{
    Environment,
    SFX
}

public class AudioSystem : MonoBehaviour
{
    [SerializeField] private EnvironmentAudioManager environmentAudio;
    [SerializeField] private SFXAudioManager sfxAudio;

    public void PlayEnvironmentAudio(AudioType audioType, string audioName)
    {

    }
}

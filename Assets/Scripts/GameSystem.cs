using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSystem : MonoBehaviour
{

    public static GameSystem Instance;

    [SerializeField] private AudioSystem audioSystem;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }

    private void Start()
    {
        PlayEnvironmentAudioByType(EnvironmentAudioType.Menu);
    }

    public void PlayEnvironmentAudioByType(EnvironmentAudioType audioType)
    {
        audioSystem.PlayEnvironmentAudioByType(audioType);
    }
    
    public void PlaySFXAudioByType(SFXAudioType audioType)
    {
        audioSystem.PlaySFXAudioByType(audioType);
    }
}

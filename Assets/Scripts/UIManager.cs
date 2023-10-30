using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Button playButton;

    private void Awake()
    {
        playButton.onClick.AddListener(GoToGameScene);
    }

    public void GoToGameScene()
    {
        GameSystem.Instance.PlaySFXAudioByType(SFXAudioType.OnClick);
        SceneManager.LoadScene("sGame");
        GameSystem.Instance.PlayEnvironmentAudioByType(EnvironmentAudioType.Gameplay);
    }
}

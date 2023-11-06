using System;
using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class PlayerBehaviour : MonoBehaviour
{

    private Animator playerAnimator;
    
    private void Awake()
    {
        playerAnimator = GetComponent<Animator>();
    }
    
    private void Start()
    {
        GameSystem.Instance.inputManager.OnHit += TimberHit;
    }
    
    private void TimberHit()
    {
        playerAnimator.SetTrigger("pHit");
        GameSystem.Instance.PlaySFXAudioByType(SFXAudioType.TimberHit);
    }

    private void OnDestroy()
    {
        GameSystem.Instance.inputManager.OnHit -= TimberHit;
    }
}

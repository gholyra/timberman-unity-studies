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
        GameSystem.Instance.inputManager.OnHit += HitHandler;
    }
    
    private void HitHandler(Vector2 touchPos)
    {
        CheckHitPosition(touchPos);
        PlayHitAnimation();
        PlayHitSFX();
        TimberHit();
    }

    private void CheckHitPosition(Vector2 touchPos)
    {
        float screenSize = Camera.main.pixelWidth;
        if (touchPos.x < (screenSize / 2))
        {
            transform.parent.rotation = new Quaternion(0, 0, 0, 0);
        }
        else if (touchPos.x > screenSize / 2)
        {
            transform.parent.rotation = new Quaternion(0, 180, 0, 0);
        }
    }

    private void PlayHitAnimation()
    {
        playerAnimator.SetTrigger("pHit");
    }

    private void PlayHitSFX()
    {
        GameSystem.Instance.PlaySFXAudioByType(SFXAudioType.TimberHit);
    }

    private void TimberHit()
    {
        //TODO
        GameSystem.Instance.OnTrunkHit();
    }

    private void OnDestroy()
    {
        GameSystem.Instance.inputManager.OnHit -= HitHandler;
    }
}

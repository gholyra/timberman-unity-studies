using UnityEngine;

public abstract class TrunkBase : MonoBehaviour
{

    [SerializeField] private float moveOffset;

    private SpriteRenderer spriteRenderer;
    
    private void OnEnable()
    {
        TrunkPool.OnTrunkHit += TrunkFall;
        int randomNum = Random.Range(0, 2);
        spriteRenderer.flipX = randomNum == 0;
    }

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void TrunkFall()
    {
        transform.position = new Vector2(0, transform.position.y - moveOffset);
    }

    public void TrunkGotHit()
    {
        TrunkPool.OnTrunkHit -= TrunkFall;
        TrunkPool.OnTrunkHit?.Invoke();
    }
    
}

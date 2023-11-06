using UnityEngine;

public abstract class TrunkBase : MonoBehaviour
{

    [SerializeField] private float moveOffset;
    
    private void OnEnable()
    {
        TrunkPool.OnTrunkHit += TrunkFall;
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

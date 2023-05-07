using UnityEngine;

public class Player : MonoBehaviour
{
    public PlayerSpriteRenderer smallRenderer;
    public PlayerSpriteRenderer bigRenderer;

    private DeathAnimation deathAnimation;

    private void Awake()
    {
        deathAnimation = GetComponent<DeathAnimation>();
    }
    public void Hit()
    {

    }
}

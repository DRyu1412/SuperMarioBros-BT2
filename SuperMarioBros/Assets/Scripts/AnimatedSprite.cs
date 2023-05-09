using UnityEngine;

public class AnimatedSprite : MonoBehaviour
{
    public Sprite[] sprite;
    public float framerate = 1f / 6f;

    private SpriteRenderer spriteRenderer;
    private int frame;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnEnable()
    {
        InvokeRepeating(nameof(Animate), framerate, framerate);
    }

    private void OnDisable()
    {
        CancelInvoke();
    }

    private void Animate()
    {
        frame++;

        if(frame >= sprite.Length)
        {
            frame = 0;
        }

        if(frame >=0 && frame < sprite.Length)
        {
            spriteRenderer.sprite = sprite[frame];
        }
    }
        
}

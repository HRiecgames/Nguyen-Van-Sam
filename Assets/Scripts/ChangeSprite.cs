using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSprite : MonoBehaviour
{
    public SpriteData spriteData;
    private SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        if (spriteData != null && spriteData.sprite != null)
        {
            spriteRenderer.sprite = spriteData.sprite;
        } 
    }

}

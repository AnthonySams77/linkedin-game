using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

enum SpriteType { spikes }

public class AtlasTest : MonoBehaviour
{
    [SerializeField]
    private SpriteType currentType;

    private SpriteType lastType;

    [SerializeField]
    private SpriteAtlas atlas;

    private SpriteRenderer myRenderer;

    // Start is called before the first frame update
    void Start()
    {
        myRenderer = GetComponent<SpriteRenderer>();
        lastType = SpriteType.spikes;
    }

    // Update is called once per frame
    void Update()
    {
        ChangeSprite();
    }

    private void ChangeSprite()
    {
        if (currentType != lastType)
        {
            myRenderer.sprite = atlas.GetSprite(currentType.ToString());

            lastType = currentType;
        }
    }
}

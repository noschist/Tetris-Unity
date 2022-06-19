using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField] private Color col1,col2;
    [SerializeField] private SpriteRenderer colRenderer;

    public void Init(bool isAlt)
    {
        colRenderer.color = isAlt ? col2 : col1;
    }
}

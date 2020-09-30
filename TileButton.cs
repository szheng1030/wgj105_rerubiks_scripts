using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileButton : MonoBehaviour
{
    private Tile tileScript;

    public void Start()
    {
        tileScript = GetComponentInParent<Tile>();
    }

    public void Click()
    {
        tileScript.CreateTile(GM.playerColour);
        GM.justPainted = true;
    }
}

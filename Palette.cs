using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Palette : MonoBehaviour
{
    public Tile.Colour colour;

    public void Click()
    {
        GM.playerColour = colour;
    }
}

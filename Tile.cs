using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    public enum Colour
    {
        Red,
        Blue,
        Orange,
        Green,
        White,
        Yellow,
    }

    public GameObject red;
    public GameObject blue;
    public GameObject orange;
    public GameObject green;
    public GameObject white;
    public GameObject yellow;

    private GameObject currentTile;
    public Colour ogColour;
    public bool isRestoring = false;

    public void CreateTile(Colour colour)
    {
        GM.justPainted = true;

        if (currentTile != null)
            Destroy(currentTile);

        switch (colour)
        {
            case Colour.Red:
                {
                    currentTile = (GameObject)Instantiate(red, transform.position, Quaternion.Euler(0, 180, 0));
                    currentTile.transform.parent = transform; 
                    break;
                }
            case Colour.Blue:
                {
                    currentTile = (GameObject)Instantiate(blue, transform.position, Quaternion.Euler(0, 180, 0));
                    currentTile.transform.parent = transform;
                    break;
                }
            case Colour.Orange:
                {
                    currentTile = (GameObject)Instantiate(orange, transform.position, Quaternion.Euler(0, 180, 0));
                    currentTile.transform.parent = transform;
                    break;
                }
            case Colour.Green:
                {
                    currentTile = (GameObject)Instantiate(green, transform.position, Quaternion.Euler(0, 180, 0));
                    currentTile.transform.parent = transform;
                    break;
                }
            case Colour.White:
                {
                    currentTile = (GameObject)Instantiate(white, transform.position, Quaternion.Euler(0, 180, 0));
                    currentTile.transform.parent = transform;
                    break;
                }
            case Colour.Yellow:
                {
                    currentTile = (GameObject)Instantiate(yellow, transform.position, Quaternion.Euler(0, 180, 0));
                    currentTile.transform.parent = transform;
                    break;
                }
        }
    }

    public void InitializeTile(Colour colour, GM.Face face)
    {
        switch (face)
        {
            case GM.Face.Red:
            {
                    switch (colour)
                    {
                        case Colour.Red:
                            currentTile = (GameObject)Instantiate(red, transform.position, Quaternion.Euler(0, 90, 0));
                            ogColour = Colour.Red;
                            break;
                        case Colour.Blue:
                            currentTile = (GameObject)Instantiate(blue, transform.position, Quaternion.Euler(0, 90, 0));
                            ogColour = Colour.Blue;
                            break;
                        case Colour.Orange:
                            currentTile = (GameObject)Instantiate(orange, transform.position, Quaternion.Euler(0, 90, 0));
                            ogColour = Colour.Orange;
                            break;
                        case Colour.Green:
                            currentTile = (GameObject)Instantiate(green, transform.position, Quaternion.Euler(0, 90, 0));
                            ogColour = Colour.Green;
                            break;
                        case Colour.Yellow:
                            currentTile = (GameObject)Instantiate(yellow, transform.position, Quaternion.Euler(0, 90, 0));
                            ogColour = Colour.Yellow;
                            break;
                        case Colour.White:
                            currentTile = (GameObject)Instantiate(white, transform.position, Quaternion.Euler(0, 90, 0));
                            ogColour = Colour.White;
                            break;
                    }
                    currentTile.transform.parent = transform;
                    break;
            }
            case GM.Face.Blue:
            {
                    switch (colour)
                    {
                        case Colour.Red:
                            currentTile = (GameObject)Instantiate(red, transform.position, Quaternion.Euler(0, 0, 0));
                            ogColour = Colour.Red;
                            break;
                        case Colour.Blue:
                            currentTile = (GameObject)Instantiate(blue, transform.position, Quaternion.Euler(0, 0, 0));
                            ogColour = Colour.Blue;
                            break;
                        case Colour.Orange:
                            currentTile = (GameObject)Instantiate(orange, transform.position, Quaternion.Euler(0, 0, 0));
                            ogColour = Colour.Orange;
                            break;
                        case Colour.Green:
                            currentTile = (GameObject)Instantiate(green, transform.position, Quaternion.Euler(0, 0, 0));
                            ogColour = Colour.Green;
                            break;
                        case Colour.Yellow:
                            currentTile = (GameObject)Instantiate(yellow, transform.position, Quaternion.Euler(0, 0, 0));
                            ogColour = Colour.Yellow;
                            break;
                        case Colour.White:
                            currentTile = (GameObject)Instantiate(white, transform.position, Quaternion.Euler(0, 0, 0));
                            ogColour = Colour.White;
                            break;
                    }
                    currentTile.transform.parent = transform;
                    break;
            }
            case GM.Face.Orange:
            {
                    switch (colour)
                    {
                        case Colour.Red:
                            currentTile = (GameObject)Instantiate(red, transform.position, Quaternion.Euler(0, -90, 0));
                            ogColour = Colour.Red;
                            break;
                        case Colour.Blue:
                            currentTile = (GameObject)Instantiate(blue, transform.position, Quaternion.Euler(0, -90, 0));
                            ogColour = Colour.Blue;
                            break;
                        case Colour.Orange:
                            currentTile = (GameObject)Instantiate(orange, transform.position, Quaternion.Euler(0, -90, 0));
                            ogColour = Colour.Orange;
                            break;
                        case Colour.Green:
                            currentTile = (GameObject)Instantiate(green, transform.position, Quaternion.Euler(0, -90, 0));
                            ogColour = Colour.Green;
                            break;
                        case Colour.Yellow:
                            currentTile = (GameObject)Instantiate(yellow, transform.position, Quaternion.Euler(0, -90, 0));
                            ogColour = Colour.Yellow;
                            break;
                        case Colour.White:
                            currentTile = (GameObject)Instantiate(white, transform.position, Quaternion.Euler(0, -90, 0));
                            ogColour = Colour.White;
                            break;
                    }
                    currentTile.transform.parent = transform;
                    break;
            }
            case GM.Face.Green:
            {
                    switch (colour)
                    {
                        case Colour.Red:
                            currentTile = (GameObject)Instantiate(red, transform.position, Quaternion.Euler(0, 180, 0));
                            ogColour = Colour.Red;
                            break;
                        case Colour.Blue:
                            currentTile = (GameObject)Instantiate(blue, transform.position, Quaternion.Euler(0, 180, 0));
                            ogColour = Colour.Blue;
                            break;
                        case Colour.Orange:
                            currentTile = (GameObject)Instantiate(orange, transform.position, Quaternion.Euler(0, 180, 0));
                            ogColour = Colour.Orange;
                            break;
                        case Colour.Green:
                            currentTile = (GameObject)Instantiate(green, transform.position, Quaternion.Euler(0, 180, 0));
                            ogColour = Colour.Green;
                            break;
                        case Colour.Yellow:
                            currentTile = (GameObject)Instantiate(yellow, transform.position, Quaternion.Euler(0, 180, 0));
                            ogColour = Colour.Yellow;
                            break;
                        case Colour.White:
                            currentTile = (GameObject)Instantiate(white, transform.position, Quaternion.Euler(0, 180, 0));
                            ogColour = Colour.White;
                            break;
                    }
                    currentTile.transform.parent = transform;
                    break;
            }
            case GM.Face.White:
            {
                    switch (colour)
                    {
                        case Colour.Red:
                            currentTile = (GameObject)Instantiate(red, transform.position, Quaternion.Euler(-90, 0, 0));
                            ogColour = Colour.Red;
                            break;
                        case Colour.Blue:
                            currentTile = (GameObject)Instantiate(blue, transform.position, Quaternion.Euler(-90, 0, 0));
                            ogColour = Colour.Blue;
                            break;
                        case Colour.Orange:
                            currentTile = (GameObject)Instantiate(orange, transform.position, Quaternion.Euler(-90, 0, 0));
                            ogColour = Colour.Orange;
                            break;
                        case Colour.Green:
                            currentTile = (GameObject)Instantiate(green, transform.position, Quaternion.Euler(-90, 0, 0));
                            ogColour = Colour.Green;
                            break;
                        case Colour.Yellow:
                            currentTile = (GameObject)Instantiate(yellow, transform.position, Quaternion.Euler(-90, 0, 0));
                            ogColour = Colour.Yellow;
                            break;
                        case Colour.White:
                            currentTile = (GameObject)Instantiate(white, transform.position, Quaternion.Euler(-90, 0, 0));
                            ogColour = Colour.White;
                            break;
                    }
                    currentTile.transform.parent = transform;
                    break;
            }
            case GM.Face.Yellow:
            {
                    switch (colour)
                    {
                        case Colour.Red:
                            currentTile = (GameObject)Instantiate(red, transform.position, Quaternion.Euler(90, 180, 0));
                            ogColour = Colour.Red;
                            break;
                        case Colour.Blue:
                            currentTile = (GameObject)Instantiate(blue, transform.position, Quaternion.Euler(90, 180, 0));
                            ogColour = Colour.Blue;
                            break;
                        case Colour.Orange:
                            currentTile = (GameObject)Instantiate(orange, transform.position, Quaternion.Euler(90, 180, 0));
                            ogColour = Colour.Orange;
                            break;
                        case Colour.Green:
                            currentTile = (GameObject)Instantiate(green, transform.position, Quaternion.Euler(90, 180, 0));
                            ogColour = Colour.Green;
                            break;
                        case Colour.Yellow:
                            currentTile = (GameObject)Instantiate(yellow, transform.position, Quaternion.Euler(90, 180, 0));
                            ogColour = Colour.Yellow;
                            break;
                        case Colour.White:
                            currentTile = (GameObject)Instantiate(white, transform.position, Quaternion.Euler(90, 180, 0));
                            ogColour = Colour.White;
                            break;
                    }
                    currentTile.transform.parent = transform;
                    break;
            }
        }
    }

    public void RestoreTile(Colour colour)
    {
        Destroy(currentTile);
        isRestoring = true;
        StartCoroutine(LateRestore(1));

        switch (colour)
        {
            case Colour.Red:
                {
                    currentTile = (GameObject)Instantiate(red, transform.position, Quaternion.Euler(90, 180, 0));
                    currentTile.transform.parent = transform;
                    break;
                }
            case Colour.Blue:
                {
                    currentTile = (GameObject)Instantiate(blue, transform.position, Quaternion.Euler(90, 180, 0));
                    currentTile.transform.parent = transform;
                    break;
                }
            case Colour.Orange:
                {
                    currentTile = (GameObject)Instantiate(orange, transform.position, Quaternion.Euler(90, 180, 0));
                    currentTile.transform.parent = transform;
                    break;
                }
            case Colour.Green:
                {
                    currentTile = (GameObject)Instantiate(green, transform.position, Quaternion.Euler(90, 180, 0));
                    currentTile.transform.parent = transform;
                    break;
                }
            case Colour.White:
                {
                    currentTile = (GameObject)Instantiate(white, transform.position, Quaternion.Euler(90, 180, 0));
                    currentTile.transform.parent = transform;
                    break;
                }
            case Colour.Yellow:
                {
                    currentTile = (GameObject)Instantiate(yellow, transform.position, Quaternion.Euler(90, 180, 0));
                    currentTile.transform.parent = transform;
                    break;
                }
        }
    }

    IEnumerator LateRestore(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        isRestoring = false;
    }
}

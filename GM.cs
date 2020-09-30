using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GM : MonoBehaviour
{
    public static Tile.Colour playerColour;

    public Tile tile;

    public enum Rotate
    {
        Left,
        Right,
        Up,
        Down,
        None,
    }

    public enum Face
    {
        Red,
        Blue,
        Orange,
        Green,
        White,
        Yellow,
    }
    public static int UDRotateCount = 0;

    public static Face currentFront = Face.Green;
    public static Face currentBottom = Face.Yellow;

    public static bool isInitiation = true;
    public static bool justPainted = true;

    public static bool gameWin = false;
    public Animator introAnim;
    public GameObject introUI;

    private void Start()
    {
        tile = GetComponent<Tile>();
        StartCoroutine(LateStart(1));
    }

    private void LateUpdate()
    {
        if (justPainted)
            justPainted = false;

        if (gameWin)
        {
            StartCoroutine(EndDelay(0.5f));
            gameWin = false;
        }
    }

    public static void UpdateFace(Rotate rotate)
    {
        if (currentFront == Face.Green)
        {
            if (currentBottom == Face.Yellow)
            {
                if (rotate == Rotate.Right)
                {
                    currentFront = Face.Red;
                    currentBottom = Face.Yellow;
                }
                else if (rotate == Rotate.Left)
                {
                    currentFront = Face.Orange;
                    currentBottom = Face.Yellow;
                }
                else if (rotate == Rotate.Up)
                {
                    currentFront = Face.White;
                    currentBottom = Face.Green;
                }
                else if (rotate == Rotate.Down)
                {
                    currentFront = Face.Yellow;
                    currentBottom = Face.Blue;
                }
            }
            else if (currentBottom == Face.Red)
            {
                if (rotate == Rotate.Right)
                {
                    currentFront = Face.White;
                    currentBottom = Face.Red;
                }
                else if (rotate == Rotate.Left)
                {
                    currentFront = Face.Yellow;
                    currentBottom = Face.Red;
                }
                else if (rotate == Rotate.Up)
                {
                    currentFront = Face.Orange;
                    currentBottom = Face.Green;
                }
                else if (rotate == Rotate.Down)
                {
                    currentFront = Face.Red;
                    currentBottom = Face.Blue;
                }
            }
            else if (currentBottom == Face.White)
            {
                if (rotate == Rotate.Right)
                {
                    currentFront = Face.Orange;
                    currentBottom = Face.White;
                }
                else if (rotate == Rotate.Left)
                {
                    currentFront = Face.Red;
                    currentBottom = Face.White;
                }
                else if (rotate == Rotate.Up)
                {
                    currentFront = Face.Yellow;
                    currentBottom = Face.Green;
                }
                else if (rotate == Rotate.Down)
                {
                    currentFront = Face.White;
                    currentBottom = Face.Blue;
                }
            }
            else if (currentBottom == Face.Orange)
            {
                if (rotate == Rotate.Right)
                {
                    currentFront = Face.Yellow;
                    currentBottom = Face.Orange;
                }
                else if (rotate == Rotate.Left)
                {
                    currentFront = Face.White;
                    currentBottom = Face.Orange;
                }
                else if (rotate == Rotate.Up)
                {
                    currentFront = Face.Red;
                    currentBottom = Face.Green;
                }
                else if (rotate == Rotate.Down)
                {
                    currentFront = Face.Orange;
                    currentBottom = Face.Blue;
                }
            }
        }
        else if (currentFront == Face.Red)
        {
            if (currentBottom == Face.Yellow)
            {
                if (rotate == Rotate.Right)
                {
                    currentFront = Face.Blue;
                    currentBottom = Face.Yellow;
                }
                else if (rotate == Rotate.Left)
                {
                    currentFront = Face.Green;
                    currentBottom = Face.Yellow;
                }
                else if (rotate == Rotate.Up)
                {
                    currentFront = Face.White;
                    currentBottom = Face.Red;
                }
                else if (rotate == Rotate.Down)
                {
                    currentFront = Face.Yellow;
                    currentBottom = Face.Orange;
                }
            }
            else if (currentBottom == Face.Blue)
            {
                if (rotate == Rotate.Right)
                {
                    currentFront = Face.White;
                    currentBottom = Face.Blue;
                }
                else if (rotate == Rotate.Left)
                {
                    currentFront = Face.Yellow;
                    currentBottom = Face.Blue;
                }
                else if (rotate == Rotate.Up)
                {
                    currentFront = Face.Green;
                    currentBottom = Face.Red;
                }
                else if (rotate == Rotate.Down)
                {
                    currentFront = Face.Blue;
                    currentBottom = Face.Orange;
                }
            }
            else if (currentBottom == Face.White)
            {
                if (rotate == Rotate.Right)
                {
                    currentFront = Face.Green;
                    currentBottom = Face.White;
                }
                else if (rotate == Rotate.Left)
                {
                    currentFront = Face.Blue;
                    currentBottom = Face.White;
                }
                else if (rotate == Rotate.Up)
                {
                    currentFront = Face.Yellow;
                    currentBottom = Face.Red;
                }
                else if (rotate == Rotate.Down)
                {
                    currentFront = Face.White;
                    currentBottom = Face.Orange;
                }
            }
            else if (currentBottom == Face.Green)
            {
                if (rotate == Rotate.Right)
                {
                    currentFront = Face.Yellow;
                    currentBottom = Face.Green;
                }
                else if (rotate == Rotate.Left)
                {
                    currentFront = Face.White;
                    currentBottom = Face.Green;
                }
                else if (rotate == Rotate.Up)
                {
                    currentFront = Face.Blue;
                    currentBottom = Face.Red;
                }
                else if (rotate == Rotate.Down)
                {
                    currentFront = Face.Green;
                    currentBottom = Face.Orange;
                }
            }
        }
        else if (currentFront == Face.Blue)
        {
            if (currentBottom == Face.Yellow)
            {
                if (rotate == Rotate.Right)
                {
                    currentFront = Face.Orange;
                    currentBottom = Face.Yellow;
                }
                else if (rotate == Rotate.Left)
                {
                    currentFront = Face.Red;
                    currentBottom = Face.Yellow;
                }
                else if (rotate == Rotate.Up)
                {
                    currentFront = Face.White;
                    currentBottom = Face.Blue;
                }
                else if (rotate == Rotate.Down)
                {
                    currentFront = Face.Yellow;
                    currentBottom = Face.Green;
                }
            }
            else if (currentBottom == Face.Orange)
            {
                if (rotate == Rotate.Right)
                {
                    currentFront = Face.White;
                    currentBottom = Face.Orange;
                }
                else if (rotate == Rotate.Left)
                {
                    currentFront = Face.Yellow;
                    currentBottom = Face.Orange;
                }
                else if (rotate == Rotate.Up)
                {
                    currentFront = Face.Red;
                    currentBottom = Face.Blue;
                }
                else if (rotate == Rotate.Down)
                {
                    currentFront = Face.Orange;
                    currentBottom = Face.Green;
                }
            }
            else if (currentBottom == Face.White)
            {
                if (rotate == Rotate.Right)
                {
                    currentFront = Face.Red;
                    currentBottom = Face.White;
                }
                else if (rotate == Rotate.Left)
                {
                    currentFront = Face.Orange;
                    currentBottom = Face.White;
                }
                else if (rotate == Rotate.Up)
                {
                    currentFront = Face.Yellow;
                    currentBottom = Face.Blue;
                }
                else if (rotate == Rotate.Down)
                {
                    currentFront = Face.White;
                    currentBottom = Face.Green;
                }
            }
            else if (currentBottom == Face.Red)
            {
                if (rotate == Rotate.Right)
                {
                    currentFront = Face.Yellow;
                    currentBottom = Face.Red;
                }
                else if (rotate == Rotate.Left)
                {
                    currentFront = Face.White;
                    currentBottom = Face.Red;
                }
                else if (rotate == Rotate.Up)
                {
                    currentFront = Face.Orange;
                    currentBottom = Face.Blue;
                }
                else if (rotate == Rotate.Down)
                {
                    currentFront = Face.Red;
                    currentBottom = Face.Green;
                }
            }
        }
        else if (currentFront == Face.Orange)
        {
            if (currentBottom == Face.Yellow)
            {
                if (rotate == Rotate.Right)
                {
                    currentFront = Face.Green;
                    currentBottom = Face.Yellow;
                }
                else if (rotate == Rotate.Left)
                {
                    currentFront = Face.Blue;
                    currentBottom = Face.Yellow;
                }
                else if (rotate == Rotate.Up)
                {
                    currentFront = Face.White;
                    currentBottom = Face.Orange;
                }
                else if (rotate == Rotate.Down)
                {
                    currentFront = Face.Yellow;
                    currentBottom = Face.Red;
                }
            }
            else if (currentBottom == Face.Green)
            {
                if (rotate == Rotate.Right)
                {
                    currentFront = Face.White;
                    currentBottom = Face.Green;
                }
                else if (rotate == Rotate.Left)
                {
                    currentFront = Face.Yellow;
                    currentBottom = Face.Green;
                }
                else if (rotate == Rotate.Up)
                {
                    currentFront = Face.Blue;
                    currentBottom = Face.Orange;
                }
                else if (rotate == Rotate.Down)
                {
                    currentFront = Face.Green;
                    currentBottom = Face.Red;
                }
            }
            else if (currentBottom == Face.White)
            {
                if (rotate == Rotate.Right)
                {
                    currentFront = Face.Blue;
                    currentBottom = Face.White;
                }
                else if (rotate == Rotate.Left)
                {
                    currentFront = Face.Green;
                    currentBottom = Face.White;
                }
                else if (rotate == Rotate.Up)
                {
                    currentFront = Face.Yellow;
                    currentBottom = Face.Orange;
                }
                else if (rotate == Rotate.Down)
                {
                    currentFront = Face.White;
                    currentBottom = Face.Red;
                }
            }
            else if (currentBottom == Face.Blue)
            {
                if (rotate == Rotate.Right)
                {
                    currentFront = Face.Yellow;
                    currentBottom = Face.Blue;
                }
                else if (rotate == Rotate.Left)
                {
                    currentFront = Face.White;
                    currentBottom = Face.Blue;
                }
                else if (rotate == Rotate.Up)
                {
                    currentFront = Face.Green;
                    currentBottom = Face.Orange;
                }
                else if (rotate == Rotate.Down)
                {
                    currentFront = Face.Blue;
                    currentBottom = Face.Red;
                }
            }
        }
        else if (currentFront == Face.White)
        {
            if (currentBottom == Face.Green)
            {
                if (rotate == Rotate.Right)
                {
                    currentFront = Face.Red;
                    currentBottom = Face.Green;
                }
                else if (rotate == Rotate.Left)
                {
                    currentFront = Face.Orange;
                    currentBottom = Face.Green;
                }
                else if (rotate == Rotate.Up)
                {
                    currentFront = Face.Blue;
                    currentBottom = Face.White;
                }
                else if (rotate == Rotate.Down)
                {
                    currentFront = Face.Green;
                    currentBottom = Face.Yellow;
                }
            }
            else if (currentBottom == Face.Red)
            {
                if (rotate == Rotate.Right)
                {
                    currentFront = Face.Blue;
                    currentBottom = Face.Red;
                }
                else if (rotate == Rotate.Left)
                {
                    currentFront = Face.Green;
                    currentBottom = Face.Red;
                }
                else if (rotate == Rotate.Up)
                {
                    currentFront = Face.Orange;
                    currentBottom = Face.White;
                }
                else if (rotate == Rotate.Down)
                {
                    currentFront = Face.Red;
                    currentBottom = Face.Yellow;
                }
            }
            else if (currentBottom == Face.Blue)
            {
                if (rotate == Rotate.Right)
                {
                    currentFront = Face.Orange;
                    currentBottom = Face.Blue;
                }
                else if (rotate == Rotate.Left)
                {
                    currentFront = Face.Red;
                    currentBottom = Face.Blue;
                }
                else if (rotate == Rotate.Up)
                {
                    currentFront = Face.Green;
                    currentBottom = Face.White;
                }
                else if (rotate == Rotate.Down)
                {
                    currentFront = Face.Blue;
                    currentBottom = Face.Yellow;
                }
            }
            else if (currentBottom == Face.Orange)
            {
                if (rotate == Rotate.Right)
                {
                    currentFront = Face.Green;
                    currentBottom = Face.Orange;
                }
                else if (rotate == Rotate.Left)
                {
                    currentFront = Face.Blue;
                    currentBottom = Face.Orange;
                }
                else if (rotate == Rotate.Up)
                {
                    currentFront = Face.Red;
                    currentBottom = Face.White;
                }
                else if (rotate == Rotate.Down)
                {
                    currentFront = Face.Orange;
                    currentBottom = Face.Yellow;
                }
            }
        }
        else if (currentFront == Face.Yellow)
        {
            if (currentBottom == Face.Blue)
            {
                if (rotate == Rotate.Right)
                {
                    currentFront = Face.Red;
                    currentBottom = Face.Blue;
                }
                else if (rotate == Rotate.Left)
                {
                    currentFront = Face.Orange;
                    currentBottom = Face.Blue;
                }
                else if (rotate == Rotate.Up)
                {
                    currentFront = Face.Green;
                    currentBottom = Face.Yellow;
                }
                else if (rotate == Rotate.Down)
                {
                    currentFront = Face.Blue;
                    currentBottom = Face.White;
                }
            }
            else if (currentBottom == Face.Red)
            {
                if (rotate == Rotate.Right)
                {
                    currentFront = Face.Green;
                    currentBottom = Face.Red;
                }
                else if (rotate == Rotate.Left)
                {
                    currentFront = Face.Blue;
                    currentBottom = Face.Red;
                }
                else if (rotate == Rotate.Up)
                {
                    currentFront = Face.Orange;
                    currentBottom = Face.Yellow;
                }
                else if (rotate == Rotate.Down)
                {
                    currentFront = Face.Red;
                    currentBottom = Face.White;
                }
            }
            else if (currentBottom == Face.Green)
            {
                if (rotate == Rotate.Right)
                {
                    currentFront = Face.Orange;
                    currentBottom = Face.Green;
                }
                else if (rotate == Rotate.Left)
                {
                    currentFront = Face.Red;
                    currentBottom = Face.Green;
                }
                else if (rotate == Rotate.Up)
                {
                    currentFront = Face.Blue;
                    currentBottom = Face.Yellow;
                }
                else if (rotate == Rotate.Down)
                {
                    currentFront = Face.Green;
                    currentBottom = Face.White;
                }
            }
            else if (currentBottom == Face.Orange)
            {
                if (rotate == Rotate.Right)
                {
                    currentFront = Face.Blue;
                    currentBottom = Face.Orange;
                }
                else if (rotate == Rotate.Left)
                {
                    currentFront = Face.Green;
                    currentBottom = Face.Orange;
                }
                else if (rotate == Rotate.Up)
                {
                    currentFront = Face.Red;
                    currentBottom = Face.Yellow;
                }
                else if (rotate == Rotate.Down)
                {
                    currentFront = Face.Orange;
                    currentBottom = Face.White;
                }
            }
        }
    }

    IEnumerator LateStart(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        isInitiation = false;
    }

    IEnumerator EndDelay(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        introUI.SetActive(true);
        introAnim.SetBool("gameWin", true);
        StartCoroutine(NextLevel(4.1f));
    }

    IEnumerator NextLevel (float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        if (SceneManager.GetActiveScene().name == "Level_3")
            SceneManager.LoadScene("Home");
        else
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}

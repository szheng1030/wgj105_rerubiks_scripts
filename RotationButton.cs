using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationButton : MonoBehaviour
{
    public enum Rotation
    {
        Right,
        Left,
        Up,
        Down,
    }

    public Rotation rotation;

    public void Click()
    {
        switch (rotation)
        {
            case Rotation.Right: Cube.rotation = Cube.Rotation.Right;
                {
                    GM.UpdateFace(GM.Rotate.Right);
                    break;
                }
            case Rotation.Left: Cube.rotation = Cube.Rotation.Left;
                {
                    GM.UpdateFace(GM.Rotate.Left);
                    break;
                }
            case Rotation.Up: Cube.rotation = Cube.Rotation.Up;
                {
                    GM.UpdateFace(GM.Rotate.Down);
                    GM.UDRotateCount--;
                    if (GM.UDRotateCount == -1)
                        GM.UDRotateCount = 3;
                    break;
                }
            case Rotation.Down: Cube.rotation = Cube.Rotation.Down;
                {
                    GM.UpdateFace(GM.Rotate.Up);
                    GM.UDRotateCount++;
                    if (GM.UDRotateCount == 4)
                        GM.UDRotateCount = 0;
                    break;
                }
        }
    }
}

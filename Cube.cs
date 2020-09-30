using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public enum Rotation
    {
        Right,
        Left,
        Up,
        Down,
        None,
    }

    private Quaternion startAngle;

    public static Rotation rotation = Rotation.None;

    public float speed;

    void Start()
    {
        startAngle = transform.rotation;
    }

    void Update()
    {
        if (rotation == Rotation.Right)
        {
            StopAllCoroutines();
            StartCoroutine(Rotate(Rotation.Right));
            rotation = Rotation.None;
        }
        else if (rotation == Rotation.Left)
        {
            StopAllCoroutines();
            StartCoroutine(Rotate(Rotation.Left));
            rotation = Rotation.None;
        }
        else if (rotation == Rotation.Up)
        {
            StopAllCoroutines();
            StartCoroutine(Rotate(Rotation.Up));
            rotation = Rotation.None;
        }
        else if (rotation == Rotation.Down)
        {
            StopAllCoroutines();
            StartCoroutine(Rotate(Rotation.Down));
            rotation = Rotation.None;
        }
    }


    public IEnumerator Rotate(Rotation rotation)
    {
        Quaternion endAngle = Quaternion.Euler(0, 0, 0);

        switch (rotation)
        {
            case Rotation.Right: endAngle = Quaternion.Euler(0, 90, 0) * startAngle;
                break;
            case Rotation.Left: endAngle = Quaternion.Euler(0, -90, 0) * startAngle;
                break;
            case Rotation.Up: endAngle = Quaternion.Euler(90, 0, 0) * startAngle;
                break;
            case Rotation.Down: endAngle = Quaternion.Euler(-90, 0, 0) * startAngle;
                break;
        }

        startAngle = endAngle;

        while (transform.rotation != endAngle)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, endAngle, Time.deltaTime * speed);
            yield return 0;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Home_Panel : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(DisableUI(3.1f));
    }

    IEnumerator DisableUI(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        gameObject.SetActive(false);
    }
}

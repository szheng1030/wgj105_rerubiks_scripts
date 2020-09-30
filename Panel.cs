using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panel: MonoBehaviour
{
    // Start is called before the first frame update
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

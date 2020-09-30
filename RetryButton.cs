using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryButton : MonoBehaviour
{
    public Animator anim;
    public GameObject panel;

    public void Click()
    {
        StartCoroutine(FadeDelay(0.3f));
    }

    IEnumerator FadeDelay(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        panel.SetActive(true);
        anim.SetBool("Fade", true);
        StartCoroutine(SceneChangeDelay(1.1f));
    }

    IEnumerator SceneChangeDelay(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public GameObject panel;
    public Animator anim;

    public void Click()
    {
        panel.SetActive(true);
        anim.SetBool("Fade", true);
        StartCoroutine(StartDelay(1.1f));
    }

    IEnumerator StartDelay(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        SceneManager.LoadScene("Level_1");
    }
}

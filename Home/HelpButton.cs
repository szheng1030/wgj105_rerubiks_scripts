using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpButton : MonoBehaviour
{
    public Animator anim;

    public void Click()
    {
        if (!anim.GetBool("Help"))
            anim.SetBool("Help", true);
        else
            anim.SetBool("Help", false);
    }
}

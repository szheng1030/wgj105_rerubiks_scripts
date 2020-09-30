using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuIcon : MonoBehaviour
{
    private bool menuOpen = false;

    public Animator iconAnim;
    public Animator menuAnim;

    public void Click()
    {
        if (!menuOpen)
        {
            iconAnim.SetBool("menuOpen", true);
            menuAnim.SetBool("menuOpen", true);
            menuOpen = true;
        }
        else if(menuOpen)
        {
            iconAnim.SetBool("menuOpen", false);
            menuAnim.SetBool("menuOpen", false);
            menuOpen = false;
        }
    }
}

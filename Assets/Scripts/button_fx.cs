using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button_fx : MonoBehaviour
{
    public AudioSource click_fx;

    public void ClickSound()
    {
        click_fx.Play();
    }
}

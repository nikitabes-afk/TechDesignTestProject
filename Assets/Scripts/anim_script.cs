using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anim_script : MonoBehaviour
{
    public GameObject click_object;

    private Animator anim;

    public AudioSource soundPlay;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        bool movement = false;

        if (Input.GetMouseButtonDown(0))
        {
            Vector3 wp = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            PolygonCollider2D coll = click_object.GetComponent<PolygonCollider2D>();

            if(coll.OverlapPoint(wp)) 
            {
                movement = true;
            }

            anim.SetBool("Click", movement);

            if(movement)
                PlayThisSoundEffect();
        }
    }


    public void PlayThisSoundEffect()
    {
        soundPlay.Play();
    }
}

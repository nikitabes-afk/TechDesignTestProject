using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sounds_click : MonoBehaviour
{
    public GameObject cat;
    public AudioSource soundPlay;

    void Start()
    {
    }

    void Update()
    {
        bool movement = false;

        if (Input.GetMouseButtonDown(0))
        {
            Vector3 wp = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            PolygonCollider2D coll = cat.GetComponent<PolygonCollider2D>();

            if (coll.OverlapPoint(wp))
            {
                movement = true;
            }

            if (movement)
                PlayThisSoundEffect();
        }
    }


    public void PlayThisSoundEffect()
    {
        soundPlay.Play();
    }
}

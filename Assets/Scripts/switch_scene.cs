using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class switch_scene : MonoBehaviour
{
    public int scene;
    public void changeScene()
    {
        SceneManager.LoadScene(scene);
    }
}

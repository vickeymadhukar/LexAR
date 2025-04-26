using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneloader : MonoBehaviour
{
    public void scenechanger(Scene s)
    {
        // Load the scene based on the scene name or index
        SceneManager.LoadScene(s.name);
    }
}

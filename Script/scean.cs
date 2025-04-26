using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scean : MonoBehaviour
{
    public string namee;
  public void loadscean(string namee)
    {
        SceneManager.LoadScene(namee);
    }
}

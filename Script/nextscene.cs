using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class nextscene : MonoBehaviour
{
    public string scenename;

    public void jumptonext(string sceneNam) 
    {
        sceneNam = scenename;
        SceneManager.LoadScene(sceneNam);    
            
    }


}

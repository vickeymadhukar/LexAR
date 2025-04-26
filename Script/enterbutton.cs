using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enterbutton : MonoBehaviour
{
    
    [SerializeField]
    GameObject mainmenu;

    public void mainP()
    {
        mainmenu.SetActive(true);
    }
}

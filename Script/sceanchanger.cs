using UnityEngine;
using UnityEngine.SceneManagement;

public class sceanchanger : MonoBehaviour
{
    public GameObject[] canvases; // All canvases in the current scene
    public string targetScene; // Scene to load when this button is clicked

    public void ChangeScene()
    {
        // Save the currently active canvas name
        foreach (GameObject canvas in canvases)
        {
            if (canvas.activeSelf)
            {
                PlayerPrefs.SetString("ActiveCanvas", canvas.name); // Save active canvas
                break;
            }
        }

        // Save the name of the target scene
        PlayerPrefs.SetString("PreviousScene", SceneManager.GetActiveScene().name);

        // Load the target scene
        SceneManager.LoadScene(targetScene);
    }
}

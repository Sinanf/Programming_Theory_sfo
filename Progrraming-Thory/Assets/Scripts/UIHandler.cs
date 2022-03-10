using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public abstract class UIHandler : MonoBehaviour
{
    // Load the main menu scene
    public virtual void GoToMenu()
    {
        SceneManager.LoadScene(0);
    }

    // Load the top score scene
    public virtual void GoToScene()
    {
        SceneManager.LoadScene(1);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Escape_Button : MonoBehaviour
{
    public Object SceneToLoad;

    public void OnClick_EscapeScene()
    {
        SceneManager.LoadScene(SceneToLoad.name);
    }

}

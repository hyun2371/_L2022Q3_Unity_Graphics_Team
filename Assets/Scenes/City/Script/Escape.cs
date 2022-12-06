using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Escape : MonoBehaviour
{
    public Object SceneToLoad;
    public Text TextComponent;
    public InputField InputFieldComponent;

    public void OnClick_EscapeScene()
    {
        //SceneManager.LoadScene(SceneToLoad.name);
        //print("Hello");

        TextComponent.text = InputFieldComponent.text;

    }
}

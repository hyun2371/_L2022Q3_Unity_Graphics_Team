using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject EndPanel;


    public void EndGame()
    {
        Debug.Log("Game Over");
        GameObject.Find("Turret").SetActive(false);
        EndPanel.SetActive(true);
        Invoke("Restart", 5f);

    }

    void Restart()
    {
        SceneManager.LoadScene("Dungeon");
    }
}

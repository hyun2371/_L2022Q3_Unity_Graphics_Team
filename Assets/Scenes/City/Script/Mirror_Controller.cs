using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Mirror_Controller : MonoBehaviour
{

    public GameObject text;
    public GameObject button;


    //isTrigger에 체크했으면 이 함수 써야함
    private void OnTriggerEnter(Collider other)
    {


        //UI text 표시
        text.SetActive(true);
        button.SetActive(true);

        //move Scene
        //SceneManager.LoadScene(SceneToLoad.name);
    }

    //collider에서 나간거 감지
    private void OnTriggerExit(Collider other)
    {
        text.SetActive(false);
        button.SetActive(false);

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Mirror_Controller : MonoBehaviour
{

    public GameObject alert;
    //public Object SceneToLoad;


    //isTrigger에 체크했으면 이 함수 써야함
    private void OnTriggerEnter(Collider other)
    {


        //UI text 표시
        alert.SetActive(true);

        //move Scene
        //SceneManager.LoadScene(SceneToLoad.name);
    }

    //collider에서 나간거 감지
    private void OnTriggerExit(Collider other)
    {
        alert.SetActive(false);

    }
}

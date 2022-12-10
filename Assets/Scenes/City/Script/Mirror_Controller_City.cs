using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Mirror_Controller_City : MonoBehaviour
{
    public Object SceneToLoad;
    public GameObject obstacle;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            SceneManager.LoadScene(SceneToLoad.name);
        }
    }
    //private void Update()
    //{
    //    int jewelCount = GameObject.Find("JewelText").GetComponent<ManageJewelCount>().jewelCount;
    //    print(jewelCount);
    //    if (jewelCount==2&& obstacle!=null)
    //    {
    //        obstacle.SetActive(false);
    //        Destroy(obstacle);
    //    }
    //}


    //isTrigger에 체크했으면 이 함수 써야함
    //private void OnTriggerEnter(Collider other)
    //{


    //    //UI text 표시
    //    //alert.SetActive(true);

    //    //move Scene
    //    SceneManager.LoadScene(SceneToLoad.name);
    //}

    ////collider에서 나간거 감지
    //private void OnTriggerExit(Collider other)
    //{
    //    //alert.SetActive(false);

    //}
}

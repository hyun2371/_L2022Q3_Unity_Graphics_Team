using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Mirror_Controller : MonoBehaviour
{
    public GameObject Pivot;

    public Object SceneToLoad;

    //private void OnMouseDown()
    //{
    //    //SceneManager.LoadScene("LoadSceneTest02");
    //    //열고싶은 씬 지정
    //    SceneManager.LoadScene(SceneToLoad.name);
    //}

    //isTrigger에 체크했으면 이 함수 써야함
    private void OnTriggerEnter(Collider other)
    {
        //Pivot.GetComponent<Animator>().SetInteger("State", 1);


        //UI text 표시

        //move Scene
        SceneManager.LoadScene(SceneToLoad.name);
    }

    //collider에서 나간거 감지
    private void OnTriggerExit(Collider other)
    {
        //Pivot.GetComponent<Animator>().SetInteger("State", 2);


    }
}

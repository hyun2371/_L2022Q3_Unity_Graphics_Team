using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mirror_Controller_Dungeon : MonoBehaviour
{
    public Object SceneToLoad;

    public GameObject text;

    //isTrigger에 체크했으면 이 함수 써야함
    private void OnTriggerEnter(Collider other)
    {
        //Pivot.GetComponent<Animator>().SetInteger("State", 1);


        //UI text 표시
        text.SetActive(true);

        //move Scene
        //SceneManager.LoadScene(SceneToLoad.name);
    }

    //collider에서 나간거 감지
    private void OnTriggerExit(Collider other)
    {
        //Pivot.GetComponent<Animator>().SetInteger("State", 2);
        text.SetActive(false);


    }
}

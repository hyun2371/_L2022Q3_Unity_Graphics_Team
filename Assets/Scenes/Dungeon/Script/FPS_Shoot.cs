using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPS_Shoot : MonoBehaviour
{
    public GameObject BulletPrefab; //inspector���� prefab�� drap drop
    public int bulletSpeed = 3000;
    AudioSource Audio;
    public AudioClip ShootSound,ShotSound;
    public GameObject ShootParticle;


    // Start is called before the first frame update
    void Start()
    {
        Audio = GameObject.Find("FPS").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //���� ���콺 ��ư�� ������
        {
            print("shoot");
            GameObject Bullet = InstantiateBullet(); //�Ѿ� ����

            Bullet.GetComponent<Rigidbody>().AddForce(Bullet.transform.forward * bulletSpeed); //�ش� �������� ���� ���� ������ 
            Destroy(Bullet, 2f);

            InstantiateParticle(ShootParticle);
                

        }

    }

    GameObject InstantiateBullet()
    {
        GameObject Shooter = gameObject; //���� ��ũ��Ʈ�� �Ҵ�Ǵ� object
        Vector3 ClonePos = Shooter.transform.position + Shooter.transform.forward * 1.4f ; //��ġ ����
        Quaternion CloneRot = Shooter.transform.rotation;  //��� ������ �ٶ󺸰� �ִ���
        GameObject Clone = Instantiate(BulletPrefab, ClonePos, CloneRot);

        return Clone;
    }

    void InstantiateParticle(GameObject Particle)
    {
        GameObject Shooter = GameObject.FindGameObjectWithTag("MainCamera");
        Vector3 ClonePos = Shooter.transform.position + Shooter.transform.forward * 0.6f + Shooter.transform.up * 1.8f;
        Quaternion CloneRot = Shooter.transform.rotation;
        GameObject Clone = Instantiate(Particle, ClonePos, CloneRot);
        Clone.transform.localScale = Vector3.one * 0.3f;  // particle ũ�� 0.5���� ����
        Destroy(Clone, 2f);


    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bullet")
        {
            PlayClip(ShotSound);
            print("Player hit");
            GameObject.Find("FPSController").GetComponent<ManageLife>().getShot();

        }
    }

    void PlayClip(AudioClip clip)
    {
        Audio.clip = clip;
        Audio.Play();
    }
}
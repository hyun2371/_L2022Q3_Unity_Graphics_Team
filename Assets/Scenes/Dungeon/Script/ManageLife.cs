using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageLife : MonoBehaviour
{
    private float MaxHealth = 10;
    public float CurrentHealth;
    private float PotionEffect = 5;
    public HealthBar healthBar;
    void Start()
    {
        CurrentHealth = MaxHealth;
        healthBar.SetMaxHealth(MaxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if (CurrentHealth <= 0)
        {
            GameObject.Find("GameManager").GetComponent<GameManager>().EndGame();
        }
    }
    public void DrinkPotion()
    {
        print("got potion");
        if (CurrentHealth + PotionEffect > MaxHealth)
        {
            healthBar.SetHealth(MaxHealth);
        }
        else
        {
            CurrentHealth += PotionEffect;
            healthBar.SetHealth(CurrentHealth);
        }
    }

    public void getShot()
    {
        CurrentHealth--;
        healthBar.SetHealth(CurrentHealth);
    }


}

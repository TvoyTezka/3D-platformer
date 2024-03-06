using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public int health = 10;
    public AudioSource audioSource;
    public AudioClip damageSound;

    public GameObject fireballPrefab;
    public Transform attackPoint;

    public int coins = 0;
    
    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health>0)
        {
            audioSource.PlayOneShot(damageSound);
            print("Здоровье игрока: " + health);
        }
        else
        {
            int sceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(sceneIndex);
        }
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(fireballPrefab, attackPoint.position, attackPoint.rotation);
        }
    }

    public void CollectCoins()
    {
        coins ++;
    }
 }

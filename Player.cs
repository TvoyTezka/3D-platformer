using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    //Максимальное здоровье игрока
    public int maxHealth = 10;
    //Текущее здоровбе игрока
    public int health = 10;

    //Компонент воспроизведения звука
    public AudioSource audioSource;
    //Компонент, где хранится звуковой файл
    public AudioClip damageSound;

    //Префаб огненного шара и место его появления (attackpoint)
    public GameObject fireballPrefab;
    public Transform attackPoint;

    //Число собранных монеток
    public int coins = 0;
    
    //Новый метод, который обрабатывает наносимый урон по игроку
    public void TakeDamage(int damage)
    {
        //Вычитать из здоровья дамаг
        health -= damage;
        
        //Если здоровье ещё есть, то:
        if (health>0)
        {
            //Проигрывать звук удара по игроку
            audioSource.PlayOneShot(damageSound);
            print("Здоровье игрока: " + health);
        }
        //Если здоровья нет, то:
        else
        {
            //Перезагружать текущую сцену
            int sceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(sceneIndex);
        }
    }

    //Действия на каждом кадре:
    private void Update()
    {
        //Если игрок нажал на левую кнопку мыши, то:
        if (Input.GetMouseButtonDown(0))
        {
            //Создать копию огненного шара и выпустить её
            Instantiate(fireballPrefab, attackPoint.position, attackPoint.rotation);
        }
    }

    //Новый метод для увеличения количества монеток
    public void CollectCoins()
    {
        coins ++;
    }
 }

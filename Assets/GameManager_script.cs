
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager_script : MonoBehaviour
{
    // Using static to make sure the game has only copy //
    public static GameManager_script instance;

    // Variable to store the health //
    public int health;


    // Reference to the UI //
    public TextMeshProUGUI scoreText;

    // Reference to the audio //
    public AudioSource audioSource;

    // Reference of the AudioClip//
    public AudioClip[] healSoundArr;

    // Reference for the BGM1 , 2//
    public AudioClip BGM1;
    public AudioClip BGM2;
    public AudioClip healLong;

    // Start is called before the first frame update
    void Start()
    {
        // store this class into the instance variable //
        instance = this;

        // Start health with 100 //
        health = 100;

        // Display the current health onto the screen //
        scoreText.text = "Health: " + this.health;
    }

    // Create a function to add health //
    public void AddHealth(int _health, bool playSound = true)
    {
        this.health += _health;
        print("this.health: " + this.health);
        scoreText.text = "Health: " + this.health;

        if (playSound)
        {
            audioSource.PlayOneShot(healSoundArr[Random.Range(0, healSoundArr.Length)]);
        }
    }


    public void PlayBGM1()
    {
        audioSource.clip = BGM1;
        audioSource.Play();
    }

    public void PlayBGM2()
    {
        audioSource.clip = BGM2;
        audioSource.Play();
    }

        public void PlayhealLong()
    {
        audioSource.clip = healLong;
        audioSource.Play();
    }
}

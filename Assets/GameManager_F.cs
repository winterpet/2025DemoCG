using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager_F : MonoBehaviour
{
    // Using static to make sure the game has only copy //
    public static GameManager_F instance;

    // Variable to store the health //
    private int health;

    // Reference to the UI //
    public TextMeshProUGUI scoreText;

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
    public void AddHealth(int _health) 
    {
        // Add health //
        this.health += _health;

        // Display the current health onto the console //
        print("this.health: " + this.health);

        // Display the current health onto the screen //
        scoreText.text = "Health: " + this.health;
    }
}

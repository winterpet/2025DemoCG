using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager_script : MonoBehaviour
{

    // using static to make sure the game has only one copy //
    public static GameManager_script instance;

    // vARIABLE TO STore the health //
    private int health;

    public TextMeshProUGUI scoreText;

    // Start is called before the first frame update
    void Start()
    {
        // store this class into the instancce variable //
        instance = this;

        health = 100;

        scoreText.text = "Score: " + this.health;
    }



    public void AddHealth(int _health)
    {
        this.health += _health;

        print("this.health: " + this.health);

        scoreText.text = "Score: " + this.health;
    }
}

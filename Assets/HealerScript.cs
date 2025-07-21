using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealerScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Just wanna test adding health by pressing 'H' Key //
        if (Input.GetKeyDown(KeyCode.H)) 
        {
            // Call the gamemanager to add health //
            GameManager_F.instance.AddHealth(10);
        }
    }

    // Write some code for the Healer to detect that 
    // It touches the player
    private void OnCollisionEnter(Collision collision)
    {
        // Make sure This healer touches player //
        if (collision.gameObject.tag.Equals("Player")) 
        {
            print("Touched player!");

            // Now we can add the health of the player!! //
            // Call the gamemanager to add health //
            GameManager_F.instance.AddHealth(10);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    // detect player entering the area //
    private void OnTriggerEnter(Collider other)
    {
        // Make sure the PLAYER is in the trigger box //
        if (other.gameObject.tag.Equals("Player"))
        {
            print("Player in");
            GameManager_script.instance.PlayBGM2();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Make sure the PLAYER is in the trigger box //
        if (other.gameObject.tag.Equals("Player"))
        {
            print("Player out");
            GameManager_script.instance.PlayBGM1();
        }
    }
}

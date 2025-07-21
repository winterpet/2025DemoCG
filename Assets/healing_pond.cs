using UnityEngine;

public class healing_pond : MonoBehaviour
{
    public GameManager_script playerStats;
    private bool playerInZone = false;
    private float healTimer = 0f;
    public float healCooldown = 3f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player in healing pond");

            GameManager_script.instance.audioSource.Stop();
            GameManager_script.instance.PlayhealLong();

            playerInZone = true;
            healTimer = 0f;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player left healing pond");

            playerInZone = false;
            healTimer = 0f;
            GameManager_script.instance.PlayBGM1();

        }
    }

    private void Update()
    {
        if (playerInZone)
        {
            healTimer += Time.deltaTime;

            if (healTimer >= healCooldown)
            {
                if (playerStats.health < 200)
                {
                    // Heal without triggering extra sound
                    GameManager_script.instance.AddHealth(1, false);
                    Debug.Log("Healed 10 HP");
                }
                else
                {
                    Debug.Log("Health is already at maximum!");
                }

                healTimer = 0f;
            }
        }
    }
}

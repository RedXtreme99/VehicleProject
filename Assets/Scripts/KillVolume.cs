using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillVolume : MonoBehaviour
{
    UIController uIController = null;

    private void Awake()
    {
        uIController = FindObjectOfType<UIController>();
    }

    private void OnTriggerEnter(Collider other)
    {
        // Turn off game object that enters
        // other.gameObject.SetActive(false);
        PlayerController playerController = other.GetComponent<PlayerController>();
        if (playerController != null)
        {
            playerController.Die();
        }

        if (uIController != null)
        {
            uIController.ShowWinText("You Died!\nPress backspace to restart");
        }
    }
}

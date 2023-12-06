using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class OpenShopUi : MonoBehaviour
{

    public GameObject shopPanel;
    private bool playerOnRange;

    private void OnInteract(InputValue inputValue)
    {
        if (playerOnRange && inputValue.isPressed)
        {
            shopPanel.SetActive(true);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision != null)
        {
            playerOnRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        playerOnRange = false;
        shopPanel.SetActive(false);
    }


}

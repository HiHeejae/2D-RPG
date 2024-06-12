using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private GameObject playerObj;

    void Update()
    {
        if (playerObj == null)
        {
            playerObj = GameObject.FindGameObjectWithTag("Player");
        }
        transform.position = new Vector3(playerObj.transform.position.x, playerObj.transform.position.y, transform.position.z);
    }
}

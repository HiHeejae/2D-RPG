using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    private GameObject playerObj;
    private float distance;


    private void Update()
    {
        if (playerObj == null) playerObj = GameManager.Instance.player;
        if (playerObj == null) return;

        distance = Vector2.Distance(transform.position, playerObj.transform.position);
        Debug.Log($"distance : {distance}");
    }
}

using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{
    public Image CharacterImg;
    public Text IdText;

    public Slider HPSlider;

    public GameObject player;
    public GameObject spawnPos;

    private void Start()
    {
        IdText.text = GameManager.Instance.UserID;
        player = GameManager.Instance.SpawnPlayer(spawnPos.transform);
    }

    private void Display()
    {
        CharacterImg.sprite = player.GetComponent<SpriteRenderer>().sprite;
        HPSlider.value = GameManager.Instance.PlayerHP;
    }

    private void Update()
    {
        Display();
    }
}

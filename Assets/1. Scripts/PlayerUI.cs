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

    private GameObject player;
    public GameObject spawnPos;
    public Text GoldText;

    public Text monsterTxt;

    public int monsterCount;

    void Start()
    {
        IdText.text = GameManager.Instance.UserID;
        player = GameManager.Instance.SpawnPlayer(spawnPos.transform);
        monsterTxt.text = $"남은 몬스터 수 : {monsterCount}마리";
    }

    void Update()
    {
        display();
        GoldText.text =  $"{GameManager.Instance.Coin}";
        monsterTxt.text = $"남은 몬스터 수 : {monsterCount}마리";
    }
    
    
    private void display()
    {
        CharacterImg.sprite = player.GetComponent<SpriteRenderer>().sprite;
        HPSlider.value = GameManager.Instance.PlayerHP;
    }

    public static PlayerUI Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }


}

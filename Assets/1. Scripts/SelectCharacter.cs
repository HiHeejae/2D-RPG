
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SelectCharacter : MonoBehaviour
{
    [Header("Infor")]
    public Text NameTxt;
    public Text FeatureTxt;
    public Image CharImage;

    [Header("Character")]
    public GameObject[] Character; //Warrior, Archer, Mage
    public CharacterInfo[] CharacterInfos;
    private int charIndex = 0;

    [Header("GameStart")]
    public GameObject GameStart;
    public Text GameCountTxt;
    private bool isPlayButtonClicked = false;
    private float gameCount = 3f;

    //public static string CharacterName;

    private void Update()
    {
        if (isPlayButtonClicked)
        {
            gameCount -= Time.deltaTime;
            if (gameCount <= 0)
            {
                SceneManager.LoadScene("MainScene");
            }
            GameCountTxt.text = $"곧 게임이 시작됩니다. \n {gameCount:F1}";
        }
    }

    public void PlayBtn()
    {
        GameStart.SetActive(true);
        isPlayButtonClicked = true;
        Define.Player player = (Define.Player)Enum.Parse(typeof(Define.Player), Character[charIndex].name);
        GameManager.Instance.SelectedPlayer = player;

    }


    private void Start()
    {
        SetPanelInfo();
    }

    public void SelectCharacterBtn(string btnName)
    {
        Character[charIndex].SetActive(false);

        if (btnName == "Next")
        {
            charIndex++;
            charIndex = charIndex % Character.Length;
        }

        if (btnName == "Prev")
        {
            charIndex--;
            charIndex = charIndex % Character.Length;
            charIndex = charIndex < 0 ? charIndex + Character.Length : charIndex;
        }

        Debug.Log($"CharIndex : {charIndex}");
        Character[charIndex].SetActive(true);
        SetPanelInfo();

    }
    private void SetPanelInfo()
    {
        NameTxt.text = CharacterInfos[charIndex].Name;
        FeatureTxt.text = CharacterInfos[charIndex].Feature;
        CharImage.sprite = Character[charIndex].GetComponent<SpriteRenderer>().sprite;
    }

}

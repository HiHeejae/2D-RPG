using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartManager : MonoBehaviour
{
    [Header("Membership")]
    public GameObject MembershipUI;
    public InputField MembershipID;
    public InputField MembershipPW;
    public InputField MembershipFind;

    [Header("Login")]
    public GameObject LoginUI;
    public InputField LoginID;
    public InputField LoginPW;

    [Header("Find")]
    public GameObject FindUI;
    public InputField FindFind;

    [Header("ErrorMessage")]
    public GameObject ErrorUI;
    public Text ErrorMessage;

    public void MemberShipBtn()
    {
        PlayerPrefs.SetString("ID", MembershipID.text);
        PlayerPrefs.SetString("PW", MembershipID.text);
        PlayerPrefs.SetString("FIND", MembershipID.text);

        MembershipUI.SetActive(false);
    }

    public void LoginBtn()
    {
        if (PlayerPrefs.GetString("ID") != LoginID.text)
        {
            LoginUI.SetActive(false);
            LoginUI.SetActive(true);
            ErrorMessage.text = "아이디가 일치하지 않습니다.";
            Invoke("ErrorMessageExit", 3f);
            return;
        }
        if (PlayerPrefs.GetString("PW") != LoginPW.text)
        {
            LoginUI.SetActive(false);
            ErrorUI.SetActive(true);
            ErrorMessage.text = "비밀번호가 일치하지 않습니다.";
            Invoke("ErrorMessageExit", 3f);
            return;

        }
        SceneManager.LoadScene("SelectScene");
    }

    void ErrorMessageExit()
    {
        ErrorUI.SetActive(false);
    }


    public void FindBtn()
    {
        FindUI.SetActive(false);
        ErrorUI.SetActive(true);
        if (PlayerPrefs.GetString("FIND") == FindFind.text)
        {
            ErrorMessage.text = $"ID : {PlayerPrefs.GetString("ID")}\nPW : {PlayerPrefs.GetString("PW")}";
        }
        else
        {
            ErrorMessage.text = " 잘못된 힌트입니다.";
        }
        Invoke("ErrorMessageExit", 3f);
    }

        private void Update()
        {
            Debug.Log("ID : " + PlayerPrefs.GetString("ID"));
            Debug.Log("PW : " + PlayerPrefs.GetString("PW"));
            Debug.Log("FIND : " + PlayerPrefs.GetString("FIND"));
        }
    } 

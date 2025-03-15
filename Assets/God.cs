using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class God : MonoBehaviour
{
    public string description;
    public Texture icon;
    public string name;
    public int prayers;
    public float happiness = 1;
    public string mainPunish;
    public string mainBoon;

    Button btn, pray;
    GameObject focus;

    private void Start()
    {
        btn = GetComponent<Button>();
        btn.onClick.AddListener(showGod);
        focus = GameObject.Find("GodFocus");
        pray = focus.transform.GetChild(5).transform.GetComponent<Button>();
        pray.onClick.AddListener(updatePrayers);
        focus.SetActive(false);
    }


    public void showGod() 
    {
        prayers = 0;
        focus.transform.GetChild(0).GetComponent<TMP_Text>().text = name;
        focus.transform.GetChild(1).GetComponent<TMP_Text>().text = description;
        focus.transform.GetChild(2).GetComponent<TMP_Text>().text = "Punishment: " + mainPunish;
        focus.transform.GetChild(3).GetComponent<TMP_Text>().text = "Boon: " + mainBoon;
        focus.transform.GetChild(5).GetComponent<RawImage>().texture = icon;
        focus.transform.GetChild(6).GetComponent<TMP_Text>().text = "Number of prayers: " + prayers.ToString();
        focus.SetActive(true);

        GameObject.Find("MainMenu").SetActive(false);
    }

    public void updatePrayers() 
    {
        prayers++;
        focus.transform.GetChild(6).GetComponent<TMP_Text>().text = "Number of prayers: " + prayers.ToString();
    }
}

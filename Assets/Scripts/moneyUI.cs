using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class moneyUI : MonoBehaviour
{

    public Text moneyText;

    // Update is called once per frame
    void Update()
    {
        moneyText.text = "$" + playerStats.Money.ToString();
    }
}
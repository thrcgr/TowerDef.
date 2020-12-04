using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class raundsSurvived : MonoBehaviour
{

    public Text roundsText;

    void OnEnable()
    {
        StartCoroutine(AnimateText()); //////             
    }

    IEnumerator AnimateText()
    {
        roundsText.text = "1";    /////
        int round = 1;

        yield return new WaitForSeconds(.7f);

        while (round < playerStats.Rounds)
        {
            round++;
            roundsText.text = round.ToString();

            yield return new WaitForSeconds(.05f);
        }

    }

}
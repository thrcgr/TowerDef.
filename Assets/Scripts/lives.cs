using UnityEngine;
using UnityEngine.UI;

public class lives : MonoBehaviour
{

    public Text livesText;

    // Update is called once per frame
    void Update()
    {
        livesText.text = playerStats.Lives.ToString() + " LIVES";
    }
}
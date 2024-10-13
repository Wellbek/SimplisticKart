using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownController : MonoBehaviour
{
    public int countdownTime;
    public Text[] countdownDisplay;

    private void Start()
    {
        StartCoroutine(CountdownToStart());
    }

    IEnumerator CountdownToStart()
    {
        while (countdownTime > 0)
        {
            for (int i = 0; i < countdownDisplay.Length; i++)
            {
                countdownDisplay[i].text = countdownTime.ToString();
            }

            yield return new WaitForSeconds(1f);

            countdownTime--;
        }

        for (int i = 0; i < countdownDisplay.Length; i++)
        {
            countdownDisplay[i].text = "GO!";
        }

        GameController.instance.BeginGame();

        yield return new WaitForSeconds(1f);

        for (int i = 0; i < countdownDisplay.Length; i++)
        {
            countdownDisplay[i].gameObject.SetActive(false);
        }
    }
}

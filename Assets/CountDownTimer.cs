using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CountDownTimer : MonoBehaviour
{
    private float timeValue = 600f;
    public float time = 600;
    bool count = false;

    [SerializeField] TMP_Text countDownMinute;
    [SerializeField] TMP_Text countDownSecond;
    [SerializeField] TMP_Text showUpMinute;
    [SerializeField] TMP_Text showUpSecond;
    [SerializeField] Button button;
    [SerializeField] Button showUpButton;
    [SerializeField] TMP_Text hatchText;
    [SerializeField] TMP_Text showUpText;

    void Update()
    {
        if(count == true)
        {
            if (timeValue > 0)
            {
                timeValue -= Time.deltaTime;
            }
            else
            {
                timeValue = 0;
                count = false;
            }
            DisplayTime(timeValue);
        }
        else
        {
            timeValue = time;
            float minutes = Mathf.FloorToInt(timeValue / 60);
            float seconds = Mathf.FloorToInt(timeValue % 60);

            countDownMinute.text = string.Format("{0:00}", minutes);
            countDownSecond.text = string.Format("{0:00}", seconds);
            showUpMinute.text = countDownMinute.text;
            showUpSecond.text = countDownSecond.text;
            button.image.enabled = true;
            showUpButton.image.enabled = true;
            hatchText.enabled = true;
            showUpText.enabled = true;
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        if (timeToDisplay < 0)
        {
            timeToDisplay = 0;
        }
        else
        {

            float minutes = Mathf.FloorToInt(timeToDisplay / 60);
            float seconds = Mathf.FloorToInt(timeToDisplay % 60);

            countDownMinute.text = string.Format("{0:00}", minutes);
            countDownSecond.text = string.Format("{0:00}", seconds);
            showUpMinute.text = countDownMinute.text;
            showUpSecond.text = countDownSecond.text;
            button.image.enabled = false;
            showUpButton.image.enabled = false;
            hatchText.enabled = false;
            showUpText.enabled = false;
        }
    }

    public void onButtonPressed()
    {
        count = true;
        showUpButton.image.enabled = false;
        showUpText.enabled = false;
    }
}

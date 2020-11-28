using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CreditsHandler : MonoBehaviour
{
    public TextMeshProUGUI creditsText;

    public GameObject confirmationPanel;

    public int rewardedCredits = 5;
    // Start is called before the first frame update
    void Start()
    {
        AdmobScript.instance.RequestRewardedAd();

        confirmationPanel.SetActive(false);
    }

    public void ShowRewardedAd()
    {
        AdmobScript.instance.ShowRewardedAd();

        int credits = int.Parse(creditsText.text);
        creditsText.text = (credits += rewardedCredits).ToString();

        hideConfirmationPanel();
    }

    public void showConfirmationPanel()
    {
        confirmationPanel.SetActive(true);
    }

    public void hideConfirmationPanel()
    {
        confirmationPanel.SetActive(false);
    }
}

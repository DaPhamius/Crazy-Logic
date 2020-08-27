using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
public class UnityMonetization : MonoBehaviour, IUnityAdsListener
{
    string GooglePlay_ID = "3775595";
    bool TestMode = true;
    string myPlacementId = "rewardedVideo";
    string bannerPlacementId = "banner";


    void Start()
    {
        Advertisement.AddListener(this);
        Advertisement.Initialize(GooglePlay_ID, TestMode);

        Advertisement.Banner.SetPosition(BannerPosition.BOTTOM_CENTER);
        Advertisement.Banner.Show(bannerPlacementId);
    }


    public void DisPlayInterstitialAD()
    {
        Advertisement.Show();
    }

    public void DisplayVideoAD()
    {
        Advertisement.Show(myPlacementId);
    }
    public void GiveOneHint()
    {
        int currentAmountOfHints = PlayerPrefs.GetInt("amountOfHints", 0);
        currentAmountOfHints += 1;
        PlayerPrefs.SetInt("amountOfHints", currentAmountOfHints);
        PlayerPrefs.Save();
    }
    // Implement IUnityAdsListener interface methods:
    public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
    {
        // Define conditional logic for each ad completion status:
        if (showResult == ShowResult.Finished)
        {
            GiveOneHint();
            // Reward the user for watching the ad to completion.
        }
        else if (showResult == ShowResult.Skipped)
        {
            // Do not reward the user for skipping the ad.
        }
        else if (showResult == ShowResult.Failed)
        {
            Debug.LogWarning("The ad did not finish due to an error.");
        }
    }

    public void OnUnityAdsReady(string placementId)
    {
        // If the ready Placement is rewarded, show the ad:
        if (placementId == myPlacementId)
        {
        }
    }

    public void DeleteListener()
    {
        Advertisement.RemoveListener(this);
    }
    public void OnUnityAdsDidError(string message)
    {
        // Log the error.
    }

    public void OnUnityAdsDidStart(string placementId)
    {
        // Optional actions to take when the end-users triggers an ad.
    }
}



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;
using System;
using GoogleMobileAds.Api;

public class AdmobScript : MonoBehaviour
{
    public static AdmobScript instance;

    string AppID = "ca-app-pub-7547232384749565~2701425620";

    string RewardedAdID = "ca-app-pub-3940256099942544/5224354917";

    private BannerView bannerView;
    private RewardBasedVideoAd rewardedAd;
    void Awake() //called before start
    {
        if (instance == null) //used to make sure there is no instance of GameControl started
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);//destroy gameObject this script is attached to
        }

        DontDestroyOnLoad(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        //set ads to be appropriate for children
        RequestConfiguration requestConfiguration = new RequestConfiguration.Builder()
        .SetTagForChildDirectedTreatment(TagForChildDirectedTreatment.True).SetMaxAdContentRating(MaxAdContentRating.G).build();

        MobileAds.SetRequestConfiguration(requestConfiguration);

        MobileAds.Initialize(AppID);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void RequestRewardedAd()
    {
        rewardedAd = RewardBasedVideoAd.Instance;

        // Called when an ad request has successfully loaded.
        this.rewardedAd.OnAdLoaded += HandleRewardedAdLoaded;
        // Called when an ad request failed to load.
        this.rewardedAd.OnAdFailedToLoad += HandleRewardedAdFailedToLoad;
        // Called when an ad is shown.
        this.rewardedAd.OnAdOpening += HandleRewardedAdOpening;
        // Called when the ad is closed.
        this.rewardedAd.OnAdClosed += HandleRewardedAdClosed;

        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().AddExtra("max_ad_content_rating", "G").TagForChildDirectedTreatment(true).Build();
        // Load the rewarded ad with the request.
        this.rewardedAd.LoadAd(request, RewardedAdID);
    }

    public void ShowRewardedAd()
    {
        if (this.rewardedAd.IsLoaded())
        {
            this.rewardedAd.Show();
        }
    }

    //FOR EVENTS AND DELEGATES FOR ADS
    //Rewarded Ads Events and Delegates
    public void HandleRewardedAdLoaded(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleRewardedAdLoaded event received");
    }

    public void HandleRewardedAdFailedToLoad(object sender, AdFailedToLoadEventArgs args)
    {
        MonoBehaviour.print(
            "HandleRewardedAdFailedToLoad event received with message: "
                             + args.Message);
    }


    public void HandleRewardedAdOpening(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleRewardedAdOpening event received");
    }

    public void HandleRewardedAdFailedToShow(object sender, AdErrorEventArgs args)
    {
        MonoBehaviour.print(
            "HandleRewardedAdFailedToShow event received with message: "
                             + args.Message);
    }

    public void HandleRewardedAdClosed(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleRewardedAdClosed event received");
    }

    public void HandleUserEarnedReward(object sender, Reward args)
    {
        string type = args.Type;
        double amount = args.Amount;
        MonoBehaviour.print(
            "HandleRewardedAdRewarded event received for "
                        + amount.ToString() + " " + type);
    }
}

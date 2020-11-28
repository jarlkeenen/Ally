using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    public static SceneTransition instance;

    private Animator anime;

    public float transitionTime;

    private int canvas;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        anime = GetComponent<Animator>();

        StartCoroutine(changeSortOrderAfterAnimation());
    }

    private void Update()
    {
        Debug.Log(Screen.width + "  " + Screen.height);
    }

    public void ScreenTransition(string levelName)
    {
        StartCoroutine(LoadLevel(levelName));
    }

    IEnumerator LoadLevel(string levelName)
    {
        transform.parent.GetComponent<Canvas>().sortingOrder = 3;

        anime.SetTrigger("Transition");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(levelName);
    }

    public void loadGreenhouse()
    {
        ScreenTransition("Greenhouse");
    }

    public void loadTitle()
    {
        ScreenTransition("Menu");
    }

    public void loadPlant()
    {
        ScreenTransition("End");
    }

    public void loadTutorial()
    {
        ScreenTransition("Tutorial");
    }

    public void loadMarket()
    {
        ScreenTransition("Market");
    }

    public void loadNotification()
    {
        ScreenTransition("Notification");
    }

    public void loadSettings()
    {
        ScreenTransition("Settings");
    }

    public void loadSeedInventory()
    {
        ScreenTransition("SeedInventory");
    }

    public void loadHarvestBasket()
    {
        ScreenTransition("HarvestBasket");
    }

    IEnumerator changeSortOrderAfterAnimation()
    {
        transform.parent.GetComponent<Canvas>().sortingOrder = 3;

        yield return new WaitForSeconds(transitionTime);

        transform.parent.GetComponent<Canvas>().sortingOrder = -1;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class scr : MonoBehaviour

{
    public Text TimerText;
    private float Time;
    public float TimeMax;
    public GameObject GameOverPanel;
    // Start is called before the first frame update
    void Start()
    {
        Time = TimeMax;
        StartCoroutine(Count());
        GameOverPanel.SetActive(false);
             
    }

    // Update is called once per frame
    void Update()
    {
        TimerText.text = "Time: " + (int)Time;
        //if (Time==0)
        //{ GO(); }    
    }
    IEnumerator Count()
    {
        while (Time >0f)
        {
            Time--;
            yield return new WaitForSeconds(1f);
        }    
        
    }
    void go()
    { GameOverPanel.SetActive(true); }
    void resstart()
    { SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); }
}
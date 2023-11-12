using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using DG.Tweening;

public class EndScreenBehaviour : MonoBehaviour
{
    [HideInInspector]
    public int currentLevelID;

    [HideInInspector]
    public int treasuresObtained;

    [HideInInspector]
    public float time;

    [SerializeField]
    private List<Image> treasureImages;

    [SerializeField]
    private TextMeshProUGUI timeText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowStats() 
    {
        int minutes = (int)(time / 60f);
        int seconds = (int)(time - minutes * 60);
        int milliseconds = (int)((time - (int)time) * 100f);

        timeText.text = string.Format("{0:00}:{1:00}:{2:00}", minutes, seconds, milliseconds);

        StartCoroutine(DisplayTreasures());
    }

    IEnumerator DisplayTreasures() 
    {
        for(int i = 0; i < treasuresObtained; i++) 
            {
                treasureImages[i].transform.DOScale(Vector3.one,0.3f);
            //Maybe play a sound would be nice
                yield return new WaitForSeconds(1f);
            }

    }

    
    public void RetryButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void HomeButton() 
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void NextButton() 
    {
        SceneManager.LoadScene("LevelSelector");
    }

}

using UnityEngine;
using TMPro;
using DG.Tweening;

public class CoinUI : MonoBehaviour
{
    public TextMeshProUGUI coinText;
    public Transform coinImage;
    private EventSystem eventSystem;
    private int coinAmount=0;
    public float punchScaleFactor = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        eventSystem = FindObjectOfType<EventSystem>();
        eventSystem.OnCoinPicked += UIUpdate;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UIUpdate()
    {
        coinAmount++;
        coinImage.DOPunchScale(Vector3.one * punchScaleFactor,0.2f);
        coinText.text = coinAmount.ToString();
    }


}

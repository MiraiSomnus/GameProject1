using UnityEngine;
using TMPro;

public class GUIManager : MonoBehaviour
{

    public static GUIManager Instance;

    [SerializeField] private TextMeshProUGUI score_Txt;
    [SerializeField] private TextMeshProUGUI health_Txt;
    private int score;
    private void Awake()
    {
        if(Instance==null){
            Instance = this;
            

        }
        else{
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        score_Txt.text = "0";
        SetScoreDisplay ();
    }

    private void SetScoreDisplay(){
        score_Txt.text = score.ToString();
    }

    public void IncreaseScore(int value){
        score+= value;
        SetScoreDisplay();
    }

     public void DecreaseScore(int value){
        score-= value;
        SetScoreDisplay();
    }

    public void UpdateHealth(float healthPercent){
        health_Txt.text = healthPercent.ToString();
    }
}

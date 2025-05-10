using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GUIManager : MonoBehaviour
{

    public static GUIManager Instance;

    [SerializeField] private TextMeshProUGUI score_Txt;
    [SerializeField] private Image healthBar_img;
     [SerializeField] private TextMeshProUGUI ammo_Txt;
    private int score;
    //private int maxScore = 400;

    public object Random { get; internal set; }

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

    void Update()
    {
        /*if(score==maxScore){
            scene
        }*/
    }

    private void SetScoreDisplay(){
        score_Txt.text = score.ToString();
    }

    public void IncreaseScore(int value){
        score+= value;
        SetScoreDisplay();
    }

     public void UpdateScore(int value){
        score = value;
        SetScoreDisplay();
    }

    public void UpdateHealth(float healthPercent){
        healthBar_img.fillAmount = healthPercent;
    }

    public void ammoCount(int count){
        ammo_Txt.text = count.ToString();
    }
}

using UnityEngine;

public class DoorManager : MonoBehaviour
{

  int doorScore= 200;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Update()
    {
        
       
    }

    public void doorDestroy (int score)
    {
        doorScore -= score;
        if(doorScore <= 0){
            Destroy(gameObject);
            GUIManager.Instance.UpdateScore(doorScore);
           
        }
    }
}

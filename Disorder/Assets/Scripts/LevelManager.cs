using TMPro.EditorUtilities;
using UnityEngine;

public class LevelManager : MonoBehaviour
{

    public static LevelManager Instance;

    private void Awake()
    {
        if(LevelManager.Instance ==null){Instance = this;}
        else {Destroy(gameObject);}
    } 

    public void Retry(){
        DeathManager ui = GetComponent<DeathManager>();

        if(ui != null){
            ui.ToggleDeathScreen();
        }


    }


}

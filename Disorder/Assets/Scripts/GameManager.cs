using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public PlayerManager player;
    public EnemyManager enemy;


    private void Awake() {
        
        //Checks singleton existence-R
    if (instance == null){
            //creates singleton if non exist whilst assinging to the object-R
        instance = this;
            //Prevents this object from being destroyed -R
          DontDestroyOnLoad(gameObject);
        }

        // Singleton exists so destroy object
        else{
            Destroy(gameObject);
        }
    }
}

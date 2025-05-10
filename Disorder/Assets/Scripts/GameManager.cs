using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public PlayerManager player;
    public EnemyManager enemy;
    public GunManager guner;

    public PlayerManager shoot;

    public Transform playerobj;
    public Transform enemyPos;

    public  Transform gunpos;
    
    public Transform muzzle;

    public Transform pistol;

    public Gun gunScript;
    
    public PlayerShoot playerShoots;

    public PlayerShoot cam;

    public Input pressShoot;

    public IEnumerator enu;

    public Input input;

    public  WaitForSeconds wait;

    public Coroutine coroutine;

   


    private void Awake() {
        
        
        //Checks singleton existence-R
    if (instance !=null && instance != this){
            //creates singleton if non exist whilst assinging to the object-R
        Destroy(gameObject);
        StopAllCoroutines();
        }

    

        // Singleton exists so destroy object
        else{
            instance = this;
        }
    }
}

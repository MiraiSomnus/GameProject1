using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyManager : MonoBehaviour,IDamageable
{
    [SerializeField] private Transform trans;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
     public float health = 100f;
     public int scoreValue= 25;

     public static EnemyManager Instance;



    private void Start()
    {
        //Sets enemy to player position
        //Vector3 playerPosition=  GameManager.instance.player.orientation.position;
       // Vector3 startingOffset= new Vector3(5f,0f,5f);
       // trans.position= playerPosition + startingOffset;        
    }

   private void Update(){
        Face();

   }

   private void Attack(){

   }

   private void Face(){
    //Subtracts Enemy position to Player's
    Vector3 towardsPlayer= GameManager.instance.player.orientation.position - trans.position;
    //print("Distance : " + towardsPlayer.magnitude);
    
    trans.rotation = Quaternion.LookRotation(towardsPlayer);
   }

    public void TakeDamage(float damage)
    {
        health-=damage;
        if(health <= 0){
            //Enemy Death
            Destroy(gameObject);
            GUIManager.Instance.IncreaseScore(scoreValue);
           
        }
    }

    

}
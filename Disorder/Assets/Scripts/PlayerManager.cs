using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerManager : MonoBehaviour
{
  

  [Header("Movement")]
    public Transform orientation;
    public float playerSpeed;
    float horizontalInput;
    float verticalInput;
    public float groundDrag;
  [Header("Ground Check")]
    public float playerHeight;
    public LayerMask ground;
    bool grounded;
    [Header("Health")]
    private float health, maxHealth;
    public float damageInbetween =1f;
     private float lastDamageTime;
    public EnemyManager enemy;
    Vector3 moveDirection;
    Rigidbody rigBody;
    // Start is called once before the first execution of Update after the MonoBehaviour is created.//
    private void Start()
    {
      rigBody = GetComponent<Rigidbody>();
      rigBody.freezeRotation = true;
      health = 100f;
      maxHealth =100f;
      UpdateHealth(0);
    }

    // Update is called once per frame.//
    private void Update()
    {
        theInput();
        grounded = Physics.Raycast(transform.position,UnityEngine.Vector3.down, playerHeight * 0.5f +0.2f, ground);

        if(grounded){
          rigBody.linearDamping = groundDrag;
                }
          else{
            rigBody.linearDamping=0;
            }
          
          controlSpeed();
        
    }

    

    private void FixedUpdate(){
      playerMove();
    }
    private void theInput()
    { 
    horizontalInput= Input.GetAxis("Horizontal");
    verticalInput= Input.GetAxis("Vertical");

    }

    private void playerMove()
    { 
      //calculates movement direction
      moveDirection =orientation.forward*verticalInput+orientation.right*horizontalInput;
      rigBody.AddForce(moveDirection.normalized * playerSpeed * 10f, ForceMode.Force);

        
    }
    
    private void controlSpeed(){
      Vector3 fvelocity = new Vector3(rigBody.linearVelocity.x, 0f, rigBody.linearVelocity.z);

      if(fvelocity.magnitude>playerSpeed){
        Vector3 limitedVel = fvelocity.normalized * playerSpeed;
        rigBody.linearVelocity = new Vector3(limitedVel.x,rigBody.linearVelocity.y,limitedVel.z);
      }

    } 
    
    public void OnCollisionStay(Collision collide)
    { 
        if(collide.gameObject.CompareTag("Enemy")&& Time.time - lastDamageTime >= damageInbetween){
          UpdateHealth(-1f);
          
        }
    }

  public void UpdateHealth(float value){

    health += value;
    
    if(health<=0){
      print ("You are dead");
      Death();
    }
    health = Mathf.Clamp(health,0,maxHealth);
    if(health>maxHealth){
      health = maxHealth;
    }
    GUIManager.Instance.UpdateHealth( health/maxHealth);
  }

  public void Death(){
  LevelManager.Instance.Retry();
    gameObject.SetActive(false);
  }
}

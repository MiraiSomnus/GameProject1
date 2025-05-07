using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunManager : MonoBehaviour
{
    //Creates a serialzied field for GunManager
    [SerializeField] private Gun gun;
    [SerializeField] private Transform muzzle;

    float lastTimeFired;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Start()
    {
       
        PlayerShoot.gunShoot += Fire;
        PlayerShoot.reloadInput += StartReload;
    }

// Checks if the gun is available to shoot by checking if the player is not reloading but aswell as checking  if the last gunshot taken is greater than the rate of fire divided by 60(Double back for further understanding).//
    private bool shootAvail() => !gun.reload && lastTimeFired > 1f/ (gun.fireRate/60f);
    public void StartReload(){
        if(!gun.reload){

        StartCoroutine(Reload());
        } Debug.Log("reloading");
    }    
    private IEnumerator Reload(){
       
        gun.reload = true;
        yield return new WaitForSeconds(gun.reloadTime);
        gun.ammoCount = gun.magazine;
        gun.reload = false;
        Debug.Log("reloaded");
    }
    public void Fire()
    {   Debug.Log("Gun is shooting");

         if(gun.ammoCount > 0)
         {
            if (shootAvail())
            {
                if(Physics.Raycast(muzzle.position, transform.forward, out RaycastHit hitInfo, gun.maxDistance))
                {
                    Debug.Log(hitInfo.transform.name);
                    IDamageable damageable = hitInfo.transform.GetComponent<IDamageable>();
                    damageable?.TakeDamage(gun.damage);
                }

                gun.ammoCount--;
                lastTimeFired = 0;
                whenFired();
         }
    }
}

    private void Update()
    {   lastTimeFired+= Time.deltaTime;
     Debug.DrawRay(muzzle.position, muzzle.forward);
    }
    private void whenFired(){
        
    }
}

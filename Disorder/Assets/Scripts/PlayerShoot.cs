using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour{
     
    public static PlayerShoot Instance;
      public static Action gunShoot;
      public static Action reloadInput;
      
      

    [SerializeField] public KeyCode reloadKey = KeyCode.R;
    
    private void Update()
    {
    if(Input.GetMouseButton(0))
      gunShoot?.Invoke();
      //Sound
      // The ? is an null condional operator it disables a null exception if it occurs.//
    if (Input.GetKeyDown(reloadKey))
      reloadInput?.Invoke(); 
      //Sound
    }
}
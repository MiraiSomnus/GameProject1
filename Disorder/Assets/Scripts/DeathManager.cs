using System.Collections;
using UnityEngine;

public class DeathManager : MonoBehaviour

{
     [SerializeField] GameObject deathScreen;
     public void ToggleDeathScreen(){
    deathScreen.SetActive(!deathScreen.activeSelf);
   }
}
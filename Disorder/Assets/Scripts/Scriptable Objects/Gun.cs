using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Gun", menuName = "Weapon/Gun")]
/** This files creates data holder that can be used for the various guns and weapons that will be present within the weapons system **/
public class Gun : ScriptableObject
{
    [Header("Name")]
    public new string name;
    [Header("Damage/Distance")]
    public float damage;
    public float maxDistance;
    [Header("Magazine/Fire Rate")]
    public int ammoCount;
    public int magazine;
    public float fireRate;
    public float reloadTime;
    public bool reload;
}

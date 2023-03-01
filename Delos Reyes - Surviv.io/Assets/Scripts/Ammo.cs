using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour
{//lootable item and should also appear on player;

  public GameObject gun; //the gun itll try to access to add to it's clip

  [Header ("Ammo Type")]
  public bool AR;
  public bool shotgun;
  public bool pistol;

  void OnTriggerEnter2D (Collider2D collider)
  {
    if (collider.tag == "Opponents")
    {
      Unit uScript = collider.gameObject.GetComponent<Unit>();
      //Debug.Log(uScript);

      if (AR)
      {
        if (uScript.ARsupply < 100) 
        {
          uScript.ARsupply++;
          Destroy(this.gameObject);
        }
        else return;
      }
      else if (shotgun)
      {
        if (uScript.SGsupply < 80) 
        {
          uScript.SGsupply++;
          Destroy(this.gameObject);
        }
        else return;
      }
      else
      {
        if (uScript.PTsupply < 60) 
        {
          uScript.PTsupply++;
          Destroy(this.gameObject);
        }
        else return;
      }
    }
  }
}

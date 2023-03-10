using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
  private GameObject player;

  public bool isFollowing;

  public float xOffset;
  public float yOffset;

// Use this for initialization
void Start ()
  {
      player = GameObject.Find("player");
      isFollowing = true;
  }

// Update is called once per frame
void Update ()
  {
    if (isFollowing) transform.position = new Vector3(player.transform.position.x + xOffset, player.transform.position.y + yOffset, transform.position.z);
  }
}

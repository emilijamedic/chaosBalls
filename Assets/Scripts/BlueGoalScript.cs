using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalScript : MonoBehaviour
{
public bool isSolved = false;
private void OnTriggerEnter(Collider other)
{
GameObject collidedWith = other.gameObject;
if (collidedWith.tag == gameObject.tag) {
isSolved = true;
GetComponent<Light>().enabled = false;
Destroy(collidedWith);
}
}
}


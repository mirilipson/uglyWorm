using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tailMove : MonoBehaviour
{
public float Speed;

public Vector3 tailTarget;

public int indx;

public GameObject tailTargetObj;

public wormMove mainWorm;

void start()
{
mainWorm = GameObject.FindGameObjectWithTag("wormHead").GetComponent<wormMove>();
Speed = mainWorm.Speed;
tailTargetObj = mainWorm.tailObjects[mainWorm.tailObjects.Count-2];
indx = mainWorm.tailObjects.IndexOf(gameObject);

}
    void Update()
    {
	tailTarget = tailTargetObj.transform.position;
	transform.LookAt(tailTarget);
	transform.position = Vector3.Lerp(transform.position,tailTarget,Time.deltaTime*Speed);
    }

	void OnTriggerEnter(Collider other)
	{
	if(other.CompareTag("wormHead"))
	{
	if(indx > 2)
	{
	Application.LoadLevel(Application.loadedLevel);
	}
	}
	}
}


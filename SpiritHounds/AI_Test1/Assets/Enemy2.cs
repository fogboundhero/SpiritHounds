using UnityEngine;
using System.Collections;

public class Enemy2 : MonoBehaviour {

	public float speed = 2.0f;
	public Transform Target = null;
	public float playerDistance;
	public float rotationDamping;
	
	// Use this for initialization
	void Start () {
	


	}
	

	void Update () {
		//transform.Translate (Vector3.down * Time.deltaTime * speed);

		playerDistance = Vector3.Distance(Target.position, transform.position);

		if (playerDistance < 20.0f) {
			
			lookAtPlayer ();

		}

		if (playerDistance < 20.0f){

			
			chasePlayer();

		}


	}

	void lookAtPlayer(){

		Quaternion rotation = Quaternion.LookRotation (Target.position - transform.position);
		transform.rotation = Quaternion.Slerp (transform.rotation, rotation, Time.deltaTime * rotationDamping);

	}

	void chasePlayer(){
		//transform.GetComponent<NavMeshAgent> ().transform.Translate (Vector3.forward * speed * Time.deltaTime);
		transform.GetComponent<NavMeshAgent> ().destination = Target.position;
		//transform.Translate (Vector3.forward * speed * Time.deltaTime);

//		Target = GameObject.Find ("Player").transform;
//			
//				if (Target != null) 
//				{
//						Vector3 dir = Target.position - transform.position;
//		
//						transform.position += (Target.position - transform.position).normalized 
//						* speed * Time.deltaTime;
//					}
	}

}

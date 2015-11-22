using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

    public float speed = 1;

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += transform.forward;
	}

    void OnCollisionEnter(Collision col)
    {
        Debug.Log("Bullet hit something");
        Destroy(gameObject);
        //Destroy(this);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dam : MonoBehaviour {

    private void OnCollisionEnter(Collision collision)
    {
        var hit = collision.gameObject;
        var hp = hit.GetComponent<Health>();
        if(hp != null)
        {
            hp.TakeDam(10);
        }

        Destroy(gameObject)
    }

    // Update is called once per frame
    void Update () {
		
	}
}

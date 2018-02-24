using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VaazunMonistaja : MonoBehaviour {

    public Transform prefab;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void nappulaPainettu()
    {
        Transform apu = Instantiate<Transform>(prefab);
        apu.SetPositionAndRotation(new Vector3(-1f, -1f, 0), Quaternion.identity);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Bouncer { 
    public class ReferenceHider : MonoBehaviour {

        public List<GameObject> objectsToHide = new List<GameObject>();

	    // Use this for initialization
	    void Start () {
            foreach(var element in objectsToHide)
            {
                element.SetActive(false);
            }
		
	    }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamicGITest : MonoBehaviour {

	void Update () {
        RendererExtensions.UpdateGIMaterials(GetComponent<Renderer>());
	}
}

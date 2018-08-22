using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("Test/Time Scale Adjust")]
public class TestTimeScaleAdjust : MonoBehaviour
{
    public KeyCode addKey;
    public KeyCode subKey;
    [Range(0, 1)]
    public float rate = 0.8f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(addKey))
        {
            Time.timeScale /= rate;
            print("Add! Time Scale:" + Time.timeScale);
        }
        if (Input.GetKeyDown(subKey))
        {
            Time.timeScale *= rate;
            print("Sub! Time Scale:" + Time.timeScale);
        }
    }
}

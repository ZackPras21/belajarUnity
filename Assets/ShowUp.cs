using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowUp : MonoBehaviour

{
    // Start is called before the first frame update
    [SerializeField] GameObject environment;
    [SerializeField] GameObject egg;
    public void onButtonPressed()
    {
        environment.transform.position = new Vector3(-5.051628f, 1.2425365f, 6.15943f);
        egg.transform.position = new Vector3(0, 3f, -3.59f);
    }

    public void back()
    {
        environment.transform.position = new Vector3(-5.051628f, -0.2425365f, 6.15943f);
        egg.transform.position = new Vector3(0, 1.5f, -3.59f);
    }
}

using UnityEngine;
using System.Collections;

public class LensManager : MonoBehaviour {

    public Material shader1;
    public Material shader2;
    public Material shader3;
    public Material shader4;
    public Material shader5;
    public Material shader6;

    public GameObject main_obj;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    
	}
    
    public void changeLensMode(int lens_mode)
    {
        if(lens_mode == 1)
        {
            main_obj.GetComponent<Renderer>().material = shader1;
        }
        else if (lens_mode == 2)
        {
            main_obj.GetComponent<Renderer>().material = shader2;
        }
        else if (lens_mode == 3)
        {
            main_obj.GetComponent<Renderer>().material = shader3;
        }
        else if (lens_mode == 4)
        {
            main_obj.GetComponent<Renderer>().material = shader4;
        }
        else if (lens_mode == 5)
        {
            main_obj.GetComponent<Renderer>().material = shader5;
        }
        else
        {
            main_obj.GetComponent<Renderer>().material = shader6;
        }
    }
}

using UnityEngine;
using System.Collections;
using common;

public class ManageBtns : MonoBehaviour {

    public UnityEngine.UI.Button shareBtn;
    public UnityEngine.UI.Button backBtn;
	// Use this for initialization
	void Start () {
        EventTriggerListener.Get(shareBtn.gameObject).onDown += ShareBtnDown;
        EventTriggerListener.Get(shareBtn.gameObject).onUp += ShareBtnUp;
        EventTriggerListener.Get(backBtn.gameObject).onDown += ShareBtnDown;
        EventTriggerListener.Get(backBtn.gameObject).onUp += ShareBtnUp;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void ShareBtnDown(GameObject obj)
    {
        Debug.Log("share btn down action");
        Utils.btn_clicked = true;
    }

    void ShareBtnUp(GameObject obj)
    {
        Debug.Log("share btn up action");
        Utils.btn_clicked = false;
    }

}

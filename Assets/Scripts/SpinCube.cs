using UnityEngine;

public class SpinCube : MonoBehaviour {


    public float spinValue = 90;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(Vector3.up * spinValue * Time.deltaTime);
	}

    public void flipSpin(){
        spinValue = -spinValue;
    }
}

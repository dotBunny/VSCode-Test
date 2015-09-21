using UnityEngine;

public class Tester : MonoBehaviour {
    public static float TimeTest = 0f;
    float Timestamp = 0;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	public void Update () {
        Timestamp = Time.time;
        TimeTest = Timestamp;
        if ( Timestamp < 0 ) {
            Debug.Log("BLAH");
        }
    }
    
    public void OnGUI()
    {
        if (GUILayout.Button("Trigger") ) {
            Debug.Log("TRIGGERED");
        }
    }
}

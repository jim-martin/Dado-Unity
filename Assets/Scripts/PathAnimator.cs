using UnityEngine;
using UnityEditor;
using System.Collections;


[RequireComponent(typeof(TrailRenderer))]
public class PathAnimator : MonoBehaviour {

	public float interval = 0.5f;
	public Color shiftColor = Color.white;
	private Color standardColor;

	int currentStep = 0;
	int numSteps = 5;
	float startTime;

	float startLerp;
	float endLerp;

	TrailRenderer t;
	SerializedObject o;

	void Awake () {
		t = GetComponent<TrailRenderer>();
	}

	void Start () {

		startTime = Time.time;
		InvokeRepeating("StepColorShift", 0.01f, interval);

		o = new SerializedObject(t);
		int index = currentStep % numSteps;
		standardColor = o.FindProperty("m_Colors.m_Color[" + index + "]").colorValue;

	}

	void Update () {

		//lerp based on time from start
		int index = currentStep % numSteps;
		int index_m = (currentStep - 1) % numSteps;
		o.FindProperty("m_Colors.m_Color[" + index + "]").colorValue = Color.Lerp(  shiftColor, standardColor,((endLerp - Time.time)/interval) );
		o.FindProperty("m_Colors.m_Color[" + index_m + "]").colorValue = Color.Lerp(  standardColor, shiftColor, ((endLerp - Time.time)/interval) );
		o.ApplyModifiedProperties();

	}

	void StepColorShift () {

		currentStep++;

		startLerp = Time.time;
		endLerp = startLerp + interval;
	
	}


}

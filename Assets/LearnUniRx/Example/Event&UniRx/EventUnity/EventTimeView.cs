using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventTimeView : MonoBehaviour {

	public EventTimeCounter timeCounter;
	public Text counterText;

	private void Start ()
	{
		timeCounter.OnTimeChanged += time =>
		{
			counterText.text = time + "";
		};
	}
}

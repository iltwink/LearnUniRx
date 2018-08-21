using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventTimeCounter : MonoBehaviour {

	public delegate void TimerEventhandle (int time);
	public event TimerEventhandle OnTimeChanged;

	private void Start ()
	{
		StartCoroutine (TimerCoroutine());
	}

	IEnumerator TimerCoroutine ()
	{
		var time = 100;
		while (time > 0)
		{
			time--;
			OnTimeChanged (time);
			yield return new WaitForSeconds (1);
		}
	}

}

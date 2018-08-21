using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class UniRxTimeCounter : MonoBehaviour
{
	// Subject is same Event
	private Subject<int> timerSubject = new Subject<int> ();

	public IObservable<int> OntimeChaneged { get { return timerSubject; } }

	private void Start ()
	{
		StartCoroutine (TimerCoroutine ());
	}

	private IEnumerator TimerCoroutine ()
	{
		var time = 100;
		while(time > 0)
		{
			time--;
			timerSubject.OnNext (time);
			yield return new WaitForSeconds (1);
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UniRx;

public class UniRxTimeView : MonoBehaviour {

	public UniRxTimeCounter timeCounter;
	public Text counterText;

	private void Start ()
	{
		//Subscribe stream
		timeCounter.OntimeChaneged.Subscribe (_ =>
		{
			counterText.text = _ + "";
		});
	}

}

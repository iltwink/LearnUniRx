using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class SubscribeAbbreviatedCall : MonoBehaviour
{

	Subject<int> subject = new Subject<int> ();

	private void OnNext ()
	{
		subject.Subscribe (_ => print ("Hello :" + _));
	}


	private void OnNextOnError ()
	{
		subject.Subscribe (
			_ => print ("Hello1 : " + _),
			_error => print ("Error : " + _error));
	}

	private void OnNextOnErrorOnCompleted ()
	{
		subject.Subscribe (
			_ => print ("Hello2 :" + _),
			_error => print ("Error : " + _error),
			() => print ("Completed3!"));
	}

	private void Start ()
	{
		OnNext ();
		OnNextOnError ();
		OnNextOnErrorOnCompleted ();
	}

	public void SendMessageUnitDefault ()
	{
		var _subject = new Subject<Unit> ();
		_subject.Subscribe (_ => print ("No mean : " + _));
		_subject.OnNext (Unit.Default);
	}

	public void SendMessage ()
	{
		subject.OnNext (100);
	}
	public void SendMessageOnError ()
	{
		subject.OnError (null);
	}

	public void SendMessageOnCompleted ()
	{
		subject.OnCompleted ();
	}
}

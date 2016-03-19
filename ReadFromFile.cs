using UnityEngine;
using System.Collections;

public class ReadFromFile : MonoBehaviour {
	public string allText;
	
	void Start () {
		System.IO.StreamReader MyReader = new System.IO.StreamReader("C:\\helloworld.txt");
		while((allText = MyReader.ReadLine()) != null)
		{
			Debug.Log (allText);
		}
		MyReader.Close();
	}
}

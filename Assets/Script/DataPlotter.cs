using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DataPlotter : MonoBehaviour {
	public string inputFile;
	public GameObject Datapoint;
	private List<Dictionary<string, object>> pointList;

	public int columnX = 3;
	public int columnY = 4;
	public int columnZ = 6;

	public string xName;
	public string yName;
	public string zName;

	void Start () {
		pointList = CSVReader.Read (inputFile);
		Debug.Log (pointList);

		List<string> columnList = new List<string> (pointList [1].Keys);

		Debug.Log ("There are " + columnList.Count + " Columns in CSV");

		foreach (string key in columnList)
			Debug.Log ("Column name is " + key);

		xName = columnList [columnX];
		yName = columnList [columnY];
		zName = columnList [columnZ];

		Debug.Log (xName);
		Debug.Log (yName);
		Debug.Log (zName);

		for (int i = 0; i < 500; i++) {
			float x = Convert.ToSingle (pointList [i] [xName]);
			System.Text.StringBuilder strB = new System.Text.StringBuilder (pointList [i] [yName].ToString ());
			strB [2] = '.';
			float y = Convert.ToSingle (strB.ToString ());

			float z = Convert.ToSingle (pointList [i] [zName]);

			Instantiate (Datapoint, new Vector3 (x, y, z), Quaternion.identity);
		}
	
	}
}















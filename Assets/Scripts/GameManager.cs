using UnityEngine;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour {
	public TextAsset itemDataCsv;
	public List<ItemData> itemList;

	// Use this for initialization
	void Start () 
	{
		LoadCsv ();	
	}

	void LoadCsv()
	{
		var csv = CSVReader.SplitCsvGrid (itemDataCsv.ToString());
		print (csv.GetLength (1));
		itemList = new List<ItemData> ();
		for(int i = 1; i < csv.GetLength(1); i++)
		{
			ItemData item = new ItemData ();
			item.SetData (GetRaw(csv, i));
			itemList.Add (item);
		}
	}

	public string[] GetRaw (string[,] csvData, int rowNum) 
	{
		string[] data = new string[ csvData.GetLength(0) ];
		for (int i=0; i<csvData.GetLength(0); i++)
		{
			data[i] = csvData[i, rowNum];
		}
		return data;
	}
}

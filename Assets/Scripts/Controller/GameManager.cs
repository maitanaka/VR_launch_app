using UnityEngine;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

public class GameManager : SingletonMonoBehaviour<GameManager> {
	public TextAsset itemDataCsv;
	public List<ItemData> itemDataList;
	// Use this for initialization
	void Start () 
	{
		LoadCsv ();	
	}

	void LoadCsv()
	{
		var csv = CSVReader.SplitCsvGrid (itemDataCsv.ToString());
		print (csv.GetLength (1));
		itemDataList = new List<ItemData> ();
		for(int i = 1; i < csv.GetLength(1); i++)
		{
			ItemData item = new ItemData ();
			item.SetData (GetRaw(csv, i));
			itemDataList.Add (item);
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

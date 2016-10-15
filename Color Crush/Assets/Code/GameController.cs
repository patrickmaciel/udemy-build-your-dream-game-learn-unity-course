using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
	int width = 10;
	int height = 10;
	int startX = 260;
	int startY = 350;
	int blockWidth = 32;
	int blockheight = 32;

	GameObject[,] grid;

	public GameObject BlockPrefab;
	public GameObject canvas;
	public GameObject scoreObject;
	int score = 0;

	// Use this for initialization
	void Start () {
		grid = new GameObject[width, height];
		
		int x = startX;
		int y = startY;

		for (int i=0; i < height; i++) {
			for (int j=0; j < width; j++) {
				GameObject block = Instantiate(BlockPrefab);
				grid[i,j] = block;

				block.GetComponent<RectTransform>().anchoredPosition = new Vector2(x, y);
				block.transform.SetParent(canvas.transform);

				int random = Random.Range(0,6);
				switch (random) {
					case 0:
						block.GetComponent<BlockController>().SetType(BlockController.BlockType.Blue);
						break;
					case 1:
						block.GetComponent<BlockController>().SetType(BlockController.BlockType.Green);
						break;
					case 2:
						block.GetComponent<BlockController>().SetType(BlockController.BlockType.Purple);
						break;
					case 3:
						block.GetComponent<BlockController>().SetType(BlockController.BlockType.Red);
						break;
					case 4:
						block.GetComponent<BlockController>().SetType(BlockController.BlockType.Yellow);
						break;
				}

				x+= blockWidth;
			}

			y-= blockheight;
			x = startX;
		} 
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

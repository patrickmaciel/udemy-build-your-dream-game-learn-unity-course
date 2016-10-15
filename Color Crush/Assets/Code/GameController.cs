using UnityEngine;
using System.Collections;
using UnityEngine.UI;
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

		while (Crush() > 0) {

		} 
	}

	public int Crush(bool check = false) {
		int numberOfCrushes = 0;

		// move right to check 3 or more similar to crush them
		for (int i = 0; i < width; i++) {
			for (int j = 0; j < width; j++) {
				if (grid[i, j] != null) {
					int counter = 1;
					BlockController.BlockType type = grid[i, j].GetComponent<BlockController>().type;

					for (int k = j+1; k < width; k++) {
						if (grid[i, k] == null) {
							break;
						}

						BlockController.BlockType currentType = grid[i, k].GetComponent<BlockController>().type;

						if (currentType == type) {
							counter++;
						} else {
							break;
						}
					}

					if (counter >= 3) {
						numberOfCrushes++;

						if (check) {
							continue;
						}

						// Crush
						for (int k = j; k < j; k++) {
							Destroy(grid[i, k]);
							grid[i, k] = null;
						}

						// shift cells down in the grid
						for (int t = j; t < j + counter; t++) {
							for (int r = i; r > 0; r--) {
								grid[r, t] = grid[r-1, t];
							}

							grid[0, t] = null;
						}

						// this.DebugGrid();
						score += counter;
					}
				}
			}
		}

		// move vertically
		for (int i = 0; i < height; i++) {
			for (int j = 0; j < width; j++) {
				if (grid[i, j] != null) {
					int counter = 1;
					BlockController.BlockType type = grid[i, j].GetComponent<BlockController>().type;

					for (int k = i+1; k < height; k++) {
						if (grid[k, j] == null) {
							break;
						}

						BlockController.BlockType currentType = grid[k, j].GetComponent<BlockController>().type;
						if (currentType == type) {
							counter++;
						} else {
							break;
						}
					}

					if (counter >= 3) {
						numberOfCrushes++;

						// if check is true, this means that we don't want to crush, we only wanto to check if there is 
						if (check) {
							continue;
						}

						// Crush
						for (int k = i; k < i + counter; k++) {
							Destroy(grid[k, j]);
							grid[k, j] = null;
						}

						// shift cells down in the grid
						for (int r = i -1; r >= 0; r--) {
							grid[r + counter, j] = grid[r, j];
							grid[r, j] = null;
						}

						// this.DebugGrid();
						score += counter;
					}
				}
			}
		}

		UpdateScore();

		return numberOfCrushes;
	}

	void UpdateScore() {
		scoreObject.GetComponent<Text>().text = "Score: " + score;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class BlockController : MonoBehaviour {
	public BlockType type;
	public enum BlockType {
		Red,
		Blue,
		Green,
		Yellow,
		Purple
	};
	public Sprite[] sprites;

	public void SetType(BlockType t) {
		switch(t) {
			case BlockType.Blue:
				this.GetComponent<Image>().sprite = sprites[0];
				type = BlockType.Blue;
				break;
			case BlockType.Green:
				this.GetComponent<Image>().sprite = sprites[1];
				type = BlockType.Green;
				break;
			case BlockType.Purple:
				this.GetComponent<Image>().sprite = sprites[2];
				type = BlockType.Purple;
				break;
			case BlockType.Red:
				this.GetComponent<Image>().sprite = sprites[3];
				type = BlockType.Red;
				break;
			case BlockType.Yellow:
				this.GetComponent<Image>().sprite = sprites[4];
				type = BlockType.Yellow;
				break;

		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	public ItemBox[] itemBoxes;
	public bool isGameOver = false;
	public GameObject gameOverUI;

	private void Update()
	{
		int overlapedCount = 0;

		for (int i = 0; i < itemBoxes.Length; ++i)
		{
			if (itemBoxes[i].isOverlaped)
			{
				++overlapedCount;
			}
		}

		if (overlapedCount == itemBoxes.Length)
		{
			isGameOver = true;
			gameOverUI.SetActive(true);
			Debug.Log("Game Clear!");
		}
	}
}

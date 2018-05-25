using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Completed;

public class Bomb : InventoryItem {

    [ContextMenu("Use Bomb")]
	public void UseItem() {
        foreach (Enemy enemy in GameManager.instance.enemies) {
            Destroy(enemy.gameObject);
        }
    }
}

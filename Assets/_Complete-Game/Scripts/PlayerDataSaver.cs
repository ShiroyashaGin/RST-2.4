using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDataSaver : MonoBehaviour {

    public static PlayerDataSaver instance;

    public int _playerFood;
    public InventoryItem _inventoryItem;


    // Use this for initialization
    void Awake() {
        if(instance == null) {
            instance = this;
        }
        else {
            Destroy(this);
        }
    }
}

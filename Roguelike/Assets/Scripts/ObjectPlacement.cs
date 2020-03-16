using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPlacement : MonoBehaviour {

    public Transform[] entrancePoints, exitPoints;
    public Transform[] healthAmmoPoints;
    public Transform[] wallPoints;
    public Transform[] lootPoints;
    public Transform[] enemyPoints;

    private void Awake() {
        PlaceItems();
    }

    void PlaceItems() {
        int en = Random.Range(0, entrancePoints.Length);
        int ex = Random.Range(0, exitPoints.Length);

        int wallType = Random.Range(3, 5);
        Debug.Log(wallType);

        entrancePoints[en].gameObject.active = false;
        exitPoints[ex].gameObject.active = false;

        if(en <= 7) {
            healthAmmoPoints[12].gameObject.active = false;
            healthAmmoPoints[13].gameObject.active = false;
            healthAmmoPoints[14].gameObject.active = false;
            healthAmmoPoints[15].gameObject.active = false;
        } else {
            healthAmmoPoints[8].gameObject.active = false;
            healthAmmoPoints[9].gameObject.active = false;
            healthAmmoPoints[10].gameObject.active = false;
            healthAmmoPoints[11].gameObject.active = false;
        }
        if(ex <= 7) {
            healthAmmoPoints[4].gameObject.active = false;
            healthAmmoPoints[5].gameObject.active = false;
            healthAmmoPoints[6].gameObject.active = false;
            healthAmmoPoints[7].gameObject.active = false;
        } else {
            healthAmmoPoints[0].gameObject.active = false;
            healthAmmoPoints[1].gameObject.active = false;
            healthAmmoPoints[2].gameObject.active = false;
            healthAmmoPoints[3].gameObject.active = false;
        }

        switch(wallType) {
            case 0:
                for(int w = 0; w < 1; w++) {
                    wallPoints[w].gameObject.active = true;
                }
            break;
            case 1:
                for(int w = 0; w < 1; w++) {
                    wallPoints[w].gameObject.active = false;
                }
            break;
            case 2:
                wallPoints[0].gameObject.active = false;
                wallPoints[1].gameObject.active = false;
                wallPoints[2].gameObject.active = false;
                wallPoints[3].gameObject.active = false;
                wallPoints[4].gameObject.active = false;
                wallPoints[5].gameObject.active = false;
                wallPoints[6].gameObject.active = false;
                wallPoints[7].gameObject.active = false;
                wallPoints[8].gameObject.active = false;

                wallPoints[27].gameObject.active = false;
                wallPoints[28].gameObject.active = false;
                wallPoints[29].gameObject.active = false;
                wallPoints[30].gameObject.active = false;
                wallPoints[31].gameObject.active = false;
                wallPoints[32].gameObject.active = false;
                wallPoints[33].gameObject.active = false;
                wallPoints[34].gameObject.active = false;
                wallPoints[35].gameObject.active = false;
            break;
            case 3:
                wallPoints[9].gameObject.active = false;
                wallPoints[10].gameObject.active = false;
                wallPoints[11].gameObject.active = false;
                wallPoints[12].gameObject.active = false;
                wallPoints[13].gameObject.active = false;
                wallPoints[14].gameObject.active = false;
                wallPoints[15].gameObject.active = false;
                wallPoints[16].gameObject.active = false;
                wallPoints[17].gameObject.active = false;

                wallPoints[18].gameObject.active = false;
                wallPoints[19].gameObject.active = false;
                wallPoints[20].gameObject.active = false;
                wallPoints[21].gameObject.active = false;
                wallPoints[22].gameObject.active = false;
                wallPoints[23].gameObject.active = false;
                wallPoints[24].gameObject.active = false;
                wallPoints[25].gameObject.active = false;
                wallPoints[26].gameObject.active = false;
            break;
            case 4:
                wallPoints[0].gameObject.active = false;
                wallPoints[2].gameObject.active = false;
                wallPoints[4].gameObject.active = false;
                wallPoints[6].gameObject.active = false;
                wallPoints[8].gameObject.active = false;

                wallPoints[27].gameObject.active = false;
                wallPoints[29].gameObject.active = false;
                wallPoints[31].gameObject.active = false;
                wallPoints[33].gameObject.active = false;
                wallPoints[35].gameObject.active = false;
            break;
        }
    }
    
}

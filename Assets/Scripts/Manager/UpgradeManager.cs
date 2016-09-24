using UnityEngine;
using System.Collections;

public class UpgradeManager : MonoBehaviour {

    public static UpgradeManager instance;

    public TurretUpgradeBlueprint turretToUpgrade;

    void Awake ()
    {
        if (instance != null)
        {

            Debug.Log("More than one UpgradeManager in Scene!");
            return;

        }
        instance = this;
    }

    public void UpgradeTurretOn(Node node)
    {

        if (PlayerStats.Money < turretToUpgrade.cost)
            return;

        PlayerStats.Money -= turretToUpgrade.cost;

        Destroy(node.turret);

        GameObject turret = (GameObject)Instantiate(turretToUpgrade.prefabUpgrade, node.GetBuildPosition(), Quaternion.identity);
        node.turret = turret;

    }

    public void SelectTurretToUpgrade(TurretUpgradeBlueprint upgrade)
    {

        turretToUpgrade = upgrade;

        if (turretToUpgrade == null)
        {
            Debug.Log("Kein Upgrade augewählt!");
            return;
        }

    }
}

using UnityEngine;

public class Upgrader : MonoBehaviour {

    public TurretUpgradeBlueprint Turret_1;
    public TurretUpgradeBlueprint Turret_2;

    UpgradeManager upgradeManager;

    void Start()
    {
        upgradeManager = UpgradeManager.instance;
    }
    
    public void SelectUpgrade_1()
    {
        upgradeManager.SelectTurretToUpgrade(Turret_1);
    }

    public void SelectUpgrade_2()
    {
        upgradeManager.SelectTurretToUpgrade(Turret_2);
    }
}

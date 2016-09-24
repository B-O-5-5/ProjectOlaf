using UnityEngine;

public class Shop : MonoBehaviour {

    public TurretBlueprint Turret_1;
    public TurretBlueprint Turret_4;

    BuildManager buildManager;

    void Start()
    {

        buildManager = BuildManager.instance;

    }

	public void SelectTurret_1()
    {
        buildManager.SelectTurretToBuild(Turret_1);
    }

    public void SelectTurret_4()
    {
        buildManager.SelectTurretToBuild(Turret_4);
    }

}

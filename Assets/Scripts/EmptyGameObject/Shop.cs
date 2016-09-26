using UnityEngine;

public class Shop : MonoBehaviour {

    public TurretBlueprint Turret_1;
    public TurretBlueprint Turret_2;
    public TurretBlueprint Turret_3;
    public TurretBlueprint Turret_4;
    public TurretBlueprint Turret_5;
    public TurretBlueprint Turret_6;

    BuildManager buildManager;

    void Start()
    {

        buildManager = BuildManager.instance;

    }

	public void SelectTurret_1()
    {
        buildManager.SelectTurretToBuild(Turret_1);
    }

    public void SelectTurret_2()
    {
        buildManager.SelectTurretToBuild(Turret_2);
    }

    public void SelectTurret_3()
    {
        buildManager.SelectTurretToBuild(Turret_3);
    }

    public void SelectTurret_4()
    {
        buildManager.SelectTurretToBuild(Turret_4);
    }

    public void SelectTurret_5()
    {
        buildManager.SelectTurretToBuild(Turret_5);
    }

    public void SelectTurret_6()
    {
        buildManager.SelectTurretToBuild(Turret_6);
    }
}

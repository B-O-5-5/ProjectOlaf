using UnityEngine;

public class BuildManager : MonoBehaviour {

    public static BuildManager instance;

    void Awake()
    {
        if(instance != null)
        {

            Debug.Log("More than one BuildManager in Scene!");
            return;

        }
        instance = this;
    }

    public TurretBlueprint turretToBuild;


    public bool CanBuild { get { return turretToBuild != null; } }

    public void BuildTurretOn (Node node)
    {

        if (PlayerStats.Money < turretToBuild.cost) 
            return;

        PlayerStats.Money -= turretToBuild.cost;

        GameObject turret = (GameObject)Instantiate(turretToBuild.prefab, node.GetBuildPosition(), Quaternion.identity);
        node.turret = turret;
    }

    public void SelectTurretToBuild(TurretBlueprint turret)
    {

        turretToBuild = turret;

    }

}

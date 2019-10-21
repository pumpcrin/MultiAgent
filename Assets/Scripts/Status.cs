using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

// デフォルトステータスの受け皿として利用することもあるため、Serializableを使用する

[Serializable]
public class Status
{
    [NonSerialized] public int id;
    public int Hp;
    public int Satiety;
    public int Money;

    [NonSerialized] public RoutineEnum currentRoutineEnum;
    [NonSerialized] public int routineIndex;
    public Status(Database database){
        var defaultStatus = database.parameters.VillagerDefaultStatus;
        Hp = defaultStatus.Hp;
        Satiety = defaultStatus.Satiety;
        Money = defaultStatus.Money;
    }
    
}

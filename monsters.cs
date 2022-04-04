using System;
using System.Collections.Generic;
using System.Text;

namespace MonsterGenerator
{
  class Monster
  {

    public string name;
    public int hitPoints;
    public string icon;
    public Monster(string monsterName, int monsterHitPoints, string monsterIcon)
    {
      name = monsterName;
      hitPoints = monsterHitPoints;
      icon = monsterIcon;
    }


  }
}


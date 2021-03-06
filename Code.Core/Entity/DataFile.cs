﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SecretNest.TeamPlayer.Entity
{
    public class DataFile
    {
        //基础信息
        public Basis Basis { get; set; }

        //队伍信息
        public Dictionary<TeamSelection, Team> Teams { get; set; }
        
        public List<List<Game>> Games { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using AlsiUtils;
using AlsiUtils.Data_Objects;
using AlsiUtils.Strategies;

namespace AlsiTrade_Backend
{
    public class RunCalcs
    {

        public static List<Trade> RunEMAScalpLiveTrade(Parameter_EMA_Scalp Parameter, GlobalObjects.TimeInterval Interval, bool TradesOnly)
        {
            DateTime s = DateTime.Now.AddDays(-10);
            DateTime e = DateTime.Now;
            GlobalObjects.Prices = AlsiUtils.DataBase.readDataFromDataBase(Interval, AlsiUtils.DataBase.dataTable.MasterMinute, s, e, false);
            return AlsiUtils.Strategies.EMA_Scalp.EmaScalp(Parameter, GlobalObjects.Prices, TradesOnly);

        }

        public static List<Trade> RunEMAScalp(Parameter_EMA_Scalp Parameter, GlobalObjects.TimeInterval Interval, bool TradesOnly, DateTime Start, DateTime End, DataBase.dataTable Table)
        {
            GlobalObjects.Prices = AlsiUtils.DataBase.readDataFromDataBase(Interval, Table, Start, End, false);
            return AlsiUtils.Strategies.EMA_Scalp.EmaScalp(Parameter, GlobalObjects.Prices, TradesOnly);
        }
    }
}
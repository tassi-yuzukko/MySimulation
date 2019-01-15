using System;
using System.Collections.Generic;
using System.Text;

namespace MySimulation.Core.Dto
{
    public struct Input
    {
        /// <summary>
        /// 保有期間
        /// </summary>
        int HoldingPeriod { get; set; }

        /// <summary>
        /// 初期投資
        /// </summary>
        decimal InitialIInvestiment { get; set; }

        /// <summary>
        /// 月ごとの投資額
        /// </summary>
        PerMonth PerMonth { get; set; }
    }

    public struct PerMonth
    {

    }
}

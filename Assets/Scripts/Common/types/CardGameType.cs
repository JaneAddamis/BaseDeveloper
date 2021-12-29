using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum CardGameType
{
    /// <summary>
    /// 18 rounds: 13 normal rounds + 5 color rounds
    /// </summary>
    FullBola,

    /// <summary>
    /// 10 rounds: 5 normal rounds + 5 color rounds
    /// </summary>
    MiniBola,

    /// <summary>
    /// 5 rounds: 5 normal rounds
    /// </summary>
    MicroBola,

    /// <summary>
    /// 18 rounds: FullBola | 2 vs 2
    /// </summary>
    EstimationCouple,

    /// <summary>
    /// 18 rounds: FullBola | old school score calculatons
    /// </summary>
    EstimationClassic
}
